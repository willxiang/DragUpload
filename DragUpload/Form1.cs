using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestSharp;
using System.IO;
using Newtonsoft.Json;
using DragUpload.Model;
using System.Configuration;

namespace DragUpload
{
    public partial class Form1 : Form
    {

        ImgurConfig imgurConfig = null;

        public Form1()
        {
            InitializeComponent();
            radioBtn_SMMS.Checked = true;
            imgurConfig = new ImgurConfig();

            SQLiteHelper.ConnectionString = ConfigurationManager.AppSettings["sqlite"];
            SQLiteHelper.CreateTable();
        }


        Picture activePicture = null;
        Picture backupPicture = new Picture();

        void imgurDelete(string hash)
        {
            var client = new RestClient("https://api.imgur.com/3/image/" + hash);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", imgurConfig.Authorization);
            var response = client.Execute(request);
        }


        void imgurUpload()
        {
            var client = new RestClient("https://api.imgur.com/3/upload");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", imgurConfig.Authorization);
            request.AddFile("image", activePicture.Path);
            var response = client.Execute(request);
            var smms = JsonConvert.DeserializeObject<Imgur>(response.Content);

            if (smms == null)
            {
                MessageBox.Show("服务器连接失败");
                return;
            }


            txtDel.Text = smms.data.deletehash;
            txtUrl.Text = smms.data.link;
            txtMD.Text = String.Format("![{0}]({1})", smms.data.id, smms.data.link);


            ImgRecord record = new ImgRecord();
            record.name = smms.data.id;
            record.url = smms.data.link;
            record.deleteUrl = smms.data.deletehash;
            SQLiteHelper.Add(record);
        }


        private void smmsupload()
        {
            try
            {
                var client = new RestClient("https://sm.ms/api/upload");

                var request = new RestRequest(Method.POST);

                request.AddFile("smfile", activePicture.Path);

                var response = client.Execute(request);

                var smms = JsonConvert.DeserializeObject<SMMS>(response.Content);

                txtDel.Text = smms.data.delete;
                txtUrl.Text = smms.data.url;
                txtMD.Text = String.Format("![{0}]({1})", smms.data.filename, smms.data.url);


                ImgRecord record = new ImgRecord();
                record.name = smms.data.filename;
                record.url = smms.data.url;
                record.deleteUrl = smms.data.delete;


                SQLiteHelper.Add(record);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (s.Length > 0)
            {
                ReadPicture(s[0].ToString());
                if (radioBtn_SMMS.Checked)
                    smmsupload();
                else
                    imgurUpload();
            }

        }







        private void ReadPicture(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            FileStream stream = fileInfo.OpenRead();

            byte[] bytes = new byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);

            if (activePicture == null)
                activePicture = new Picture();

            activePicture.Name = fileInfo.Name;
            activePicture.Bytes = bytes;
            activePicture.Path = path;
        }




        private void txtUrl_Click(object sender, EventArgs e)
        {
            txtUrl.SelectAll();
        }

        private void txtMD_Click(object sender, EventArgs e)
        {
            txtMD.SelectAll();
        }

        private void txtDel_Click(object sender, EventArgs e)
        {
            txtDel.SelectAll();
        }

        private void lbldel_Click(object sender, EventArgs e)
        {
            imgurDelete(this.txtDel.Text);
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            if (this.btnExpand.Text == ">")
            {
                this.btnExpand.Text = "<";
                this.Size = new Size(1000, 299);
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
                getData();
            }
            else
            {
                this.btnExpand.Text = ">";
                this.Size = new Size(391, 299);
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            }
        }


        private void getData()
        {
            this.dataGridViewImg.DataSource = SQLiteHelper.GetData();
            this.dataGridViewImg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("是否确定删除？", "再次确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in this.dataGridViewImg.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        DataGridViewCellCollection cells = row.Cells;
                        var id = Convert.ToInt32(cells["id"].Value);
                        SQLiteHelper.Remove(id);
                        this.dataGridViewImg.Rows.Remove(row);
                    }
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridViewImg.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    DataGridViewCellCollection cells = row.Cells;
                    var url = cells["url"].Value.ToString();
                    System.Windows.Forms.Clipboard.SetText(url);
                }
            }
        }

        private void dataGridViewImg_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.Button == MouseButtons.Right && !this.dataGridViewImg.Rows[e.RowIndex].IsNewRow)
            {
                freshDataGridViewRowsSelectedState();
                this.dataGridViewImg.Rows[e.RowIndex].Selected = true;
                contextMenuStrip1.Show(Cursor.Position);
            }
        }



        private void freshDataGridViewRowsSelectedState()
        {
            foreach (DataGridViewRow row in this.dataGridViewImg.Rows)
            {
                row.Selected = false;
            }
        }






    }
}
