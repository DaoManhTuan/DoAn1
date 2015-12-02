namespace TOSApp
{
    partial class f001_register
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
            this.m_txt_mat_khau = new System.Windows.Forms.TextBox();
            this.m_txt_tai_khoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txt_mat_khau_2 = new System.Windows.Forms.TextBox();
            this.m_cmd_OK = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.m_txt_output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_txt_mat_khau
            // 
            this.m_txt_mat_khau.Location = new System.Drawing.Point(126, 91);
            this.m_txt_mat_khau.Name = "m_txt_mat_khau";
            this.m_txt_mat_khau.PasswordChar = '*';
            this.m_txt_mat_khau.Size = new System.Drawing.Size(176, 20);
            this.m_txt_mat_khau.TabIndex = 5;
            // 
            // m_txt_tai_khoan
            // 
            this.m_txt_tai_khoan.Location = new System.Drawing.Point(126, 39);
            this.m_txt_tai_khoan.Name = "m_txt_tai_khoan";
            this.m_txt_tai_khoan.Size = new System.Drawing.Size(176, 20);
            this.m_txt_tai_khoan.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // m_txt_mat_khau_2
            // 
            this.m_txt_mat_khau_2.Location = new System.Drawing.Point(126, 138);
            this.m_txt_mat_khau_2.Name = "m_txt_mat_khau_2";
            this.m_txt_mat_khau_2.PasswordChar = '*';
            this.m_txt_mat_khau_2.Size = new System.Drawing.Size(176, 20);
            this.m_txt_mat_khau_2.TabIndex = 5;
            // 
            // m_cmd_OK
            // 
            this.m_cmd_OK.Location = new System.Drawing.Point(126, 218);
            this.m_cmd_OK.Name = "m_cmd_OK";
            this.m_cmd_OK.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_OK.TabIndex = 7;
            this.m_cmd_OK.Text = "Xác nhận";
            this.m_cmd_OK.Click += new System.EventHandler(this.m_cmd_OK_Click);
            // 
            // m_cmd_thoat
            // 
            this.m_cmd_thoat.Location = new System.Drawing.Point(227, 218);
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_thoat.TabIndex = 7;
            this.m_cmd_thoat.Text = "Thoát";
            this.m_cmd_thoat.Click += new System.EventHandler(this.m_cmd_thoat_Click);
            // 
            // m_txt_output
            // 
            this.m_txt_output.AutoSize = true;
            this.m_txt_output.Location = new System.Drawing.Point(71, 189);
            this.m_txt_output.Name = "m_txt_output";
            this.m_txt_output.Size = new System.Drawing.Size(0, 13);
            this.m_txt_output.TabIndex = 8;
            // 
            // f001_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 271);
            this.Controls.Add(this.m_txt_output);
            this.Controls.Add(this.m_cmd_thoat);
            this.Controls.Add(this.m_cmd_OK);
            this.Controls.Add(this.m_txt_mat_khau_2);
            this.Controls.Add(this.m_txt_mat_khau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_txt_tai_khoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "f001_register";
            this.Text = "f0001_register";
            this.Load += new System.EventHandler(this.f001_register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_txt_mat_khau;
        private System.Windows.Forms.TextBox m_txt_tai_khoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_txt_mat_khau_2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_OK;
        private DevExpress.XtraEditors.SimpleButton m_cmd_thoat;
        private System.Windows.Forms.Label m_txt_output;
    }
}