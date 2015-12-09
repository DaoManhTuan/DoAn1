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
    public partial class f9904_danh_sach_sinh_vien_canh_cao : Form
    {
        public f9904_danh_sach_sinh_vien_canh_cao()
        {
            InitializeComponent();
        }
        private void f9903_danh_sach_sinh_vien_nhan_hoc_bong_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_cbo_hoc_ky();
                load_data_2_cbo_muc_canh_cao();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }

        }

        private void load_data_2_cbo_muc_canh_cao()
        {
            WinFormControls.load_data_to_combobox("CM_DM_TU_DIEN", "ID", "TEN_TU_DIEN", "WHERE ID_LOAI_TU_DIEN = 5", WinFormControls.eTAT_CA.TAT_CA, m_cbo_muc_canh_cao);
        }

        private void load_data_2_cbo_hoc_ky()
        {
            WinFormControls.load_data_to_combobox("V_DM_HOC_KY", "ID", "MA_HOC_KY", "", WinFormControls.eTAT_CA.NO, m_cbo_hoc_ky);
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            string v_str_query;
            if(CIPConvert.ToDecimal( m_cbo_muc_canh_cao.SelectedValue.ToString()) > -1)
                v_str_query = "SELECT  VKQHT.* ,DS_XU_LY.MUC_CANH_CAO FROM V_KET_QUA_HOC_TAP AS VKQHT, (SELECT * FROM dbo.fn_ds_xu_ly_hoc_tap(" + m_cbo_hoc_ky.SelectedValue.ToString() + ") ) AS DS_XU_LY WHERE DS_XU_LY.ID_SINH_VIEN = VKQHT.ID_SINH_VIEN AND VKQHT.ID_HOC_KY = " + m_cbo_hoc_ky.SelectedValue.ToString() + "AND DS_XU_LY.MUC_CANH_CAO = N'" + m_cbo_muc_canh_cao.Text + "'";
            else
                v_str_query = "SELECT  VKQHT.* ,DS_XU_LY.MUC_CANH_CAO FROM V_KET_QUA_HOC_TAP AS VKQHT, (SELECT * FROM dbo.fn_ds_xu_ly_hoc_tap(" + m_cbo_hoc_ky.SelectedValue.ToString() + ") ) AS DS_XU_LY WHERE DS_XU_LY.ID_SINH_VIEN = VKQHT.ID_SINH_VIEN AND VKQHT.ID_HOC_KY = " + m_cbo_hoc_ky.SelectedValue.ToString() ;
            v_us.FillDatasetWithQuery(v_ds, v_str_query);
            m_grc_bao_cao_hoc_tap_theo_sv.DataSource = v_ds.Tables[0];

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
    }
}
