namespace TOSApp.DanhMuc
{
    partial class f111_DM_LOP_SINH_VIEN_DE
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txt_lop_sinh_vien = new System.Windows.Forms.TextBox();
            this.m_cbo_ten_khoa_vien = new System.Windows.Forms.ComboBox();
            this.m_cbo_khoa = new System.Windows.Forms.ComboBox();
            this.m_cmd_ok = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết lớp sinh viên";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(354, 288);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cbo_khoa);
            this.panel1.Controls.Add(this.m_cbo_ten_khoa_vien);
            this.panel1.Controls.Add(this.m_txt_lop_sinh_vien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 224);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_cmd_cancel);
            this.panel2.Controls.Add(this.m_cmd_ok);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 52);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khoa viện";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khóa";
            // 
            // m_txt_lop_sinh_vien
            // 
            this.m_txt_lop_sinh_vien.Location = new System.Drawing.Point(164, 59);
            this.m_txt_lop_sinh_vien.Name = "m_txt_lop_sinh_vien";
            this.m_txt_lop_sinh_vien.Size = new System.Drawing.Size(153, 20);
            this.m_txt_lop_sinh_vien.TabIndex = 3;
            this.m_txt_lop_sinh_vien.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // m_cbo_ten_khoa_vien
            // 
            this.m_cbo_ten_khoa_vien.FormattingEnabled = true;
            this.m_cbo_ten_khoa_vien.Location = new System.Drawing.Point(164, 104);
            this.m_cbo_ten_khoa_vien.Name = "m_cbo_ten_khoa_vien";
            this.m_cbo_ten_khoa_vien.Size = new System.Drawing.Size(153, 21);
            this.m_cbo_ten_khoa_vien.TabIndex = 4;
            // 
            // m_cbo_khoa
            // 
            this.m_cbo_khoa.FormattingEnabled = true;
            this.m_cbo_khoa.Location = new System.Drawing.Point(164, 145);
            this.m_cbo_khoa.Name = "m_cbo_khoa";
            this.m_cbo_khoa.Size = new System.Drawing.Size(153, 21);
            this.m_cbo_khoa.TabIndex = 5;
            // 
            // m_cmd_ok
            // 
            this.m_cmd_ok.Location = new System.Drawing.Point(55, 13);
            this.m_cmd_ok.Name = "m_cmd_ok";
            this.m_cmd_ok.Size = new System.Drawing.Size(43, 33);
            this.m_cmd_ok.TabIndex = 0;
            this.m_cmd_ok.Text = "Ok";
            // 
            // m_cmd_cancel
            // 
            this.m_cmd_cancel.Location = new System.Drawing.Point(267, 13);
            this.m_cmd_cancel.Name = "m_cmd_cancel";
            this.m_cmd_cancel.Size = new System.Drawing.Size(50, 33);
            this.m_cmd_cancel.TabIndex = 1;
            this.m_cmd_cancel.Text = "Cancel";
            // 
            // f111_DM_LOP_SINH_VIEN_DE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 307);
            this.Controls.Add(this.groupBox1);
            this.Name = "f111_DM_LOP_SINH_VIEN_DE";
            this.Text = "f111_DM_LOP_SINH_VIEN_DE";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox m_cbo_khoa;
        private System.Windows.Forms.ComboBox m_cbo_ten_khoa_vien;
        private System.Windows.Forms.TextBox m_txt_lop_sinh_vien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_cancel;
        private DevExpress.XtraEditors.SimpleButton m_cmd_ok;
    }
}