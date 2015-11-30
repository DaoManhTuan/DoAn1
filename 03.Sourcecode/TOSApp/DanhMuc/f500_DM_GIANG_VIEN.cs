using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IPCOREUS;

namespace TOSApp.DanhMuc
{
    public partial class f500_DM_GIANG_VIEN : Form
    {
        public f500_DM_GIANG_VIEN()
        {
            InitializeComponent();
            load_data_2_grid();
            load_data_2_cbo_khoa_vien();
        }
        DataRow m_dr;
        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_GIANG_VIEN");
            m_grc_dm_giang_vien.DataSource = v_ds.Tables[0];
        }
        private void load_data_2_cbo_khoa_vien()
        {            
            WinFormControls.load_data_to_combobox("DM_KHOA_VIEN", "ID", "TEN_KHOA_VIEN", "WHERE TRANG_THAI_HSD = 7", WinFormControls.eTAT_CA.NO, m_cbo_khoa_vien);        
        }


        private void m_grv_dm_giang_vien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                Point pt = view.GridControl.PointToClient(Control.MousePosition);
                DoRowClick(view, pt);
            }
            catch(Exception v_e) 
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!" + v_e);
            }
        }

        private void DoRowClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                DataRow v_dr = m_grv_dm_giang_vien.GetDataRow(m_grv_dm_giang_vien.FocusedRowHandle);
                if (v_dr != null)
                    load_data_2_thong_tin_chi_tiet(v_dr);
            }
        }

        private void load_data_2_thong_tin_chi_tiet(DataRow v_dr)
        {
            m_txt_ma_giang_vien.Text = v_dr["MA_GIANG_VIEN"].ToString();
            m_txt_ho_ten_GV.Text = v_dr["TEN_GIANG_VIEN"].ToString();
            m_txt_so_dien_thoai.Text = v_dr["SDT"].ToString();
            m_txt_que_quan.Text = v_dr["QUE_QUAN"].ToString();
            m_dat_ngay_sinh.Value = (DateTime)(v_dr["NGAY_SINH"]);
            if (v_dr["GIOI_TINH"].ToString() == "NAM")
            {
                m_rdb_gt_nam.Checked = true;
                m_rdb_gt_nu.Checked = false;
            }
            else
            {
                m_rdb_gt_nam.Checked = false;
                m_rdb_gt_nu.Checked = true;
            }
            m_cbo_khoa_vien.SelectedValue = CIPConvert.ToDecimal(v_dr["ID_KHOA_VIEN"].ToString());
        }

        private void m_cmd_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_dm_giang_vien.GetDataRow(m_grv_dm_giang_vien.FocusedRowHandle);
                if (v_dr != null)
                {
                    US_DM_GIANG_VIEN v_us = new US_DM_GIANG_VIEN(CIPConvert.ToDecimal(v_dr["ID"].ToString()));

                    DialogResult result = new DialogResult();
                    result = MessageBox.Show("Bạn có chắc chắc muốn xóa giảng viên ?" + v_us.strTEN_GIANG_VIEN, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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
                    MessageBox.Show("Hãy chọn giảng viên cần xóa!");
                }
            }
            catch (Exception v_e)
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }
       
    }
}
