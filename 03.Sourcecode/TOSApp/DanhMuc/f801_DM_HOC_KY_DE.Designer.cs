namespace TOSApp.DanhMuc
{
    partial class f801_DM_HOC_KY_DE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f801_DM_HOC_KY_DE));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_ok = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_txt_nam_ket_thuc = new System.Windows.Forms.TextBox();
            this.m_txt_nam_bat_dau = new System.Windows.Forms.TextBox();
            this.m_txt_ma_hoc_ky = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 232);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết học kỳ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(326, 213);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_cancel);
            this.panel1.Controls.Add(this.m_cmd_ok);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 37);
            this.panel1.TabIndex = 12;
            // 
            // m_cmd_cancel
            // 
            this.m_cmd_cancel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_cancel.Image")));
            this.m_cmd_cancel.Location = new System.Drawing.Point(190, 3);
            this.m_cmd_cancel.Name = "m_cmd_cancel";
            this.m_cmd_cancel.Size = new System.Drawing.Size(89, 32);
            this.m_cmd_cancel.TabIndex = 4;
            this.m_cmd_cancel.Text = "Thoát";
            this.m_cmd_cancel.Click += new System.EventHandler(this.m_cmd_cancel_Click);
            // 
            // m_cmd_ok
            // 
            this.m_cmd_ok.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_ok.Image")));
            this.m_cmd_ok.Location = new System.Drawing.Point(29, 3);
            this.m_cmd_ok.Name = "m_cmd_ok";
            this.m_cmd_ok.Size = new System.Drawing.Size(90, 31);
            this.m_cmd_ok.TabIndex = 3;
            this.m_cmd_ok.Text = "OK";
            this.m_cmd_ok.Click += new System.EventHandler(this.m_cmd_ok_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_txt_nam_ket_thuc);
            this.panel2.Controls.Add(this.m_txt_nam_bat_dau);
            this.panel2.Controls.Add(this.m_txt_ma_hoc_ky);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 164);
            this.panel2.TabIndex = 11;
            // 
            // m_txt_nam_ket_thuc
            // 
            this.m_txt_nam_ket_thuc.Location = new System.Drawing.Point(156, 128);
            this.m_txt_nam_ket_thuc.MaxLength = 4;
            this.m_txt_nam_ket_thuc.Name = "m_txt_nam_ket_thuc";
            this.m_txt_nam_ket_thuc.Size = new System.Drawing.Size(123, 20);
            this.m_txt_nam_ket_thuc.TabIndex = 2;
            this.m_txt_nam_ket_thuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_txt_nam_hoc_ket_thuc_KeyPress);
            // 
            // m_txt_nam_bat_dau
            // 
            this.m_txt_nam_bat_dau.Location = new System.Drawing.Point(156, 76);
            this.m_txt_nam_bat_dau.MaxLength = 4;
            this.m_txt_nam_bat_dau.Name = "m_txt_nam_bat_dau";
            this.m_txt_nam_bat_dau.Size = new System.Drawing.Size(123, 20);
            this.m_txt_nam_bat_dau.TabIndex = 1;
            this.m_txt_nam_bat_dau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_txt_nam_hoc_bat_dau_KeyPress);
            // 
            // m_txt_ma_hoc_ky
            // 
            this.m_txt_ma_hoc_ky.Location = new System.Drawing.Point(156, 25);
            this.m_txt_ma_hoc_ky.MaxLength = 5;
            this.m_txt_ma_hoc_ky.Name = "m_txt_ma_hoc_ky";
            this.m_txt_ma_hoc_ky.Size = new System.Drawing.Size(123, 20);
            this.m_txt_ma_hoc_ky.TabIndex = 0;
            this.m_txt_ma_hoc_ky.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_txt_ma_hoc_ky_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học kỳ*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Năm học bắt đầu *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm học kết thúc*";
            // 
            // f801_DM_HOC_KY_DE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 232);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "f801_DM_HOC_KY_DE";
            this.Text = "f801_DM_HOC_KY_DE";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_cancel;
        private DevExpress.XtraEditors.SimpleButton m_cmd_ok;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_txt_nam_ket_thuc;
        private System.Windows.Forms.TextBox m_txt_nam_bat_dau;
        private System.Windows.Forms.TextBox m_txt_ma_hoc_ky;
    }
}