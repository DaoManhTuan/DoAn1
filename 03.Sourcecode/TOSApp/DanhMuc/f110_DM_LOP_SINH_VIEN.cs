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
using System.Windows.Forms;

namespace TOSApp.DanhMuc
{
    public partial class f110_DM_LOP_SINH_VIEN : Form
    {
        public f110_DM_LOP_SINH_VIEN()
        {
            InitializeComponent();
        }

        private void f110_DM_LOP_SINH_VIEN_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_to_cbo_khoa_vien();
                load_data_2_khoa();
                load_data_2_grid();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void load_data_2_khoa()
        {
            try
            {
                WinFormControls.load_data_to_combobox_with_query(m_cbo_khoa, "ID", "KHOA", WinFormControls.eTAT_CA.YES, "SELECT ID, KHOA FROM DM_KHOA WHERE TRANG_THAI_HSD = 7");
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
                WinFormControls.load_data_to_combobox_with_query(m_cbo_ten_khoa_vien, "ID", "TEN_KHOA_VIEN", WinFormControls.eTAT_CA.YES, "SELECT ID, TEN_KHOA_VIEN FROM DM_KHOA_VIEN WHERE PHAN_LOAI IN (3,6,5) AND TRANG_THAI_HSD = 7");
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_LOP_SINH_VIEN");
            m_grc_dm_lop_sinh_vien.DataSource = v_ds.Tables[0];
            load_data_2_thong_tin_chi_tiet(v_ds.Tables[0].Rows[0]);
        }

        private void load_data_2_thong_tin_chi_tiet(DataRow v_dr)
        {
            m_txt_lop_sinh_vien.Text = v_dr["LOP_SINH_VIEN"].ToString();
            m_cbo_ten_khoa_vien.SelectedValue = CIPConvert.ToDecimal( v_dr["ID_KHOA_VIEN"].ToString());
            m_cbo_khoa.SelectedValue = CIPConvert.ToDecimal(v_dr["ID_KHOA"].ToString());
        }

        private void m_grv_dm_lop_sinh_vien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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
                DataRow v_dr = m_grv_dm_lop_sinh_vien.GetDataRow(m_grv_dm_lop_sinh_vien.FocusedRowHandle);
                if (v_dr != null)
                    load_data_2_thong_tin_chi_tiet(v_dr);
            }
        }

        private void m_cmd_sua_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_dm_lop_sinh_vien.GetDataRow(m_grv_dm_lop_sinh_vien.FocusedRowHandle);
                if (v_dr != null)
                {
                    if (kiemtradulieu())
                    {
                        US_DM_LOP_SINH_VIEN v_us = new US_DM_LOP_SINH_VIEN(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                        v_us.strLOP_SINH_VIEN = m_txt_lop_sinh_vien.Text;
                        v_us.dcID_KHOA = CIPConvert.ToDecimal(m_cbo_khoa.SelectedValue.ToString());
                        v_us.dcID_KHOA_VIEN = CIPConvert.ToDecimal(m_cbo_ten_khoa_vien.SelectedValue.ToString());
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
            if (CIPConvert.ToDecimal(m_cbo_ten_khoa_vien.SelectedValue.ToString()) == -1)
            {
                MessageBox.Show("Chọn khoa viện!");
                return false;
            }
            if (CIPConvert.ToDecimal(m_cbo_khoa.SelectedValue.ToString()) == -1)
            {
                MessageBox.Show("Chọn khóa!");
                return false;
            }
            if (m_txt_lop_sinh_vien.Text == "" )
            {
                MessageBox.Show("Hãy điền tên lớp sinh viên");
                return false;
            }
            return true;
        }

        private void m_cmd_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_dm_lop_sinh_vien.GetDataRow(m_grv_dm_lop_sinh_vien.FocusedRowHandle);
                if (v_dr != null)
                {
                    US_DM_LOP_SINH_VIEN v_us = new US_DM_LOP_SINH_VIEN(CIPConvert.ToDecimal(v_dr["ID"].ToString()));

                    DialogResult result = new DialogResult();
                    result = MessageBox.Show("Bạn có chắc chắc muốn xóa học phần " + v_us.strLOP_SINH_VIEN + " ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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

        private void m_cmd_them_Click(object sender, EventArgs e)
        {
            try
            {
                f111_DM_LOP_SINH_VIEN_DE v_f = new f111_DM_LOP_SINH_VIEN_DE();
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
