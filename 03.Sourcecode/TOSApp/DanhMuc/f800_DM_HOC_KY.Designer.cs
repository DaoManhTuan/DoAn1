namespace TOSApp.DanhMuc
{
    partial class f800_DM_HOC_KY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f800_DM_HOC_KY));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.m_cmd_them = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_sua = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.m_txt_nam_ket_thuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_txt_nam_bat_dau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_txt_ma_hoc_ky = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_grc_dm_hoc_ky = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_hoc_ky = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MA_HOC_KY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAM_HOC_BAT_DAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAM_HOC_KET_THUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel15.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_hoc_ky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_hoc_ky)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel15, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.m_grc_dm_hoc_ky, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 490);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.m_cmd_them);
            this.panel15.Controls.Add(this.m_cmd_xoa);
            this.panel15.Controls.Add(this.m_cmd_sua);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(658, 419);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(406, 68);
            this.panel15.TabIndex = 3;
            // 
            // m_cmd_them
            // 
            this.m_cmd_them.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_them.Image")));
            this.m_cmd_them.Location = new System.Drawing.Point(41, 24);
            this.m_cmd_them.Name = "m_cmd_them";
            this.m_cmd_them.Size = new System.Drawing.Size(88, 35);
            this.m_cmd_them.TabIndex = 0;
            this.m_cmd_them.Text = "Thêm";
            this.m_cmd_them.Click += new System.EventHandler(this.m_cmd_them_Click);
            // 
            // m_cmd_xoa
            // 
            this.m_cmd_xoa.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xoa.Image")));
            this.m_cmd_xoa.Location = new System.Drawing.Point(291, 24);
            this.m_cmd_xoa.Name = "m_cmd_xoa";
            this.m_cmd_xoa.Size = new System.Drawing.Size(92, 35);
            this.m_cmd_xoa.TabIndex = 0;
            this.m_cmd_xoa.Text = "Xóa";
            this.m_cmd_xoa.Click += new System.EventHandler(this.m_cmd_xoa_Click);
            // 
            // m_cmd_sua
            // 
            this.m_cmd_sua.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_sua.Image")));
            this.m_cmd_sua.Location = new System.Drawing.Point(166, 24);
            this.m_cmd_sua.Name = "m_cmd_sua";
            this.m_cmd_sua.Size = new System.Drawing.Size(92, 35);
            this.m_cmd_sua.TabIndex = 0;
            this.m_cmd_sua.Text = "Cập nhật";
            this.m_cmd_sua.Click += new System.EventHandler(this.m_cmd_sua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1061, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết học kỳ";
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1055, 73);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(705, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 67);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.m_txt_nam_ket_thuc);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(347, 67);
            this.panel4.TabIndex = 4;
            // 
            // m_txt_nam_ket_thuc
            // 
            this.m_txt_nam_ket_thuc.Location = new System.Drawing.Point(178, 18);
            this.m_txt_nam_ket_thuc.MaxLength = 4;
            this.m_txt_nam_ket_thuc.Name = "m_txt_nam_ket_thuc";
            this.m_txt_nam_ket_thuc.Size = new System.Drawing.Size(131, 20);
            this.m_txt_nam_ket_thuc.TabIndex = 1;
            this.m_txt_nam_ket_thuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_txt_nam_ket_thuc_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Năm học kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã học kỳ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_txt_nam_bat_dau);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(354, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 67);
            this.panel2.TabIndex = 1;
            // 
            // m_txt_nam_bat_dau
            // 
            this.m_txt_nam_bat_dau.Location = new System.Drawing.Point(182, 18);
            this.m_txt_nam_bat_dau.MaxLength = 4;
            this.m_txt_nam_bat_dau.Name = "m_txt_nam_bat_dau";
            this.m_txt_nam_bat_dau.Size = new System.Drawing.Size(144, 20);
            this.m_txt_nam_bat_dau.TabIndex = 1;
            this.m_txt_nam_bat_dau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_txt_nam_bat_dau_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm học bắt đầu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_txt_ma_hoc_ky);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 67);
            this.panel1.TabIndex = 0;
            // 
            // m_txt_ma_hoc_ky
            // 
            this.m_txt_ma_hoc_ky.Location = new System.Drawing.Point(143, 18);
            this.m_txt_ma_hoc_ky.Name = "m_txt_ma_hoc_ky";
            this.m_txt_ma_hoc_ky.Size = new System.Drawing.Size(140, 20);
            this.m_txt_ma_hoc_ky.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học kỳ";
            // 
            // m_grc_dm_hoc_ky
            // 
            this.m_grc_dm_hoc_ky.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_hoc_ky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_hoc_ky.Location = new System.Drawing.Point(3, 101);
            this.m_grc_dm_hoc_ky.MainView = this.m_grv_dm_hoc_ky;
            this.m_grc_dm_hoc_ky.Name = "m_grc_dm_hoc_ky";
            this.m_grc_dm_hoc_ky.Size = new System.Drawing.Size(1061, 312);
            this.m_grc_dm_hoc_ky.TabIndex = 1;
            this.m_grc_dm_hoc_ky.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_hoc_ky});
            // 
            // m_grv_dm_hoc_ky
            // 
            this.m_grv_dm_hoc_ky.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MA_HOC_KY,
            this.NAM_HOC_BAT_DAU,
            this.NAM_HOC_KET_THUC});
            this.m_grv_dm_hoc_ky.GridControl = this.m_grc_dm_hoc_ky;
            this.m_grv_dm_hoc_ky.Name = "m_grv_dm_hoc_ky";
            this.m_grv_dm_hoc_ky.OptionsBehavior.Editable = false;
            this.m_grv_dm_hoc_ky.OptionsBehavior.ReadOnly = true;
            this.m_grv_dm_hoc_ky.OptionsFind.AlwaysVisible = true;
            this.m_grv_dm_hoc_ky.OptionsView.ShowAutoFilterRow = true;
            this.m_grv_dm_hoc_ky.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.m_grv_dm_khoa_FocusedRowChanged);
            // 
            // MA_HOC_KY
            // 
            this.MA_HOC_KY.Caption = "Mã học kỳ";
            this.MA_HOC_KY.FieldName = "MA_HOC_KY";
            this.MA_HOC_KY.Name = "MA_HOC_KY";
            this.MA_HOC_KY.Visible = true;
            this.MA_HOC_KY.VisibleIndex = 0;
            // 
            // NAM_HOC_BAT_DAU
            // 
            this.NAM_HOC_BAT_DAU.Caption = "Năm học bắt đầu";
            this.NAM_HOC_BAT_DAU.FieldName = "NAM_HOC_BAT_DAU";
            this.NAM_HOC_BAT_DAU.Name = "NAM_HOC_BAT_DAU";
            this.NAM_HOC_BAT_DAU.Visible = true;
            this.NAM_HOC_BAT_DAU.VisibleIndex = 1;
            // 
            // NAM_HOC_KET_THUC
            // 
            this.NAM_HOC_KET_THUC.Caption = "Năm học kết thúc";
            this.NAM_HOC_KET_THUC.FieldName = "NAM_HOC_KET_THUC";
            this.NAM_HOC_KET_THUC.Name = "NAM_HOC_KET_THUC";
            this.NAM_HOC_KET_THUC.Visible = true;
            this.NAM_HOC_KET_THUC.VisibleIndex = 2;
            // 
            // f800_DM_HOC_KY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 490);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "f800_DM_HOC_KY";
            this.Text = "f800_DM_HOC_KY";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_hoc_ky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_hoc_ky)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl m_grc_dm_hoc_ky;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_hoc_ky;
        private System.Windows.Forms.Panel panel15;
        private DevExpress.XtraEditors.SimpleButton m_cmd_them;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xoa;
        private DevExpress.XtraEditors.SimpleButton m_cmd_sua;
        private DevExpress.XtraGrid.Columns.GridColumn MA_HOC_KY;
        private DevExpress.XtraGrid.Columns.GridColumn NAM_HOC_BAT_DAU;
        private DevExpress.XtraGrid.Columns.GridColumn NAM_HOC_KET_THUC;
        private System.Windows.Forms.TextBox m_txt_nam_ket_thuc;
        private System.Windows.Forms.TextBox m_txt_nam_bat_dau;
        private System.Windows.Forms.TextBox m_txt_ma_hoc_ky;
    }
}