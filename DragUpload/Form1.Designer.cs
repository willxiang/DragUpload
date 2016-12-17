namespace DragUpload
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtMD = new System.Windows.Forms.TextBox();
            this.lblmd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExpand = new System.Windows.Forms.Button();
            this.dataGridViewImg = new System.Windows.Forms.DataGridView();
            this.radioBtn_Imgur = new System.Windows.Forms.RadioButton();
            this.radioBtn_SMMS = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uRLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImg)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(41, 77);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.ReadOnly = true;
            this.txtUrl.Size = new System.Drawing.Size(309, 21);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Click += new System.EventHandler(this.txtUrl_Click);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(39, 53);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(65, 12);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "图片地址：";
            // 
            // txtMD
            // 
            this.txtMD.Location = new System.Drawing.Point(41, 202);
            this.txtMD.Name = "txtMD";
            this.txtMD.ReadOnly = true;
            this.txtMD.Size = new System.Drawing.Size(309, 21);
            this.txtMD.TabIndex = 0;
            this.txtMD.Click += new System.EventHandler(this.txtMD_Click);
            // 
            // lblmd
            // 
            this.lblmd.AutoSize = true;
            this.lblmd.Location = new System.Drawing.Point(39, 178);
            this.lblmd.Name = "lblmd";
            this.lblmd.Size = new System.Drawing.Size(65, 12);
            this.lblmd.TabIndex = 1;
            this.lblmd.Text = "markdown：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExpand);
            this.panel1.Controls.Add(this.dataGridViewImg);
            this.panel1.Controls.Add(this.radioBtn_Imgur);
            this.panel1.Controls.Add(this.radioBtn_SMMS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblUrl);
            this.panel1.Controls.Add(this.txtUrl);
            this.panel1.Controls.Add(this.lblmd);
            this.panel1.Controls.Add(this.txtMD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 260);
            this.panel1.TabIndex = 2;
            // 
            // btnExpand
            // 
            this.btnExpand.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExpand.Location = new System.Drawing.Point(356, 90);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(23, 128);
            this.btnExpand.TabIndex = 4;
            this.btnExpand.Text = ">";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // dataGridViewImg
            // 
            this.dataGridViewImg.AllowUserToAddRows = false;
            this.dataGridViewImg.AllowUserToDeleteRows = false;
            this.dataGridViewImg.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridViewImg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewImg.Location = new System.Drawing.Point(385, 14);
            this.dataGridViewImg.Name = "dataGridViewImg";
            this.dataGridViewImg.RowTemplate.Height = 23;
            this.dataGridViewImg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewImg.Size = new System.Drawing.Size(587, 221);
            this.dataGridViewImg.TabIndex = 3;
            this.dataGridViewImg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewImg_CellClick);
            this.dataGridViewImg.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewImg_CellMouseUp);
            // 
            // radioBtn_Imgur
            // 
            this.radioBtn_Imgur.AutoSize = true;
            this.radioBtn_Imgur.Location = new System.Drawing.Point(171, 12);
            this.radioBtn_Imgur.Name = "radioBtn_Imgur";
            this.radioBtn_Imgur.Size = new System.Drawing.Size(53, 16);
            this.radioBtn_Imgur.TabIndex = 2;
            this.radioBtn_Imgur.TabStop = true;
            this.radioBtn_Imgur.Text = "imgur";
            this.radioBtn_Imgur.UseVisualStyleBackColor = true;
            // 
            // radioBtn_SMMS
            // 
            this.radioBtn_SMMS.AutoSize = true;
            this.radioBtn_SMMS.Location = new System.Drawing.Point(98, 12);
            this.radioBtn_SMMS.Name = "radioBtn_SMMS";
            this.radioBtn_SMMS.Size = new System.Drawing.Size(53, 16);
            this.radioBtn_SMMS.TabIndex = 2;
            this.radioBtn_SMMS.TabStop = true;
            this.radioBtn_SMMS.Text = "sm.ms";
            this.radioBtn_SMMS.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "服务器：";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 48);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uRLToolStripMenuItem,
            this.markDownToolStripMenuItem});
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // uRLToolStripMenuItem
            // 
            this.uRLToolStripMenuItem.Name = "uRLToolStripMenuItem";
            this.uRLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uRLToolStripMenuItem.Text = "URL";
            this.uRLToolStripMenuItem.Click += new System.EventHandler(this.uRLToolStripMenuItem_Click);
            // 
            // markDownToolStripMenuItem
            // 
            this.markDownToolStripMenuItem.Name = "markDownToolStripMenuItem";
            this.markDownToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.markDownToolStripMenuItem.Text = "MarkDown";
            this.markDownToolStripMenuItem.Click += new System.EventHandler(this.markDownToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 260);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "上传图片";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImg)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtMD;
        private System.Windows.Forms.Label lblmd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBtn_Imgur;
        private System.Windows.Forms.RadioButton radioBtn_SMMS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.DataGridView dataGridViewImg;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uRLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markDownToolStripMenuItem;
    }
}

