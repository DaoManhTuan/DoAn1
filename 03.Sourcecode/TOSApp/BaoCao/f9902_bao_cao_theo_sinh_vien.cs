using IP.Core.IPCommon;
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
    public partial class f9902_bao_cao_theo_sinh_vien : Form
    {
        public f9902_bao_cao_theo_sinh_vien()
        {
            InitializeComponent();
        }

        private void f9902_bao_cao_theo_sinh_vien_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_to_cbo();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }

        }

        private void load_data_to_cbo()
        {
            load_data_2_cbo_hoc_ky();

        }

        private void load_data_2_cbo_hoc_ky()
        {
            WinFormControls.load_data_to_combobox("V_DM_HOC_KY", "ID", "MA_HOC_KY", "", WinFormControls.eTAT_CA.TAT_CA, m_cbo_hoc_ky);
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            string v_str_query = "";
            if (CIPConvert.ToDecimal(m_cbo_hoc_ky.SelectedValue.ToString()) > -1)
                v_str_query = "SELECT * FROM V_DIEM_THI WHERE MA_SINH_VIEN = '" + m_txt_ma_sinh_vien.Text + "' AND ID_HOC_KY = " + m_cbo_hoc_ky.SelectedValue.ToString() ;
            else
                v_str_query = "SELECT * FROM V_DIEM_THI WHERE MA_SINH_VIEN = '" + m_txt_ma_sinh_vien.Text+ "'";
            v_us.FillDatasetWithQuery(v_ds, v_str_query);
            m_grc_bao_cao_hoc_tap_theo_sv.DataSource = v_ds.Tables[0];

        }

        private void m_cmd_xem_Click(object sender, EventArgs e)
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
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT ID FROM V_DM_SINH_VIEN WHERE MA_SINH_VIEN = '" + m_txt_ma_sinh_vien.Text+"'");
            if (v_ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Hãy chọn lại sinh viên! \n Không có sinh viên nào có mã số: " + m_txt_ma_sinh_vien.Text);
                m_txt_ma_sinh_vien.Focus();
                return false;
            }
            return true;
        }

        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog f = new SaveFileDialog();

                if (f.ShowDialog() == DialogResult.OK)
                {
                    User.xuat_excel(m_grv_bao_cao_hoc_tap_theo_sv, f.FileName);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }

        }

        private void m_txt_ma_sinh_vien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

    }
}
