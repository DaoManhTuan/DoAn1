using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;




using System.Data.OleDb;
using DevExpress.XtraPivotGrid;
using System.Collections;


namespace TOSApp.BaoCao
{
    public partial class f9906_bao_cao_demo : Form
    {
        public f9906_bao_cao_demo()
        {
            InitializeComponent();
            load_data_2_grid();
             
            chartControl1.OptionsPrint.SizeMode = DevExpress.XtraCharts.Printing.PrintSizeMode.Zoom;
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "KET_QUA_HOC_TAP");
            pivotGridControl1.DataSource = v_ds.Tables[0];
            
        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        private void f9906_bao_cao_demo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUAN_LY_DIEMDataSet.KET_QUA_HOC_TAP' table. You can move, or remove it, as needed.
            this.kET_QUA_HOC_TAPTableAdapter.Fill(this.qUAN_LY_DIEMDataSet.KET_QUA_HOC_TAP);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DevExpress.XtraPrinting.PrintingSystem ps = new DevExpress.XtraPrinting.PrintingSystem();
            CompositeLink cl = new CompositeLink(ps);
            PrintableComponentLink pclChart = new PrintableComponentLink();
            PrintableComponentLink pclPivot = new PrintableComponentLink();

            pclChart.Component = chartControl1;
            pclPivot.Component = pivotGridControl1;

            cl.Links.AddRange(new object[] { pclChart, pclPivot });

            cl.ShowPreviewDialog();           
            cl.PrintingSystem.ExportToPdf(Application.StartupPath + "\\..\\..\\test.pdf");
           
        }

       
    }
}
