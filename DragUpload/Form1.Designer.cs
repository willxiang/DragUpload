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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtMD = new System.Windows.Forms.TextBox();
            this.lblmd = new System.Windows.Forms.Label();
            this.txtDel = new System.Windows.Forms.TextBox();
            this.lbldel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBtn_Imgur = new System.Windows.Forms.RadioButton();
            this.radioBtn_SMMS = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.txtMD.Location = new System.Drawing.Point(41, 145);
            this.txtMD.Name = "txtMD";
            this.txtMD.ReadOnly = true;
            this.txtMD.Size = new System.Drawing.Size(309, 21);
            this.txtMD.TabIndex = 0;
            this.txtMD.Click += new System.EventHandler(this.txtMD_Click);
            // 
            // lblmd
            // 
            this.lblmd.AutoSize = true;
            this.lblmd.Location = new System.Drawing.Point(39, 121);
            this.lblmd.Name = "lblmd";
            this.lblmd.Size = new System.Drawing.Size(65, 12);
            this.lblmd.TabIndex = 1;
            this.lblmd.Text = "markdown：";
            // 
            // txtDel
            // 
            this.txtDel.Location = new System.Drawing.Point(41, 212);
            this.txtDel.Name = "txtDel";
            this.txtDel.ReadOnly = true;
            this.txtDel.Size = new System.Drawing.Size(309, 21);
            this.txtDel.TabIndex = 0;
            this.txtDel.Click += new System.EventHandler(this.txtDel_Click);
            // 
            // lbldel
            // 
            this.lbldel.AutoSize = true;
            this.lbldel.Location = new System.Drawing.Point(39, 188);
            this.lbldel.Name = "lbldel";
            this.lbldel.Size = new System.Drawing.Size(65, 12);
            this.lbldel.TabIndex = 1;
            this.lbldel.Text = "删除地址：";
            this.lbldel.Click += new System.EventHandler(this.lbldel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioBtn_Imgur);
            this.panel1.Controls.Add(this.radioBtn_SMMS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblUrl);
            this.panel1.Controls.Add(this.lbldel);
            this.panel1.Controls.Add(this.txtUrl);
            this.panel1.Controls.Add(this.lblmd);
            this.panel1.Controls.Add(this.txtMD);
            this.panel1.Controls.Add(this.txtDel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 260);
            this.panel1.TabIndex = 2;
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
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 260);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "上传图片";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtMD;
        private System.Windows.Forms.Label lblmd;
        private System.Windows.Forms.TextBox txtDel;
        private System.Windows.Forms.Label lbldel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBtn_Imgur;
        private System.Windows.Forms.RadioButton radioBtn_SMMS;
        private System.Windows.Forms.Label label1;
    }
}

