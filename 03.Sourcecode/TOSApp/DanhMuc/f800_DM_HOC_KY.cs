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
    public partial class f800_DM_HOC_KY : Form
    {
        public f800_DM_HOC_KY()
        {
            InitializeComponent();
        }
        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_HOC_KY");
            m_grc_dm_hoc_ky.DataSource = v_ds.Tables[0];
            load_data_2_thong_tin_chi_tiet(v_ds.Tables[0].Rows[0]);

        }

        private void m_cmd_xoa_Click(object sender, EventArgs e)
        {

            try
            {
                DataRow v_dr = m_grv_dm_hoc_ky.GetDataRow(m_grv_dm_hoc_ky.FocusedRowHandle);
                if (v_dr != null)
                {
                    US_DM_HOC_KY v_us = new US_DM_HOC_KY(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show("Bạn có chắc chắc muốn xóa học kỳ ?" + v_us.strMA_HOC_KY, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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
                    MessageBox.Show("Hãy chọn học kỳ cần xóa!");
                }
            }
            catch
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
                DataRow v_dr = m_grv_dm_hoc_ky.GetDataRow(m_grv_dm_hoc_ky.FocusedRowHandle);
                if (v_dr != null)
                    load_data_2_thong_tin_chi_tiet(v_dr);
            }
        }

        private void load_data_2_thong_tin_chi_tiet(DataRow v_dr)
        {
            m_txt_ma_hoc_ky.Text = v_dr["MA_HOC_KY"].ToString();
            m_txt_nam_bat_dau.Text = v_dr["NAM_HOC_BAT_DAU"].ToString();
            m_txt_nam_ket_thuc.Text = v_dr["NAM_HOC_KET_THUC"].ToString();
        }

        private void m_cmd_sua_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_dm_hoc_ky.GetDataRow(m_grv_dm_hoc_ky.FocusedRowHandle);
                if (v_dr == null)
                {
                    MessageBox.Show("Hãy chọn 1 dòng dữ liệu!");
                }
                else
                {
                    if (check_du_lieu_truoc_luu())
                    {
                        US_DM_HOC_KY v_us = new US_DM_HOC_KY((decimal)v_dr["ID"]);
                        v_us.strMA_HOC_KY = m_txt_ma_hoc_ky.Text;
                        v_us.dcNAM_HOC_BAT_DAU = CIPConvert.ToDecimal(m_txt_nam_bat_dau.Text);
                        v_us.dcNAM_HOC_KET_THUC = CIPConvert.ToDecimal(m_txt_nam_ket_thuc.Text);
                        v_us.Update();
                        MessageBox.Show("Cập nhật thành công học kỳ:" + m_txt_ma_hoc_ky.Text);
                        load_data_2_grid();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình xử lý!");
            }
        }

        private bool check_du_lieu_truoc_luu()
        {
            if (m_txt_ma_hoc_ky.Text==" "||m_txt_nam_bat_dau.Text==" "||m_txt_nam_ket_thuc.Text==" ")
            {
                MessageBox.Show("Dữ liệu chưa chính xác!");
                return false;
            }
            if (m_txt_nam_ket_thuc.Text.Contains(" ")||m_txt_nam_bat_dau.Text.Contains(" "))
            {
                MessageBox.Show("Năm bắt đầu và kết thúc không được chứ khoảng trắng");
                return false;
            }
            if (CIPConvert.ToDecimal( m_txt_nam_bat_dau.Text)<2010||CIPConvert.ToDecimal( m_txt_nam_bat_dau.Text)>2100)
            {
                MessageBox.Show("Năm bắt đầu chưa chính xác! (phải nằm trong 2010 -2100)");
                return false;
            }
            if (CIPConvert.ToDecimal(m_txt_nam_ket_thuc.Text) < 2010 || CIPConvert.ToDecimal(m_txt_nam_ket_thuc.Text) > 2100)
            {
                MessageBox.Show("Năm kết thúc chưa chính xác! (phải nằm trong 2010 -2100)");
                return false;
            }
            if (CIPConvert.ToDecimal(m_txt_nam_bat_dau.Text) >= CIPConvert.ToDecimal(m_txt_nam_ket_thuc.Text))
            {
                MessageBox.Show("Năm kết thúc phải lớn hơn năm bắt đầu");
                return false;
            }
            return true;
        }

        private void m_cmd_them_Click(object sender, EventArgs e)
        {
            try
            {
                f801_DM_HOC_KY_DE f801 = new f801_DM_HOC_KY_DE();
                f801.ShowDialog();
                load_data_2_grid();
            }
            catch (Exception v)
            {

                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_txt_nam_bat_dau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void m_txt_nam_ket_thuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void f800_DM_HOC_KY_Load(object sender, EventArgs e)
        {
            load_data_2_grid();
        }

        private void m_txt_ma_hoc_ky_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
