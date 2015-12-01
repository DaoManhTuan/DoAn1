using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TOSApp
{
    class User
    {
       public static string tai_khoan;
       public static string mat_khau;
       public static decimal id_nhom;
       public static bool trang_thai_dang_nhap= false;

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


    }
}
