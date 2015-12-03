namespace TOSApp.NghiepVu
{
    partial class f200_xu_ly_diem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f200_xu_ly_diem));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.m_grc_ket_qua_hoc_tap = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ket_qua_hoc_tap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_grvcol_ma_sinh_vien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_grvcol_ten_sinh_vien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_grvcol_lop_sinh_vien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_grvcol_ma_hoc_ky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_grvcol_cpa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_grvcol_gpa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.m_cmd_ket_qua = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.m_cbo_hoc_ky = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_cbo_khoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cbo_lop_sinh_vien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cbo_khoa_vien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ket_qua_hoc_tap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ket_qua_hoc_tap)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.m_grc_ket_qua_hoc_tap, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(908, 430);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // m_grc_ket_qua_hoc_tap
            // 
            this.m_grc_ket_qua_hoc_tap.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ket_qua_hoc_tap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ket_qua_hoc_tap.Location = new System.Drawing.Point(3, 74);
            this.m_grc_ket_qua_hoc_tap.MainView = this.m_grv_ket_qua_hoc_tap;
            this.m_grc_ket_qua_hoc_tap.Name = "m_grc_ket_qua_hoc_tap";
            this.m_grc_ket_qua_hoc_tap.Size = new System.Drawing.Size(902, 353);
            this.m_grc_ket_qua_hoc_tap.TabIndex = 0;
            this.m_grc_ket_qua_hoc_tap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ket_qua_hoc_tap});
            // 
            // m_grv_ket_qua_hoc_tap
            // 
            this.m_grv_ket_qua_hoc_tap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.m_grvcol_ma_sinh_vien,
            this.m_grvcol_ten_sinh_vien,
            this.m_grvcol_lop_sinh_vien,
            this.m_grvcol_ma_hoc_ky,
            this.m_grvcol_cpa,
            this.m_grvcol_gpa});
            this.m_grv_ket_qua_hoc_tap.GridControl = this.m_grc_ket_qua_hoc_tap;
            this.m_grv_ket_qua_hoc_tap.Name = "m_grv_ket_qua_hoc_tap";
            // 
            // m_grvcol_ma_sinh_vien
            // 
            this.m_grvcol_ma_sinh_vien.Caption = "Mã sinh viên";
            this.m_grvcol_ma_sinh_vien.FieldName = "MA_SINH_VIEN";
            this.m_grvcol_ma_sinh_vien.Name = "m_grvcol_ma_sinh_vien";
            this.m_grvcol_ma_sinh_vien.Visible = true;
            this.m_grvcol_ma_sinh_vien.VisibleIndex = 0;
            // 
            // m_grvcol_ten_sinh_vien
            // 
            this.m_grvcol_ten_sinh_vien.Caption = "Tên sinh viên";
            this.m_grvcol_ten_sinh_vien.FieldName = "TEN_SINH_VIEN";
            this.m_grvcol_ten_sinh_vien.Name = "m_grvcol_ten_sinh_vien";
            this.m_grvcol_ten_sinh_vien.Visible = true;
            this.m_grvcol_ten_sinh_vien.VisibleIndex = 1;
            // 
            // m_grvcol_lop_sinh_vien
            // 
            this.m_grvcol_lop_sinh_vien.Caption = "Lớp sinh viên";
            this.m_grvcol_lop_sinh_vien.FieldName = "LOP_SINH_VIEN";
            this.m_grvcol_lop_sinh_vien.Name = "m_grvcol_lop_sinh_vien";
            this.m_grvcol_lop_sinh_vien.Visible = true;
            this.m_grvcol_lop_sinh_vien.VisibleIndex = 2;
            // 
            // m_grvcol_ma_hoc_ky
            // 
            this.m_grvcol_ma_hoc_ky.Caption = "Học kỳ";
            this.m_grvcol_ma_hoc_ky.FieldName = "HOC_KY";
            this.m_grvcol_ma_hoc_ky.Name = "m_grvcol_ma_hoc_ky";
            this.m_grvcol_ma_hoc_ky.Visible = true;
            this.m_grvcol_ma_hoc_ky.VisibleIndex = 3;
            // 
            // m_grvcol_cpa
            // 
            this.m_grvcol_cpa.Caption = "CPA";
            this.m_grvcol_cpa.FieldName = "CPA";
            this.m_grvcol_cpa.Name = "m_grvcol_cpa";
            this.m_grvcol_cpa.Visible = true;
            this.m_grvcol_cpa.VisibleIndex = 5;
            // 
            // m_grvcol_gpa
            // 
            this.m_grvcol_gpa.Caption = "GPA";
            this.m_grvcol_gpa.FieldName = "GPA";
            this.m_grvcol_gpa.Name = "m_grvcol_gpa";
            this.m_grvcol_gpa.Visible = true;
            this.m_grvcol_gpa.VisibleIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(902, 65);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.m_cmd_ket_qua);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(723, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(176, 59);
            this.panel5.TabIndex = 4;
            // 
            // m_cmd_ket_qua
            // 
            this.m_cmd_ket_qua.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_ket_qua.Appearance.Options.UseFont = true;
            this.m_cmd_ket_qua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_cmd_ket_qua.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_ket_qua.Image")));
            this.m_cmd_ket_qua.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_ket_qua.Name = "m_cmd_ket_qua";
            this.m_cmd_ket_qua.Size = new System.Drawing.Size(176, 59);
            this.m_cmd_ket_qua.TabIndex = 0;
            this.m_cmd_ket_qua.Text = "Kết quả";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.m_cbo_hoc_ky);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(543, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(174, 59);
            this.panel4.TabIndex = 3;
            // 
            // m_cbo_hoc_ky
            // 
            this.m_cbo_hoc_ky.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_cbo_hoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_hoc_ky.FormattingEnabled = true;
            this.m_cbo_hoc_ky.Location = new System.Drawing.Point(0, 38);
            this.m_cbo_hoc_ky.Name = "m_cbo_hoc_ky";
            this.m_cbo_hoc_ky.Size = new System.Drawing.Size(174, 21);
            this.m_cbo_hoc_ky.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Học kỳ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_cbo_khoa);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(363, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 59);
            this.panel3.TabIndex = 2;
            // 
            // m_cbo_khoa
            // 
            this.m_cbo_khoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_cbo_khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_khoa.FormattingEnabled = true;
            this.m_cbo_khoa.Location = new System.Drawing.Point(0, 38);
            this.m_cbo_khoa.Name = "m_cbo_khoa";
            this.m_cbo_khoa.Size = new System.Drawing.Size(174, 21);
            this.m_cbo_khoa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khóa";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_cbo_lop_sinh_vien);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(183, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 59);
            this.panel2.TabIndex = 1;
            // 
            // m_cbo_lop_sinh_vien
            // 
            this.m_cbo_lop_sinh_vien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_cbo_lop_sinh_vien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_lop_sinh_vien.FormattingEnabled = true;
            this.m_cbo_lop_sinh_vien.Location = new System.Drawing.Point(0, 38);
            this.m_cbo_lop_sinh_vien.Name = "m_cbo_lop_sinh_vien";
            this.m_cbo_lop_sinh_vien.Size = new System.Drawing.Size(174, 21);
            this.m_cbo_lop_sinh_vien.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lớp sinh viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cbo_khoa_vien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 59);
            this.panel1.TabIndex = 0;
            // 
            // m_cbo_khoa_vien
            // 
            this.m_cbo_khoa_vien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_cbo_khoa_vien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_khoa_vien.FormattingEnabled = true;
            this.m_cbo_khoa_vien.Location = new System.Drawing.Point(0, 38);
            this.m_cbo_khoa_vien.Name = "m_cbo_khoa_vien";
            this.m_cbo_khoa_vien.Size = new System.Drawing.Size(174, 21);
            this.m_cbo_khoa_vien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa/Viện";
            // 
            // f200_xu_ly_diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 302);
            this.Name = "f200_xu_ly_diem";
            this.Text = "Xử lý điểm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ket_qua_hoc_tap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ket_qua_hoc_tap)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl m_grc_ket_qua_hoc_tap;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ket_qua_hoc_tap;
        private DevExpress.XtraGrid.Columns.GridColumn m_grvcol_ma_sinh_vien;
        private DevExpress.XtraGrid.Columns.GridColumn m_grvcol_ten_sinh_vien;
        private DevExpress.XtraGrid.Columns.GridColumn m_grvcol_lop_sinh_vien;
        private DevExpress.XtraGrid.Columns.GridColumn m_grvcol_ma_hoc_ky;
        private DevExpress.XtraGrid.Columns.GridColumn m_grvcol_cpa;
        private DevExpress.XtraGrid.Columns.GridColumn m_grvcol_gpa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton m_cmd_ket_qua;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox m_cbo_hoc_ky;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox m_cbo_khoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox m_cbo_lop_sinh_vien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox m_cbo_khoa_vien;
        private System.Windows.Forms.Label label1;
    }
}