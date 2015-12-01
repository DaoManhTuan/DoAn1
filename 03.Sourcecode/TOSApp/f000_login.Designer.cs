namespace TOSApp
{
    partial class f000_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.m_cmd_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_dang_nhap = new DevExpress.XtraEditors.SimpleButton();
            this.m_txt_password = new System.Windows.Forms.TextBox();
            this.m_txt_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TOSApp.Properties.Resources.login;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 115);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // m_cmd_thoat
            // 
            this.m_cmd_thoat.Location = new System.Drawing.Point(235, 234);
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_thoat.TabIndex = 3;
            this.m_cmd_thoat.Text = "Thoát";
            this.m_cmd_thoat.Click += new System.EventHandler(this.m_cmd_thoat_Click);
            // 
            // m_cmd_dang_nhap
            // 
            this.m_cmd_dang_nhap.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m_cmd_dang_nhap.Location = new System.Drawing.Point(137, 234);
            this.m_cmd_dang_nhap.Name = "m_cmd_dang_nhap";
            this.m_cmd_dang_nhap.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_dang_nhap.TabIndex = 2;
            this.m_cmd_dang_nhap.Text = "Đăng nhập ";
            this.m_cmd_dang_nhap.Click += new System.EventHandler(this.m_cmd_dang_nhap_Click);
            // 
            // m_txt_password
            // 
            this.m_txt_password.Location = new System.Drawing.Point(134, 189);
            this.m_txt_password.Name = "m_txt_password";
            this.m_txt_password.PasswordChar = '*';
            this.m_txt_password.Size = new System.Drawing.Size(176, 20);
            this.m_txt_password.TabIndex = 1;
            // 
            // m_txt_user
            // 
            this.m_txt_user.Location = new System.Drawing.Point(134, 153);
            this.m_txt_user.Name = "m_txt_user";
            this.m_txt_user.Size = new System.Drawing.Size(176, 20);
            this.m_txt_user.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "User";
            // 
            // f000_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 272);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.m_cmd_thoat);
            this.Controls.Add(this.m_cmd_dang_nhap);
            this.Controls.Add(this.m_txt_password);
            this.Controls.Add(this.m_txt_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "f000_login";
            this.Text = "f000_login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_thoat;
        private DevExpress.XtraEditors.SimpleButton m_cmd_dang_nhap;
        private System.Windows.Forms.TextBox m_txt_password;
        private System.Windows.Forms.TextBox m_txt_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}