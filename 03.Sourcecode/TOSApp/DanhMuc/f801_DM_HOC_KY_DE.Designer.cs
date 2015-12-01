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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_cmd_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_ok = new DevExpress.XtraEditors.SimpleButton();
            this.m_cbo_ma_hoc_ky = new System.Windows.Forms.ComboBox();
            this.m_cbo_nam_hoc_bat_dau = new System.Windows.Forms.ComboBox();
            this.m_cbo_nam_hoc_ket_thuc = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_cbo_nam_hoc_ket_thuc);
            this.panel2.Controls.Add(this.m_cbo_nam_hoc_bat_dau);
            this.panel2.Controls.Add(this.m_cbo_ma_hoc_ky);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 130);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Năm học bắt đầu ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm học kết thúc";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // m_cmd_cancel
            // 
            this.m_cmd_cancel.Location = new System.Drawing.Point(274, 25);
            this.m_cmd_cancel.Name = "m_cmd_cancel";
            this.m_cmd_cancel.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_cancel.TabIndex = 0;
            this.m_cmd_cancel.Text = "Cancel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_cancel);
            this.panel1.Controls.Add(this.m_cmd_ok);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 70);
            this.panel1.TabIndex = 8;
            // 
            // m_cmd_ok
            // 
            this.m_cmd_ok.Location = new System.Drawing.Point(169, 25);
            this.m_cmd_ok.Name = "m_cmd_ok";
            this.m_cmd_ok.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_ok.TabIndex = 0;
            this.m_cmd_ok.Text = "OK";
            // 
            // m_cbo_ma_hoc_ky
            // 
            this.m_cbo_ma_hoc_ky.FormattingEnabled = true;
            this.m_cbo_ma_hoc_ky.Location = new System.Drawing.Point(169, 20);
            this.m_cbo_ma_hoc_ky.Name = "m_cbo_ma_hoc_ky";
            this.m_cbo_ma_hoc_ky.Size = new System.Drawing.Size(134, 21);
            this.m_cbo_ma_hoc_ky.TabIndex = 5;
            // 
            // m_cbo_nam_hoc_bat_dau
            // 
            this.m_cbo_nam_hoc_bat_dau.FormattingEnabled = true;
            this.m_cbo_nam_hoc_bat_dau.Location = new System.Drawing.Point(169, 57);
            this.m_cbo_nam_hoc_bat_dau.Name = "m_cbo_nam_hoc_bat_dau";
            this.m_cbo_nam_hoc_bat_dau.Size = new System.Drawing.Size(134, 21);
            this.m_cbo_nam_hoc_bat_dau.TabIndex = 6;
            // 
            // m_cbo_nam_hoc_ket_thuc
            // 
            this.m_cbo_nam_hoc_ket_thuc.FormattingEnabled = true;
            this.m_cbo_nam_hoc_ket_thuc.Location = new System.Drawing.Point(169, 88);
            this.m_cbo_nam_hoc_ket_thuc.Name = "m_cbo_nam_hoc_ket_thuc";
            this.m_cbo_nam_hoc_ket_thuc.Size = new System.Drawing.Size(134, 21);
            this.m_cbo_nam_hoc_ket_thuc.TabIndex = 7;
            // 
            // f801_DM_HOC_KY_DE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 200);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f801_DM_HOC_KY_DE";
            this.Text = "f801_DM_HOC_KY_DE";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_cancel;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_ok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox m_cbo_nam_hoc_ket_thuc;
        private System.Windows.Forms.ComboBox m_cbo_nam_hoc_bat_dau;
        private System.Windows.Forms.ComboBox m_cbo_ma_hoc_ky;
    }
}