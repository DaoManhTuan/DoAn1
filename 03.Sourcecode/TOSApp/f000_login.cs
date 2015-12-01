using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TOSApp
{
    public partial class f000_login : Form
    {
        public f000_login()
        {
            InitializeComponent();
         
        }

        private void m_cmd_dang_nhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_du_lieu())
                {
                    US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                    DataSet v_ds = new DataSet();
                    v_ds.Tables.Add(new DataTable());
                    v_us.FillDatasetWithQuery(v_ds, "select * from user_name where tai_khoan= '" + m_txt_user.Text + "'and mat_khau='" + User.GetMD5(m_txt_password.Text)+"'");
                    if (v_ds.Tables[0].Rows.Count != 1)
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                        return;
                    }
                    else
                    {
                        User.id_nhom =(decimal) v_ds.Tables[0].Rows[0]["ID_NHOM"];
                        User.tai_khoan = v_ds.Tables[0].Rows[0]["TAI_KHOAN"].ToString();
                        User.mat_khau = v_ds.Tables[0].Rows[0]["MAT_KHAU"].ToString();

                        this.Hide();
                        f999_main f999 = new f999_main();
                        f999.ShowDialog();
                        //this.Close();
                    }
                }
            }
            catch (Exception v_e)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình đăng nhập" + v_e);

            }
        }

        private bool check_du_lieu()
        {
            if (m_txt_password.Text==" "||m_txt_user.Text== " "||m_txt_user.TextLength==0||m_txt_password.TextLength==0)
            {
                return false;
            }
            if (User.trang_thai_dang_nhap)
            {
                return false;
            }
            return true;
        }

        private void m_cmd_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_dang_ky_Click(object sender, EventArgs e)
        {
            try
            {
                f001_register f001 = new f001_register();
                this.Hide();
                f001.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
        }
    }
}
