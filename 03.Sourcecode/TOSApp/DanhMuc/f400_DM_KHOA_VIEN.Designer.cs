namespace TOSApp.DanhMuc
{
    partial class f400_DM_KHOA_VIEN
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
            this.m_grc_dm_khoa_vien = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_khoa_vien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PHAN_LOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_txt_ma_khoa_vien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.m_txt_ten_khoa_vien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.m_cbo_loai_khoa_vien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.m_cmd_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_cap_nhat = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_them = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_khoa_vien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_khoa_vien)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc_dm_khoa_vien
            // 
            this.m_grc_dm_khoa_vien.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_khoa_vien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_khoa_vien.Location = new System.Drawing.Point(0, 0);
            this.m_grc_dm_khoa_vien.MainView = this.m_grv_dm_khoa_vien;
            this.m_grc_dm_khoa_vien.Name = "m_grc_dm_khoa_vien";
            this.m_grc_dm_khoa_vien.Size = new System.Drawing.Size(739, 242);
            this.m_grc_dm_khoa_vien.TabIndex = 0;
            this.m_grc_dm_khoa_vien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_khoa_vien});
            // 
            // m_grv_dm_khoa_vien
            // 
            this.m_grv_dm_khoa_vien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn2,
            this.PHAN_LOAI});
            this.m_grv_dm_khoa_vien.GridControl = this.m_grc_dm_khoa_vien;
            this.m_grv_dm_khoa_vien.Name = "m_grv_dm_khoa_vien";
            this.m_grv_dm_khoa_vien.OptionsFind.AlwaysVisible = true;
            this.m_grv_dm_khoa_vien.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.m_grv_dm_khoa_vien_FocusedRowChanged);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên Khoa Viện";
            this.gridColumn3.FieldName = "TEN_KHOA_VIEN";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã Khoa Viện";
            this.gridColumn2.FieldName = "MA_KHOA_VIEN";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // PHAN_LOAI
            // 
            this.PHAN_LOAI.Caption = "Phân loại";
            this.PHAN_LOAI.FieldName = "TEN_PHAN_LOAI";
            this.PHAN_LOAI.Name = "PHAN_LOAI";
            this.PHAN_LOAI.Visible = true;
            this.PHAN_LOAI.VisibleIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 72);
            this.panel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết Khoa/Viện";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.85139F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.8499F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.29871F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(733, 53);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_txt_ma_khoa_vien);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 47);
            this.panel2.TabIndex = 2;
            // 
            // m_txt_ma_khoa_vien
            // 
            this.m_txt_ma_khoa_vien.Location = new System.Drawing.Point(84, 13);
            this.m_txt_ma_khoa_vien.Name = "m_txt_ma_khoa_vien";
            this.m_txt_ma_khoa_vien.Size = new System.Drawing.Size(125, 20);
            this.m_txt_ma_khoa_vien.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã khoa viện";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.m_txt_ten_khoa_vien);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(439, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(291, 47);
            this.panel4.TabIndex = 0;
            // 
            // m_txt_ten_khoa_vien
            // 
            this.m_txt_ten_khoa_vien.Location = new System.Drawing.Point(98, 13);
            this.m_txt_ten_khoa_vien.Name = "m_txt_ten_khoa_vien";
            this.m_txt_ten_khoa_vien.Size = new System.Drawing.Size(187, 20);
            this.m_txt_ten_khoa_vien.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên khoa Viện";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.m_cbo_loai_khoa_vien);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(221, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(212, 47);
            this.panel7.TabIndex = 1;
            // 
            // m_cbo_loai_khoa_vien
            // 
            this.m_cbo_loai_khoa_vien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_loai_khoa_vien.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.m_cbo_loai_khoa_vien.Items.AddRange(new object[] {
            "Khoa",
            "Viện",
            "Chương trình đặc biệt"});
            this.m_cbo_loai_khoa_vien.Location = new System.Drawing.Point(70, 13);
            this.m_cbo_loai_khoa_vien.Name = "m_cbo_loai_khoa_vien";
            this.m_cbo_loai_khoa_vien.Size = new System.Drawing.Size(121, 21);
            this.m_cbo_loai_khoa_vien.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Khoa/Viện:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(739, 300);
            this.panel3.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.m_grc_dm_khoa_vien);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(739, 242);
            this.panel6.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.m_cmd_xoa);
            this.panel5.Controls.Add(this.m_cmd_cap_nhat);
            this.panel5.Controls.Add(this.m_cmd_them);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 242);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(739, 58);
            this.panel5.TabIndex = 1;
            // 
            // m_cmd_xoa
            // 
            this.m_cmd_xoa.Location = new System.Drawing.Point(632, 23);
            this.m_cmd_xoa.Name = "m_cmd_xoa";
            this.m_cmd_xoa.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_xoa.TabIndex = 0;
            this.m_cmd_xoa.Text = "Xóa";
            this.m_cmd_xoa.Click += new System.EventHandler(this.m_cmd_xoa_Click);
            // 
            // m_cmd_cap_nhat
            // 
            this.m_cmd_cap_nhat.Location = new System.Drawing.Point(511, 23);
            this.m_cmd_cap_nhat.Name = "m_cmd_cap_nhat";
            this.m_cmd_cap_nhat.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_cap_nhat.TabIndex = 0;
            this.m_cmd_cap_nhat.Text = "Cập nhật";
            this.m_cmd_cap_nhat.Click += new System.EventHandler(this.m_cmd_cap_nhat_Click);
            // 
            // m_cmd_them
            // 
            this.m_cmd_them.Location = new System.Drawing.Point(388, 23);
            this.m_cmd_them.Name = "m_cmd_them";
            this.m_cmd_them.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_them.TabIndex = 0;
            this.m_cmd_them.Text = "Thêm";
            this.m_cmd_them.Click += new System.EventHandler(this.m_cmd_them_Click);
            // 
            // f400_DM_KHOA_VIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 372);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "f400_DM_KHOA_VIEN";
            this.Text = "f400_DM_KHOA_VIEN";
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_khoa_vien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_khoa_vien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_dm_khoa_vien;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_khoa_vien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox m_txt_ten_khoa_vien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.Columns.GridColumn PHAN_LOAI;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton m_cmd_them;
        private DevExpress.XtraEditors.SimpleButton m_cmd_cap_nhat;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xoa;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox m_cbo_loai_khoa_vien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox m_txt_ma_khoa_vien;
        private System.Windows.Forms.Label label1;
    }
}