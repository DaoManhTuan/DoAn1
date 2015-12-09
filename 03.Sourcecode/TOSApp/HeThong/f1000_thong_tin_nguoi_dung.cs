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
using IPCOREUS;
using IP.Core.IPCommon;

namespace TOSApp.HeThong
{
    public partial class f1000_thong_tin_nguoi_dung : Form
    {
        public f1000_thong_tin_nguoi_dung()
        {
            InitializeComponent();
        }

        private void f1000_thong_tin_nguoi_dung_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_cbo();
                load_data_2_grid();
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
            
        }

        private void load_data_2_cbo()
        {
            WinFormControls.load_data_to_combobox("NHOM_USER", "ID", "TEN_NHOM", " Where trang_thai_hsd=7", WinFormControls.eTAT_CA.NO, m_cbo_nhom);
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_USER_NAME");
            v_ds.Tables[0].Rows[0].Delete();
            m_grc_user_name.DataSource = v_ds.Tables[0];
            load_data_2_thong_tin_chi_tiet(v_ds.Tables[0].Rows[1]);
        }

        private void m_grv_user_name_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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
                DataRow v_dr = m_grv_user_name.GetDataRow(m_grv_user_name.FocusedRowHandle);
                if (v_dr != null)
                    load_data_2_thong_tin_chi_tiet(v_dr);
            }
        }

        private void load_data_2_thong_tin_chi_tiet(DataRow v_dr)
        {
            m_txt_tai_khoan.Text = v_dr["TAI_KHOAN"].ToString();
            m_cbo_nhom.SelectedValue = (decimal)v_dr["ID_NHOM"];
        }

        private void m_cmd_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_user_name.GetDataRow(m_grv_user_name.FocusedRowHandle);
                if (v_dr != null)
                {
                    US_USER_NAME v_us = new US_USER_NAME(CIPConvert.ToDecimal(v_dr["ID"].ToString()));

                    DialogResult result = new DialogResult();
                    result = MessageBox.Show("Bạn có chắc chắc muốn xóa tài khoản ?" + v_us.strTAI_KHOAN, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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
                    MessageBox.Show("Hãy chọn tài khoản cần xóa!");
                }
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
                DataRow v_dr = m_grv_user_name.GetDataRow(m_grv_user_name.FocusedRowHandle);
                if (v_dr != null)
                {
                    if (check_du_lieu_truoc_luu())
                    {
                        US_USER_NAME v_us = new US_USER_NAME(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                        v_us.strTAI_KHOAN = m_txt_tai_khoan.Text;
                        v_us.dcID_NHOM = (decimal)m_cbo_nhom.SelectedValue;
                        v_us.Update();
                        MessageBox.Show("Cập nhật thành công tài khoản " + m_txt_tai_khoan.Text);
                        load_data_2_grid();
                    }
                }
                else
                {
                    MessageBox.Show("chọn 1 dòng");
                }
            }
            catch
            {

                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private bool check_du_lieu_truoc_luu()
        {
            if (m_txt_tai_khoan.Text == "")
            {
                MessageBox.Show("Tài khoản chưa đúng!");
                m_txt_tai_khoan.Focus();
                return false;
            }

            DataRow v_dr = m_grv_user_name.GetDataRow(m_grv_user_name.FocusedRowHandle);
            if (v_dr["TAI_KHOAN"].ToString() != m_txt_tai_khoan.Text)
            {
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us.FillDatasetWithQuery(v_ds, "select * from user_name where tai_khoan = '" + m_txt_tai_khoan.Text + "'");
                if (v_ds.Tables[0].Rows.Count != 0)
                {
                    MessageBox.Show("Tài khoản đã tồn tại!");
                    return false;
                }
            }
            return true;
        }

    }
}
