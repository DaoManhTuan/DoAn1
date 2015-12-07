using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPCOREUS;

namespace TOSApp.DanhMuc
{
    public partial class f201_DM_LOP_HOC_DE : Form
    {
        public f201_DM_LOP_HOC_DE()
        {
            InitializeComponent();
            Load_data_2_form();
        }

        private void Load_data_2_form()
        {
            load_data_2_cbo_hoc_ky();
            load_data_2_cbo_giang_vien();
            load_data_2_cbo_hoc_phan();
            radom_ma_lop_hoc();
        }

        private void radom_ma_lop_hoc()
        {
            Random v_rd = new Random();
            for (int i = 0; i < 8; i++)
            {               
                m_txt_ma_lop_hoc.Text += v_rd.Next(0,9).ToString();
            }
        }
        private void load_data_2_cbo_hoc_ky()
        {
            WinFormControls.load_data_to_combobox("V_DM_HOC_KY", "ID", "MA_HOC_KY", "", WinFormControls.eTAT_CA.NO, m_cbo_hoc_ky);
        }

        private void load_data_2_cbo_giang_vien()
        {
            WinFormControls.load_data_to_combobox("V_DM_GIANG_VIEN", "ID", "TEN_GIANG_VIEN", "", WinFormControls.eTAT_CA.NO, m_cbo_giang_vien);
        }

        private void load_data_2_cbo_hoc_phan()
        {
            WinFormControls.load_data_to_combobox("V_DM_HOC_PHAN", "ID", "TEN_HOC_PHAN", "", WinFormControls.eTAT_CA.NO, m_cbo_hoc_phan);
        }


        private void m_cmd_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cbo_hoc_phan_SelectedIndexChanged(object sender, EventArgs e)
        {
            US_V_DM_HOC_PHAN v_us = new US_V_DM_HOC_PHAN((decimal)m_cbo_hoc_phan.SelectedValue);
            decimal id_khoa_vien = v_us.dcID_KHOA_VIEN;
            WinFormControls.load_data_to_combobox("V_DM_GIANG_VIEN", "ID", "TEN_GIANG_VIEN", " Where ID_KHOA_VIEN=" + id_khoa_vien, WinFormControls.eTAT_CA.NO, m_cbo_giang_vien);
        }

        private void m_cmd_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_du_lieu_truoc_luu())
                {
                    US_DM_LOP_HOC v_us = new US_DM_LOP_HOC();
                    v_us.strMA_LOP_HOC = m_txt_ma_lop_hoc.Text;
                    v_us.dcID_HOC_KY =(decimal) m_cbo_hoc_ky.SelectedValue;
                    v_us.dcID_HOC_PHAN = (decimal)m_cbo_hoc_phan.SelectedValue;
                    v_us.dcID_GIANG_VIEN = (decimal)m_cbo_giang_vien.SelectedValue;
                    v_us.dcTRANG_THAI_HSD = 7;
                    v_us.Insert();
                    this.Close();
                    MessageBox.Show("Đã thêm thành công lớp học: " + m_txt_ma_lop_hoc.Text);
                }
                
               
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private bool check_du_lieu_truoc_luu()
        {          
            return true;
        }
    }
}
