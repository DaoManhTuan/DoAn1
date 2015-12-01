using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using IP.Core.IPCommon;
using IPCOREUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TOSApp.DanhMuc
{
    public partial class f600_DM_HOC_PHAN : Form
    {
        public f600_DM_HOC_PHAN()
        {
            InitializeComponent();
        }

        private void f600_DM_HOC_PHAN_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_to_cbo_khoa_vien();
                load_data_2_grid();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void load_data_2_to_cbo_khoa_vien()
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

        private void load_data_2_grid()
        {
            try
            {
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us.FillDatasetWithTableName(v_ds, "V_DM_HOC_PHAN");
                m_grc_dm_hoc_phan.DataSource = v_ds.Tables[0];
                load_data_2_thong_tin_chi_tiet(v_ds.Tables[0].Rows[0]);
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_grv_dm_hoc_phan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                Point pt = view.GridControl.PointToClient(Control.MousePosition);
                DoRowClick(view, pt);
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void DoRowClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                DataRow v_dr = m_grv_dm_hoc_phan.GetDataRow(m_grv_dm_hoc_phan.FocusedRowHandle);
                if (v_dr != null)
                    load_data_2_thong_tin_chi_tiet(v_dr);
            }
        }

        private void load_data_2_thong_tin_chi_tiet(DataRow v_dr)
        {
            try
            {
                m_cbo_khoa_vien.SelectedValue = CIPConvert.ToDecimal(v_dr["ID_KHOA_VIEN"].ToString());
                m_txt_ma_hoc_phan.Text = v_dr["MA_HOC_PHAN"].ToString();
                m_txt_ten_hoc_phan.Text = v_dr["TEN_HOC_PHAN"].ToString();
                m_txt_so_tin_chi_hoc_phan.Text = v_dr["SO_TIN_CHI_HOC_PHAN"].ToString();
                m_txt_so_tin_chi_hoc_phi.Text = v_dr["SO_TIN_CHI_HOC_PHI"].ToString();
                m_txt_trong_so.Text = v_dr["TRONG_SO"].ToString();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }

        }

        private void m_cmd_sua_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_dm_hoc_phan.GetDataRow(m_grv_dm_hoc_phan.FocusedRowHandle);
                if (v_dr != null)
                {
                    if (kiemtradulieu())
                    {
                        US_DM_HOC_PHAN v_us = new US_DM_HOC_PHAN(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                        v_us.dcID_KHOA_VIEN = CIPConvert.ToDecimal(m_cbo_khoa_vien.SelectedValue.ToString());
                        v_us.dcSO_TIN_CHI_HOC_PHAN = CIPConvert.ToDecimal(m_txt_so_tin_chi_hoc_phan.Text);
                        v_us.dcSO_TIN_CHI_HOC_PHI = CIPConvert.ToDecimal(m_txt_so_tin_chi_hoc_phi.Text);
                        v_us.strTEN_HOC_PHAN = m_txt_ten_hoc_phan.Text;
                        v_us.dcTRONG_SO = CIPConvert.ToDecimal(m_txt_trong_so.Text);
                        v_us.strMA_HOC_PHAN = m_txt_ma_hoc_phan.Text;
                        v_us.Update();
                        MessageBox.Show("Cập nhật thành công!");
                        load_data_2_grid();
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn một dòng!");
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

        private void m_cmd_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_dm_hoc_phan.GetDataRow(m_grv_dm_hoc_phan.FocusedRowHandle);
                if (v_dr != null)
                {
                    US_DM_HOC_PHAN v_us = new US_DM_HOC_PHAN(CIPConvert.ToDecimal(v_dr["ID"].ToString()));

                    DialogResult result = new DialogResult();
                    result = MessageBox.Show("Bạn có chắc chắc muốn xóa học phần " + v_us.strTEN_HOC_PHAN + " ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        v_us.dcTRANG_THAI_HSD = 10;
                        v_us.Update();
                        MessageBox.Show("Bạn vừa xóa thành công!");
                        load_data_2_grid();
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn một dòng!");
                }
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

        private void m_cmd_them_Click(object sender, EventArgs e)
        {
            try
            {
                f601_DM_HOC_PHAN_DE v_f = new f601_DM_HOC_PHAN_DE();
                v_f.ShowDialog();
                load_data_2_grid();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }


    }
}
