using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.Customization;
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

        public static void phan_quyen_user(Control m_form)
        {
            List<Control> v_list = new List<Control>();
            GetAllControls(m_form,v_list);
            
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from phan_quyen_nhom_user where trang_thai_hsd=7 and id_nhom =" + User.id_nhom);

            foreach (Control control in v_list)
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

        private static void GetAllControls(Control container, List<Control> ControlList)
        {
            foreach (Control c in container.Controls)
            {
                GetAllControls(c, ControlList);
                if (c is Panel) ControlList.Add(c);
            }
        }
        /// <summary>
        /// hàm này cho phép xuất excel và lưu dữ liệu trong Release
        /// </summary>
        /// <param name="v_grv"> tên của gridview</param>
        /// <param name="name"> tên file mà bạn muốn xuất ra</param>
        public static void xuat_excel(DevExpress.XtraGrid.Views.Grid.GridView v_grv, string name)
        {
            name =name+ ".xls";
            v_grv.SaveLayoutToXml("tempLayout.xml");
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in v_grv.Columns)
            {
                col.Visible = true;
            }
            v_grv.ExportToXls(name);
            
            v_grv.RestoreLayoutFromXml("tempLayout.xml");
        }

       
        public static string GetDiemChu(decimal v_qua_trinh,decimal v_diem_thi,decimal v_trong_so)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            string v_str_query = "SELECT * FROM dbo.fn_tinh_ket_qua(" + v_qua_trinh.ToString().Replace(',', '.') + "," + v_diem_thi.ToString().Replace(',', '.') + "," + v_trong_so.ToString().Replace(',', '.') + ")";
            v_us.FillDatasetWithQuery(v_ds, v_str_query);
            return v_ds.Tables[0].Rows[0][1].ToString();
        }
        public static decimal GetDiemSo(decimal v_qua_trinh, decimal v_diem_thi, decimal v_trong_so)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM dbo.fn_tinh_ket_qua(" + v_qua_trinh.ToString() + "," + v_diem_thi.ToString() + "," + v_trong_so.ToString() + ")");
            return CIPConvert.ToDecimal( v_ds.Tables[0].Rows[0][0].ToString());
        }
        public static decimal GetGPA(decimal v_dc_id_sinh_vien, decimal v_dc_id_hoc_ky)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM dbo.fn_ket_qua_hoc_tap(" + v_dc_id_hoc_ky.ToString() + "," + v_dc_id_sinh_vien.ToString() + ")");
            return CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0][0].ToString());
        }
        public static decimal GetCPA(decimal v_dc_id_sinh_vien, decimal v_dc_id_hoc_ky)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM dbo.fn_ket_qua_hoc_tap(" + v_dc_id_hoc_ky.ToString() + "," + v_dc_id_sinh_vien.ToString() + ")");
            return CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0][1].ToString());
        }
    }
}
