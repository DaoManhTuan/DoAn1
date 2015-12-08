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
using TOSApp.NghiepVu;
using TOSApp.HeThong;
using TOSApp.BaoCao;
namespace TOSApp
{
    public partial class f999_main : Form
    {
        public f999_main()
        {
            InitializeComponent();
            phan_quyen_user(User.id_nhom);
         
        }
        //Form danh mục
        f100_DM_SINH_VIEN f100;
        f500_DM_GIANG_VIEN f500;
        f400_DM_KHOA_VIEN f400;
        f600_DM_HOC_PHAN f600;
        f200_DM_LOP_HOC f200;
        f800_DM_HOC_KY f800;
        f900_DM_KHOA f900;
        f110_DM_LOP_SINH_VIEN f110;
        // Form nghiệp vụ
        f100_quan_ly_diem m_f100_quan_ly_diem;
        f200_xu_ly_diem m_f200_xu_ly_diem;
        f300_tra_cuu m_f300_tra_cuu;
        // Form quản trị hệ thống
        f1000_thong_tin_nguoi_dung f1000;
        //form bao cao
        f9900_bao_cao_hoc_tap_theo_lop_sin_vien f9900_bao_cao_hoc_tap_theo_lop_sin_vien;
        f9901_bao_cao_theo_lop_hoc f9901_bao_cao_theo_lop_hoc;
        f9902_bao_cao_theo_sinh_vien f9902_bao_cao_theo_sinh_vien;
        f9903_danh_sach_sinh_vien_nhan_hoc_bong f9903_danh_sach_sinh_vien_nhan_hoc_bong;
        f9904_danh_sach_sinh_vien_canh_cao f9904_danh_sach_sinh_vien_canh_cao;
        f9905_bao_cao_cpa_gpa_theo_lop_sinh_vien f9905_bao_cao_cpa_gpa_theo_lop_sinh_vien;
        List<Control> ControlList = new List<Control>();

        private void phan_quyen_user( decimal id_nhom)
        {
            
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from phan_quyen_nhom_user where trang_thai_hsd=7 and id_nhom =" +id_nhom);

            ArrayList visiblePages = m_rib_main.TotalPageCategory.GetVisiblePages();

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
            //fix code -> nhục
            if (User.id_nhom==3)
            {
                RibbonPageGroup group = m_rib_main.GetGroupByName("m_rib_quan_ly_diem_thi");
                group.Visible = false;
            }
            
           
        }

        public bool IsFormOpen(Form checkForm)
        {
            foreach (Form form in Application.OpenForms)
                if (form.Name == checkForm.Name)
                    return true;
            return false;
        }
       
        private void m_cmd_sinh_vien_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (f100 ==null || !IsFormOpen(f100))
                {
                    f100 = new f100_DM_SINH_VIEN();
                    f100.MdiParent = this;
                    f100.Show();
                }
                else
                {
                    f100.Focus();
                }
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
                if (f500 == null || !IsFormOpen(f500))
                {
                    f500 = new f500_DM_GIANG_VIEN();
                    f500.MdiParent = this;
                    f500.Show();
                }
                else
                {
                    f500.Focus();

                }
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
                if (f400 == null || !IsFormOpen(f400))
                {
                    f400 = new f400_DM_KHOA_VIEN();
                    f400.MdiParent = this;
                    f400.Show();
                }
                else
                {
                    f400.Focus();
                }
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
                if (f600 == null || !IsFormOpen(f600))
                {
                    f600 = new f600_DM_HOC_PHAN();
                    f600.MdiParent = this;
                    f600.Show();
                }
                else
                {
                    f600.Focus();
                }
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
                if (f200 == null || !IsFormOpen(f200))
                {
                    f200 = new f200_DM_LOP_HOC();
                    f200.MdiParent = this;
                    f200.Show();
                }
                else
                {
                    f200.Focus();
                }
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
                if (f800 == null || !IsFormOpen(f800))
                {
                    f800 = new f800_DM_HOC_KY();
                    f800.MdiParent = this;
                    f800.Show();
                }
                else
                {
                    f800.Focus();
                }
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
                if (f900 == null || !IsFormOpen(f900))
                {
                    f900 = new f900_DM_KHOA();
                    f900.MdiParent = this;
                    f900.Show();
                }
                else
                {
                    f900.Focus();
                }
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
                if (f110 == null || !IsFormOpen(f110))
                {
                    f110 = new f110_DM_LOP_SINH_VIEN();
                    f110.MdiParent = this;
                    f110.Show();
                }
                else
                {
                    f110.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_dang_xuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                User.trang_thai_dang_nhap = false;
                this.Close();
            }
            catch
            {

                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
            

        }

