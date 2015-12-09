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

namespace TOSApp.BaoCao
{
    public partial class f9907_bieu_do_CPA_GPA_sv : Form
    {
        public f9907_bieu_do_CPA_GPA_sv()
        {
            InitializeComponent();
        }

        private void f9907_bieu_do_CPA_GPA_sv_Load(object sender, EventArgs e)
        {
            chartControl1.OptionsPrint.SizeMode = DevExpress.XtraCharts.Printing.PrintSizeMode.Zoom;
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from v_ket_qua_hoc_tap where ma_sinh_vien = " + m_txt_ma_sinh_vien.Text);
            pivotGridControl1.DataSource = v_ds.Tables[0];

        }

        private void m_cmd_loc_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiem_tra_du_lieu_truoc_luu())
                {

                    load_data_2_grid();
                }
            }
            catch (Exception v)
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
        }

        private bool kiem_tra_du_lieu_truoc_luu()
        {
            if (m_txt_ma_sinh_vien.Text == " " || m_txt_ma_sinh_vien.TextLength == 0)
            {
                MessageBox.Show("Sinh viên có mã " + m_txt_ma_sinh_vien.Text + " không tồn tại!");
                m_txt_ma_sinh_vien.Focus();
                return false;
               
            }
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from v_ket_qua_hoc_tap where ma_sinh_vien = " + m_txt_ma_sinh_vien.Text);
            if (v_ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Sinh viên có mã " + m_txt_ma_sinh_vien.Text + " không tồn tại!");
                m_txt_ma_sinh_vien.Focus();
                return false;
               
            }
            else
            {
                m_lb_ho_ten_sinh_vien.Text = v_ds.Tables[0].Rows[0]["TEN_SINH_VIEN"].ToString();
            }
            return true;
        }

        private void m_cmd_xuat_pdf_Click(object sender, EventArgs e)
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
                    cl.PrintingSystem.ExportToPdf(Application.StartupPath + "\\..\\..\\CPA_GPA.pdf");
               
            }
            catch (Exception v)
            {

                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
        }

      
    }
}
