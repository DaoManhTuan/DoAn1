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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f001_register));
            this.m_txt_mat_khau = new System.Windows.Forms.TextBox();
            this.m_txt_tai_khoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_cmd_OK = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.m_txt_output = new System.Windows.Forms.Label();
            this.m_cbo_nhom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_txt_mat_khau
            // 
            this.m_txt_mat_khau.Location = new System.Drawing.Point(126, 91);
            this.m_txt_mat_khau.Name = "m_txt_mat_khau";
            this.m_txt_mat_khau.PasswordChar = '*';
            this.m_txt_mat_khau.Size = new System.Drawing.Size(176, 20);
            this.m_txt_mat_khau.TabIndex = 2;
            // 
            // m_txt_tai_khoan
            // 
            this.m_txt_tai_khoan.Location = new System.Drawing.Point(126, 39);
            this.m_txt_tai_khoan.Name = "m_txt_tai_khoan";
            this.m_txt_tai_khoan.Size = new System.Drawing.Size(176, 20);
            this.m_txt_tai_khoan.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tài khoản";
            // 
            // m_cmd_OK
            // 
            this.m_cmd_OK.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_OK.Image")));
            this.m_cmd_OK.Location = new System.Drawing.Point(34, 218);
            this.m_cmd_OK.Name = "m_cmd_OK";
            this.m_cmd_OK.Size = new System.Drawing.Size(95, 41);
            this.m_cmd_OK.TabIndex = 4;
            this.m_cmd_OK.Text = "Xác nhận";
            this.m_cmd_OK.Click += new System.EventHandler(this.m_cmd_OK_Click);
            // 
            // m_cmd_thoat
            // 
            this.m_cmd_thoat.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_thoat.Image")));
            this.m_cmd_thoat.Location = new System.Drawing.Point(227, 218);
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.Size = new System.Drawing.Size(75, 41);
            this.m_cmd_thoat.TabIndex = 5;
            this.m_cmd_thoat.Text = "Thoát";
            this.m_cmd_thoat.Click += new System.EventHandler(this.m_cmd_thoat_Click);
            // 
            // m_txt_output
            // 
            this.m_txt_output.AutoSize = true;
            this.m_txt_output.ForeColor = System.Drawing.Color.Red;
            this.m_txt_output.Location = new System.Drawing.Point(71, 189);
            this.m_txt_output.Name = "m_txt_output";
            this.m_txt_output.Size = new System.Drawing.Size(0, 13);
            this.m_txt_output.TabIndex = 8;
            // 
            // m_cbo_nhom
            // 
            this.m_cbo_nhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_nhom.FormattingEnabled = true;
            this.m_cbo_nhom.Location = new System.Drawing.Point(128, 136);
            this.m_cbo_nhom.Name = "m_cbo_nhom";
            this.m_cbo_nhom.Size = new System.Drawing.Size(174, 21);
            this.m_cbo_nhom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nhóm người dùng";
            // 
            // f001_register
            // 
            this.AcceptButton = this.m_cmd_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 271);
            this.Controls.Add(this.m_cbo_nhom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_txt_output);
            this.Controls.Add(this.m_cmd_thoat);
            this.Controls.Add(this.m_cmd_OK);
            this.Controls.Add(this.m_txt_mat_khau);
            this.Controls.Add(this.m_txt_tai_khoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "f001_register";
            this.Text = "Đăng ký tài khoản";
            this.Load += new System.EventHandler(this.f001_register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_txt_mat_khau;
        private System.Windows.Forms.TextBox m_txt_tai_khoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_OK;
        private DevExpress.XtraEditors.SimpleButton m_cmd_thoat;
        private System.Windows.Forms.Label m_txt_output;
        private System.Windows.Forms.ComboBox m_cbo_nhom;
        private System.Windows.Forms.Label label3;
    }
}