        private void m_cmd_tao_tai_khoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f001_register f001 = new f001_register();
                f001.ShowDialog();
            }
            catch (Exception)
            {
                
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_thong_tin_nguoi_dung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            try
            {
                if (f1000 == null || !IsFormOpen(f1000))
                {
                    f1000 = new f1000_thong_tin_nguoi_dung();
                    f1000.MdiParent = this;
                    f1000.Show();
                }
                else
                {
                    f1000.Focus();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_xu_ly_diem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (m_f200_xu_ly_diem == null || !IsFormOpen(m_f200_xu_ly_diem))
                {
                    m_f200_xu_ly_diem = new f200_xu_ly_diem();
                    m_f200_xu_ly_diem.MdiParent = this;
                    m_f200_xu_ly_diem.Show();
                }
                else
                {
                    m_f200_xu_ly_diem.Focus();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_quan_ly_diem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (m_f100_quan_ly_diem == null || !IsFormOpen(m_f100_quan_ly_diem))
                {
                    m_f100_quan_ly_diem = new f100_quan_ly_diem();
                    m_f100_quan_ly_diem.MdiParent = this;
                    m_f100_quan_ly_diem.Show();
                }
                else
                {
                    m_f100_quan_ly_diem.Focus();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_tra_cuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (m_f300_tra_cuu == null || !IsFormOpen(m_f300_tra_cuu))
                {
                    m_f300_tra_cuu = new f300_tra_cuu();
                    m_f300_tra_cuu.MdiParent = this;
                    m_f300_tra_cuu.Show();
                }
                else
                {
                    m_f300_tra_cuu.Focus();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_bc_lop_sinh_vien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (f9900_bao_cao_hoc_tap_theo_lop_sin_vien == null || !IsFormOpen(f9900_bao_cao_hoc_tap_theo_lop_sin_vien))
                {
                    f9900_bao_cao_hoc_tap_theo_lop_sin_vien = new BaoCao.f9900_bao_cao_hoc_tap_theo_lop_sin_vien();
                    f9900_bao_cao_hoc_tap_theo_lop_sin_vien.MdiParent = this;
                    f9900_bao_cao_hoc_tap_theo_lop_sin_vien.Show();
                }
                else
                {
                    f9900_bao_cao_hoc_tap_theo_lop_sin_vien.Focus();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_bc_lop_hoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                if (f9901_bao_cao_theo_lop_hoc == null || !IsFormOpen(f9901_bao_cao_theo_lop_hoc))
                {
                    f9901_bao_cao_theo_lop_hoc = new BaoCao.f9901_bao_cao_theo_lop_hoc();
                    f9901_bao_cao_theo_lop_hoc.MdiParent = this;
                    f9901_bao_cao_theo_lop_hoc.Show();
                }
                else
                {
                    f9901_bao_cao_theo_lop_hoc.Focus();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_bc_sinh_vien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (f9902_bao_cao_theo_sinh_vien == null || !IsFormOpen(f9902_bao_cao_theo_sinh_vien))
                {
                    f9902_bao_cao_theo_sinh_vien = new BaoCao.f9902_bao_cao_theo_sinh_vien();
                    f9902_bao_cao_theo_sinh_vien.MdiParent = this;
                    f9902_bao_cao_theo_sinh_vien.Show();
                }
                else
                {
                    f9902_bao_cao_theo_sinh_vien.Focus();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_cpa_lop_sinh_vien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (f9905_bao_cao_cpa_gpa_theo_lop_sinh_vien == null || !IsFormOpen(f9905_bao_cao_cpa_gpa_theo_lop_sinh_vien))
                {
                    f9905_bao_cao_cpa_gpa_theo_lop_sinh_vien = new BaoCao.f9905_bao_cao_cpa_gpa_theo_lop_sinh_vien();
                    f9905_bao_cao_cpa_gpa_theo_lop_sinh_vien.MdiParent = this;
                    f9905_bao_cao_cpa_gpa_theo_lop_sinh_vien.Show();
                }
                else
                {
                    f9905_bao_cao_cpa_gpa_theo_lop_sinh_vien.Focus();
                }
            }
            catch (Exception v_e)
            {

                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
        }

       
    }
}
