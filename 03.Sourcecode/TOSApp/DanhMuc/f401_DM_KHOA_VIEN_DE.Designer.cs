namespace TOSApp.DanhMuc
{
    partial class f401_DM_KHOA_VIEN_DE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f401_DM_KHOA_VIEN_DE));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.m_cbo_phan_loai_khoa_vien = new System.Windows.Forms.ComboBox();
            this.m_txt_ten_khoa_vien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txt_ma_khoa_vien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_cmd_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_OK = new DevExpress.XtraEditors.SimpleButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.m_cbo_phan_loai_khoa_vien);
            this.panel2.Controls.Add(this.m_txt_ten_khoa_vien);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.m_txt_ma_khoa_vien);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 196);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Khoa/Viện*";
            // 
            // m_cbo_phan_loai_khoa_vien
            // 
            this.m_cbo_phan_loai_khoa_vien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_phan_loai_khoa_vien.FormattingEnabled = true;
            this.m_cbo_phan_loai_khoa_vien.Location = new System.Drawing.Point(128, 51);
            this.m_cbo_phan_loai_khoa_vien.Name = "m_cbo_phan_loai_khoa_vien";
            this.m_cbo_phan_loai_khoa_vien.Size = new System.Drawing.Size(180, 21);
            this.m_cbo_phan_loai_khoa_vien.TabIndex = 2;
            // 
            // m_txt_ten_khoa_vien
            // 
            this.m_txt_ten_khoa_vien.Location = new System.Drawing.Point(128, 87);
            this.m_txt_ten_khoa_vien.Multiline = true;
            this.m_txt_ten_khoa_vien.Name = "m_txt_ten_khoa_vien";
            this.m_txt_ten_khoa_vien.Size = new System.Drawing.Size(180, 67);
            this.m_txt_ten_khoa_vien.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khoa Viện*";
            // 
            // m_txt_ma_khoa_vien
            // 
            this.m_txt_ma_khoa_vien.Location = new System.Drawing.Point(128, 25);
            this.m_txt_ma_khoa_vien.Name = "m_txt_ma_khoa_vien";
            this.m_txt_ma_khoa_vien.Size = new System.Drawing.Size(180, 20);
            this.m_txt_ma_khoa_vien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khoa viện*";
            // 
            // m_cmd_Cancel
            // 
            this.m_cmd_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_Cancel.Image")));
            this.m_cmd_Cancel.Location = new System.Drawing.Point(233, 25);
            this.m_cmd_Cancel.Name = "m_cmd_Cancel";
            this.m_cmd_Cancel.Size = new System.Drawing.Size(75, 33);
            this.m_cmd_Cancel.TabIndex = 0;
            this.m_cmd_Cancel.Text = "Thoát";
            this.m_cmd_Cancel.Click += new System.EventHandler(this.m_cmd_Cancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_Cancel);
            this.panel1.Controls.Add(this.m_cmd_OK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 70);
            this.panel1.TabIndex = 4;
            // 
            // m_cmd_OK
            // 
            this.m_cmd_OK.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_OK.Image")));
            this.m_cmd_OK.Location = new System.Drawing.Point(31, 25);
            this.m_cmd_OK.Name = "m_cmd_OK";
            this.m_cmd_OK.Size = new System.Drawing.Size(75, 33);
            this.m_cmd_OK.TabIndex = 0;
            this.m_cmd_OK.Text = "OK";
            this.m_cmd_OK.Click += new System.EventHandler(this.m_cmd_OK_Click);
            // 
            // f401_DM_KHOA_VIEN_DE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 266);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "f401_DM_KHOA_VIEN_DE";
            this.Text = "THÊM MỚI KHOA /VIỆN";
            this.Load += new System.EventHandler(this.f401_DM_KHOA_VIEN_DE_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox m_txt_ten_khoa_vien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txt_ma_khoa_vien;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_Cancel;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_OK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox m_cbo_phan_loai_khoa_vien;
    }
}