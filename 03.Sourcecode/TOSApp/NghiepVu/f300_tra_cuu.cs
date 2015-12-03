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

        private void f300_tra_cuu_Load(object sender, EventArgs e)
        {
            load_data_to_cbo();
        }

        private void load_data_to_cbo()
        {
            WinFormControls.load_data_to_combobox("DM_HOC_KY", "ID", "MA_HOC_KY", " where trang_thai_hsd=7", WinFormControls.eTAT_CA.NO, m_cbo_ky_hoc);
        }

        private void m_cbo_ky_hoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new System.Data.DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from KET_QUA_HOC_TAP where ID_SINH_VIEN =" + m_dc_id_sinh_vien + " and ID_HOC_KY=" + m_cbo_ky_hoc.SelectedValue.ToString());
            if (v_ds.Tables[0].Rows.Count == 1)
            {
                m_txt_gpa.Text = v_ds.Tables[0].Rows[0]["GPA"].ToString();
            }
            else m_txt_gpa.Text = "Chưa có điểm kỳ này";

        }

        private void m_cmd_tim_kiem_Click(object sender, EventArgs e)
        {

            try
            {
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new System.Data.DataTable());
                v_us.FillDatasetWithQuery(v_ds, "select * from dm_sinh_vien where ma_sinh_vien =" +m_txt_input.Text);
                m_dc_id_sinh_vien = (decimal)v_ds.Tables[0].Rows[0]["ID"];
                if (check_du_lieu_truoc_luu(v_ds))
                {
                   IPCOREUS.US_V_SINH_VIEN_GPA k_us = new IPCOREUS.US_V_SINH_VIEN_GPA();
                    DataSet k_ds = new DataSet();
                    v_ds.Tables.Add(new System.Data.DataTable());
                    v_us.FillDatasetWithQuery(v_ds, "select * from V_SINH_VIEN_GPA where ID_SINH_VIEN= "+(decimal)v_ds.Tables[0].Rows[0]["ID"]);
                    m_txt_ho_ten_sinh_vien.Text = k_us.strTEN_SINH_VIEN;
                    m_txt_khoa_hoc.Text = k_us.strKHOA;
                    m_txt_khoa_vien.Text = k_us.strTEN_KHOA_VIEN ;
                    m_dat_ngay_sinh.Value = k_us.datNGAY_SINH;
                    m_txt_que_quan.Text = k_us.strQUE_QUAN;
                    m_txt_trang_thai.Text = k_us.strTEN_TRANG_THAI;
                    if (k_us.strGIOI_TINH == "N")
                    {
                        m_rdb_nam.Checked = true;
                    }
                    else m_rdb_nu.Checked = false;
                }

            }
            catch{
           
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private bool check_du_lieu_truoc_luu(DataSet v_ds)
        {
            if (m_txt_input.Text == " " || m_txt_input.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập lại mã số sinh viên!");
                m_txt_input.Focus();
                return false;

            }
            else if (v_ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không có sinh viên nào có mã số:" + m_txt_input.Text);
                m_txt_input.Focus();
                return false;
            } return true;
        }

        private void m_txt_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

    }
}
