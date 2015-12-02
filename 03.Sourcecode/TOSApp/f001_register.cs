using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPCOREUS;

namespace TOSApp
{
    public partial class f001_register : Form
    {
        public f001_register()
        {
            InitializeComponent();
        }

        private void m_cmd_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_du_lieu())
                {
                    US_USER_NAME v_us = new US_USER_NAME();
                    v_us.dcID_NHOM = 2;
                    v_us.strTAI_KHOAN = m_txt_tai_khoan.Text;
                    v_us.dcTRANG_THAI_HSD = 7;                   
                    v_us.strMAT_KHAU = User.GetMD5(m_txt_mat_khau.Text);
                    v_us.Insert();                    
                    MessageBox.Show("Đăng ký thành công tài khoản"+v_us.strTAI_KHOAN);
                    this.Close();
                }
            }
            catch (Exception v)
            {
                
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private bool check_du_lieu()
        {
            if (m_txt_tai_khoan.Text==" "||m_txt_mat_khau.TextLength==0||m_txt_mat_khau.TextLength<6)
            {
                m_txt_output.Text="Xem lại thông tin tài khoản và mật khẩu \n mật khẩu phải dài hơn 6 ký tự";
                return false;
            }
            if (!m_txt_mat_khau.Text.Contains(m_txt_mat_khau_2.Text))
            {
                m_txt_output.Text = "Chưa khớp mật khẩu";
                return false;
            }
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from user_name where  and tai_khoan='" + m_txt_tai_khoan.Text+"'");
            if (v_ds.Tables[0].Rows.Count!=0)
            {
                MessageBox.Show("Tài khoản này đã tồn tại!");
                return false;
            }
            return true;
        }

        private void f001_register_Load(object sender, EventArgs e)
        {

        }

   
       
    }
}
