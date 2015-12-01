using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPCOREUS;
using IP.Core.IPCommon;
namespace TOSApp.DanhMuc
{
    public partial class f501_DM_GIANG_VIEN_DE : Form
    {
        public f501_DM_GIANG_VIEN_DE()
        {
            InitializeComponent();
        }

        private void load_data_2_form()
        {          
            load_data_2_cbo_khoa_vien();
            load_data_2_ma_giang_vien();//sinh tu dong ma giang vien

        }

        private void load_data_2_cbo_khoa_vien()
        {
            WinFormControls.load_data_to_combobox("DM_KHOA_VIEN", "ID", "TEN_KHOA_VIEN", " WHERE trang_thai_hsd=7", WinFormControls.eTAT_CA.NO, m_cbo_khoa_vien);
        }

        private void load_data_2_ma_giang_vien()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from dm_giang_vien");
            m_txt_ma_giang_vien.Text = (CIPConvert.ToDecimal( v_ds.Tables[0].Rows[v_ds.Tables[0].Rows.Count -1]["MA_GIANG_VIEN"].ToString()) + 1).ToString();
        }

      
        private void m_cmd_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiem_tra_du_lieu_truoc_luu())
                {
                    US_DM_GIANG_VIEN v_us = new US_DM_GIANG_VIEN();
                    v_us.strMA_GIANG_VIEN = m_txt_ma_giang_vien.Text;
                    v_us.strTEN_GIANG_VIEN = m_txt_ho_ten_giang_vien.Text;
                    v_us.strQUE_QUAN = m_txt_que_quan.Text;
                    v_us.strSDT = m_txt_sdt.Text;
                    if (m_rdb_gt_nam.Checked)
                    {
                        v_us.strGIOI_TINH = "N";
                    }
                    else v_us.strGIOI_TINH = "W";
                    v_us.datNGAY_SINH = (DateTime)m_dat_ngay_sinh.Value;
                    v_us.dcID_KHOA_VIEN =CIPConvert.ToDecimal(m_cbo_khoa_vien.SelectedValue);
                    v_us.dcTRANG_THAI_HSD = 7;
                    v_us.Insert();
                    MessageBox.Show("Thêm thành công giảng viên:"+ m_txt_ho_ten_giang_vien.Text);
                    this.Close();
                }
            }
            catch (Exception v)
            {

                MessageBox.Show("Đã xảy ra lỗi trong quá trình xử lý!");
            }
        }

        private bool kiem_tra_du_lieu_truoc_luu()
        {
            if (m_txt_ho_ten_giang_vien.Text=="")
            {
                MessageBox.Show("Hãy điền họ tên giảng viên!");
                return false;
            }
            
            return true;
        }

        private void m_cmd_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void f501_DM_GIANG_VIEN_DE_Load(object sender, EventArgs e)
        {
            load_data_2_form();

        }
    }
}
