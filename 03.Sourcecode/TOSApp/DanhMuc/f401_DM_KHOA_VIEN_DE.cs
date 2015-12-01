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
    public partial class f401_DM_KHOA_VIEN_DE : Form
    {
        public f401_DM_KHOA_VIEN_DE()
        {
            InitializeComponent();
        }

        private void m_cmd_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void load_data_2_loai_khoa_vien()
        {
            try
            {
                WinFormControls.load_data_to_combobox_with_query(m_cbo_phan_loai_khoa_vien, "ID", "TEN_TU_DIEN", WinFormControls.eTAT_CA.NO, "SELECT ID,TEN_TU_DIEN FROM CM_DM_TU_DIEN WHERE ID_LOAI_TU_DIEN = 3");
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
                if (check_du_lieu_dau_vao())
                {
                    US_DM_KHOA_VIEN v_us = new US_DM_KHOA_VIEN();
                    v_us.dcPHAN_LOAI = CIPConvert.ToDecimal( m_cbo_phan_loai_khoa_vien.SelectedValue.ToString());
                    v_us.strMA_KHOA_VIEN = m_txt_ma_khoa_vien.Text;
                    v_us.strTEN_KHOA_VIEN = m_txt_ten_khoa_vien.Text;
                    v_us.dcTRANG_THAI_HSD = 7;//mặc định khoa viện vừa được tạo có trạng thái đang hoạt động
                    v_us.Insert();
                    MessageBox.Show("Thêm thành công Khoa/Viện có mã: " + m_txt_ten_khoa_vien.Text);
                    this.Close();
                }
            }
            catch
            {

                MessageBox.Show("Đã xảy ra lỗi trong hệ thống");
            }

        }

        private bool check_du_lieu_dau_vao()
        {
            if (m_txt_ma_khoa_vien.Text == "" || m_txt_ten_khoa_vien.Text == "")
            {
                MessageBox.Show("nhập đủ thông tin!");
                return false;
            }
            if (m_txt_ma_khoa_vien.Text.Contains(" "))
            {
                MessageBox.Show("Mã khoa viện không được chứa khoảng trắng");
                return false;
            }
            return true;
        }

        private void f401_DM_KHOA_VIEN_DE_Load(object sender, EventArgs e)
        {
            load_data_2_loai_khoa_vien();
        }

    }
}
