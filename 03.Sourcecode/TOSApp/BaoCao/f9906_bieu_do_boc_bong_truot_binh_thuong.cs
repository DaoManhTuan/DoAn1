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
using IP.Core.IPCommon;



using System.Data.OleDb;
using DevExpress.XtraPivotGrid;
using System.Collections;
using DevExpress.XtraCharts;


namespace TOSApp.BaoCao
{
    public partial class f9906_bieu_do_boc_bong_truot_binh_thuong : Form
    {
        public f9906_bieu_do_boc_bong_truot_binh_thuong()
        {
            InitializeComponent();
            chartControl1.OptionsPrint.SizeMode = DevExpress.XtraCharts.Printing.PrintSizeMode.Zoom;
        }
        int m_int_count_hoc_bong = 0;
        int m_int_count_khong_qua = 0;
        int m_int_count_binh_thuong = 0;
     

        private void f9906_bao_cao_demo_Load(object sender, EventArgs e)
        {
            load_data_2_cbo_hoc_ky();
        }

        private void load_data_2_cbo_hoc_ky()
        {
            WinFormControls.load_data_to_combobox("V_DM_HOC_KY", "ID", "MA_HOC_KY", "", WinFormControls.eTAT_CA.NO, m_cbo_hoc_ky);
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
                pclPivot.Component = m_pivot_ty_le_hoc_bong;
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
            m_int_count_hoc_bong = v_ds.Tables[0].Rows.Count;

            US_DUNG_CHUNG k_us = new US_DUNG_CHUNG();
            DataSet k_ds = new DataSet();
            k_ds.Tables.Add(new DataTable());
            k_us.FillDatasetWithQuery(k_ds, "select * from dbo.fn_ds_xu_ly_hoc_tap(" + m_cbo_hoc_ky.SelectedValue + ")");
            m_int_count_khong_qua = k_ds.Tables[0].Rows.Count;

            US_DUNG_CHUNG t_us = new US_DUNG_CHUNG();
            DataSet t_ds = new DataSet();
            t_ds.Tables.Add(new DataTable());
            t_us.FillDatasetWithQuery(t_ds, "select count(*) from v_ket_qua_hoc_tap where id_hoc_ky=" + m_cbo_hoc_ky.SelectedValue );
            m_int_count_binh_thuong=Convert.ToInt32( t_ds.Tables[0].Rows[0][0]) - m_int_count_hoc_bong - m_int_count_khong_qua;
            DataTable table = new DataTable();
            table.Columns.Add("Ky", typeof(string));
            table.Columns.Add("HocKy", typeof(string));
            table.Columns.Add("TyLe", typeof(int));
            table.Columns.Add("PhanTram", typeof(int));

            table.Rows.Add(new object[] { m_cbo_hoc_ky.SelectedText, "Học bổng", m_int_count_hoc_bong, m_int_count_hoc_bong });
            table.Rows.Add(new object[] { m_cbo_hoc_ky.SelectedText, "Trung bình", m_int_count_binh_thuong, m_int_count_binh_thuong });
            table.Rows.Add(new object[] { m_cbo_hoc_ky.SelectedText, "Không qua", m_int_count_khong_qua, m_int_count_khong_qua });
            m_pivot_ty_le_hoc_bong.DataSource = table;

            
            }
            catch (Exception v)
            {

                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
        }

        


    }
}
