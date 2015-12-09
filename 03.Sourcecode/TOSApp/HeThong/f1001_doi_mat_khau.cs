using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPCOREUS;

namespace TOSApp.HeThong
{
    public partial class f1001_doi_mat_khau : Form
    {
        public f1001_doi_mat_khau()
        {
            InitializeComponent();
        }


        private void m_cmd_doi_mat_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_du_lieu())
                {
                    update_mat_khau();
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    this.Close();
                }
            }
            catch 
            {

                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
        }

        private void update_mat_khau()
        {
            US_USER_NAME v_us = new US_USER_NAME(User.id_user);
            v_us.strMAT_KHAU = User.GetMD5(m_txt_mk_moi.Text);
            v_us.Update();
        }

        private bool check_du_lieu()
        {
            if (m_txt_mk_moi.Text.Contains(" "))
            {
                MessageBox.Show("Mật khẩu không được chứa khoảng trắng!");
                m_txt_mk_moi.Focus();
                return false;
            }
            if (m_txt_mk_moi.TextLength<=6)
            {
                MessageBox.Show("Mật khẩu phải dài hơn 6 ký tự!");
                m_txt_mk_moi.Focus();
                return false;
            }
            return true;
        }

        private void m_cmd_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_txt_xac_nhan_mk_TextChanged(object sender, EventArgs e)
        {
            if (m_txt_xac_nhan_mk.Text == m_txt_mk_moi.Text && m_txt_mk_cu.TextLength != 0)
            {
                m_lb_output.Text = "Xác nhận chính xác!";
            }
            else m_lb_output.Text = "Chưa chính xác!";
        }

    }
}
