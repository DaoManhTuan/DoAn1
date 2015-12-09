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
    public partial class f9905_bao_cao_cpa_gpa_theo_lop_sinh_vien : Form
    {
        public f9905_bao_cao_cpa_gpa_theo_lop_sinh_vien()
        {
            InitializeComponent();
        }
        bool m_bol_check = false;
        private void f9905_bao_cao_cpa_gpa_theo_lop_sinh_vien_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_cbo();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }

        }

        private void load_data_2_cbo()
        {
            load_data_2_cbo_khoa();
            load_data_2_cbo_khoa_vien();
            load_data_2_cbo_hoc_ky();
        }

        private void load_data_2_cbo_khoa()
        {
            WinFormControls.load_data_to_combobox("V_DM_KHOA", "ID", "KHOA", " ORDER BY  KHOA DESC", WinFormControls.eTAT_CA.NO, m_cbo_khoa);
        }

        private void load_data_2_cbo_khoa_vien()
        {
            m_bol_check = true;
            WinFormControls.load_data_to_combobox("V_DM_KHOA_VIEN", "ID", "TEN_KHOA_VIEN", "WHERE PHAN_LOAI <> 4", WinFormControls.eTAT_CA.NO, m_cbo_khoa_vien);
        }

        private void load_data_2_cbo_hoc_ky()
        {
            WinFormControls.load_data_to_combobox("V_DM_HOC_KY", "ID", "MA_HOC_KY", "", WinFormControls.eTAT_CA.NO, m_cbo_ky_hoc);
        }

        private void m_cmd_xem_Click(object sender, EventArgs e)
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
            string v_str_query = "";
            if (CIPConvert.ToDecimal(m_cbo_lop_sinh_vien.SelectedValue.ToString()) > -1)
                v_str_query = "SELECT * FROM V_KET_QUA_HOC_TAP WHERE ID_LOP_SINH_VIEN=" + m_cbo_lop_sinh_vien.SelectedValue + "AND ID_HOC_KY=" + m_cbo_ky_hoc.SelectedValue;
            else
                v_str_query = "SELECT * FROM V_KET_QUA_HOC_TAP WHERE ID_HOC_KY=" + m_cbo_ky_hoc.SelectedValue;
            v_us.FillDatasetWithQuery(v_ds,v_str_query);
            m_grc_bao_cao_hoc_tap_theo_lop_sinh_vien.DataSource = v_ds.Tables[0];
        }

        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {

            try
            {
                SaveFileDialog f = new SaveFileDialog();

                if (f.ShowDialog() == DialogResult.OK)
                {
                    User.xuat_excel(m_grv_bao_cao_hoc_tap_theo_lop_sinh_vien, f.FileName);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
        }

        private void m_cbo_khoa_vien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_bol_check == true)
                {
                    WinFormControls.load_data_to_combobox("V_DM_LOP_SINH_VIEN", "ID", "LOP_SINH_VIEN", "WHERE ID_KHOA = " + m_cbo_khoa.SelectedValue.ToString() + "AND ID_KHOA_VIEN = " + m_cbo_khoa_vien.SelectedValue.ToString(), WinFormControls.eTAT_CA.TAT_CA, m_cbo_lop_sinh_vien);

                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cbo_khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_bol_check == true)
                {
                    WinFormControls.load_data_to_combobox("V_DM_LOP_SINH_VIEN", "ID", "LOP_SINH_VIEN", "WHERE ID_KHOA = " + m_cbo_khoa.SelectedValue + "AND ID_KHOA_VIEN = " + m_cbo_khoa_vien.SelectedValue.ToString(), WinFormControls.eTAT_CA.TAT_CA, m_cbo_lop_sinh_vien);

                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }


    }
}
