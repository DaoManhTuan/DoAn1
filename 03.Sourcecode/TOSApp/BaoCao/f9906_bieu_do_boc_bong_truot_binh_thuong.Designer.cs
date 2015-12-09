namespace TOSApp.BaoCao
{
    partial class f9906_bieu_do_boc_bong_truot_binh_thuong
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
            DevExpress.XtraCharts.SimpleDiagram simpleDiagram1 = new DevExpress.XtraCharts.SimpleDiagram();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle1 = new DevExpress.XtraCharts.SeriesTitle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f9906_bieu_do_boc_bong_truot_binh_thuong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.m_pivot_ty_le_hoc_bong = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.m_pivot_ty_le = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.m_pivot_phan_tram = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_cmd_xua_bao_cao = new DevExpress.XtraEditors.SimpleButton();
            this.m_cbo_hoc_ky = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_cmd_loc = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pivot_ty_le_hoc_bong)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(662, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 482);
            this.panel1.TabIndex = 0;
            // 
            // chartControl1
            // 
            this.chartControl1.AppearanceNameSerializable = "Northern Lights";
            this.chartControl1.DataSource = this.m_pivot_ty_le_hoc_bong;
            simpleDiagram1.Dimension = 1;
            simpleDiagram1.EqualPieSize = false;
            this.chartControl1.Diagram = simpleDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.MaxHorizontalPercentage = 30D;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "Series";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            pieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns;
            this.chartControl1.SeriesTemplate.Label = pieSeriesLabel1;
            this.chartControl1.SeriesTemplate.LegendTextPattern = "{A}";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values";
            pieSeriesView1.RuntimeExploding = false;
            pieSeriesView1.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise;
            pieSeriesView1.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle1});
            this.chartControl1.SeriesTemplate.View = pieSeriesView1;
            this.chartControl1.Size = new System.Drawing.Size(393, 482);
            this.chartControl1.TabIndex = 0;
            // 
            // m_pivot_ty_le_hoc_bong
            // 
            this.m_pivot_ty_le_hoc_bong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_pivot_ty_le_hoc_bong.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField1,
            this.m_pivot_ty_le,
            this.pivotGridField4,
            this.m_pivot_phan_tram});
            this.m_pivot_ty_le_hoc_bong.Location = new System.Drawing.Point(0, 0);
            this.m_pivot_ty_le_hoc_bong.Name = "m_pivot_ty_le_hoc_bong";
            this.m_pivot_ty_le_hoc_bong.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.m_pivot_ty_le_hoc_bong.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.m_pivot_ty_le_hoc_bong.Size = new System.Drawing.Size(662, 424);
            this.m_pivot_ty_le_hoc_bong.TabIndex = 0;
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "Phân loại";
            this.pivotGridField1.FieldName = "HocKy";
            this.pivotGridField1.Name = "pivotGridField1";
            // 
            // m_pivot_ty_le
            // 
            this.m_pivot_ty_le.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.m_pivot_ty_le.AreaIndex = 0;
            this.m_pivot_ty_le.Caption = "Tỷ lệ";
            this.m_pivot_ty_le.FieldName = "TyLe";
            this.m_pivot_ty_le.GrandTotalText = "Tỉ lệ";
            this.m_pivot_ty_le.Name = "m_pivot_ty_le";
            // 
            // pivotGridField4
            // 
            this.pivotGridField4.AreaIndex = 0;
            this.pivotGridField4.Caption = "Học kỳ";
            this.pivotGridField4.FieldName = "Ky";
            this.pivotGridField4.Name = "pivotGridField4";
            // 
            // m_pivot_phan_tram
            // 
            this.m_pivot_phan_tram.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.m_pivot_phan_tram.AreaIndex = 1;
            this.m_pivot_phan_tram.Caption = "Phần trăm";
            this.m_pivot_phan_tram.FieldName = "PhanTram";
            this.m_pivot_phan_tram.Name = "m_pivot_phan_tram";
            this.m_pivot_phan_tram.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 482);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.m_pivot_ty_le_hoc_bong);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(662, 424);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_cmd_xua_bao_cao);
            this.panel3.Controls.Add(this.m_cbo_hoc_ky);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.m_cmd_loc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(662, 58);
            this.panel3.TabIndex = 0;
            // 
            // m_cmd_xua_bao_cao
            // 
            this.m_cmd_xua_bao_cao.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xua_bao_cao.Image")));
            this.m_cmd_xua_bao_cao.Location = new System.Drawing.Point(519, 8);
            this.m_cmd_xua_bao_cao.Name = "m_cmd_xua_bao_cao";
            this.m_cmd_xua_bao_cao.Size = new System.Drawing.Size(113, 36);
            this.m_cmd_xua_bao_cao.TabIndex = 3;
            this.m_cmd_xua_bao_cao.Text = "Xuất báo cáo";
            this.m_cmd_xua_bao_cao.Click += new System.EventHandler(this.m_cmd_xua_bao_cao_Click);
            // 
            // m_cbo_hoc_ky
            // 
            this.m_cbo_hoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_hoc_ky.FormattingEnabled = true;
            this.m_cbo_hoc_ky.Location = new System.Drawing.Point(100, 16);
            this.m_cbo_hoc_ky.Name = "m_cbo_hoc_ky";
            this.m_cbo_hoc_ky.Size = new System.Drawing.Size(121, 21);
            this.m_cbo_hoc_ky.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kỳ học";
            // 
            // m_cmd_loc
            // 
            this.m_cmd_loc.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_loc.Image")));
            this.m_cmd_loc.Location = new System.Drawing.Point(422, 8);
            this.m_cmd_loc.Name = "m_cmd_loc";
            this.m_cmd_loc.Size = new System.Drawing.Size(75, 36);
            this.m_cmd_loc.TabIndex = 0;
            this.m_cmd_loc.Text = "Lọc";
            this.m_cmd_loc.Click += new System.EventHandler(this.m_cmd_loc_Click);
            // 
            // f9906_bieu_do_boc_bong_truot_binh_thuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f9906_bieu_do_boc_bong_truot_binh_thuong";
            this.Text = "Tỷ lệ học bổng";
            this.Load += new System.EventHandler(this.f9906_bao_cao_demo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pivot_ty_le_hoc_bong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraPivotGrid.PivotGridControl m_pivot_ty_le_hoc_bong;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField m_pivot_ty_le;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private DevExpress.XtraEditors.SimpleButton m_cmd_loc;
        private System.Windows.Forms.ComboBox m_cbo_hoc_ky;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xua_bao_cao;
        private DevExpress.XtraPivotGrid.PivotGridField m_pivot_phan_tram;
    }
}