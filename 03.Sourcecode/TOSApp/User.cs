using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TOSApp
{
    class User
    {
        public static string tai_khoan;
        public static string mat_khau;
        public static decimal id_nhom;
        public static bool trang_thai_dang_nhap = false;
        public static string GetMD5(string txt)
        {
            string str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (byte tmp in buffer)
            {
                str += tmp.ToString("x2");
            }
            return str;
        }

        public static void phan_quyen_user(Form m_form)
        {
            List<Control> v_list = new List<Control>();
            GetAllControl(m_form,v_list);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from phan_quyen_nhom_user where trang_thai_hsd=7 and id_nhom =" + User.id_nhom);

            foreach (Control control in v_list)
            {
                if (control.GetType() == typeof(DevExpress.XtraEditors.SimpleButton))
                {
                    for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
                    {
                        if (control.Name == v_ds.Tables[0].Rows[i]["CONTROL"].ToString())
                        {
                            control.Visible = false;
                        }
                    }
                }
            }
        }

        public static void GetAllControl(Control c, List<Control> m_list)
        {
            foreach (Control control in c.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                    m_list.Add(control);

                if (control.GetType() == typeof(Panel))
                    GetAllControl(control , m_list);
            }
        }
    }
}
