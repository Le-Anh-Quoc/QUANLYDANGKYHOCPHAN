namespace GUI
{
    partial class FormSinhVien
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnLichSuDangKy = new System.Windows.Forms.Button();
            this.btnLopHocPhan = new System.Windows.Forms.Button();
            this.btnDangKyMon = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(231, 38);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1072, 617);
            this.pnlMain.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.lblHocKy);
            this.panel2.Controls.Add(this.btnThongTin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(231, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1072, 38);
            this.panel2.TabIndex = 7;
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Enabled = false;
            this.lblHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocKy.Location = new System.Drawing.Point(9, 9);
            this.lblHocKy.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(74, 24);
            this.lblHocKy.TabIndex = 9;
            this.lblHocKy.Text = "Học kỳ";
            // 
            // btnThongTin
            // 
            this.btnThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btnThongTin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThongTin.FlatAppearance.BorderSize = 0;
            this.btnThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.ForeColor = System.Drawing.Color.White;
            this.btnThongTin.Location = new System.Drawing.Point(910, 0);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(162, 38);
            this.btnThongTin.TabIndex = 4;
            this.btnThongTin.Text = "Tên (chức danh)";
            this.btnThongTin.UseVisualStyleBackColor = false;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.pnlMenu.Controls.Add(this.btnDangXuat);
            this.pnlMenu.Controls.Add(this.btnLichSuDangKy);
            this.pnlMenu.Controls.Add(this.btnLopHocPhan);
            this.pnlMenu.Controls.Add(this.btnDangKyMon);
            this.pnlMenu.Controls.Add(this.panel4);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(231, 655);
            this.pnlMenu.TabIndex = 6;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 595);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(231, 60);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnLichSuDangKy
            // 
            this.btnLichSuDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btnLichSuDangKy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLichSuDangKy.FlatAppearance.BorderSize = 0;
            this.btnLichSuDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichSuDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSuDangKy.ForeColor = System.Drawing.Color.White;
            this.btnLichSuDangKy.Location = new System.Drawing.Point(0, 276);
            this.btnLichSuDangKy.Name = "btnLichSuDangKy";
            this.btnLichSuDangKy.Size = new System.Drawing.Size(231, 60);
            this.btnLichSuDangKy.TabIndex = 4;
            this.btnLichSuDangKy.Text = "Lịch sử đăng ký";
            this.btnLichSuDangKy.UseVisualStyleBackColor = false;
            this.btnLichSuDangKy.Click += new System.EventHandler(this.btnLichSuDangKy_Click);
            // 
            // btnLopHocPhan
            // 
            this.btnLopHocPhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btnLopHocPhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLopHocPhan.FlatAppearance.BorderSize = 0;
            this.btnLopHocPhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLopHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLopHocPhan.ForeColor = System.Drawing.Color.White;
            this.btnLopHocPhan.Location = new System.Drawing.Point(0, 216);
            this.btnLopHocPhan.Name = "btnLopHocPhan";
            this.btnLopHocPhan.Size = new System.Drawing.Size(231, 60);
            this.btnLopHocPhan.TabIndex = 3;
            this.btnLopHocPhan.Text = "Lớp học phần";
            this.btnLopHocPhan.UseVisualStyleBackColor = false;
            this.btnLopHocPhan.Click += new System.EventHandler(this.btnLopHocPhan_Click);
            // 
            // btnDangKyMon
            // 
            this.btnDangKyMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btnDangKyMon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangKyMon.FlatAppearance.BorderSize = 0;
            this.btnDangKyMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKyMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKyMon.ForeColor = System.Drawing.Color.White;
            this.btnDangKyMon.Location = new System.Drawing.Point(0, 156);
            this.btnDangKyMon.Name = "btnDangKyMon";
            this.btnDangKyMon.Size = new System.Drawing.Size(231, 60);
            this.btnDangKyMon.TabIndex = 2;
            this.btnDangKyMon.Text = "Đăng ký môn";
            this.btnDangKyMon.UseVisualStyleBackColor = false;
            this.btnDangKyMon.Click += new System.EventHandler(this.btnDangKyMon_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 156);
            this.panel4.TabIndex = 1;
            // 
            // FormSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 655);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FormSinhVien";
            this.Text = "FormSinhVien";
            this.Load += new System.EventHandler(this.FormSinhVien_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnLichSuDangKy;
        private System.Windows.Forms.Button btnLopHocPhan;
        private System.Windows.Forms.Button btnDangKyMon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label lblHocKy;
    }
}