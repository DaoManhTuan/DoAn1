using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPCOREUS;
using IP.Core.IPCommon;

namespace TOSApp.NghiepVu
{
    public partial class f300_tra_cuu : Form
    {
        public f300_tra_cuu()
        {
            InitializeComponent();
        }

        decimal m_dc_id_sinh_vien = 0;
        decimal m_dc_id_ket_qua_hoc_tap = 0;
        private void f300_tra_cuu_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_to_cbo();
            }
            catch
            {

                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void load_data_to_cbo()
        {
            WinFormControls.load_data_to_combobox("V_DM_HOC_KY", "ID", "MA_HOC_KY", "", WinFormControls.eTAT_CA.NO, m_cbo_ky_hoc);
        }

        private void m_cmd_tim_kiem_Click(object sender, EventArgs e)
        {

            try
            {
                if (tim_kiem_sinh_vien())
                {
                    US_V_DM_SINH_VIEN v_us_sinh_vien = new US_V_DM_SINH_VIEN(m_dc_id_sinh_vien);
                    m_txt_lop_sinh_vien.Text = v_us_sinh_vien.strLOP_SINH_VIEN;
                    m_txt_ho_ten_sinh_vien.Text = v_us_sinh_vien.strTEN_SINH_VIEN;
                    m_txt_khoa_hoc.Text = v_us_sinh_vien.strKHOA;
                    m_txt_khoa_vien.Text = v_us_sinh_vien.strTEN_KHOA_VIEN;
                    m_dat_ngay_sinh.Value = v_us_sinh_vien.datNGAY_SINH;
                    m_txt_que_quan.Text = v_us_sinh_vien.strQUE_QUAN;
                    m_txt_trang_thai.Text = v_us_sinh_vien.strTEN_TRANG_THAI;
                    m_txt_so_dien_thoai.Text = v_us_sinh_vien.strSDT;
                    if (v_us_sinh_vien.strGIOI_TINH == "N")
                    {
                        m_rdb_nam.Checked = true;
                    }
                    else m_rdb_nu.Checked = false;
                    if (tim_kiem_diem_sinh_vien())
                    {
                        m_txt_gpa.Text = "";
                        m_txt_cpa.Text = "";
                        US_KET_QUA_HOC_TAP v_us_kq_hoc_tap = new US_KET_QUA_HOC_TAP(m_dc_id_ket_qua_hoc_tap);
                        m_txt_gpa.Text = v_us_kq_hoc_tap.dcGPA.ToString();
                        m_txt_cpa.Text = v_us_kq_hoc_tap.dcCPA.ToString();
                    }
                    load_data_2_grid();
                }
                

            }
            catch
            {

                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new System.Data.DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM V_DIEM_THI WHERE ID_SINH_VIEN =" + m_dc_id_sinh_vien.ToString() + " AND ID_HOC_KY = " + m_cbo_ky_hoc.SelectedValue.ToString());
            m_grc_ket_qua_tra_cuu.DataSource = v_ds.Tables[0];
        }

        private bool tim_kiem_sinh_vien()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new System.Data.DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT ID FROM V_DM_SINH_VIEN WHERE MA_SINH_VIEN =" + m_txt_input.Text);
            if (v_ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không có sinh viên nào có mã số:" + m_txt_input.Text);
                m_txt_input.Focus();
                return false;
            }
            else
            {
                m_dc_id_sinh_vien = (decimal)v_ds.Tables[0].Rows[0]["ID"];
                return true;
            }
        }
        private bool tim_kiem_diem_sinh_vien()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new System.Data.DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT ID FROM V_KET_QUA_HOC_TAP WHERE ID_SINH_VIEN= " + m_dc_id_sinh_vien.ToString() + " AND ID_HOC_KY = " + m_cbo_ky_hoc.SelectedValue.ToString());
            if (v_ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else
            {
                m_dc_id_ket_qua_hoc_tap = CIPConvert.ToDecimal( v_ds.Tables[0].Rows[0]["ID"].ToString());
                return true;
            }
        }
        private void m_txt_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void m_cbo_ky_hoc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                m_txt_gpa.Text = "";
                m_txt_cpa.Text = "";
                if (tim_kiem_diem_sinh_vien() && tim_kiem_sinh_vien())
                {
                    US_KET_QUA_HOC_TAP v_us_kq_hoc_tap = new US_KET_QUA_HOC_TAP(m_dc_id_ket_qua_hoc_tap);
                    m_txt_gpa.Text = v_us_kq_hoc_tap.dcGPA.ToString();
                    m_txt_cpa.Text = v_us_kq_hoc_tap.dcCPA.ToString();
                }
                load_data_2_grid();

            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

    }
}
