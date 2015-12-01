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
    public partial class f900_DM_KHOA : Form
    {
        public f900_DM_KHOA()
        {
            InitializeComponent();
        }

        private void f900_DM_KHOA_Load(object sender, EventArgs e)
        {
            load_data_2_grid();
          
        }
        DataRow m_dr;
     

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "DM_KHOA");
            m_grc_dm_khoa.DataSource = v_ds.Tables[0];

        }

        private void m_cmd_xoa_Click(object sender, EventArgs e)
        {

            try
            {
                DataRow v_dr = m_grv_dm_khoa.GetDataRow(m_grv_dm_khoa.FocusedRowHandle);
                if (v_dr != null)
                {
                    US_DM_KHOA v_us = new US_DM_KHOA(CIPConvert.ToDecimal(v_dr["ID"].ToString()));

                    DialogResult result = new DialogResult();
                    result = MessageBox.Show("Bạn có chắc chắc muốn xóa khóa ?" + v_us.strKHOA, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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
                    MessageBox.Show("Hãy chọn khoa khóa cần xóa!");
                }
            }
            catch (Exception v_e)
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_grv_dm_khoa_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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
                DataRow v_dr = m_grv_dm_khoa.GetDataRow(m_grv_dm_khoa.FocusedRowHandle);
                if (v_dr != null)
                    load_data_2_thong_tin_chi_tiet(v_dr);
            }
        }

        private void load_data_2_thong_tin_chi_tiet(DataRow v_dr)
        {
            m_dr = v_dr;
            m_txt_khoa.Text = v_dr["KHOA"].ToString();
            m_txt_nam_bat_dau.Text = v_dr["NAM_BAT_DAU"].ToString();
        }

        private void m_cmd_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_du_lieu_truoc_luu())
                {
                    US_DM_KHOA v_us = new US_DM_KHOA((decimal)m_dr["ID"]);
                    v_us.strKHOA = m_txt_khoa.Text;
                    v_us.dcTRANG_THAI_HSD = 7;
                    v_us.dcNAM_BAT_DAU =CIPConvert.ToDecimal( m_txt_nam_bat_dau.Text);
                    v_us.Update();
                    MessageBox.Show("Cập nhật thành công khóa:"+m_txt_khoa.Text);
                    load_data_2_grid();
                }
            }
            catch (Exception v)
            {

                MessageBox.Show("Đã xảy ra lỗi trong quá trình xử lý!");
            }
        }

        private bool check_du_lieu_truoc_luu()
        {
            if (m_txt_nam_bat_dau.Text==" "||m_txt_khoa.Text==" ")
            {
                return false;
            }
            return true;
        }

        private void m_txt_nam_bat_dau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void m_cmd_them_Click(object sender, EventArgs e)
        {
            f901_DM_KHOA_DE f901 = new f901_DM_KHOA_DE();
            f901.ShowDialog();
            load_data_2_grid();
        }



    }
}
