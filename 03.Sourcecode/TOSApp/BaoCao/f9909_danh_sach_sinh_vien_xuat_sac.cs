using IP.Core.IPCommon;
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
    public partial class f9909_danh_sach_sinh_vien_xuat_sac : Form
    {
        public f9909_danh_sach_sinh_vien_xuat_sac()
        {
            InitializeComponent();
        }

        private void f9909_danh_sach_sinh_vien_xuat_sac_Load(object sender, EventArgs e)
        {
            load_data_2_cbo_hoc_ky();
        }

        private void load_data_2_cbo_hoc_ky()
        {
            WinFormControls.load_data_to_combobox("V_DM_HOC_KY", "ID", "MA_HOC_KY", "", WinFormControls.eTAT_CA.NO, m_cbo_hoc_ky);
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

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetDanhSachSV(v_ds, CIPConvert.ToDecimal(m_cbo_hoc_ky.SelectedValue.ToString()));
            m_grc_bao_cao_hoc_tap_theo_sv.DataSource = v_ds.Tables[0];

        }
         
    }
}
