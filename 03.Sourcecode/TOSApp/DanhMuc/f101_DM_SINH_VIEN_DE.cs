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

namespace TOSApp.DanhMuc
{
    public partial class f101_DM_SINH_VIEN_DE : Form
    {
        public f101_DM_SINH_VIEN_DE()
        {
            InitializeComponent();
        }

        bool m_bl_check = false;
        private void f101_DM_SINH_VIEN_DE_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_cbo();
                m_txt_ma_so_sinh_vien.Focus();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void load_data_2_cbo()
        {
            load_data_2_cbo_khoa();
            load_data_2_cbo_khoa_vien();
            load_data_2_cbo_trang_thai();
        }

        private void load_data_2_cbo_trang_thai()
        {
            WinFormControls.load_data_to_combobox("CM_DM_TU_DIEN", "ID", "TEN_TU_DIEN", "WHERE ID_LOAI_TU_DIEN = 2", WinFormControls.eTAT_CA.NO, m_cbo_trang_thai);
        }

        private void load_data_2_cbo_khoa_vien()
        {

            WinFormControls.load_data_to_combobox("DM_KHOA_VIEN", "ID", "TEN_KHOA_VIEN", "WHERE TRANG_THAI_HSD = 7 AND PHAN_LOAI != 4", WinFormControls.eTAT_CA.NO, m_cbo_khoa_vien);
            m_bl_check = true;
        }

        private void load_data_2_cbo_khoa()
        {
            WinFormControls.load_data_to_combobox("DM_KHOA", "ID", "KHOA", "WHERE TRANG_THAI_HSD = 7 order by KHOA desc", WinFormControls.eTAT_CA.NO, m_cbo_khoa);
        }

        private void m_cbo_khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //load lại dữ liệu Dm_lớp_sinh viên
                if (m_bl_check)
                    WinFormControls.load_data_to_combobox("V_DM_LOP_SINH_VIEN", "ID", "LOP_SINH_VIEN", "WHERE ID_KHOA = " + m_cbo_khoa.SelectedValue + "AND ID_KHOA_VIEN = " + m_cbo_khoa_vien.SelectedValue.ToString(), WinFormControls.eTAT_CA.YES, m_cbo_lop_sinh_vien);
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
            //load data lại cho lớp sinh viên
            if (m_bl_check)
                WinFormControls.load_data_to_combobox("V_DM_LOP_SINH_VIEN", "ID", "LOP_SINH_VIEN", "WHERE ID_KHOA = " + m_cbo_khoa.SelectedValue + "AND ID_KHOA_VIEN = " + m_cbo_khoa_vien.SelectedValue.ToString(), WinFormControls.eTAT_CA.YES, m_cbo_lop_sinh_vien);
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }


        private void m_cmd_Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
                        
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_du_lieu_truoc_luu() == true)
                {
                    US_DM_SINH_VIEN v_us = new US_DM_SINH_VIEN();
                    v_us.strMA_SINH_VIEN = m_txt_ma_so_sinh_vien.Text;
                    v_us.strTEN_SINH_VIEN = m_txt_ho_ten_sinh_vien.Text;
                    v_us.strSDT = m_txt_so_dien_thoai.Text;
                    v_us.dcTRANG_THAI_HSD = 7;
                    if (m_rdb_nam.Checked == true)
                    {
                        v_us.strGIOI_TINH = "N";
                    }
                    else v_us.strGIOI_TINH = "W";
                    v_us.strQUE_QUAN = m_txt_que_quan.Text;
                    v_us.datNGAY_SINH = m_dat_ngay_sinh.Value;
                    v_us.dcID_LOP_SINH_VIEN = CIPConvert.ToDecimal(m_cbo_lop_sinh_vien.SelectedValue);
                    v_us.dcTRANG_THAI = CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue);
                    v_us.Insert();
                    MessageBox.Show("Đã thêm thành công sinh viên " + m_txt_ho_ten_sinh_vien.Text);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private bool check_du_lieu_truoc_luu()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from dm_sinh_vien where ma_sinh_vien='" + m_txt_ma_so_sinh_vien.Text + "'");

            if (v_ds.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show("Sinh viên có mã số này đã tồn tại!");
                return false;
            }
            if (m_txt_ma_so_sinh_vien.Text == "" || m_txt_ho_ten_sinh_vien.Text == "")
            {
                MessageBox.Show("Hãy điền đủ thông tin trước khi lưu!");
                return false;
            }
            if (CIPConvert.ToDecimal(m_cbo_lop_sinh_vien.SelectedValue) == -1)
            {
                MessageBox.Show("Hãy chọn lớp phù hợp!");
                return false;
            }
            return true;
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
