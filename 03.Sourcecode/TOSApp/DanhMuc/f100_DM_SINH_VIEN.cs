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
using IPCOREDS;


namespace TOSApp.DanhMuc
{
    public partial class f100_DM_SINH_VIEN : Form
    {
        public f100_DM_SINH_VIEN()
        {
            InitializeComponent();
            load_data_2_grid();
        }

        bool m_bol_check = false;

        private void load_data_2_cbo()
        {
            load_data_2_cbo_khoa();
            load_data_2_cbo_khoa_vien();
            load_data_2_cbo_trang_thai();
        }

        private void load_data_2_cbo_trang_thai()
        {
            WinFormControls.load_data_to_combobox("CM_DM_TU_DIEN", "ID", "TEN_TU_DIEN", "WHERE ID_LOAI_TU_DIEN = 2", WinFormControls.eTAT_CA.NO, m_cbo_trang_thai);
        }

        private void load_data_2_cbo_khoa_vien()
        {
            m_bol_check = true;
            WinFormControls.load_data_to_combobox("DM_KHOA_VIEN", "ID", "TEN_KHOA_VIEN", "WHERE TRANG_THAI_HSD = 7 AND PHAN_LOAI != 4", WinFormControls.eTAT_CA.NO, m_cbo_khoa_vien);

        }

        private void load_data_2_cbo_khoa()
        {
            WinFormControls.load_data_to_combobox("DM_KHOA", "ID", "KHOA", "WHERE TRANG_THAI_HSD = 7 order by KHOA desc", WinFormControls.eTAT_CA.NO, m_cbo_khoa);
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_SINH_VIEN");
            m_grc_dm_sinh_vien.DataSource = v_ds.Tables[0];
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

        private void DoRowClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                DataRow v_dr = m_grv_dm_sinh_vien.GetDataRow(m_grv_dm_sinh_vien.FocusedRowHandle);
                if (v_dr != null)
                    load_data_2_thong_tin_chi_tiet(v_dr);
            }
        }

        private void load_data_2_thong_tin_chi_tiet(DataRow v_dr)
        {

            m_txt_ma_so_sinh_vien.Text = v_dr["MA_SINH_VIEN"].ToString();
            m_txt_ho_ten_sinh_vien.Text = v_dr["TEN_SINH_VIEN"].ToString();
            m_dat_ngay_sinh.Value = Convert.ToDateTime(v_dr["NGAY_SINH"].ToString());

            if (v_dr["GIOI_TINH"].ToString() == "NAM")
            {
                m_rdb_nam.Checked = true;
                m_rdb_nu.Checked = false;
            }
            else
            {
                m_rdb_nam.Checked = false;
                m_rdb_nu.Checked = true;
            }

            m_cbo_khoa.SelectedValue = CIPConvert.ToDecimal(v_dr["ID_KHOA"].ToString());
            m_cbo_khoa_vien.SelectedValue = CIPConvert.ToDecimal(v_dr["ID_KHOA_VIEN"].ToString());
            m_cbo_lop_sinh_vien.SelectedValue = CIPConvert.ToDecimal(v_dr["ID_LOP_SINH_VIEN"].ToString());
            m_txt_so_dien_thoai.Text = v_dr["SDT"].ToString();
            m_txt_que_quan.Text = v_dr["QUE_QUAN"].ToString();
            m_cbo_trang_thai.SelectedValue = CIPConvert.ToDecimal(v_dr["TRANG_THAI"].ToString());
        }

