using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPCOREUS;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;

namespace TOSApp.DanhMuc
{
    public partial class f400_DM_KHOA_VIEN : Form
    {
        public f400_DM_KHOA_VIEN()
        {
            InitializeComponent();
            load_data_2_grid();
        }
        DataRow m_dr;
        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_KHOA_VIEN");
            m_grc_dm_khoa_vien.DataSource = v_ds.Tables[0];
        }

        private void m_cmd_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_dm_khoa_vien.GetDataRow(m_grv_dm_khoa_vien.FocusedRowHandle);
                if (v_dr != null)
                {
                    US_DM_KHOA_VIEN v_us = new US_DM_KHOA_VIEN(CIPConvert.ToDecimal(v_dr["ID"].ToString()));

                    DialogResult result = new DialogResult();
                    result = MessageBox.Show("Bạn có chắc chắc muốn xóa Khoa Viện ?" + v_us.strTEN_KHOA_VIEN, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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
                    MessageBox.Show("Hãy chọn khoa viện cần xóa!");
                }
            }
            catch (Exception v_e)
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_them_Click(object sender, EventArgs e)
        {
            try
            {
                f401_DM_KHOA_VIEN_DE f400 = new f401_DM_KHOA_VIEN_DE();
                f400.ShowDialog();
                load_data_2_grid();
            }
            catch (Exception v_e)
            {               
                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
           
        }

        private void m_grv_dm_khoa_vien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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
                DataRow v_dr = m_grv_dm_khoa_vien.GetDataRow(m_grv_dm_khoa_vien.FocusedRowHandle);
                if (v_dr != null)
                    load_data_2_thong_tin_chi_tiet(v_dr);
            }
        }

        private void load_data_2_thong_tin_chi_tiet(DataRow v_dr)
        {
            m_dr = v_dr;
            m_txt_ma_khoa_vien.Text = v_dr["MA_KHOA_VIEN"].ToString();
            if (Convert.ToInt32( v_dr["PHAN_LOAI"])==4)
            {
                m_cbo_loai_khoa_vien.Text = "Khoa";
            }
            if (Convert.ToInt32(v_dr["PHAN_LOAI"]) == 3)
            {
                m_cbo_loai_khoa_vien.Text = "Viện";
            }
            else m_cbo_loai_khoa_vien.Text = "Chương trình đặc biệt";
            m_txt_ten_khoa_vien.Text = v_dr["TEN_KHOA_VIEN"].ToString();
           
        }

        private void m_cmd_cap_nhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_du_lieu_dau_vao())
                {
                    US_DM_KHOA_VIEN v_us = new US_DM_KHOA_VIEN(CIPConvert.ToDecimal(m_dr["ID"]));
                    v_us.strMA_KHOA_VIEN = m_txt_ma_khoa_vien.Text;
                    v_us.strTEN_KHOA_VIEN = m_txt_ten_khoa_vien.Text;
                    if (m_cbo_loai_khoa_vien.Text=="Khoa")
                    {
                        v_us.dcPHAN_LOAI = 4;
                    }
                    if (m_cbo_loai_khoa_vien.Text == "Viện")
                    {
                        v_us.dcPHAN_LOAI = 3;
                    }
                    else v_us.dcPHAN_LOAI = 6;
                    v_us.Update();
                    MessageBox.Show("Cập nhật thành công!");
                    load_data_2_grid();
                }
            }
            catch (Exception v_e)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình xử lý!");
            }
        }

        private bool check_du_lieu_dau_vao()
        {
            if (m_txt_ma_khoa_vien.Text == "" || m_txt_ten_khoa_vien.Text == "")
            {
                return false;
            }
            if (m_txt_ma_khoa_vien.Text.Contains(" "))
            {
                MessageBox.Show("Mã khoa viện không được chứa khoảng trắng");
                return false;
            }
            return true;
        }
      

    }
}
