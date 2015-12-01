using IP.Core.IPCommon;
using IPCOREUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TOSApp.DanhMuc
{
    public partial class f601_DM_HOC_PHAN_DE : Form
    {
        public f601_DM_HOC_PHAN_DE()
        {
            InitializeComponent();
        }

        private void m_cmd_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemtradulieu())
                {
                    US_DM_HOC_PHAN v_us = new US_DM_HOC_PHAN();
                    v_us.dcID_KHOA_VIEN = CIPConvert.ToDecimal(m_cbo_khoa_vien.SelectedValue.ToString());
                    v_us.dcSO_TIN_CHI_HOC_PHAN = CIPConvert.ToDecimal(m_txt_so_tin_chi_hoc_phan.Text);
                    v_us.dcSO_TIN_CHI_HOC_PHI = CIPConvert.ToDecimal(m_txt_so_tin_chi_hoc_phi.Text);
                    v_us.strTEN_HOC_PHAN = m_txt_ten_hoc_phan.Text;
                    v_us.strMA_HOC_PHAN = m_txt_ma_hoc_phan.Text;
                    v_us.dcTRONG_SO = CIPConvert.ToDecimal(m_txt_trong_so.Text);
                    v_us.dcTRANG_THAI_HSD = 7;
                    v_us.Insert();
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private bool kiemtradulieu()
        {
            if (CIPConvert.ToDecimal(m_cbo_khoa_vien.SelectedValue.ToString()) == -1)
            {
                MessageBox.Show("Chọn khoa viện!");
                return false;
            }
            if (m_txt_trong_so.Text == "" || m_txt_ten_hoc_phan.Text == "" || m_txt_so_tin_chi_hoc_phan.Text == "" || m_txt_so_tin_chi_hoc_phi.Text == "" || m_txt_trong_so.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
                return false;
            }
            return true;
        }

        private void m_cmd_thoat_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void f601_DM_HOC_PHAN_DE_Load(object sender, EventArgs e)
        {
            try
            {
                WinFormControls.load_data_to_combobox_with_query(m_cbo_khoa_vien, "ID", "TEN_KHOA_VIEN", WinFormControls.eTAT_CA.YES, "SELECT ID, TEN_KHOA_VIEN FROM DM_KHOA_VIEN WHERE PHAN_LOAI IN (3,4) AND TRANG_THAI_HSD = 7");
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_txt_so_tin_chi_hoc_phan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void m_txt_so_tin_chi_hoc_phi_KeyPress(object sender, KeyPressEventArgs e)
        {

            char decimalChar = ',';
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { }
            else if (e.KeyChar == decimalChar && m_txt_so_tin_chi_hoc_phi.Text.IndexOf(decimalChar) == -1)
            { }
            else
            {
                e.Handled = true;
            }
        }

        private void m_txt_trong_so_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalChar = ',';
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { }
            else if (e.KeyChar == decimalChar && m_txt_trong_so.Text.IndexOf(decimalChar) == -1)
            { }
            else
            {
                e.Handled = true;
            }
        }

       
    }
}
