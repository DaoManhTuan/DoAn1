namespace TOSApp.BaoCao
{
    partial class f9907_bieu_do_CPA_GPA_sv
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView3 = new DevExpress.XtraCharts.LineSeriesView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.HO_TEN_SINH_VIEN = new DevExpress.XtraPivotGrid.PivotGridField();
            this.KY_HOC = new DevExpress.XtraPivotGrid.PivotGridField();
            this.CPA_ = new DevExpress.XtraPivotGrid.PivotGridField();
            this.GPA_ = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cmd_xuat_pdf = new DevExpress.XtraEditors.SimpleButton();
            this.m_lb_ho_ten_sinh_vien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_cmd_loc = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.m_txt_ma_sinh_vien = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(686, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 489);
            this.panel1.TabIndex = 0;
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.pivotGridControl1;
            xyDiagram1.AxisX.Title.Text = "Kỳ học";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Title.Text = "CPA GPA";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.MaxHorizontalPercentage = 30D;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "Series";
            series1.Name = "Series 1";
            series1.View = lineSeriesView1;
            series1.Visible = false;
            series2.Name = "Series 2";
            series2.View = lineSeriesView2;
            series2.Visible = false;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.chartControl1.SeriesTemplate.View = lineSeriesView3;
            this.chartControl1.Size = new System.Drawing.Size(440, 489);
            this.chartControl1.TabIndex = 0;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.HO_TEN_SINH_VIEN,
            this.KY_HOC,
            this.CPA_,
            this.GPA_});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(686, 389);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // HO_TEN_SINH_VIEN
            // 
            this.HO_TEN_SINH_VIEN.AreaIndex = 0;
            this.HO_TEN_SINH_VIEN.Caption = "Sinh viên";
            this.HO_TEN_SINH_VIEN.FieldName = "TEN_SINH_VIEN";
            this.HO_TEN_SINH_VIEN.Name = "HO_TEN_SINH_VIEN";
            this.HO_TEN_SINH_VIEN.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            // 
            // KY_HOC
            // 
            this.KY_HOC.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.KY_HOC.AreaIndex = 0;
            this.KY_HOC.Caption = "Kỳ học";
            this.KY_HOC.FieldName = "MA_HOC_KY";
            this.KY_HOC.Name = "KY_HOC";
            // 
            // CPA_
            // 
            this.CPA_.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.CPA_.AreaIndex = 0;
            this.CPA_.Caption = "CPA";
            this.CPA_.CellFormat.FormatString = "0.0  kWatt/h";
            this.CPA_.FieldName = "CPA";
            this.CPA_.Name = "CPA_";
            // 
            // GPA_
            // 
            this.GPA_.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.GPA_.AreaIndex = 1;
            this.GPA_.Caption = "GPA";
            this.GPA_.CellFormat.FormatString = "0.0  kWatt/h";
            this.GPA_.FieldName = "GPA";
            this.GPA_.Name = "GPA_";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_cmd_xuat_pdf);
            this.panel2.Controls.Add(this.m_lb_ho_ten_sinh_vien);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.m_cmd_loc);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.m_txt_ma_sinh_vien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 100);
            this.panel2.TabIndex = 0;
            // 
            // m_cmd_xuat_pdf
            // 
            this.m_cmd_xuat_pdf.Location = new System.Drawing.Point(445, 29);
            this.m_cmd_xuat_pdf.Name = "m_cmd_xuat_pdf";
            this.m_cmd_xuat_pdf.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_xuat_pdf.TabIndex = 4;
            this.m_cmd_xuat_pdf.Text = "Xuất PDF";
            this.m_cmd_xuat_pdf.Click += new System.EventHandler(this.m_cmd_xuat_pdf_Click);
            // 
            // m_lb_ho_ten_sinh_vien
            // 
            this.m_lb_ho_ten_sinh_vien.AutoSize = true;
            this.m_lb_ho_ten_sinh_vien.Location = new System.Drawing.Point(127, 75);
            this.m_lb_ho_ten_sinh_vien.Name = "m_lb_ho_ten_sinh_vien";
            this.m_lb_ho_ten_sinh_vien.Size = new System.Drawing.Size(87, 13);
            this.m_lb_ho_ten_sinh_vien.TabIndex = 3;
            this.m_lb_ho_ten_sinh_vien.Text = "Họ tên sinh viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên sinh viên:";
            // 
            // m_cmd_loc
            // 
            this.m_cmd_loc.Location = new System.Drawing.Point(330, 30);
            this.m_cmd_loc.Name = "m_cmd_loc";
            this.m_cmd_loc.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_loc.TabIndex = 2;
            this.m_cmd_loc.Text = "Lọc";
            this.m_cmd_loc.Click += new System.EventHandler(this.m_cmd_loc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sinh viên";
            // 
            // m_txt_ma_sinh_vien
            // 
            this.m_txt_ma_sinh_vien.Location = new System.Drawing.Point(129, 32);
            this.m_txt_ma_sinh_vien.Name = "m_txt_ma_sinh_vien";
            this.m_txt_ma_sinh_vien.Size = new System.Drawing.Size(160, 20);
            this.m_txt_ma_sinh_vien.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pivotGridControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(686, 389);
            this.panel3.TabIndex = 0;
            // 
            // f9907_bieu_do_CPA_GPA_sv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 489);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f9907_bieu_do_CPA_GPA_sv";
            this.Text = "f9907_bieu_do_CPA_GPA_sv";
            this.Load += new System.EventHandler(this.f9907_bieu_do_CPA_GPA_sv_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_loc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txt_ma_sinh_vien;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField HO_TEN_SINH_VIEN;
        private DevExpress.XtraPivotGrid.PivotGridField KY_HOC;
        private DevExpress.XtraPivotGrid.PivotGridField CPA_;
        private DevExpress.XtraPivotGrid.PivotGridField GPA_;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label m_lb_ho_ten_sinh_vien;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_pdf;
    }
}