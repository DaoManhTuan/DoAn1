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
    public partial class f801_DM_HOC_KY_DE : Form
    {
        public f801_DM_HOC_KY_DE()
        {
            InitializeComponent();
        }

        private void m_cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_du_lieu_truoc_luu())
                {
                    US_DM_HOC_KY v_us = new US_DM_HOC_KY();
                    v_us.dcTRANG_THAI_HSD = 7;
                    v_us.dcNAM_HOC_BAT_DAU = CIPConvert.ToDecimal(m_txt_nam_bat_dau.Text);
                    v_us.dcNAM_HOC_KET_THUC = CIPConvert.ToDecimal(m_txt_nam_ket_thuc.Text);
                    v_us.strMA_HOC_KY = m_txt_ma_hoc_ky.Text;
                    v_us.Insert();
                    this.Close();
                    MessageBox.Show("Thêm thành công học kỳ:"+m_txt_ma_hoc_ky.Text);
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
        }

        private bool check_du_lieu_truoc_luu()
        {
            if (m_txt_ma_hoc_ky.Text == "" || m_txt_nam_bat_dau.Text == "" || m_txt_nam_ket_thuc.Text == "")
            {
                MessageBox.Show("Dữ liệu chưa chính xác!");
                return false;
            }
            if (m_txt_nam_ket_thuc.Text.Contains(" ") || m_txt_nam_bat_dau.Text.Contains(" "))
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
                return false;
            }
            if (CIPConvert.ToDecimal(m_txt_nam_bat_dau.Text) < 2010 || CIPConvert.ToDecimal(m_txt_nam_bat_dau.Text) > 2100)
            {
                MessageBox.Show("Năm bắt đầu chưa chính xác! (phải nằm trong 2010 -2100)");
                return false;
            }
            if (CIPConvert.ToDecimal(m_txt_nam_ket_thuc.Text) < 2010 || CIPConvert.ToDecimal(m_txt_nam_ket_thuc.Text) > 2100)
            {
                MessageBox.Show("Năm kết thúc chưa chính xác! (phải nằm trong 2010 -2100)");
                return false;
            }
            if (CIPConvert.ToDecimal(m_txt_nam_bat_dau.Text) >= CIPConvert.ToDecimal(m_txt_nam_ket_thuc.Text))
            {
                MessageBox.Show("Năm kết thúc phải lớn hơn năm bắt đầu");
                return false;
            }
            return true;
        }

        private void m_txt_nam_hoc_bat_dau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void m_txt_nam_hoc_ket_thuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void m_txt_ma_hoc_ky_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

      

      
    }
}
