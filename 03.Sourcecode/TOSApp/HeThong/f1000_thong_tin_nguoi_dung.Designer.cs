namespace TOSApp.HeThong
{
    partial class f1000_thong_tin_nguoi_dung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f1000_thong_tin_nguoi_dung));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.m_cmd_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_sua = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cbo_nhom = new System.Windows.Forms.ComboBox();
            this.m_txt_tai_khoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_grc_user_name = new DevExpress.XtraGrid.GridControl();
            this.m_grv_user_name = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TAI_KHOAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_NHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_user_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_user_name)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 56);
            this.panel1.TabIndex = 0;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.m_cmd_xoa);
            this.panel15.Controls.Add(this.m_cmd_sua);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(161, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(406, 56);
            this.panel15.TabIndex = 2;
            // 
            // m_cmd_xoa
            // 
            this.m_cmd_xoa.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xoa.Image")));
            this.m_cmd_xoa.Location = new System.Drawing.Point(293, 7);
            this.m_cmd_xoa.Name = "m_cmd_xoa";
            this.m_cmd_xoa.Size = new System.Drawing.Size(92, 35);
            this.m_cmd_xoa.TabIndex = 0;
            this.m_cmd_xoa.Text = "Xóa";
            this.m_cmd_xoa.Click += new System.EventHandler(this.m_cmd_xoa_Click);
            // 
            // m_cmd_sua
            // 
            this.m_cmd_sua.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_sua.Image")));
            this.m_cmd_sua.Location = new System.Drawing.Point(170, 7);
            this.m_cmd_sua.Name = "m_cmd_sua";
            this.m_cmd_sua.Size = new System.Drawing.Size(92, 35);
            this.m_cmd_sua.TabIndex = 0;
            this.m_cmd_sua.Text = "Cập nhật";
            this.m_cmd_sua.Click += new System.EventHandler(this.m_cmd_sua_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_cbo_nhom);
            this.panel2.Controls.Add(this.m_txt_tai_khoan);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 100);
            this.panel2.TabIndex = 1;
            // 
            // m_cbo_nhom
            // 
            this.m_cbo_nhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_nhom.FormattingEnabled = true;
            this.m_cbo_nhom.Location = new System.Drawing.Point(365, 23);
            this.m_cbo_nhom.Name = "m_cbo_nhom";
            this.m_cbo_nhom.Size = new System.Drawing.Size(168, 21);
            this.m_cbo_nhom.TabIndex = 2;
            // 
            // m_txt_tai_khoan
            // 
            this.m_txt_tai_khoan.Location = new System.Drawing.Point(97, 23);
            this.m_txt_tai_khoan.Name = "m_txt_tai_khoan";
            this.m_txt_tai_khoan.Size = new System.Drawing.Size(153, 20);
            this.m_txt_tai_khoan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_grc_user_name);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(567, 299);
            this.panel3.TabIndex = 2;
            // 
            // m_grc_user_name
            // 
            this.m_grc_user_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_user_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_user_name.Location = new System.Drawing.Point(0, 0);
            this.m_grc_user_name.MainView = this.m_grv_user_name;
            this.m_grc_user_name.Name = "m_grc_user_name";
            this.m_grc_user_name.Size = new System.Drawing.Size(567, 299);
            this.m_grc_user_name.TabIndex = 0;
            this.m_grc_user_name.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_user_name});
            // 
            // m_grv_user_name
            // 
            this.m_grv_user_name.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TAI_KHOAN,
            this.TEN_NHOM});
            this.m_grv_user_name.GridControl = this.m_grc_user_name;
            this.m_grv_user_name.Name = "m_grv_user_name";
            this.m_grv_user_name.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.m_grv_user_name_FocusedRowChanged);
            // 
            // TAI_KHOAN
            // 
            this.TAI_KHOAN.Caption = "Tài khoản";
            this.TAI_KHOAN.FieldName = "TAI_KHOAN";
            this.TAI_KHOAN.Name = "TAI_KHOAN";
            this.TAI_KHOAN.Visible = true;
            this.TAI_KHOAN.VisibleIndex = 0;
            // 
            // TEN_NHOM
            // 
            this.TEN_NHOM.Caption = "Nhóm";
            this.TEN_NHOM.FieldName = "TEN_NHOM";
            this.TEN_NHOM.Name = "TEN_NHOM";
            this.TEN_NHOM.Visible = true;
            this.TEN_NHOM.VisibleIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhóm";
            // 
            // f1000_thong_tin_nguoi_dung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 455);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f1000_thong_tin_nguoi_dung";
            this.Text = "f1000_thong_tin_nguoi_dung";
            this.Load += new System.EventHandler(this.f1000_thong_tin_nguoi_dung_Load);
            this.panel1.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_user_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_user_name)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl m_grc_user_name;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_user_name;
        private System.Windows.Forms.Panel panel15;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xoa;
        private DevExpress.XtraEditors.SimpleButton m_cmd_sua;
        private System.Windows.Forms.ComboBox m_cbo_nhom;
        private System.Windows.Forms.TextBox m_txt_tai_khoan;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn TAI_KHOAN;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_NHOM;
        private System.Windows.Forms.Label label2;
    }
}