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

namespace TOSApp.NghiepVu
{
    public partial class f100_quan_ly_diem : Form
    {
        public f100_quan_ly_diem()
        {
            InitializeComponent();
        }
        bool m_bol_isUpdate = true;
        decimal m_id_sinh_vien;
        private void f100_quan_ly_diem_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_cbo_ma_lop_hoc();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
            
        }

        private void load_data_2_cbo_ma_lop_hoc()
        {
            WinFormControls.load_data_to_combobox_with_query(m_cbo_ma_lop_hoc, "ID", "MA_LOP_HOC", WinFormControls.eTAT_CA.NO, "SELECT ID, MA_LOP_HOC FROM V_DM_LOP_HOC");

        }

        private void m_cbo_ma_lop_hoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                US_DM_LOP_HOC v_us_lop_hoc = new US_DM_LOP_HOC(CIPConvert.ToDecimal(m_cbo_ma_lop_hoc.SelectedValue.ToString()));
                load_data_2_thong_tin_lop_hoc(v_us_lop_hoc);
                load_data_2_grid();
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
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM V_DIEM_THI WHERE ID_LOP_HOC = " + m_cbo_ma_lop_hoc.SelectedValue.ToString());
            m_grc_diem_thi.DataSource = v_ds.Tables[0];
        }

        private void load_data_2_thong_tin_lop_hoc(US_DM_LOP_HOC v_us_lop_hoc)
        {
            US_DM_HOC_KY v_us_hoc_ky = new US_DM_HOC_KY(CIPConvert.ToDecimal(v_us_lop_hoc.dcID_HOC_KY));
            US_DM_HOC_PHAN v_us_hoc_phan = new US_DM_HOC_PHAN(CIPConvert.ToDecimal(v_us_lop_hoc.dcID_HOC_PHAN));
            m_cbo_ma_lop_hoc.SelectedValue = v_us_lop_hoc.dcID;
            m_txt_hoc_ky.Text = v_us_hoc_ky.strMA_HOC_KY.ToString();
            m_txt_ma_hoc_phan.Text = v_us_hoc_phan.strMA_HOC_PHAN.ToString();
            m_txt_trong_so.Text = v_us_hoc_phan.dcTRONG_SO.ToString();
            m_txt_so_tin_chi_hoc_phan.Text = v_us_hoc_phan.dcSO_TIN_CHI_HOC_PHAN.ToString();
        }
        private void m_txt_ma_so_sinh_vien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(m_txt_ma_so_sinh_vien.Text == "")
                {
                    m_lab_eror.Text = "";
                }
                else
                {
                    US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                    DataSet v_ds = new DataSet();
                    v_ds.Tables.Add(new DataTable());
                    v_us.FillDatasetWithQuery(v_ds, "SELECT ID FROM V_DM_SINH_VIEN WHERE MA_SINH_VIEN = '" + m_txt_ma_so_sinh_vien.Text + "'");
                    if (v_ds.Tables[0].Rows.Count == 0)
                    {
                        m_lab_eror.Text = "Mã số sinh viên không tồn tại!";
                    }
                    else
                    {
                        US_DM_SINH_VIEN v_us_sinh_vien = new US_DM_SINH_VIEN(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0]["ID"].ToString()));
                        load_data_2_thong_tin_sinh_vien(v_us_sinh_vien);
                        m_id_sinh_vien = v_us_sinh_vien.dcID;
                        m_lab_eror.Text = "";
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_txt_ma_so_sinh_vien_Enter(object sender, EventArgs e)
        {


        }

        private void load_data_2_thong_tin_sinh_vien(US_DM_SINH_VIEN v_us_sinh_vien)
        {
            US_DM_LOP_SINH_VIEN v_us_lop_sinh_vien = new US_DM_LOP_SINH_VIEN(v_us_sinh_vien.dcID_LOP_SINH_VIEN);
            US_DM_KHOA v_us_khoa = new US_DM_KHOA(v_us_lop_sinh_vien.dcID_KHOA);
            US_DM_KHOA_VIEN v_us_khoa_vien = new US_DM_KHOA_VIEN(v_us_lop_sinh_vien.dcID_KHOA_VIEN);
            m_txt_ma_so_sinh_vien.Text = v_us_sinh_vien.strMA_SINH_VIEN.ToString();
            m_txt_ho_ten_sinh_vien.Text = v_us_sinh_vien.strTEN_SINH_VIEN.ToString();
            m_txt_khoa.Text = v_us_khoa.strKHOA.ToString();
            m_txt_khoa_vien.Text = v_us_khoa_vien.strTEN_KHOA_VIEN.ToString();
            m_txt_lop_sinh_vien.Text = v_us_lop_sinh_vien.strLOP_SINH_VIEN.ToString();
        }

        private void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_du_lieu())
                {
                    // kiểm tra xem là update hay insert
                    US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                    DataSet v_ds = new DataSet();
                    v_ds.Tables.Add(new DataTable());
                    v_us.FillDatasetWithQuery(v_ds, "SELECT ID,ID_SINH_VIEN,ID_LOP_HOC FROM V_DIEM_THI WHERE MA_SINH_VIEN = '" + m_txt_ma_so_sinh_vien.Text + "' AND ID_LOP_HOC =" + m_cbo_ma_lop_hoc.SelectedValue.ToString());
                    if (v_ds.Tables[0].Rows.Count == 0)
                    {
                        m_bol_isUpdate = false;
                    }
                    else
                        m_bol_isUpdate = true;
                    if(m_bol_isUpdate)
                    {
                        US_DIEM_THI v_us_diem_thi = new US_DIEM_THI(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0]["ID"].ToString()));
                        v_us_diem_thi.dcDIEM_QUA_TRINH = CIPConvert.ToDecimal(m_txt_diem_qua_trinh.Text);
                        v_us_diem_thi.dcID_SINH_VIEN = m_id_sinh_vien;
                        v_us_diem_thi.dcID_LOP_HOC = CIPConvert.ToDecimal(m_cbo_ma_lop_hoc.SelectedValue);
                        v_us_diem_thi.dcDIEM_THI = CIPConvert.ToDecimal(m_txt_diem_thi.Text);
                        v_us_diem_thi.strDIEM_CHU = User.GetDiemChu(v_us_diem_thi.dcDIEM_QUA_TRINH, v_us_diem_thi.dcDIEM_THI, CIPConvert.ToDecimal(CIPConvert.ToDecimal(m_txt_trong_so.Text)));
                        v_us_diem_thi.Update();
                        MessageBox.Show("Cập nhật thành công!");
                        load_data_2_grid();
                    }
                    else
                    {
                        US_DIEM_THI v_us_diem_thi = new US_DIEM_THI();
                        v_us_diem_thi.dcDIEM_QUA_TRINH = CIPConvert.ToDecimal(m_txt_diem_qua_trinh.Text);
                        v_us_diem_thi.dcDIEM_THI = CIPConvert.ToDecimal(m_txt_diem_thi.Text);
                        v_us_diem_thi.dcID_SINH_VIEN = m_id_sinh_vien;
                        v_us_diem_thi.dcID_LOP_HOC = CIPConvert.ToDecimal( m_cbo_ma_lop_hoc.SelectedValue);
                        v_us_diem_thi.strDIEM_CHU = User.GetDiemChu(v_us_diem_thi.dcDIEM_QUA_TRINH,v_us_diem_thi.dcDIEM_THI,CIPConvert.ToDecimal(m_txt_trong_so.Text));
                        v_us_diem_thi.Insert();
                        MessageBox.Show("thêm thành công!");
                        load_data_2_grid();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }

        }

        private bool check_du_lieu()
        {
            if (m_txt_diem_qua_trinh.Text == "" || m_txt_diem_qua_trinh.Text == "")
            {
                MessageBox.Show("Nhập thông tin điểm thi!");
                return false;
            }
            if(m_lab_eror.Text != "")
            {
                MessageBox.Show("Nhập mã số sinh viên hợp lệ!");
                return false;
            }
            if (CIPConvert.ToDecimal(m_txt_diem_qua_trinh.Text) < 0 || CIPConvert.ToDecimal(m_txt_diem_qua_trinh.Text) > 10 || CIPConvert.ToDecimal(m_txt_diem_thi.Text) > 10 || CIPConvert.ToDecimal(m_txt_diem_thi.Text)<0)
            {
                MessageBox.Show("Điểm nhập không hợp lệ!");
                return false;
            }
            return true;
        }

        private void m_grv_diem_thi_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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
                DataRow v_dr = m_grv_diem_thi.GetDataRow(m_grv_diem_thi.FocusedRowHandle);
                if (v_dr != null)
                {
                    US_DM_SINH_VIEN v_us_sinh_vien = new US_DM_SINH_VIEN(CIPConvert.ToDecimal( v_dr["ID_SINH_VIEN"].ToString()));
                    load_data_2_thong_tin_sinh_vien(v_us_sinh_vien);
                    US_DM_LOP_HOC v_us_lop_hoc = new US_DM_LOP_HOC(CIPConvert.ToDecimal(v_dr["ID_LOP_HOC"].ToString()));
                    load_data_2_thong_tin_lop_hoc(v_us_lop_hoc);
                }
            }
        }

        private void m_txt_diem_qua_trinh_KeyPress(object sender, KeyPressEventArgs e)
        {

            char decimalChar = ',';
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { }
            else if (e.KeyChar == decimalChar && m_txt_diem_qua_trinh.Text.IndexOf(decimalChar) == -1)
            { }
            else
            {
                e.Handled = true;
            }
        }

        private void m_txt_diem_thi_KeyPress(object sender, KeyPressEventArgs e)
        {

            char decimalChar = ',';
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { }
            else if (e.KeyChar == decimalChar && m_txt_diem_thi.Text.IndexOf(decimalChar) == -1)
            { }
            else
            {
                e.Handled = true;
            }
        }

        private void m_cmd_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_diem_thi.GetDataRow(m_grv_diem_thi.FocusedRowHandle);
                if (v_dr!= null)
                {
                    US_DIEM_THI v_us = new US_DIEM_THI(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                    v_us.Delete();
                    MessageBox.Show("xóa thành công!");
                    load_data_2_grid();
                }
                else
                {
                    MessageBox.Show("chọn 1 dong để xóa");
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

    }
}
