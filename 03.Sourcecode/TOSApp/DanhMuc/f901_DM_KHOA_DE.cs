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
    public partial class f901_DM_KHOA_DE : Form
    {
        public f901_DM_KHOA_DE()
        {
            InitializeComponent();
        }

        private void m_cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_du_lieu_truoc_luu())
                {
                    US_DM_KHOA v_us = new US_DM_KHOA();
                    v_us.strKHOA = m_txt_khoa.Text;
                    v_us.dcTRANG_THAI_HSD = 7;
                    v_us.dcNAM_BAT_DAU = CIPConvert.ToDecimal(m_txt_nam_bat_dau.Text);
                    v_us.Insert();
                    MessageBox.Show("Thêm mới thành công khóa:" +m_txt_khoa.Text);
                    this.Close();
                }
            }
            catch
            {
                
                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
        }

        private bool check_du_lieu_truoc_luu()
        {
            if (m_txt_nam_bat_dau.Text == "" || m_txt_khoa.Text == "")
            {
                MessageBox.Show("Nhập đủ thông tin!");
                return false;
            }
            if (CIPConvert.ToDecimal(m_txt_nam_bat_dau.Text) < 2010 || CIPConvert.ToDecimal(m_txt_nam_bat_dau.Text) > 2100)
            {
                MessageBox.Show("Năm bắt đầu chưa chính xác!( phải nằm trong 2010 -2100)");
                return false;
            }
            return true;
        }

        private void m_txt_nam_bat_dau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
