using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TOSApp.BaoCao
{
    public partial class f9903_danh_sach_sinh_vien_nhan_hoc_bong : Form
    {
        public f9903_danh_sach_sinh_vien_nhan_hoc_bong()
        {
            InitializeComponent();
        }

        private void f9903_danh_sach_sinh_vien_nhan_hoc_bong_Load(object sender, EventArgs e)
        {
            load_data_2_cbo_hoc_ky();
        }

        private void load_data_2_cbo_hoc_ky()
        {
            WinFormControls.load_data_to_combobox("DM_HOC_KY", "ID", "MA_HOC_KY", " where trang_thai_hsd = 7", WinFormControls.eTAT_CA.YES, m_cbo_hoc_ky);
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select top 10 from V_HOC_BONG_XU_LY_HOC_TAP where id_hoc_ky=" + m_cbo_hoc_ky.SelectedValue +" order by GPA desc");
            m_grc_bao_cao_hoc_tap_theo_sv.DataSource = v_ds.Tables[0];
            if (v_ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Dữ liệu mà bạn chọn hiện chưa có hãy chọn lại!");
            }

        }

        private void m_cmd_xem_Click(object sender, EventArgs e)
        {
            try
            {               
                    load_data_2_grid();
              
            }
            catch (Exception v)
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
        }

        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog f = new SaveFileDialog();

                if (f.ShowDialog() == DialogResult.OK)
                {
                    User.xuat_excel(m_grv_bao_cao_hoc_tap_theo_sv, f.FileName);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
        }
    }
}
