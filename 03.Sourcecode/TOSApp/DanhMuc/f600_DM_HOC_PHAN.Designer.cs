namespace TOSApp.DanhMuc
{
    partial class f600_DM_HOC_PHAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f600_DM_HOC_PHAN));
            this.m_grc_dm_hoc_phan = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_hoc_phan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_grvcol_so_tin_chi_hoc_phan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_grvcol_ma_hoc_phan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_grvcol_so_tin_chi_hoc_phi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_grvcol_trong_so = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_grv_khoa_vien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.m_cbo_khoa_vien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.m_txt_so_tin_chi_hoc_phi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txt_ten_hoc_phan = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_txt_ma_hoc_phan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.m_txt_so_tin_chi_hoc_phan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.m_txt_trong_so = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.m_cmd_them = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_sua = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_hoc_phan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_hoc_phan)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc_dm_hoc_phan
            // 
            this.m_grc_dm_hoc_phan.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_hoc_phan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_hoc_phan.Location = new System.Drawing.Point(0, 0);
            this.m_grc_dm_hoc_phan.MainView = this.m_grv_dm_hoc_phan;
            this.m_grc_dm_hoc_phan.Name = "m_grc_dm_hoc_phan";
            this.m_grc_dm_hoc_phan.Size = new System.Drawing.Size(1032, 283);
            this.m_grc_dm_hoc_phan.TabIndex = 0;
            this.m_grc_dm_hoc_phan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_hoc_phan});
            // 
            // m_grv_dm_hoc_phan
            // 
            this.m_grv_dm_hoc_phan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.m_grvcol_so_tin_chi_hoc_phan,
            this.m_grvcol_ma_hoc_phan,
            this.m_grvcol_so_tin_chi_hoc_phi,
            this.m_grvcol_trong_so,
            this.m_grv_khoa_vien});
            this.m_grv_dm_hoc_phan.GridControl = this.m_grc_dm_hoc_phan;
            this.m_grv_dm_hoc_phan.Name = "m_grv_dm_hoc_phan";
            this.m_grv_dm_hoc_phan.OptionsFind.AlwaysVisible = true;
            this.m_grv_dm_hoc_phan.OptionsView.ShowAutoFilterRow = true;
            this.m_grv_dm_hoc_phan.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.m_grv_dm_hoc_phan_FocusedRowChanged);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên học phần";
            this.gridColumn3.FieldName = "TEN_HOC_PHAN";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // m_grvcol_so_tin_chi_hoc_phan
            // 
            this.m_grvcol_so_tin_chi_hoc_phan.Caption = "Số tín chỉ học phần";
            this.m_grvcol_so_tin_chi_hoc_phan.FieldName = "SO_TIN_CHI_HOC_PHAN";
            this.m_grvcol_so_tin_chi_hoc_phan.Name = "m_grvcol_so_tin_chi_hoc_phan";
            this.m_grvcol_so_tin_chi_hoc_phan.Visible = true;
            this.m_grvcol_so_tin_chi_hoc_phan.VisibleIndex = 3;
            // 
            // m_grvcol_ma_hoc_phan
            // 
            this.m_grvcol_ma_hoc_phan.Caption = "Mã học phần";
            this.m_grvcol_ma_hoc_phan.FieldName = "MA_HOC_PHAN";
            this.m_grvcol_ma_hoc_phan.Name = "m_grvcol_ma_hoc_phan";
            this.m_grvcol_ma_hoc_phan.Visible = true;
            this.m_grvcol_ma_hoc_phan.VisibleIndex = 1;
            // 
            // m_grvcol_so_tin_chi_hoc_phi
            // 
            this.m_grvcol_so_tin_chi_hoc_phi.Caption = "Số tín chỉ học phí";
            this.m_grvcol_so_tin_chi_hoc_phi.FieldName = "SO_TIN_CHI_HOC_PHI";
            this.m_grvcol_so_tin_chi_hoc_phi.Name = "m_grvcol_so_tin_chi_hoc_phi";
            this.m_grvcol_so_tin_chi_hoc_phi.Visible = true;
            this.m_grvcol_so_tin_chi_hoc_phi.VisibleIndex = 4;
            // 
            // m_grvcol_trong_so
            // 
            this.m_grvcol_trong_so.Caption = "Trọng số";
            this.m_grvcol_trong_so.FieldName = "TRONG_SO";
            this.m_grvcol_trong_so.Name = "m_grvcol_trong_so";
            this.m_grvcol_trong_so.Visible = true;
            this.m_grvcol_trong_so.VisibleIndex = 5;
            // 
            // m_grv_khoa_vien
            // 
            this.m_grv_khoa_vien.Caption = "Tên khoa viện";
            this.m_grv_khoa_vien.FieldName = "TEN_KHOA_VIEN";
            this.m_grv_khoa_vien.Name = "m_grv_khoa_vien";
            this.m_grv_khoa_vien.Visible = true;
            this.m_grv_khoa_vien.VisibleIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 120);
            this.panel2.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1032, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết học phần";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1026, 101);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.m_cbo_khoa_vien);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(336, 44);
            this.panel4.TabIndex = 0;
            // 
            // m_cbo_khoa_vien
            // 
            this.m_cbo_khoa_vien.FormattingEnabled = true;
            this.m_cbo_khoa_vien.Location = new System.Drawing.Point(88, 9);
            this.m_cbo_khoa_vien.Name = "m_cbo_khoa_vien";
            this.m_cbo_khoa_vien.Size = new System.Drawing.Size(234, 21);
            this.m_cbo_khoa_vien.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Khoa viện";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.m_txt_so_tin_chi_hoc_phi);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(345, 53);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(336, 45);
            this.panel7.TabIndex = 2;
            // 
            // m_txt_so_tin_chi_hoc_phi
            // 
            this.m_txt_so_tin_chi_hoc_phi.Location = new System.Drawing.Point(135, 9);
            this.m_txt_so_tin_chi_hoc_phi.Name = "m_txt_so_tin_chi_hoc_phi";
            this.m_txt_so_tin_chi_hoc_phi.Size = new System.Drawing.Size(198, 20);
            this.m_txt_so_tin_chi_hoc_phi.TabIndex = 21;
            this.m_txt_so_tin_chi_hoc_phi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_txt_so_tin_chi_hoc_phi_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Số tín chỉ học phí";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.m_txt_ten_hoc_phan);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(687, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(336, 44);
            this.panel6.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên học phần";
            // 
            // m_txt_ten_hoc_phan
            // 
            this.m_txt_ten_hoc_phan.Location = new System.Drawing.Point(93, 9);
            this.m_txt_ten_hoc_phan.Name = "m_txt_ten_hoc_phan";
            this.m_txt_ten_hoc_phan.Size = new System.Drawing.Size(235, 20);
            this.m_txt_ten_hoc_phan.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_txt_ma_hoc_phan);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(345, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 44);
            this.panel3.TabIndex = 0;
            // 
            // m_txt_ma_hoc_phan
            // 
            this.m_txt_ma_hoc_phan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_txt_ma_hoc_phan.Location = new System.Drawing.Point(94, 9);
            this.m_txt_ma_hoc_phan.Name = "m_txt_ma_hoc_phan";
            this.m_txt_ma_hoc_phan.Size = new System.Drawing.Size(239, 20);
            this.m_txt_ma_hoc_phan.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã học phần";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.m_txt_so_tin_chi_hoc_phan);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 53);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(336, 45);
            this.panel8.TabIndex = 3;
            // 
            // m_txt_so_tin_chi_hoc_phan
            // 
            this.m_txt_so_tin_chi_hoc_phan.Location = new System.Drawing.Point(124, 9);
            this.m_txt_so_tin_chi_hoc_phan.Name = "m_txt_so_tin_chi_hoc_phan";
            this.m_txt_so_tin_chi_hoc_phan.Size = new System.Drawing.Size(198, 20);
            this.m_txt_so_tin_chi_hoc_phan.TabIndex = 22;
            this.m_txt_so_tin_chi_hoc_phan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_txt_so_tin_chi_hoc_phan_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Số tín chỉ học phần";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.m_txt_trong_so);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(687, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(336, 45);
            this.panel5.TabIndex = 4;
            // 
            // m_txt_trong_so
            // 
            this.m_txt_trong_so.Location = new System.Drawing.Point(130, 9);
            this.m_txt_trong_so.Name = "m_txt_trong_so";
            this.m_txt_trong_so.Size = new System.Drawing.Size(198, 20);
            this.m_txt_trong_so.TabIndex = 20;
            this.m_txt_trong_so.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_txt_trong_so_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Trọng số";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_grc_dm_hoc_phan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 283);
            this.panel1.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel15);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 403);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1032, 53);
            this.panel9.TabIndex = 9;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.m_cmd_them);
            this.panel15.Controls.Add(this.m_cmd_xoa);
            this.panel15.Controls.Add(this.m_cmd_sua);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(626, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(406, 53);
            this.panel15.TabIndex = 2;
            // 
            // m_cmd_them
            // 
            this.m_cmd_them.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_them.Image")));
            this.m_cmd_them.Location = new System.Drawing.Point(32, 7);
            this.m_cmd_them.Name = "m_cmd_them";
            this.m_cmd_them.Size = new System.Drawing.Size(88, 35);
            this.m_cmd_them.TabIndex = 0;
            this.m_cmd_them.Text = "Thêm";
            this.m_cmd_them.Click += new System.EventHandler(this.m_cmd_them_Click);
            // 
            // m_cmd_xoa
            // 
            this.m_cmd_xoa.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xoa.Image")));
            this.m_cmd_xoa.Location = new System.Drawing.Point(293, 7);
            this.m_cmd_xoa.Name = "m_cmd_xoa";
            this.m_cmd_xoa.Size = new System.Drawing.Size(92, 35);
            this.m_cmd_xoa.TabIndex = 0;
            this.m_cmd_xoa.Text = "Xóa";
            this.m_cmd_xoa.Click += new System.EventHandler(this.m_cmd_xoa_Click);
            // 
            // m_cmd_sua
            // 
            this.m_cmd_sua.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_sua.Image")));
            this.m_cmd_sua.Location = new System.Drawing.Point(170, 7);
            this.m_cmd_sua.Name = "m_cmd_sua";
            this.m_cmd_sua.Size = new System.Drawing.Size(92, 35);
            this.m_cmd_sua.TabIndex = 0;
            this.m_cmd_sua.Text = "Cập nhật";
            this.m_cmd_sua.Click += new System.EventHandler(this.m_cmd_sua_Click);
            // 
            // f600_DM_HOC_PHAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 456);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel9);
            this.Name = "f600_DM_HOC_PHAN";
            this.Text = "f600_DM_HOC_PHAN";
            this.Load += new System.EventHandler(this.f600_DM_HOC_PHAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_hoc_phan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_hoc_phan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_dm_hoc_phan;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_hoc_phan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn m_grvcol_ma_hoc_phan;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn m_grvcol_so_tin_chi_hoc_phan;
        private DevExpress.XtraGrid.Columns.GridColumn m_grvcol_so_tin_chi_hoc_phi;
        private DevExpress.XtraGrid.Columns.GridColumn m_grvcol_trong_so;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txt_ten_hoc_phan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txt_ma_hoc_phan;
        private System.Windows.Forms.TextBox m_txt_trong_so;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel8;
        private DevExpress.XtraGrid.Columns.GridColumn m_grv_khoa_vien;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox m_txt_so_tin_chi_hoc_phi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m_txt_so_tin_chi_hoc_phan;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel15;
        private DevExpress.XtraEditors.SimpleButton m_cmd_them;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xoa;
        private DevExpress.XtraEditors.SimpleButton m_cmd_sua;
        private System.Windows.Forms.ComboBox m_cbo_khoa_vien;
    }
}