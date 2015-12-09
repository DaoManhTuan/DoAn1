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
    public partial class f9901_bao_cao_theo_lop_hoc : Form
    {
        public f9901_bao_cao_theo_lop_hoc()
        {
            InitializeComponent();
        }

        private void f9901_bao_cao_theo_lop_hoc_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_cbo();
            }
            catch 
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
            
        }

        private void load_data_2_cbo()
        {
            load_data_2_cbo_hoc_ky();
        }

        private void load_data_2_cbo_hoc_ky()
        {
            WinFormControls.load_data_to_combobox("V_DM_HOC_KY", "ID", "MA_HOC_KY", "", WinFormControls.eTAT_CA.NO, m_cbo_hoc_ky);
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM V_DIEM_THI WHERE ID_LOP_HOC=" + m_cbo_ma_lop_hoc.SelectedValue );
            m_grc_bao_cao_hoc_tap_theo_ma_lop_hoc.DataSource = v_ds.Tables[0];
        }

        private void m_cmd_xem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CIPConvert.ToDecimal(m_cbo_ma_lop_hoc.SelectedValue.ToString()) > -1)
                    load_data_2_grid();
                else
                    MessageBox.Show("Hãy chọn một mã lớp học!");
            }
            catch
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
                    User.xuat_excel(m_grv_bao_cao_hoc_tap_theo_ma_lop_hoc, f.FileName);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }

        }

        private void m_cbo_hoc_ky_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                WinFormControls.load_data_to_combobox("V_DIEM_THI", "ID_LOP_HOC", "MA_LOP_HOC", "WHERE ID_HOC_KY = " + m_cbo_hoc_ky.SelectedValue.ToString(), WinFormControls.eTAT_CA.YES, m_cbo_ma_lop_hoc);
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
        }

      
    }
}
