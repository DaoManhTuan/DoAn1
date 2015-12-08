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
    public partial class f9900_bao_cao_hoc_tap_theo_lop_sin_vien : Form
    {
        public f9900_bao_cao_hoc_tap_theo_lop_sin_vien()
        {
            InitializeComponent();
        }

        private void f9900_bao_cao_hoc_tap_theo_lop_sin_vien_Load(object sender, EventArgs e)
        {

            load_data_2_cbo();
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from v_bao_cao_hoc_tap where id_lop_sinh_vien=" + m_cbo_lop_sinh_vien.SelectedValue + "and id_hoc_ky=" + m_cbo_ky_hoc.SelectedValue + " order by ma_sinh_vien");
            m_grc_bao_cao_hoc_tap_theo_lop_sinh_vien.DataSource = v_ds.Tables[0];
            if (v_ds.Tables[0].Rows.Count==0)
            {
                MessageBox.Show("Dữ liệu mà bạn chọn hiện chưa có hãy chọn lại!");
            }

        }

        private void load_data_2_cbo()
        {
            load_data_2_cbo_lop_sinh_vien();
            load_data_2_cbo_hoc_ky();
        }

        private void load_data_2_cbo_lop_sinh_vien()
        {
            WinFormControls.load_data_to_combobox("V_DM_LOP_SINH_VIEN", "ID", "LOP_SINH_VIEN", "", WinFormControls.eTAT_CA.YES, m_cbo_lop_sinh_vien);
        }

        private void load_data_2_cbo_hoc_ky()
        {
            WinFormControls.load_data_to_combobox("DM_HOC_KY", "ID", "MA_HOC_KY", " where trang_thai_hsd = 7", WinFormControls.eTAT_CA.YES, m_cbo_ky_hoc);
        }

        private void m_cmd_xem_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiem_tra_du_lieu_truoc_luu())
                {
                    load_data_2_grid();
                }
            }
            catch (Exception v)
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
        }

        private bool kiem_tra_du_lieu_truoc_luu()
        {
            if (m_cbo_lop_sinh_vien.SelectedIndex==0)
            {
                MessageBox.Show("Hãy chọn lớp sinh viên");
                return false;
                m_cbo_lop_sinh_vien.Focus();
            }

            if (m_cbo_ky_hoc.SelectedIndex==0)
            {
                MessageBox.Show("Hãy chọn học kỳ!");
                return false;
                m_cbo_ky_hoc.Focus();
            }
            return true;
        }

        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog f = new SaveFileDialog();

                if (f.ShowDialog() == DialogResult.OK)
                {
                    User.xuat_excel(m_grv_bao_cao_hoc_tap_theo_lop_sinh_vien, f.FileName);
                }
            }
            catch (Exception )
            {

                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
          
        }
    }
}
