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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace TOSApp.DanhMuc
{
    public partial class f200_DM_LOP_HOC : Form
    {
        public f200_DM_LOP_HOC()
        {
            InitializeComponent();
        }
        private void load_data_2_cbo()
        {
            load_data_2_cbo_hoc_phan();
            load_data_2_cbo_giang_vien();
            load_data_2_cbo_hoc_ky();
        }

        private void load_data_2_cbo_hoc_ky()
        {
            WinFormControls.load_data_to_combobox("v_DM_HOC_KY", "ID", "MA_HOC_KY", "", WinFormControls.eTAT_CA.NO, m_cbo_hoc_ky);
        }

        private void load_data_2_cbo_giang_vien()
        {
            WinFormControls.load_data_to_combobox("V_DM_GIANG_VIEN", "ID", "TEN_GIANG_VIEN", "", WinFormControls.eTAT_CA.NO, m_cbo_giang_vien);
        }

        private void load_data_2_cbo_hoc_phan()
        {
            WinFormControls.load_data_to_combobox("V_DM_HOC_PHAN", "ID", "TEN_HOC_PHAN", "", WinFormControls.eTAT_CA.NO, m_cbo_hoc_phan);

        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_LOP_HOC");
            m_grc_dm_lop_hoc.DataSource = v_ds.Tables[0];
            load_data_2_thong_tin_chi_tiet(v_ds.Tables[0].Rows[0]);
        }

        private void m_cbo_hoc_phan_SelectedIndexChanged(object sender, EventArgs e)
        {
            US_V_DM_HOC_PHAN v_us = new US_V_DM_HOC_PHAN((decimal)m_cbo_hoc_phan.SelectedValue);
            decimal id_khoa_vien = v_us.dcID_KHOA_VIEN;
            WinFormControls.load_data_to_combobox("V_DM_GIANG_VIEN", "ID", "TEN_GIANG_VIEN", " Where ID_KHOA_VIEN=" + id_khoa_vien, WinFormControls.eTAT_CA.NO, m_cbo_giang_vien);
            m_txt_ma_hoc_phan.Text = v_us.strMA_HOC_PHAN.ToString();

        }

        private void m_grv_dm_lop_hoc_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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
                DataRow v_dr = m_grv_dm_lop_hoc.GetDataRow(m_grv_dm_lop_hoc.FocusedRowHandle);
                if (v_dr != null)
                    load_data_2_thong_tin_chi_tiet(v_dr);
            }
        }

        private void load_data_2_thong_tin_chi_tiet(DataRow v_dr)
        {
            US_V_DM_LOP_HOC v_us = new US_V_DM_LOP_HOC((decimal)v_dr["ID"]);
            m_txt_ma_lop_hoc.Text = v_us.strMA_LOP_HOC;
            m_cbo_hoc_phan.SelectedValue = (decimal)v_us.dcID_HOC_PHAN;
            m_cbo_hoc_ky.SelectedValue = (decimal)v_us.dcID_HOC_KY;
            m_cbo_giang_vien.SelectedValue = (decimal)v_us.dcID_GIANG_VIEN;
        }

        private void m_cmd_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_dm_lop_hoc.GetDataRow(m_grv_dm_lop_hoc.FocusedRowHandle);
                if (v_dr != null)
                {
                    US_DM_LOP_HOC v_us = new US_DM_LOP_HOC(CIPConvert.ToDecimal(v_dr["ID"].ToString()));

                    DialogResult result = new DialogResult();
                    result = MessageBox.Show("Bạn có chắc chắc muốn xóa lớp học ? \n" + v_us.strMA_LOP_HOC, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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
                    MessageBox.Show("Hãy chọn lớp học cần xóa!");
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
        }

        private void m_cmd_sua_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_dm_lop_hoc.GetDataRow(m_grv_dm_lop_hoc.FocusedRowHandle);
                if( v_dr == null)
                {
                    MessageBox.Show("Chọn 1 dòng!");
                }
                else
                {
                    if (check_du_lieu_truoc_khi_luu(v_dr))
                    {
                        US_DM_LOP_HOC v_us = new US_DM_LOP_HOC((decimal)v_dr["ID"]);
                        v_us.strMA_LOP_HOC = m_txt_ma_lop_hoc.Text;
                        v_us.dcID_GIANG_VIEN = (decimal)m_cbo_giang_vien.SelectedValue;
                        v_us.dcID_HOC_PHAN = (decimal)m_cbo_hoc_phan.SelectedValue;
                        v_us.dcID_HOC_KY = (decimal)m_cbo_hoc_ky.SelectedValue;
                        v_us.Update();
                        MessageBox.Show("Cập nhật thành công");
                        load_data_2_grid();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống");
            }
        }

        private bool check_du_lieu_truoc_khi_luu(DataRow v_dr)
        {
            if (m_txt_ma_hoc_phan.Text == "" || m_txt_ma_lop_hoc.Text == "")
            {
                return false;
            }
            if (m_txt_ma_lop_hoc.Text == v_dr["MA_LOP_HOC"].ToString())
            {
                return true;
            }
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from V_dm_lop_hoc where ma_lop_hoc = '" + m_txt_ma_lop_hoc.Text+"'");

            if (v_ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Mã lớp học này đã tồn tại!");
                return false;
            }
            return true;
        }

        private void m_cmd_them_Click(object sender, EventArgs e)
        {
            try
            {
                f201_DM_LOP_HOC_DE f201 = new f201_DM_LOP_HOC_DE();
                f201.ShowDialog();
                load_data_2_grid();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void f200_DM_LOP_HOC_Load(object sender, EventArgs e)
        {
            load_data_2_cbo();
            load_data_2_grid();
            User.phan_quyen_user(this);
        }

        private void m_cbo_hoc_ky_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       


    }
}
