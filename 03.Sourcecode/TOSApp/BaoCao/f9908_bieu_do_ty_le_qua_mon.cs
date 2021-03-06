﻿using DevExpress.XtraPrinting;
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
    public partial class f9908_bieu_do_ty_le_qua_mon : Form
    {
        public f9908_bieu_do_ty_le_qua_mon()
        {
            InitializeComponent();
            chartControl1.OptionsPrint.SizeMode = DevExpress.XtraCharts.Printing.PrintSizeMode.Zoom;
        }
        int m_int_count_qua = 0;
        int m_int_count_k_qua = 0;

        private void f9908_bieu_do_ty_le_qua_mon_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_cbo_ky_hoc();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }

        }

        private void load_data_2_cbo_ky_hoc()
        {
            chartControl1.OptionsPrint.SizeMode = DevExpress.XtraCharts.Printing.PrintSizeMode.Zoom;
            WinFormControls.load_data_to_combobox("V_DM_HOC_KY", "ID", "MA_HOC_KY", "", WinFormControls.eTAT_CA.NO, m_cbo_ky_hoc);
        }

        private void m_cbo_ky_hoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                WinFormControls.load_data_to_combobox("V_DM_LOP_HOC", "ID_HOC_PHAN", "MA_HOC_PHAN", " where id_hoc_ky=" + m_cbo_ky_hoc.SelectedValue, WinFormControls.eTAT_CA.NO, m_cbo_hoc_phan);
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }

        }

        private void m_cbo_hoc_phan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us.FillDatasetWithQuery(v_ds, "select TEN_HOC_PHAN from DM_hoc_phan where id=" + m_cbo_hoc_phan.SelectedValue);
                m_lb_ten_hoc_phan.Text = v_ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
        }

        private void m_cmd_loc_Click(object sender, EventArgs e)
        {
            try
            {

                load_data_2_grid();
            }
            catch (Exception v)
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
        }
        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select distinct ID_sinh_vien,MA_HOC_KY from v_diem_thi where id_hoc_ky=" + m_cbo_ky_hoc.SelectedValue + " and id_hoc_phan = " + m_cbo_hoc_phan.SelectedValue);
            US_DUNG_CHUNG k_us = new US_DUNG_CHUNG();
            DataSet k_ds = new DataSet();
            k_ds.Tables.Add(new DataTable());
            k_us.FillDatasetWithQuery(k_ds, "select distinct ID_SINh_vien from v_diem_thi where id_hoc_ky=" + m_cbo_ky_hoc.SelectedValue + " and id_hoc_phan = " + m_cbo_hoc_phan.SelectedValue + " and DIem_chu like 'F%' ");
            m_int_count_k_qua = k_ds.Tables[0].Rows.Count;
            m_int_count_qua = v_ds.Tables[0].Rows.Count - m_int_count_k_qua;
            DataTable table = new DataTable();
            table.Columns.Add("TrangThai", typeof(string));
            table.Columns.Add("SoLuong", typeof(int));
            table.Rows.Add(new object[] { "Qua", m_int_count_qua });
            table.Rows.Add(new object[] { "Không qua", m_int_count_k_qua });
            m_pivot_ty_le_qua_mon.DataSource = table;
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
                pclPivot.Component = m_pivot_ty_le_qua_mon;
                cl.Links.AddRange(new object[] { pclChart, pclPivot });
                cl.ShowPreviewDialog();
                cl.PrintingSystem.ExportToPdf(Application.StartupPath + "\\..\\..\\BaoCao.pdf");
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }

        }

       
    }
}
