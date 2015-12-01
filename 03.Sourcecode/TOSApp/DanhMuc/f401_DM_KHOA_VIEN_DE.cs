using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPCOREUS;

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

        private void m_cmd_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_du_lieu_dau_vao())
                {
                    US_DM_KHOA_VIEN v_us = new US_DM_KHOA_VIEN();
                if (m_cbo_phan_loai_khoa_vien.Text == "Khoa")
                {
                    v_us.dcPHAN_LOAI = 4;
                }
                if (m_cbo_phan_loai_khoa_vien.Text == "Viện")
                {
                    v_us.dcPHAN_LOAI = 3;
                }
                else v_us.dcPHAN_LOAI = 6;
                v_us.strMA_KHOA_VIEN = m_txt_ma_khoa_vien.Text;
                v_us.strTEN_KHOA_VIEN = m_txt_ten_khoa_vien.Text;
                v_us.dcTRANG_THAI_HSD = 7;//mặc định khoa viện vừa được tạo có trạng thái đang hoạt động
                v_us.Insert();
                MessageBox.Show("Thêm thành công Khoa/Viện có mã: " + m_txt_ten_khoa_vien.Text);
                this.Close();
                }
            }
            catch (Exception v_e)
            {

                MessageBox.Show("Đã xảy ra lỗi trong quá trình xử lý");
            }
           
        }

        private bool check_du_lieu_dau_vao()
        {
            if (m_txt_ma_khoa_vien.Text==""||m_txt_ten_khoa_vien.Text=="")
            {
                return false;
            }
            if (m_txt_ma_khoa_vien.Text.Contains(" "))
            {
                MessageBox.Show("Mã khoa viện không được chứa khoảng trắng");
                return false;
            }
            return true;
        }

    }
}
