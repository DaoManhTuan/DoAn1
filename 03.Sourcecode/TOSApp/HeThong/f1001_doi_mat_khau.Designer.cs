﻿namespace TOSApp.HeThong
{
    partial class f1001_doi_mat_khau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f1001_doi_mat_khau));
            this.m_txt_mk_cu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txt_mk_moi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txt_xac_nhan_mk = new System.Windows.Forms.TextBox();
            this.m_cmd_doi_mat = new DevExpress.XtraEditors.SimpleButton();
            this.m_lb_output = new System.Windows.Forms.Label();
            this.m_cmd_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // m_txt_mk_cu
            // 
            this.m_txt_mk_cu.Location = new System.Drawing.Point(149, 8);
            this.m_txt_mk_cu.MaxLength = 32;
            this.m_txt_mk_cu.Name = "m_txt_mk_cu";
            this.m_txt_mk_cu.PasswordChar = '*';
            this.m_txt_mk_cu.Size = new System.Drawing.Size(193, 20);
            this.m_txt_mk_cu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu mới";
            // 
            // m_txt_mk_moi
            // 
            this.m_txt_mk_moi.Location = new System.Drawing.Point(149, 54);
            this.m_txt_mk_moi.MaxLength = 32;
            this.m_txt_mk_moi.Name = "m_txt_mk_moi";
            this.m_txt_mk_moi.PasswordChar = '*';
            this.m_txt_mk_moi.Size = new System.Drawing.Size(193, 20);
            this.m_txt_mk_moi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // m_txt_xac_nhan_mk
            // 
            this.m_txt_xac_nhan_mk.Location = new System.Drawing.Point(149, 98);
            this.m_txt_xac_nhan_mk.MaxLength = 32;
            this.m_txt_xac_nhan_mk.Name = "m_txt_xac_nhan_mk";
            this.m_txt_xac_nhan_mk.PasswordChar = '*';
            this.m_txt_xac_nhan_mk.Size = new System.Drawing.Size(193, 20);
            this.m_txt_xac_nhan_mk.TabIndex = 4;
            this.m_txt_xac_nhan_mk.TextChanged += new System.EventHandler(this.m_txt_xac_nhan_mk_TextChanged);
            // 
            // m_cmd_doi_mat
            // 
            this.m_cmd_doi_mat.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_doi_mat.Image")));
            this.m_cmd_doi_mat.Location = new System.Drawing.Point(111, 162);
            this.m_cmd_doi_mat.Name = "m_cmd_doi_mat";
            this.m_cmd_doi_mat.Size = new System.Drawing.Size(122, 34);
            this.m_cmd_doi_mat.TabIndex = 6;
            this.m_cmd_doi_mat.Text = "Đổi mật khẩu";
            this.m_cmd_doi_mat.Click += new System.EventHandler(this.m_cmd_doi_mat_Click);
            // 
            // m_lb_output
            // 
            this.m_lb_output.AutoSize = true;
            this.m_lb_output.ForeColor = System.Drawing.Color.Red;
            this.m_lb_output.Location = new System.Drawing.Point(108, 143);
            this.m_lb_output.Name = "m_lb_output";
            this.m_lb_output.Size = new System.Drawing.Size(0, 13);
            this.m_lb_output.TabIndex = 7;
            // 
            // m_cmd_thoat
            // 
            this.m_cmd_thoat.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_thoat.Image")));
            this.m_cmd_thoat.Location = new System.Drawing.Point(249, 162);
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.Size = new System.Drawing.Size(93, 34);
            this.m_cmd_thoat.TabIndex = 6;
            this.m_cmd_thoat.Text = "Thoát";
            this.m_cmd_thoat.Click += new System.EventHandler(this.m_cmd_thoat_Click);
            // 
            // f1001_doi_mat_khau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 215);
            this.Controls.Add(this.m_lb_output);
            this.Controls.Add(this.m_cmd_thoat);
            this.Controls.Add(this.m_cmd_doi_mat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_txt_xac_nhan_mk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_txt_mk_moi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_txt_mk_cu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "f1001_doi_mat_khau";
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_txt_mk_cu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txt_mk_moi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_txt_xac_nhan_mk;
        private DevExpress.XtraEditors.SimpleButton m_cmd_doi_mat;
        private System.Windows.Forms.Label m_lb_output;
        private DevExpress.XtraEditors.SimpleButton m_cmd_thoat;
    }
}