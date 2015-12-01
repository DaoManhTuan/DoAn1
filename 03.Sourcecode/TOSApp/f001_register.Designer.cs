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
            this.label4 = new System.Windows.Forms.Label();
            this.m_rdb_nhan_vien = new System.Windows.Forms.RadioButton();
            this.m_rdb_sinh_vien = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // m_txt_mat_khau
            // 
            this.m_txt_mat_khau.Location = new System.Drawing.Point(126, 98);
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
            this.label2.Location = new System.Drawing.Point(19, 101);
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
            this.label3.Location = new System.Drawing.Point(19, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // m_txt_mat_khau_2
            // 
            this.m_txt_mat_khau_2.Location = new System.Drawing.Point(126, 143);
            this.m_txt_mat_khau_2.Name = "m_txt_mat_khau_2";
            this.m_txt_mat_khau_2.PasswordChar = '*';
            this.m_txt_mat_khau_2.Size = new System.Drawing.Size(176, 20);
            this.m_txt_mat_khau_2.TabIndex = 5;
            // 
            // m_cmd_OK
            // 
            this.m_cmd_OK.Location = new System.Drawing.Point(126, 225);
            this.m_cmd_OK.Name = "m_cmd_OK";
            this.m_cmd_OK.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_OK.TabIndex = 7;
            this.m_cmd_OK.Text = "Xác nhận";
            this.m_cmd_OK.Click += new System.EventHandler(this.m_cmd_OK_Click);
            // 
            // m_cmd_thoat
            // 
            this.m_cmd_thoat.Location = new System.Drawing.Point(227, 225);
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_thoat.TabIndex = 7;
            this.m_cmd_thoat.Text = "Thoát";
            this.m_cmd_thoat.Click += new System.EventHandler(this.m_cmd_thoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "<Tài khoản là mã sinh viên>";
            // 
            // m_rdb_nhan_vien
            // 
            this.m_rdb_nhan_vien.AutoSize = true;
            this.m_rdb_nhan_vien.Location = new System.Drawing.Point(126, 182);
            this.m_rdb_nhan_vien.Name = "m_rdb_nhan_vien";
            this.m_rdb_nhan_vien.Size = new System.Drawing.Size(74, 17);
            this.m_rdb_nhan_vien.TabIndex = 9;
            this.m_rdb_nhan_vien.TabStop = true;
            this.m_rdb_nhan_vien.Text = "Nhân viên";
            this.m_rdb_nhan_vien.UseVisualStyleBackColor = true;
            // 
            // m_rdb_sinh_vien
            // 
            this.m_rdb_sinh_vien.AutoSize = true;
            this.m_rdb_sinh_vien.Location = new System.Drawing.Point(227, 182);
            this.m_rdb_sinh_vien.Name = "m_rdb_sinh_vien";
            this.m_rdb_sinh_vien.Size = new System.Drawing.Size(69, 17);
            this.m_rdb_sinh_vien.TabIndex = 9;
            this.m_rdb_sinh_vien.TabStop = true;
            this.m_rdb_sinh_vien.Text = "Sinh viên";
            this.m_rdb_sinh_vien.UseVisualStyleBackColor = true;
            // 
            // f001_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 271);
            this.Controls.Add(this.m_rdb_sinh_vien);
            this.Controls.Add(this.m_rdb_nhan_vien);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton m_rdb_nhan_vien;
        private System.Windows.Forms.RadioButton m_rdb_sinh_vien;
    }
}