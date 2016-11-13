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
            var smms = JsonConvert.DeserializeObject<imgur>(response.Content);

            txtDel.Text = smms.data.deletehash;
            txtUrl.Text = smms.data.link;
            txtMD.Text = String.Format("![{0}]({1})", smms.data.id, smms.data.link);

        }


        void smmsupload()
        {
            try
            {
                var client = new RestClient("https://sm.ms/api/upload");

                var request = new RestRequest(Method.POST);

                request.AddFile("smfile", activePicture.Path);

                var response = client.Execute(request);

                var smms = JsonConvert.DeserializeObject<SmmsResponse>(response.Content);

                txtDel.Text = smms.data.delete;
                txtUrl.Text = smms.data.url;
                txtMD.Text = String.Format("![{0}]({1})", smms.data.filename, smms.data.url);
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


        void ReadPicture(string path)
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



        class Picture
        {
            public string Name { get; set; }

            public string Path { get; set; }

            public byte[] Bytes { get; set; }

            public SmmsData smms { get; set; }
            public imgur imgur { get; set; }

        }



        class imgur
        {

            public imgurdata data { get; set; }
            public bool success { get; set; }
            public int status { get; set; }
        }

        class imgurdata
        {
            public string id { get; set; }
            public long datetime { get; set; }
            public string link { get; set; }

            public string deletehash { get; set; }
        }


        class SmmsResponse
        {
            public string code { get; set; }

            public SmmsData data { get; set; }

        }

        class SmmsData
        {
            public int width { get; set; }
            public int height { get; set; }
            public string filename { get; set; }

            public string storename { get; set; }

            public int size { get; set; }

            public string path { get; set; }

            public string hash { get; set; }

            public long timestamp { get; set; }

            public string ip { get; set; }

            public string url { get; set; }

            public string delete { get; set; }
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



    }
}
