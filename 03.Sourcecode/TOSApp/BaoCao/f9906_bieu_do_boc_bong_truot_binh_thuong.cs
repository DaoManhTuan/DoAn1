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
    public partial class f9906_bieu_do_boc_bong_truot_binh_thuong : Form
    {
        public f9906_bieu_do_boc_bong_truot_binh_thuong()
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
            load_data_2_cbo_hoc_ky();
        }

        private void load_data_2_cbo_hoc_ky()
        {
            WinFormControls.load_data_to_combobox("V_DM_HOC_KY", "ID", "MA_HOC_KY", "", WinFormControls.eTAT_CA.YES, m_cbo_hoc_ky);
        } 

        private void m_cmd_xua_bao_cao_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraPrinting.PrintingSystem ps = new DevExpress.XtraPrinting.PrintingSystem();
                CompositeLink cl = new CompositeLink(ps);
                PrintableComponentLink pclChart = new PrintableComponentLink();
                PrintableComponentLink pclPivot = new PrintableComponentLink();
                pclChart.Component = chartControl1;
                pclPivot.Component = pivotGridControl1;
                cl.Links.AddRange(new object[] { pclChart, pclPivot });
                cl.ShowPreviewDialog();
                cl.PrintingSystem.ExportToPdf(Application.StartupPath + "\\..\\..\\BaoCao.pdf");
            }
            catch (Exception c)
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }

        }

        private void m_cmd_loc_Click(object sender, EventArgs e)
        {
            try
            {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from dbo.fn_ds_hoc_bong(" + m_cbo_hoc_ky.SelectedValue + ")");

            }
            catch (Exception v)
            {

                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
        }


    }
}
