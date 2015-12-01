namespace TOSApp.DanhMuc
{
    partial class f201_DM_LOP_HOC_DE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f201_DM_LOP_HOC_DE));
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_OK = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cbo_giang_vien = new System.Windows.Forms.ComboBox();
            this.m_cbo_hoc_phan = new System.Windows.Forms.ComboBox();
            this.m_cbo_hoc_ky = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txt_ma_lop_hoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_Cancel);
            this.panel1.Controls.Add(this.m_cmd_OK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 70);
            this.panel1.TabIndex = 0;
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
            // m_cmd_OK
            // 
            this.m_cmd_OK.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_OK.Image")));
            this.m_cmd_OK.Location = new System.Drawing.Point(37, 25);
            this.m_cmd_OK.Name = "m_cmd_OK";
            this.m_cmd_OK.Size = new System.Drawing.Size(75, 33);
            this.m_cmd_OK.TabIndex = 0;
            this.m_cmd_OK.Text = "OK";
            this.m_cmd_OK.Click += new System.EventHandler(this.m_cmd_OK_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_cbo_giang_vien);
            this.panel2.Controls.Add(this.m_cbo_hoc_phan);
            this.panel2.Controls.Add(this.m_cbo_hoc_ky);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.m_txt_ma_lop_hoc);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 185);
            this.panel2.TabIndex = 1;
            // 
            // m_cbo_giang_vien
            // 
            this.m_cbo_giang_vien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_giang_vien.FormattingEnabled = true;
            this.m_cbo_giang_vien.Location = new System.Drawing.Point(128, 105);
            this.m_cbo_giang_vien.Name = "m_cbo_giang_vien";
            this.m_cbo_giang_vien.Size = new System.Drawing.Size(180, 21);
            this.m_cbo_giang_vien.TabIndex = 3;
            // 
            // m_cbo_hoc_phan
            // 
            this.m_cbo_hoc_phan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_hoc_phan.FormattingEnabled = true;
            this.m_cbo_hoc_phan.Location = new System.Drawing.Point(128, 66);
            this.m_cbo_hoc_phan.Name = "m_cbo_hoc_phan";
            this.m_cbo_hoc_phan.Size = new System.Drawing.Size(180, 21);
            this.m_cbo_hoc_phan.TabIndex = 2;
            this.m_cbo_hoc_phan.SelectedIndexChanged += new System.EventHandler(this.m_cbo_hoc_phan_SelectedIndexChanged);
            // 
            // m_cbo_hoc_ky
            // 
            this.m_cbo_hoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_hoc_ky.FormattingEnabled = true;
            this.m_cbo_hoc_ky.Location = new System.Drawing.Point(128, 143);
            this.m_cbo_hoc_ky.Name = "m_cbo_hoc_ky";
            this.m_cbo_hoc_ky.Size = new System.Drawing.Size(180, 21);
            this.m_cbo_hoc_ky.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Học kỳ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Học phần";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giảng viên";
            // 
            // m_txt_ma_lop_hoc
            // 
            this.m_txt_ma_lop_hoc.Location = new System.Drawing.Point(128, 25);
            this.m_txt_ma_lop_hoc.Name = "m_txt_ma_lop_hoc";
            this.m_txt_ma_lop_hoc.ReadOnly = true;
            this.m_txt_ma_lop_hoc.Size = new System.Drawing.Size(180, 20);
            this.m_txt_ma_lop_hoc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp học";
            // 
            // f201_DM_LOP_HOC_DE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 255);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "f201_DM_LOP_HOC_DE";
            this.Text = "THÊM LỚP HỌC";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox m_txt_ma_lop_hoc;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_Cancel;
        private DevExpress.XtraEditors.SimpleButton m_cmd_OK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox m_cbo_giang_vien;
        private System.Windows.Forms.ComboBox m_cbo_hoc_phan;
        private System.Windows.Forms.ComboBox m_cbo_hoc_ky;
    }
}