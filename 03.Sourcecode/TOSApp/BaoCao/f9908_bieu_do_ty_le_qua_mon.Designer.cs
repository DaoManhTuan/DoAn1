namespace TOSApp.BaoCao
{
    partial class f9908_bieu_do_ty_le_qua_mon
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("Grand Total", null, 0);
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle1 = new DevExpress.XtraCharts.SeriesTitle();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView2 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel2 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView3 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle2 = new DevExpress.XtraCharts.SeriesTitle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.m_pivot = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_lb_ten_hoc_phan = new System.Windows.Forms.Label();
            this.m_cbo_ky_hoc = new System.Windows.Forms.ComboBox();
            this.m_cbo_hoc_phan = new System.Windows.Forms.ComboBox();
            this.m_cmd_xuat_pdf = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.m_cmd_loc = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.m_col_qua = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pivot)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(735, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 535);
            this.panel1.TabIndex = 3;
            // 
            // chartControl1
            // 
            this.chartControl1.AppearanceNameSerializable = "Chameleon";
            this.chartControl1.DataSource = this.m_pivot;
            simpleDiagram1.Dimension = 1;
            simpleDiagram1.EqualPieSize = false;
            this.chartControl1.Diagram = simpleDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.MaxHorizontalPercentage = 30D;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "Series";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            pieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns;
            pieSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default;
            series1.Label = pieSeriesLabel1;
            series1.LegendTextPattern = "{A}";
            series1.Name = "Tổng sinh viên Total";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1});
            series1.Tag = "Tổng sinh viên Total";
            pieSeriesView1.RuntimeExploding = false;
            pieSeriesView1.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise;
            seriesTitle1.Text = "Tổng sinh viên Total";
            pieSeriesView1.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle1});
            series1.View = pieSeriesView1;
            series2.Name = "Series 1";
            pieSeriesView2.RuntimeExploding = false;
            pieSeriesView2.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise;
            series2.View = pieSeriesView2;
            series2.Visible = false;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            pieSeriesLabel2.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns;
            this.chartControl1.SeriesTemplate.Label = pieSeriesLabel2;
            this.chartControl1.SeriesTemplate.LegendTextPattern = "{A}";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values";
            pieSeriesView3.RuntimeExploding = false;
            pieSeriesView3.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise;
            pieSeriesView3.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle2});
            this.chartControl1.SeriesTemplate.View = pieSeriesView3;
            this.chartControl1.Size = new System.Drawing.Size(390, 535);
            this.chartControl1.TabIndex = 0;
            // 
            // m_pivot
            // 
            this.m_pivot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_pivot.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.m_col_qua,
            this.pivotGridField3});
            this.m_pivot.Location = new System.Drawing.Point(0, 0);
            this.m_pivot.Name = "m_pivot";
            this.m_pivot.Size = new System.Drawing.Size(735, 445);
            this.m_pivot.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_lb_ten_hoc_phan);
            this.panel3.Controls.Add(this.m_cbo_ky_hoc);
            this.panel3.Controls.Add(this.m_cbo_hoc_phan);
            this.panel3.Controls.Add(this.m_cmd_xuat_pdf);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.m_cmd_loc);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(735, 90);
            this.panel3.TabIndex = 3;
            // 
            // m_lb_ten_hoc_phan
            // 
            this.m_lb_ten_hoc_phan.AutoSize = true;
            this.m_lb_ten_hoc_phan.Location = new System.Drawing.Point(373, 32);
            this.m_lb_ten_hoc_phan.Name = "m_lb_ten_hoc_phan";
            this.m_lb_ten_hoc_phan.Size = new System.Drawing.Size(74, 13);
            this.m_lb_ten_hoc_phan.TabIndex = 14;
            this.m_lb_ten_hoc_phan.Text = "Tên học phần";
            // 
            // m_cbo_ky_hoc
            // 
            this.m_cbo_ky_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_ky_hoc.FormattingEnabled = true;
            this.m_cbo_ky_hoc.Location = new System.Drawing.Point(49, 27);
            this.m_cbo_ky_hoc.Name = "m_cbo_ky_hoc";
            this.m_cbo_ky_hoc.Size = new System.Drawing.Size(115, 21);
            this.m_cbo_ky_hoc.TabIndex = 13;
            this.m_cbo_ky_hoc.SelectedIndexChanged += new System.EventHandler(this.m_cbo_ky_hoc_SelectedIndexChanged);
            // 
            // m_cbo_hoc_phan
            // 
            this.m_cbo_hoc_phan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_hoc_phan.FormattingEnabled = true;
            this.m_cbo_hoc_phan.Location = new System.Drawing.Point(246, 27);
            this.m_cbo_hoc_phan.Name = "m_cbo_hoc_phan";
            this.m_cbo_hoc_phan.Size = new System.Drawing.Size(111, 21);
            this.m_cbo_hoc_phan.TabIndex = 13;
            this.m_cbo_hoc_phan.SelectedIndexChanged += new System.EventHandler(this.m_cbo_hoc_phan_SelectedIndexChanged);
            // 
            // m_cmd_xuat_pdf
            // 
            this.m_cmd_xuat_pdf.Location = new System.Drawing.Point(654, 27);
            this.m_cmd_xuat_pdf.Name = "m_cmd_xuat_pdf";
            this.m_cmd_xuat_pdf.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_xuat_pdf.TabIndex = 12;
            this.m_cmd_xuat_pdf.Text = "Xuất PDF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kỳ học";
            // 
            // m_cmd_loc
            // 
            this.m_cmd_loc.Location = new System.Drawing.Point(573, 26);
            this.m_cmd_loc.Name = "m_cmd_loc";
            this.m_cmd_loc.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_loc.TabIndex = 11;
            this.m_cmd_loc.Text = "Lọc";
            this.m_cmd_loc.Click += new System.EventHandler(this.m_cmd_loc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã học phần";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.m_pivot);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(735, 445);
            this.panel4.TabIndex = 3;
            // 
            // m_col_qua
            // 
            this.m_col_qua.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.m_col_qua.AreaIndex = 0;
            this.m_col_qua.Caption = "Tổng sinh viên";
            this.m_col_qua.FieldName = "Qua";
            this.m_col_qua.Name = "m_col_qua";
            this.m_col_qua.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn;
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField3.AreaIndex = 0;
            this.pivotGridField3.Caption = "Trạng thaí";
            this.pivotGridField3.FieldName = "HocKy";
            this.pivotGridField3.Name = "pivotGridField3";
            // 
            // f9908_bieu_do_ty_le_qua_mon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 535);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "f9908_bieu_do_ty_le_qua_mon";
            this.Text = "f9908_bieu_do_ty_le_qua_mon";
            this.Load += new System.EventHandler(this.f9908_bieu_do_ty_le_qua_mon_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pivot)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox m_cbo_ky_hoc;
        private System.Windows.Forms.ComboBox m_cbo_hoc_phan;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_pdf;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_loc;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraPivotGrid.PivotGridControl m_pivot;
        private System.Windows.Forms.Label m_lb_ten_hoc_phan;
        private DevExpress.XtraPivotGrid.PivotGridField m_col_qua;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
    }
}