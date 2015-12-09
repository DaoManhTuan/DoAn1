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
    public partial class f9908_bieu_do_ty_le_qua_mon : Form
    {
        public f9908_bieu_do_ty_le_qua_mon()
        {
            InitializeComponent();
        }
        int m_int_count_qua = 0;
        int m_int_count_k_qua = 0;

        private void f9908_bieu_do_ty_le_qua_mon_Load(object sender, EventArgs e)
        {
            load_data_2_cbo_ky_hoc();

        }

        private void load_data_2_cbo_ky_hoc()
        {

            WinFormControls.load_data_to_combobox("V_DM_HOC_KY", "ID", "MA_HOC_KY", "", WinFormControls.eTAT_CA.YES, m_cbo_ky_hoc);
        }

        private void m_cbo_ky_hoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_cbo_ky_hoc.SelectedIndex != 0)
            {

                WinFormControls.load_data_to_combobox("V_DM_LOP_HOC", "ID_HOC_PHAN", "MA_HOC_PHAN", " where id_hoc_ky=" + m_cbo_ky_hoc.SelectedValue, WinFormControls.eTAT_CA.NO, m_cbo_hoc_phan);

            }
        }

        private void m_cbo_hoc_phan_SelectedIndexChanged(object sender, EventArgs e)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select TEN_HOC_PHAN from DM_hoc_phan where id=" + m_cbo_hoc_phan.SelectedValue);
            m_lb_ten_hoc_phan.Text = v_ds.Tables[0].Rows[0][0].ToString();
        }

        private void m_cmd_loc_Click(object sender, EventArgs e)
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

            if (m_cbo_ky_hoc.SelectedIndex == 0)
            {
                MessageBox.Show("Hãy chọn học kỳ!");
                m_cbo_ky_hoc.Focus();
                return false;
            }

            return true;
        }


        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select distinct ID_sinh_vien,MA_HOC_KY from v_diem_thi where id_hoc_ky="  + m_cbo_ky_hoc.SelectedValue + " and id_hoc_phan = " + m_cbo_hoc_phan.SelectedValue);
            US_DUNG_CHUNG k_us = new US_DUNG_CHUNG();
            DataSet k_ds = new DataSet();
            k_ds.Tables.Add(new DataTable());
            k_us.FillDatasetWithQuery(k_ds, "select distinct ID_SINh_vien from v_diem_thi where id_hoc_ky="  + m_cbo_ky_hoc.SelectedValue + " and id_hoc_phan = " + m_cbo_hoc_phan.SelectedValue + " and DIem_chu like 'F%' ");
            m_int_count_k_qua = k_ds.Tables[0].Rows.Count;
            m_int_count_qua = v_ds.Tables[0].Rows.Count - m_int_count_k_qua;
            DataTable table = new DataTable();
            table.Columns.Add("HocKy", typeof(string));
            table.Columns.Add("Qua", typeof(int));
          //  table.Columns.Add("KhongQua", typeof(int));
           
            table.Rows.Add(new object[] {"Qua", m_int_count_qua });
            table.Rows.Add(new object[] { "Không qua", m_int_count_k_qua });
            //table.Rows.Add(new DataRow());
            //table.Rows[0]["Qua"] = m_int_count_qua;
            //table.Rows[0]["KhongQua"] = m_int_count_k_qua;
            // table.Rows.Add(new object[] ((m_int_count_qua),(m_int_count_k_qua)));
            m_pivot.DataSource = table;
            if (v_ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Dữ liệu mà bạn chọn hiện chưa có hãy chọn lại!");
            }

        }
    }
}
