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

namespace TOSApp.DanhMuc
{
    public partial class f111_DM_LOP_SINH_VIEN_DE : Form
    {
        public f111_DM_LOP_SINH_VIEN_DE()
        {
            InitializeComponent();
        }

        private void f111_DM_LOP_SINH_VIEN_DE_Load(object sender, EventArgs e)
        {
            load_data_2_khoa();
            load_data_2_to_cbo_khoa_vien();
        }
        private void load_data_2_khoa()
        {
            try
            {
                WinFormControls.load_data_to_combobox_with_query(m_cbo_khoa, "ID", "KHOA", WinFormControls.eTAT_CA.YES, "SELECT ID, KHOA FROM DM_KHOA WHERE TRANG_THAI_HSD = 7");
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void load_data_2_to_cbo_khoa_vien()
        {
            try
            {
                WinFormControls.load_data_to_combobox_with_query(m_cbo_ten_khoa_vien, "ID", "TEN_KHOA_VIEN", WinFormControls.eTAT_CA.YES, "SELECT ID, TEN_KHOA_VIEN FROM DM_KHOA_VIEN WHERE PHAN_LOAI IN (3,6,5) AND TRANG_THAI_HSD = 7");
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }
        private void m_cmd_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemtradulieu())
                {
                    US_DM_LOP_SINH_VIEN v_us = new US_DM_LOP_SINH_VIEN();
                    v_us.strLOP_SINH_VIEN = m_txt_lop_sinh_vien.Text;
                    v_us.dcID_KHOA = CIPConvert.ToDecimal(m_cbo_khoa.SelectedValue.ToString());
                    v_us.dcID_KHOA_VIEN = CIPConvert.ToDecimal(m_cbo_ten_khoa_vien.SelectedValue.ToString());
                    v_us.dcTRANG_THAI_HSD = 7;
                    v_us.Insert();
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private bool kiemtradulieu()
        {
            if (CIPConvert.ToDecimal(m_cbo_ten_khoa_vien.SelectedValue.ToString()) == -1)
            {
                MessageBox.Show("Chọn khoa viện!");
                return false;
            }
            if (CIPConvert.ToDecimal(m_cbo_khoa.SelectedValue.ToString()) == -1)
            {
                MessageBox.Show("Chọn khóa!");
                return false;
            }
            if (m_txt_lop_sinh_vien.Text == "")
            {
                MessageBox.Show("Hãy điền tên lớp sinh viên");
                return false;
            }
            return true;
        }

        private void m_cmd_cancel_Click(object sender, EventArgs e)
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

    }
}
