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
                this.Hide();
                f999_main f999 = new f999_main();
                f999.ShowDialog();
            }
            catch (Exception v_e)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình đăng nhập" + v_e);
                
            }
        }
    }
}