        private void m_cmd_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_dm_sinh_vien.GetDataRow(m_grv_dm_sinh_vien.FocusedRowHandle);
                if (v_dr != null)
                {
                    US_DM_SINH_VIEN v_us = new US_DM_SINH_VIEN(CIPConvert.ToDecimal(v_dr["ID"].ToString()));

                    DialogResult result = new DialogResult();
                    result = MessageBox.Show("Bạn có chắc chắc muốn xóa sinh viên ?" + v_us.strTEN_SINH_VIEN, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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
                    MessageBox.Show("Hãy chọn sinh viên cần xóa!");
                }
            }
            catch (Exception v_e)
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_sua_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_dm_sinh_vien.GetDataRow(m_grv_dm_sinh_vien.FocusedRowHandle);
                if (v_dr != null)
                {
                    if (check_du_lieu_truoc_luu(v_dr) == true)
                    {


                        //update DM sinh viên
                        US_DM_SINH_VIEN v_us = new US_DM_SINH_VIEN(CIPConvert.ToDecimal(v_dr["ID"].ToString()));

                        v_us.strMA_SINH_VIEN = m_txt_ma_so_sinh_vien.Text;
                        v_us.strTEN_SINH_VIEN = m_txt_ho_ten_sinh_vien.Text;
                        v_us.strSDT = m_txt_so_dien_thoai.Text;
                        if (m_rdb_nam.Checked == true)
                        {
                            v_us.strGIOI_TINH = "N";
                        }
                        else v_us.strGIOI_TINH = "W";
                        v_us.strQUE_QUAN = m_txt_que_quan.Text;
                        v_us.datNGAY_SINH = m_dat_ngay_sinh.Value;
                        v_us.dcID_LOP_SINH_VIEN = CIPConvert.ToDecimal(m_cbo_lop_sinh_vien.SelectedValue);
                        v_us.dcTRANG_THAI = CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue);
                        v_us.Update();

                        MessageBox.Show("Cập nhật thành công!");
                        load_data_2_grid();
                    }
                }
                else
                {
                    MessageBox.Show("hãy chọn 1 sinh viên!");
                }
            }
            catch (Exception v_e)
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }

        }

        private bool check_du_lieu_truoc_luu(DataRow v_dr)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from dm_sinh_vien where ma_sinh_vien='" + m_txt_ma_so_sinh_vien.Text + "' AND ma_sinh_vien != " + v_dr["MA_SINH_VIEN"].ToString());

            if (v_ds.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show("Sinh viên có mã số này đã tồn tại!");
                return false;
            }
            if (m_txt_ma_so_sinh_vien.Text == "" || m_txt_ho_ten_sinh_vien.Text == "")
            {
                MessageBox.Show("Hãy điền đủ thông tin trước khi lưu!");
                return false;
            }
            if (CIPConvert.ToDecimal(m_cbo_lop_sinh_vien.SelectedValue) == -1)
            {
                MessageBox.Show("Hãy chọn lớp phù hợp!");
                return false;
            }

            return true;
        }

        private void m_cbo_khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load lại dữ liệu Dm_lớp_sinh viên
            try
            {
                if (m_bol_check == true)
                {
                    WinFormControls.load_data_to_combobox("V_DM_LOP_SINH_VIEN", "ID", "LOP_SINH_VIEN", "WHERE ID_KHOA = " + m_cbo_khoa.SelectedValue + "AND ID_KHOA_VIEN = " + m_cbo_khoa_vien.SelectedValue.ToString(), WinFormControls.eTAT_CA.YES, m_cbo_lop_sinh_vien);

                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }

        }

        private void m_cbo_khoa_vien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load data lại cho lớp sinh viên
            try
            {
                if (m_bol_check == true)
                {
                    WinFormControls.load_data_to_combobox("V_DM_LOP_SINH_VIEN", "ID", "LOP_SINH_VIEN", "WHERE ID_KHOA = " + m_cbo_khoa.SelectedValue.ToString() + "AND ID_KHOA_VIEN = " + m_cbo_khoa_vien.SelectedValue.ToString(), WinFormControls.eTAT_CA.YES, m_cbo_lop_sinh_vien);

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
                f101_DM_SINH_VIEN_DE v_f101 = new f101_DM_SINH_VIEN_DE();
                v_f101.ShowDialog();
                load_data_2_grid();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_grv_dm_sinh_vien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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

        private void f100_DM_SINH_VIEN_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
                load_data_2_cbo();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }
    }
}
