namespace TOSApp.DanhMuc
{
    partial class f900_DM_KHOA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f900_DM_KHOA));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.m_cmd_them = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_sua = new DevExpress.XtraEditors.SimpleButton();
            this.m_grc_dm_khoa = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_khoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_grvcol_khoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_grvcol_nam_bat_dau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_txt_khoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_txt_nam_bat_dau = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_khoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_khoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel15, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.m_grc_dm_khoa, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(805, 481);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.m_cmd_them);
            this.panel15.Controls.Add(this.m_cmd_xoa);
            this.panel15.Controls.Add(this.m_cmd_sua);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(396, 439);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(406, 39);
            this.panel15.TabIndex = 2;
            // 
            // m_cmd_them
            // 
            this.m_cmd_them.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_them.Image")));
            this.m_cmd_them.Location = new System.Drawing.Point(9, 3);
            this.m_cmd_them.Name = "m_cmd_them";
            this.m_cmd_them.Size = new System.Drawing.Size(88, 35);
            this.m_cmd_them.TabIndex = 0;
            this.m_cmd_them.Text = "Thêm";
            this.m_cmd_them.Click += new System.EventHandler(this.m_cmd_them_Click);
            // 
            // m_cmd_xoa
            // 
            this.m_cmd_xoa.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xoa.Image")));
            this.m_cmd_xoa.Location = new System.Drawing.Point(305, 1);
            this.m_cmd_xoa.Name = "m_cmd_xoa";
            this.m_cmd_xoa.Size = new System.Drawing.Size(92, 35);
            this.m_cmd_xoa.TabIndex = 0;
            this.m_cmd_xoa.Text = "Xóa";
            this.m_cmd_xoa.Click += new System.EventHandler(this.m_cmd_xoa_Click);
            // 
            // m_cmd_sua
            // 
            this.m_cmd_sua.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_sua.Image")));
            this.m_cmd_sua.Location = new System.Drawing.Point(155, 3);
            this.m_cmd_sua.Name = "m_cmd_sua";
            this.m_cmd_sua.Size = new System.Drawing.Size(92, 35);
            this.m_cmd_sua.TabIndex = 0;
            this.m_cmd_sua.Text = "Cập nhật";
            this.m_cmd_sua.Click += new System.EventHandler(this.m_cmd_sua_Click);
            // 
            // m_grc_dm_khoa
            // 
            this.m_grc_dm_khoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_khoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_khoa.Location = new System.Drawing.Point(3, 90);
            this.m_grc_dm_khoa.MainView = this.m_grv_dm_khoa;
            this.m_grc_dm_khoa.Name = "m_grc_dm_khoa";
            this.m_grc_dm_khoa.Size = new System.Drawing.Size(799, 343);
            this.m_grc_dm_khoa.TabIndex = 0;
            this.m_grc_dm_khoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_khoa});
            // 
            // m_grv_dm_khoa
            // 
            this.m_grv_dm_khoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.m_grvcol_khoa,
            this.m_grvcol_nam_bat_dau});
            this.m_grv_dm_khoa.GridControl = this.m_grc_dm_khoa;
            this.m_grv_dm_khoa.Name = "m_grv_dm_khoa";
            this.m_grv_dm_khoa.OptionsFind.AlwaysVisible = true;
            this.m_grv_dm_khoa.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.m_grv_dm_khoa_FocusedRowChanged);
            // 
            // m_grvcol_khoa
            // 
            this.m_grvcol_khoa.Caption = "Khóa";
            this.m_grvcol_khoa.FieldName = "KHOA";
            this.m_grvcol_khoa.Name = "m_grvcol_khoa";
            this.m_grvcol_khoa.Visible = true;
            this.m_grvcol_khoa.VisibleIndex = 0;
            // 
            // m_grvcol_nam_bat_dau
            // 
            this.m_grvcol_nam_bat_dau.Caption = "Năm bắt đầu";
            this.m_grvcol_nam_bat_dau.FieldName = "NAM_BAT_DAU";
            this.m_grvcol_nam_bat_dau.Name = "m_grvcol_nam_bat_dau";
            this.m_grvcol_nam_bat_dau.Visible = true;
            this.m_grvcol_nam_bat_dau.VisibleIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết khóa";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(793, 62);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_txt_nam_bat_dau);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(399, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 56);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm bắt đầu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_txt_khoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 56);
            this.panel1.TabIndex = 0;
            // 
            // m_txt_khoa
            // 
            this.m_txt_khoa.Location = new System.Drawing.Point(136, 19);
            this.m_txt_khoa.MaxLength = 4;
            this.m_txt_khoa.Name = "m_txt_khoa";
            this.m_txt_khoa.Size = new System.Drawing.Size(149, 20);
            this.m_txt_khoa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khóa";
            // 
            // m_txt_nam_bat_dau
            // 
            this.m_txt_nam_bat_dau.Location = new System.Drawing.Point(114, 18);
            this.m_txt_nam_bat_dau.MaxLength = 4;
            this.m_txt_nam_bat_dau.Name = "m_txt_nam_bat_dau";
            this.m_txt_nam_bat_dau.Size = new System.Drawing.Size(149, 20);
            this.m_txt_nam_bat_dau.TabIndex = 1;
            this.m_txt_nam_bat_dau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_txt_nam_bat_dau_KeyPress);
            // 
            // f900_DM_KHOA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 481);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "f900_DM_KHOA";
            this.Text = "f900_DM_KHOA";
            this.Load += new System.EventHandler(this.f900_DM_KHOA_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_khoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_khoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl m_grc_dm_khoa;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_khoa;
        private System.Windows.Forms.Panel panel15;
        private DevExpress.XtraEditors.SimpleButton m_cmd_them;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xoa;
        private DevExpress.XtraEditors.SimpleButton m_cmd_sua;
        private DevExpress.XtraGrid.Columns.GridColumn m_grvcol_khoa;
        private DevExpress.XtraGrid.Columns.GridColumn m_grvcol_nam_bat_dau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txt_khoa;
        private System.Windows.Forms.TextBox m_txt_nam_bat_dau;
    }
}