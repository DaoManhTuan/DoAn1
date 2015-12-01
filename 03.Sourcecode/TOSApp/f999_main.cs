using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TOSApp.DanhMuc;

namespace TOSApp
{
    public partial class f999_main : Form
    {
        public f999_main()
        {
            InitializeComponent();
            
            phan_quyen_user(User.id_nhom);
         
        }
        
        private void phan_quyen_user( decimal id_nhom)
        {
            
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from phan_quyen_nhom_user where trang_thai_hsd=7 and id_nhom =" +id_nhom);
            ArrayList visiblePages = ribbonControl1.TotalPageCategory.GetVisiblePages();

            foreach (RibbonPage page in visiblePages)
            {
                for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
                {
                    if (page.Name == v_ds.Tables[0].Rows[i]["CONTROL"].ToString())
                    {

                        page.Visible = false;
                        break;
                    }
                    else page.Visible = true;
                }
            }
            
        }

        private void m_cmd_sinh_vien_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f100_DM_SINH_VIEN f100 = new f100_DM_SINH_VIEN();
                f100.MdiParent = this;
                f100.Show();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
            
        }

        private void m_cmd_giang_vien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f500_DM_GIANG_VIEN f500 = new f500_DM_GIANG_VIEN();
                f500.MdiParent = this;
                f500.Show();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
            
        }

        private void m_cmd_khoa_vien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f400_DM_KHOA_VIEN f400 = new f400_DM_KHOA_VIEN();
                f400.MdiParent = this;
                f400.Show();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
           
        }

        private void m_cmd_hoc_phan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f600_DM_HOC_PHAN f600 = new f600_DM_HOC_PHAN();
                f600.MdiParent = this;
                f600.Show();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
            
        }

        private void m_cmd_lop_hoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f200_DM_LOP_HOC f200 = new f200_DM_LOP_HOC();
                f200.MdiParent = this;
                f200.Show();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
            
        }

        private void m_cmd_hoc_ky_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f800_DM_HOC_KY f800 = new f800_DM_HOC_KY();
                f800.MdiParent = this;
                f800.Show();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
            
        }

        private void m_cmd_khoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f900_DM_KHOA v_f900 = new f900_DM_KHOA();
                v_f900.MdiParent = this;
                v_f900.Show();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_lop_sinh_vien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f110_DM_LOP_SINH_VIEN v_f110 = new f110_DM_LOP_SINH_VIEN();
                v_f110.MdiParent = this;
                v_f110.Show();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_dang_xuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            User.trang_thai_dang_nhap = false;
          
            this.Close();

        }
    }
}
