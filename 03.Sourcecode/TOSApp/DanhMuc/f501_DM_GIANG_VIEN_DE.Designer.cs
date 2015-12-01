namespace TOSApp.DanhMuc
{
    partial class f501_DM_GIANG_VIEN_DE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f501_DM_GIANG_VIEN_DE));
            this.m_dat_ngay_sinh = new System.Windows.Forms.DateTimePicker();
            this.m_txt_que_quan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_cbo_khoa_vien = new System.Windows.Forms.ComboBox();
            this.m_rdb_gt_nu = new System.Windows.Forms.RadioButton();
            this.m_rdb_gt_nam = new System.Windows.Forms.RadioButton();
            this.m_txt_sdt = new System.Windows.Forms.TextBox();
            this.m_txt_ma_giang_vien = new System.Windows.Forms.TextBox();
            this.m_txt_ho_ten_giang_vien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.m_cmd_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_OK = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_dat_ngay_sinh
            // 
            this.m_dat_ngay_sinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_ngay_sinh.Location = new System.Drawing.Point(486, 26);
            this.m_dat_ngay_sinh.Name = "m_dat_ngay_sinh";
            this.m_dat_ngay_sinh.Size = new System.Drawing.Size(198, 20);
            this.m_dat_ngay_sinh.TabIndex = 4;
            // 
            // m_txt_que_quan
            // 
            this.m_txt_que_quan.Location = new System.Drawing.Point(159, 135);
            this.m_txt_que_quan.Multiline = true;
            this.m_txt_que_quan.Name = "m_txt_que_quan";
            this.m_txt_que_quan.Size = new System.Drawing.Size(198, 62);
            this.m_txt_que_quan.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Khoa/Viện";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quê quán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên giảng viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 248);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_cbo_khoa_vien);
            this.groupBox1.Controls.Add(this.m_rdb_gt_nu);
            this.groupBox1.Controls.Add(this.m_rdb_gt_nam);
            this.groupBox1.Controls.Add(this.m_txt_sdt);
            this.groupBox1.Controls.Add(this.m_txt_ma_giang_vien);
            this.groupBox1.Controls.Add(this.m_txt_ho_ten_giang_vien);
            this.groupBox1.Controls.Add(this.m_dat_ngay_sinh);
            this.groupBox1.Controls.Add(this.m_txt_que_quan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tinh chi tiết giảng viên";
            // 
            // m_cbo_khoa_vien
            // 
            this.m_cbo_khoa_vien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_khoa_vien.FormattingEnabled = true;
            this.m_cbo_khoa_vien.Location = new System.Drawing.Point(486, 177);
            this.m_cbo_khoa_vien.Name = "m_cbo_khoa_vien";
            this.m_cbo_khoa_vien.Size = new System.Drawing.Size(198, 21);
            this.m_cbo_khoa_vien.TabIndex = 7;
            // 
            // m_rdb_gt_nu
            // 
            this.m_rdb_gt_nu.AutoSize = true;
            this.m_rdb_gt_nu.Location = new System.Drawing.Point(553, 131);
            this.m_rdb_gt_nu.Name = "m_rdb_gt_nu";
            this.m_rdb_gt_nu.Size = new System.Drawing.Size(39, 17);
            this.m_rdb_gt_nu.TabIndex = 6;
            this.m_rdb_gt_nu.TabStop = true;
            this.m_rdb_gt_nu.Text = "Nữ";
            this.m_rdb_gt_nu.UseVisualStyleBackColor = true;
            // 
            // m_rdb_gt_nam
            // 
            this.m_rdb_gt_nam.AutoSize = true;
            this.m_rdb_gt_nam.Checked = true;
            this.m_rdb_gt_nam.Location = new System.Drawing.Point(486, 131);
            this.m_rdb_gt_nam.Name = "m_rdb_gt_nam";
            this.m_rdb_gt_nam.Size = new System.Drawing.Size(47, 17);
            this.m_rdb_gt_nam.TabIndex = 6;
            this.m_rdb_gt_nam.TabStop = true;
            this.m_rdb_gt_nam.Text = "Nam";
            this.m_rdb_gt_nam.UseVisualStyleBackColor = true;
            // 
            // m_txt_sdt
            // 
            this.m_txt_sdt.Location = new System.Drawing.Point(486, 80);
            this.m_txt_sdt.MaxLength = 11;
            this.m_txt_sdt.Name = "m_txt_sdt";
            this.m_txt_sdt.Size = new System.Drawing.Size(198, 20);
            this.m_txt_sdt.TabIndex = 5;
            this.m_txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_txt_sdt_KeyPress);
            // 
            // m_txt_ma_giang_vien
            // 
            this.m_txt_ma_giang_vien.Location = new System.Drawing.Point(159, 26);
            this.m_txt_ma_giang_vien.Name = "m_txt_ma_giang_vien";
            this.m_txt_ma_giang_vien.ReadOnly = true;
            this.m_txt_ma_giang_vien.Size = new System.Drawing.Size(198, 20);
            this.m_txt_ma_giang_vien.TabIndex = 5;
            // 
            // m_txt_ho_ten_giang_vien
            // 
            this.m_txt_ho_ten_giang_vien.Location = new System.Drawing.Point(159, 84);
            this.m_txt_ho_ten_giang_vien.Name = "m_txt_ho_ten_giang_vien";
            this.m_txt_ho_ten_giang_vien.Size = new System.Drawing.Size(198, 20);
            this.m_txt_ho_ten_giang_vien.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã giảng viên";
            // 
            // m_cmd_Cancel
            // 
            this.m_cmd_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_Cancel.Image")));
            this.m_cmd_Cancel.Location = new System.Drawing.Point(609, 17);
            this.m_cmd_Cancel.Name = "m_cmd_Cancel";
            this.m_cmd_Cancel.Size = new System.Drawing.Size(75, 32);
            this.m_cmd_Cancel.TabIndex = 0;
            this.m_cmd_Cancel.Text = "Thoát";
            this.m_cmd_Cancel.Click += new System.EventHandler(this.m_cmd_Cancel_Click);
            // 
            // m_cmd_OK
            // 
            this.m_cmd_OK.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_OK.Image")));
            this.m_cmd_OK.Location = new System.Drawing.Point(475, 17);
            this.m_cmd_OK.Name = "m_cmd_OK";
            this.m_cmd_OK.Size = new System.Drawing.Size(75, 32);
            this.m_cmd_OK.TabIndex = 0;
            this.m_cmd_OK.Text = "OK";
            this.m_cmd_OK.Click += new System.EventHandler(this.m_cmd_OK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_Cancel);
            this.panel1.Controls.Add(this.m_cmd_OK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 64);
            this.panel1.TabIndex = 2;
            // 
            // f501_DM_GIANG_VIEN_DE
            // 
            this.AcceptButton = this.m_cmd_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 312);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "f501_DM_GIANG_VIEN_DE";
            this.Text = "THÊM MỚI GIẢNG VIÊN";
            this.Load += new System.EventHandler(this.f501_DM_GIANG_VIEN_DE_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker m_dat_ngay_sinh;
        private System.Windows.Forms.TextBox m_txt_que_quan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox m_txt_ho_ten_giang_vien;
        private DevExpress.XtraEditors.SimpleButton m_cmd_Cancel;
        private DevExpress.XtraEditors.SimpleButton m_cmd_OK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox m_txt_sdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton m_rdb_gt_nu;
        private System.Windows.Forms.RadioButton m_rdb_gt_nam;
        private System.Windows.Forms.TextBox m_txt_ma_giang_vien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox m_cbo_khoa_vien;
    }
}