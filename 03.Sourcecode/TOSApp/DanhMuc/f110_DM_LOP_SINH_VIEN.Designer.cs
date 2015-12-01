namespace TOSApp.DanhMuc
{
    partial class f110_DM_LOP_SINH_VIEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f110_DM_LOP_SINH_VIEN));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.m_cmd_them = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_sua = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_txt_lop_sinh_vien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cbo_ten_khoa_vien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cbo_khoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_grc_dm_lop_sinh_vien = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_lop_sinh_vien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_grvcol_lop_sinh_vien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_grvcol_ten_khoa_vien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_grvcol_khoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel15.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_lop_sinh_vien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_lop_sinh_vien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel15, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.m_grc_dm_lop_sinh_vien, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.95934F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.08398F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.95668F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(896, 335);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.m_cmd_them);
            this.panel15.Controls.Add(this.m_cmd_xoa);
            this.panel15.Controls.Add(this.m_cmd_sua);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(487, 284);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(406, 48);
            this.panel15.TabIndex = 4;
            // 
            // m_cmd_them
            // 
            this.m_cmd_them.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_them.Image")));
            this.m_cmd_them.Location = new System.Drawing.Point(31, 12);
            this.m_cmd_them.Name = "m_cmd_them";
            this.m_cmd_them.Size = new System.Drawing.Size(88, 35);
            this.m_cmd_them.TabIndex = 0;
            this.m_cmd_them.Text = "Thêm";
            this.m_cmd_them.Click += new System.EventHandler(this.m_cmd_them_Click);
            // 
            // m_cmd_xoa
            // 
            this.m_cmd_xoa.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xoa.Image")));
            this.m_cmd_xoa.Location = new System.Drawing.Point(283, 12);
            this.m_cmd_xoa.Name = "m_cmd_xoa";
            this.m_cmd_xoa.Size = new System.Drawing.Size(92, 35);
            this.m_cmd_xoa.TabIndex = 0;
            this.m_cmd_xoa.Text = "Xóa";
            this.m_cmd_xoa.Click += new System.EventHandler(this.m_cmd_xoa_Click);
            // 
            // m_cmd_sua
            // 
            this.m_cmd_sua.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_sua.Image")));
            this.m_cmd_sua.Location = new System.Drawing.Point(157, 12);
            this.m_cmd_sua.Name = "m_cmd_sua";
            this.m_cmd_sua.Size = new System.Drawing.Size(92, 35);
            this.m_cmd_sua.TabIndex = 0;
            this.m_cmd_sua.Text = "Cập nhật";
            this.m_cmd_sua.Click += new System.EventHandler(this.m_cmd_sua_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(890, 47);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_txt_lop_sinh_vien);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(595, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 41);
            this.panel3.TabIndex = 2;
            // 
            // m_txt_lop_sinh_vien
            // 
            this.m_txt_lop_sinh_vien.Location = new System.Drawing.Point(97, 19);
            this.m_txt_lop_sinh_vien.Name = "m_txt_lop_sinh_vien";
            this.m_txt_lop_sinh_vien.Size = new System.Drawing.Size(156, 20);
            this.m_txt_lop_sinh_vien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp sinh viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_cbo_ten_khoa_vien);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(299, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 41);
            this.panel2.TabIndex = 1;
            // 
            // m_cbo_ten_khoa_vien
            // 
            this.m_cbo_ten_khoa_vien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_ten_khoa_vien.FormattingEnabled = true;
            this.m_cbo_ten_khoa_vien.Location = new System.Drawing.Point(112, 18);
            this.m_cbo_ten_khoa_vien.Name = "m_cbo_ten_khoa_vien";
            this.m_cbo_ten_khoa_vien.Size = new System.Drawing.Size(156, 21);
            this.m_cbo_ten_khoa_vien.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Khoa Viện";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cbo_khoa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 41);
            this.panel1.TabIndex = 0;
            // 
            // m_cbo_khoa
            // 
            this.m_cbo_khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_khoa.FormattingEnabled = true;
            this.m_cbo_khoa.Location = new System.Drawing.Point(86, 18);
            this.m_cbo_khoa.Name = "m_cbo_khoa";
            this.m_cbo_khoa.Size = new System.Drawing.Size(156, 21);
            this.m_cbo_khoa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Khóa";
            // 
            // m_grc_dm_lop_sinh_vien
            // 
            this.m_grc_dm_lop_sinh_vien.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_lop_sinh_vien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_lop_sinh_vien.Location = new System.Drawing.Point(3, 56);
            this.m_grc_dm_lop_sinh_vien.MainView = this.m_grv_dm_lop_sinh_vien;
            this.m_grc_dm_lop_sinh_vien.Name = "m_grc_dm_lop_sinh_vien";
            this.m_grc_dm_lop_sinh_vien.Size = new System.Drawing.Size(890, 222);
            this.m_grc_dm_lop_sinh_vien.TabIndex = 1;
            this.m_grc_dm_lop_sinh_vien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_lop_sinh_vien});
            // 
            // m_grv_dm_lop_sinh_vien
            // 
            this.m_grv_dm_lop_sinh_vien.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.m_grv_dm_lop_sinh_vien.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.m_grv_dm_lop_sinh_vien.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.m_grv_dm_lop_sinh_vien.Appearance.Empty.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_dm_lop_sinh_vien.Appearance.EvenRow.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.EvenRow.Options.UseBorderColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.EvenRow.Options.UseForeColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.m_grv_dm_lop_sinh_vien.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.m_grv_dm_lop_sinh_vien.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_dm_lop_sinh_vien.Appearance.FilterPanel.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.FilterPanel.Options.UseForeColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(133)))), ((int)(((byte)(195)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.FixedLine.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.m_grv_dm_lop_sinh_vien.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.m_grv_dm_lop_sinh_vien.Appearance.FocusedCell.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.FocusedCell.Options.UseForeColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(189)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.m_grv_dm_lop_sinh_vien.Appearance.FocusedRow.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.FocusedRow.Options.UseForeColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_dm_lop_sinh_vien.Appearance.FooterPanel.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.FooterPanel.Options.UseForeColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.GroupButton.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.GroupButton.Options.UseBorderColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.m_grv_dm_lop_sinh_vien.Appearance.GroupFooter.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.GroupFooter.Options.UseForeColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.m_grv_dm_lop_sinh_vien.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_dm_lop_sinh_vien.Appearance.GroupPanel.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.GroupPanel.Options.UseForeColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_dm_lop_sinh_vien.Appearance.GroupRow.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.GroupRow.Options.UseBorderColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.GroupRow.Options.UseForeColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_dm_lop_sinh_vien.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.HorzLine.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_dm_lop_sinh_vien.Appearance.OddRow.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.OddRow.Options.UseBorderColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.OddRow.Options.UseForeColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.m_grv_dm_lop_sinh_vien.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.Preview.Options.UseFont = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.Preview.Options.UseForeColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.m_grv_dm_lop_sinh_vien.Appearance.Row.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.Row.Options.UseForeColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.m_grv_dm_lop_sinh_vien.Appearance.RowSeparator.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.m_grv_dm_lop_sinh_vien.Appearance.SelectedRow.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.SelectedRow.Options.UseForeColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.m_grv_dm_lop_sinh_vien.Appearance.TopNewRow.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_dm_lop_sinh_vien.Appearance.VertLine.Options.UseBackColor = true;
            this.m_grv_dm_lop_sinh_vien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.m_grvcol_lop_sinh_vien,
            this.m_grvcol_ten_khoa_vien,
            this.m_grvcol_khoa});
            this.m_grv_dm_lop_sinh_vien.GridControl = this.m_grc_dm_lop_sinh_vien;
            this.m_grv_dm_lop_sinh_vien.Name = "m_grv_dm_lop_sinh_vien";
            this.m_grv_dm_lop_sinh_vien.OptionsBehavior.Editable = false;
            this.m_grv_dm_lop_sinh_vien.OptionsFind.AlwaysVisible = true;
            this.m_grv_dm_lop_sinh_vien.OptionsView.ShowAutoFilterRow = true;
            this.m_grv_dm_lop_sinh_vien.PaintStyleName = "Office2003";
            this.m_grv_dm_lop_sinh_vien.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.m_grv_dm_lop_sinh_vien_FocusedRowChanged);
            // 
            // m_grvcol_lop_sinh_vien
            // 
            this.m_grvcol_lop_sinh_vien.Caption = "Lớp sinh viên";
            this.m_grvcol_lop_sinh_vien.FieldName = "LOP_SINH_VIEN";
            this.m_grvcol_lop_sinh_vien.Name = "m_grvcol_lop_sinh_vien";
            this.m_grvcol_lop_sinh_vien.Visible = true;
            this.m_grvcol_lop_sinh_vien.VisibleIndex = 0;
            // 
            // m_grvcol_ten_khoa_vien
            // 
            this.m_grvcol_ten_khoa_vien.Caption = "Tên khoa viện";
            this.m_grvcol_ten_khoa_vien.FieldName = "TEN_KHOA_VIEN";
            this.m_grvcol_ten_khoa_vien.Name = "m_grvcol_ten_khoa_vien";
            this.m_grvcol_ten_khoa_vien.Visible = true;
            this.m_grvcol_ten_khoa_vien.VisibleIndex = 1;
            // 
            // m_grvcol_khoa
            // 
            this.m_grvcol_khoa.Caption = "Khóa";
            this.m_grvcol_khoa.FieldName = "KHOA";
            this.m_grvcol_khoa.Name = "m_grvcol_khoa";
            this.m_grvcol_khoa.Visible = true;
            this.m_grvcol_khoa.VisibleIndex = 2;
            // 
            // f110_DM_LOP_SINH_VIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 354);
            this.Controls.Add(this.groupBox1);
            this.Name = "f110_DM_LOP_SINH_VIEN";
            this.Text = "DANH MỤC LỚP SINH VIÊN";
            this.Load += new System.EventHandler(this.f110_DM_LOP_SINH_VIEN_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_lop_sinh_vien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_lop_sinh_vien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel15;
        private DevExpress.XtraEditors.SimpleButton m_cmd_them;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xoa;
        private DevExpress.XtraEditors.SimpleButton m_cmd_sua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl m_grc_dm_lop_sinh_vien;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_lop_sinh_vien;
        private System.Windows.Forms.ComboBox m_cbo_khoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox m_cbo_ten_khoa_vien;
        private System.Windows.Forms.TextBox m_txt_lop_sinh_vien;
        private DevExpress.XtraGrid.Columns.GridColumn m_grvcol_lop_sinh_vien;
        private DevExpress.XtraGrid.Columns.GridColumn m_grvcol_ten_khoa_vien;
        private DevExpress.XtraGrid.Columns.GridColumn m_grvcol_khoa;
    }
}