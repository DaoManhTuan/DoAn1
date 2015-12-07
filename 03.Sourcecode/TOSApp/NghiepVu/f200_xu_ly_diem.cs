using IP.Core.IPCommon;
using IPCOREUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TOSApp.NghiepVu
{
    public partial class f200_xu_ly_diem : Form
    {
        public f200_xu_ly_diem()
        {
            InitializeComponent();
        }
        bool m_bol_check = false;
        private void f200_xu_ly_diem_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_cbo_hoc_ky();
                load_data_2_cbo_khoa();
                load_data_2_cbo_khoa_vien();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }

        }

        private void load_data_2_cbo_hoc_ky()
        {
            WinFormControls.load_data_to_combobox("V_DM_HOC_KY", "ID", "MA_HOC_KY", "", WinFormControls.eTAT_CA.NO, m_cbo_hoc_ky);
        }

        private void load_data_2_cbo_khoa_vien()
        {
            m_bol_check = true;
            WinFormControls.load_data_to_combobox("V_DM_KHOA_VIEN", "ID", "TEN_KHOA_VIEN", "WHERE TRANG_THAI_HSD = 7 AND PHAN_LOAI != 4", WinFormControls.eTAT_CA.TAT_CA, m_cbo_khoa_vien);

        }

        private void load_data_2_cbo_khoa()
        {
            WinFormControls.load_data_to_combobox("V_DM_KHOA", "ID", "KHOA", "WHERE TRANG_THAI_HSD = 7 order by KHOA desc", WinFormControls.eTAT_CA.TAT_CA, m_cbo_khoa);
        }

        private void m_cbo_khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_bol_check == true)
                {
                    if (CIPConvert.ToDecimal(m_cbo_khoa.SelectedValue.ToString()) > -1 && CIPConvert.ToDecimal(m_cbo_khoa_vien.SelectedValue.ToString()) > -1)
                        WinFormControls.load_data_to_combobox("V_DM_LOP_SINH_VIEN", "ID", "LOP_SINH_VIEN", "WHERE ID_KHOA = " + m_cbo_khoa.SelectedValue.ToString() + "AND ID_KHOA_VIEN = " + m_cbo_khoa_vien.SelectedValue.ToString(), WinFormControls.eTAT_CA.TAT_CA, m_cbo_lop_sinh_vien);
                    else if (CIPConvert.ToDecimal(m_cbo_khoa.SelectedValue.ToString()) == -1 && CIPConvert.ToDecimal(m_cbo_khoa_vien.SelectedValue.ToString()) > -1)
                        WinFormControls.load_data_to_combobox("V_DM_LOP_SINH_VIEN", "ID", "LOP_SINH_VIEN", "WHERE ID_KHOA_VIEN = " + m_cbo_khoa_vien.SelectedValue.ToString(), WinFormControls.eTAT_CA.TAT_CA, m_cbo_lop_sinh_vien);
                    else if (CIPConvert.ToDecimal(m_cbo_khoa.SelectedValue.ToString()) > -1 && CIPConvert.ToDecimal(m_cbo_khoa_vien.SelectedValue.ToString()) == -1)
                        WinFormControls.load_data_to_combobox("V_DM_LOP_SINH_VIEN", "ID", "LOP_SINH_VIEN", "WHERE ID_KHOA = " + m_cbo_khoa.SelectedValue, WinFormControls.eTAT_CA.TAT_CA, m_cbo_lop_sinh_vien);
                    else
                        WinFormControls.load_data_to_combobox("V_DM_LOP_SINH_VIEN", "ID", "LOP_SINH_VIEN", "", WinFormControls.eTAT_CA.TAT_CA, m_cbo_lop_sinh_vien);

                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cbo_khoa_vien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_bol_check == true)
                {
                    if (CIPConvert.ToDecimal(m_cbo_khoa.SelectedValue.ToString()) > -1 && CIPConvert.ToDecimal(m_cbo_khoa_vien.SelectedValue.ToString()) > -1)
                        WinFormControls.load_data_to_combobox("V_DM_LOP_SINH_VIEN", "ID", "LOP_SINH_VIEN", "WHERE ID_KHOA = " + m_cbo_khoa.SelectedValue.ToString() + "AND ID_KHOA_VIEN = " + m_cbo_khoa_vien.SelectedValue.ToString(), WinFormControls.eTAT_CA.TAT_CA, m_cbo_lop_sinh_vien);
                    else if (CIPConvert.ToDecimal(m_cbo_khoa.SelectedValue.ToString()) == -1 && CIPConvert.ToDecimal(m_cbo_khoa_vien.SelectedValue.ToString()) > -1)
                        WinFormControls.load_data_to_combobox("V_DM_LOP_SINH_VIEN", "ID", "LOP_SINH_VIEN", "WHERE ID_KHOA_VIEN = " + m_cbo_khoa_vien.SelectedValue.ToString(), WinFormControls.eTAT_CA.TAT_CA, m_cbo_lop_sinh_vien);
                    else if (CIPConvert.ToDecimal(m_cbo_khoa.SelectedValue.ToString()) > -1 && CIPConvert.ToDecimal(m_cbo_khoa_vien.SelectedValue.ToString()) == -1)
                        WinFormControls.load_data_to_combobox("V_DM_LOP_SINH_VIEN", "ID", "LOP_SINH_VIEN", "WHERE ID_KHOA = " + m_cbo_khoa.SelectedValue, WinFormControls.eTAT_CA.TAT_CA, m_cbo_lop_sinh_vien);
                    else
                        WinFormControls.load_data_to_combobox("V_DM_LOP_SINH_VIEN", "ID", "LOP_SINH_VIEN", "", WinFormControls.eTAT_CA.TAT_CA, m_cbo_lop_sinh_vien);
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_ket_qua_Click(object sender, EventArgs e)
        {
            try
            {

                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                string v_str_query;
                if (CIPConvert.ToDecimal(m_cbo_lop_sinh_vien.SelectedValue.ToString()) > -1)
                    v_str_query = "SELECT DISTINCT ID_SINH_VIEN FROM V_DIEM_THI WHERE ID_HOC_KY = " + m_cbo_hoc_ky.SelectedValue.ToString() + "AND ID_LOP_SINH_VIEN =" + m_cbo_lop_sinh_vien.SelectedValue.ToString();
                else
                {
                    if (CIPConvert.ToDecimal(m_cbo_khoa.SelectedValue.ToString()) > -1 && CIPConvert.ToDecimal(m_cbo_khoa_vien.SelectedValue.ToString()) > -1)
                        v_str_query = "SELECT DISTINCT ID_SINH_VIEN FROM V_DIEM_THI WHERE ID_HOC_KY = " + m_cbo_hoc_ky.SelectedValue.ToString() + " AND ID_KHOA = " + m_cbo_khoa.SelectedValue.ToString() + "AND ID_KHOA_VIEN = " + m_cbo_khoa_vien.SelectedValue.ToString();
                    else if (CIPConvert.ToDecimal(m_cbo_khoa.SelectedValue.ToString()) == -1 && CIPConvert.ToDecimal(m_cbo_khoa_vien.SelectedValue.ToString()) > -1)
                        v_str_query = "SELECT DISTINCT ID_SINH_VIEN FROM V_DIEM_THI WHERE ID_HOC_KY = " + m_cbo_hoc_ky.SelectedValue.ToString() + "AND ID_KHOA_VIEN = " + m_cbo_khoa_vien.SelectedValue.ToString();
                    else if (CIPConvert.ToDecimal(m_cbo_khoa.SelectedValue.ToString()) > -1 && CIPConvert.ToDecimal(m_cbo_khoa_vien.SelectedValue.ToString()) == -1)
                        v_str_query = "SELECT DISTINCT ID_SINH_VIEN FROM V_DIEM_THI WHERE ID_HOC_KY = " + m_cbo_hoc_ky.SelectedValue.ToString() + "AND ID_KHOA = " + m_cbo_khoa.SelectedValue.ToString();
                    else
                        v_str_query = "SELECT DISTINCT ID_SINH_VIEN FROM V_DIEM_THI WHERE ID_HOC_KY = " + m_cbo_hoc_ky.SelectedValue.ToString();
                }
                v_us.FillDatasetWithQuery(v_ds, v_str_query);
                for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
                {
                    //kiểm tra xem có hay không để trọn insert hoặc update
                    US_DUNG_CHUNG v_us_check = new US_DUNG_CHUNG();
                    DataSet v_ds_check = new DataSet();
                    v_ds_check.Tables.Add(new DataTable());
                    string v_str_query_test = "SELECT ID FROM V_KET_QUA_HOC_TAP WHERE ID_HOC_KY = " + m_cbo_hoc_ky.SelectedValue.ToString() + "AND ID_SINH_VIEN = " + v_ds.Tables[0].Rows[i]["ID_SINH_VIEN"].ToString();
                    v_us_check.FillDatasetWithQuery(v_ds_check, v_str_query_test);
                    if (v_ds_check.Tables[0].Rows.Count == 0)
                    {
                        US_KET_QUA_HOC_TAP v_us_ket_qua_hoc_tap = new US_KET_QUA_HOC_TAP();
                        v_us_ket_qua_hoc_tap.dcID_HOC_KY = CIPConvert.ToDecimal(m_cbo_hoc_ky.SelectedValue.ToString());
                        v_us_ket_qua_hoc_tap.dcID_SINH_VIEN = CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID_SINH_VIEN"].ToString());
                        v_us_ket_qua_hoc_tap.dcGPA = User.GetGPA(v_us_ket_qua_hoc_tap.dcID_SINH_VIEN, v_us_ket_qua_hoc_tap.dcID_HOC_KY);
                        v_us_ket_qua_hoc_tap.dcCPA = User.GetCPA(v_us_ket_qua_hoc_tap.dcID_SINH_VIEN, v_us_ket_qua_hoc_tap.dcID_HOC_KY);
                        v_us_ket_qua_hoc_tap.Insert();
                    }
                    else
                    {
                        US_KET_QUA_HOC_TAP v_us_ket_qua_hoc_tap = new US_KET_QUA_HOC_TAP(CIPConvert.ToDecimal(v_ds_check.Tables[0].Rows[0]["ID"].ToString()));
                        v_us_ket_qua_hoc_tap.dcID_HOC_KY = CIPConvert.ToDecimal(m_cbo_hoc_ky.SelectedValue.ToString());
                        v_us_ket_qua_hoc_tap.dcID_SINH_VIEN = CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID_SINH_VIEN"].ToString());
                        v_us_ket_qua_hoc_tap.dcGPA = User.GetGPA(v_us_ket_qua_hoc_tap.dcID_SINH_VIEN, v_us_ket_qua_hoc_tap.dcID_HOC_KY);
                        v_us_ket_qua_hoc_tap.dcCPA = User.GetCPA(v_us_ket_qua_hoc_tap.dcID_SINH_VIEN, v_us_ket_qua_hoc_tap.dcID_HOC_KY);
                        v_us_ket_qua_hoc_tap.Update();
                    }
                }
                MessageBox.Show("Thành công!");
                load_data_2_grid(CIPConvert.ToDecimal(m_cbo_lop_sinh_vien.SelectedValue.ToString()));
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void load_data_2_grid(decimal v_dc_value)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            string v_str_query;
            if (v_dc_value > -1)
                v_str_query = "SELECT* FROM V_KET_QUA_HOC_TAP WHERE ID_HOC_KY = " + m_cbo_hoc_ky.SelectedValue.ToString() + "AND ID_LOP_SINH_VIEN = " + m_cbo_lop_sinh_vien.SelectedValue.ToString();
            else
            {
                if (CIPConvert.ToDecimal(m_cbo_khoa.SelectedValue.ToString()) > -1 && CIPConvert.ToDecimal(m_cbo_khoa_vien.SelectedValue.ToString()) > -1)
                    v_str_query = "SELECT* FROM V_KET_QUA_HOC_TAP WHERE ID_HOC_KY = " + m_cbo_hoc_ky.SelectedValue.ToString() + " AND ID_KHOA = " + m_cbo_khoa.SelectedValue.ToString() + "AND ID_KHOA_VIEN = " + m_cbo_khoa_vien.SelectedValue.ToString();
                else if (CIPConvert.ToDecimal(m_cbo_khoa.SelectedValue.ToString()) == -1 && CIPConvert.ToDecimal(m_cbo_khoa_vien.SelectedValue.ToString()) > -1)
                    v_str_query = "SELECT* FROM V_KET_QUA_HOC_TAP WHERE ID_HOC_KY = " + m_cbo_hoc_ky.SelectedValue.ToString() + "AND ID_KHOA_VIEN = " + m_cbo_khoa_vien.SelectedValue.ToString();
                else if (CIPConvert.ToDecimal(m_cbo_khoa.SelectedValue.ToString()) > -1 && CIPConvert.ToDecimal(m_cbo_khoa_vien.SelectedValue.ToString()) == -1)
                    v_str_query = "SELECT* FROM V_KET_QUA_HOC_TAP WHERE ID_HOC_KY = " + m_cbo_hoc_ky.SelectedValue.ToString() + "AND ID_KHOA = " + m_cbo_khoa.SelectedValue.ToString();
                else
                    v_str_query = "SELECT* FROM V_KET_QUA_HOC_TAP WHERE ID_HOC_KY = " + m_cbo_hoc_ky.SelectedValue.ToString();
            }
            v_us.FillDatasetWithQuery(v_ds, v_str_query);
            m_grc_ket_qua.DataSource = v_ds.Tables[0];
        }

        private void m_cbo_lop_sinh_vien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid(CIPConvert.ToDecimal(m_cbo_lop_sinh_vien.SelectedValue.ToString()));

            }
            catch (Exception)
            {

                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }

        }

        private void m_cbo_hoc_ky_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_bol_check)
                {
                    load_data_2_grid(CIPConvert.ToDecimal(m_cbo_lop_sinh_vien.SelectedValue.ToString()));
                }
               
            }
            catch (Exception)
            {

                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < m_grv_ket_qua.RowCount; i++)
                {
                    US_KET_QUA_HOC_TAP v_us = new US_KET_QUA_HOC_TAP(CIPConvert.ToDecimal(m_grv_ket_qua.GetDataRow(i)["ID"].ToString()));
                    v_us.Delete();
                    load_data_2_grid(CIPConvert.ToDecimal(m_cbo_lop_sinh_vien.SelectedValue.ToString()));
                    MessageBox.Show("Xóa thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

    }
}
