namespace TOSApp.DanhMuc
{
    partial class f300_DM_LOP_THI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_grc_dm_lop_thi = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_lop_thi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_cap_nhat = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_them = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_lop_thi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_lop_thi)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc_dm_lop_thi
            // 
            this.m_grc_dm_lop_thi.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_lop_thi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_lop_thi.Location = new System.Drawing.Point(0, 0);
            this.m_grc_dm_lop_thi.MainView = this.m_grv_dm_lop_thi;
            this.m_grc_dm_lop_thi.Name = "m_grc_dm_lop_thi";
            this.m_grc_dm_lop_thi.Size = new System.Drawing.Size(747, 441);
            this.m_grc_dm_lop_thi.TabIndex = 0;
            this.m_grc_dm_lop_thi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_lop_thi});
            // 
            // m_grv_dm_lop_thi
            // 
            this.m_grv_dm_lop_thi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn2});
            this.m_grv_dm_lop_thi.GridControl = this.m_grc_dm_lop_thi;
            this.m_grv_dm_lop_thi.Name = "m_grv_dm_lop_thi";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã lớp thi";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên lớp thi ";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_thoat);
            this.panel1.Controls.Add(this.m_cmd_xoa);
            this.panel1.Controls.Add(this.m_cmd_cap_nhat);
            this.panel1.Controls.Add(this.m_cmd_them);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 69);
            this.panel1.TabIndex = 2;
            // 
            // m_cmd_thoat
            // 
            this.m_cmd_thoat.Location = new System.Drawing.Point(584, 23);
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.Size = new System.Drawing.Size(132, 23);
            this.m_cmd_thoat.TabIndex = 1;
            this.m_cmd_thoat.Text = "Thoát";
            // 
            // m_cmd_xoa
            // 
            this.m_cmd_xoa.Location = new System.Drawing.Point(397, 23);
            this.m_cmd_xoa.Name = "m_cmd_xoa";
            this.m_cmd_xoa.Size = new System.Drawing.Size(132, 23);
            this.m_cmd_xoa.TabIndex = 2;
            this.m_cmd_xoa.Text = "Xóa";
            // 
            // m_cmd_cap_nhat
            // 
            this.m_cmd_cap_nhat.Location = new System.Drawing.Point(227, 23);
            this.m_cmd_cap_nhat.Name = "m_cmd_cap_nhat";
            this.m_cmd_cap_nhat.Size = new System.Drawing.Size(132, 23);
            this.m_cmd_cap_nhat.TabIndex = 3;
            this.m_cmd_cap_nhat.Text = "Sửa";
            // 
            // m_cmd_them
            // 
            this.m_cmd_them.Location = new System.Drawing.Point(50, 23);
            this.m_cmd_them.Name = "m_cmd_them";
            this.m_cmd_them.Size = new System.Drawing.Size(132, 23);
            this.m_cmd_them.TabIndex = 4;
            this.m_cmd_them.Text = "Thêm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_grc_dm_lop_thi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 441);
            this.panel2.TabIndex = 3;
            // 
            // f300_DM_LOP_THI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "f300_DM_LOP_THI";
            this.Text = "f300_DM_LOP_THI";
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_lop_thi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_lop_thi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_dm_lop_thi;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_lop_thi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_thoat;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xoa;
        private DevExpress.XtraEditors.SimpleButton m_cmd_cap_nhat;
        private DevExpress.XtraEditors.SimpleButton m_cmd_them;
        private System.Windows.Forms.Panel panel2;
    }
}