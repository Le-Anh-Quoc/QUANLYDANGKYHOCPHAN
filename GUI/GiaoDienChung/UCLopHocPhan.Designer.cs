namespace GUI
{
    partial class UCLopHocPhan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMaHocPhan = new System.Windows.Forms.Label();
            this.lblTenMonHoc = new System.Windows.Forms.Label();
            this.lblTenGiaoVien = new System.Windows.Forms.Label();
            this.lblPhongHoc = new System.Windows.Forms.Label();
            this.lblSoLuongSV = new System.Windows.Forms.Label();
            this.lblSoLuongSVDK = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaHocPhan
            // 
            this.lblMaHocPhan.AutoSize = true;
            this.lblMaHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHocPhan.Location = new System.Drawing.Point(27, 20);
            this.lblMaHocPhan.Name = "lblMaHocPhan";
            this.lblMaHocPhan.Size = new System.Drawing.Size(94, 18);
            this.lblMaHocPhan.TabIndex = 0;
            this.lblMaHocPhan.Text = "Mã học phần";
            // 
            // lblTenMonHoc
            // 
            this.lblTenMonHoc.AutoSize = true;
            this.lblTenMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMonHoc.Location = new System.Drawing.Point(147, 20);
            this.lblTenMonHoc.Name = "lblTenMonHoc";
            this.lblTenMonHoc.Size = new System.Drawing.Size(96, 18);
            this.lblTenMonHoc.TabIndex = 1;
            this.lblTenMonHoc.Text = "Tên môn học";
            // 
            // lblTenGiaoVien
            // 
            this.lblTenGiaoVien.AutoSize = true;
            this.lblTenGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenGiaoVien.Location = new System.Drawing.Point(361, 20);
            this.lblTenGiaoVien.Name = "lblTenGiaoVien";
            this.lblTenGiaoVien.Size = new System.Drawing.Size(70, 18);
            this.lblTenGiaoVien.TabIndex = 2;
            this.lblTenGiaoVien.Text = "Giáo viên";
            // 
            // lblPhongHoc
            // 
            this.lblPhongHoc.AutoSize = true;
            this.lblPhongHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhongHoc.Location = new System.Drawing.Point(545, 20);
            this.lblPhongHoc.Name = "lblPhongHoc";
            this.lblPhongHoc.Size = new System.Drawing.Size(80, 18);
            this.lblPhongHoc.TabIndex = 3;
            this.lblPhongHoc.Text = "Phòng học";
            // 
            // lblSoLuongSV
            // 
            this.lblSoLuongSV.AutoSize = true;
            this.lblSoLuongSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongSV.Location = new System.Drawing.Point(729, 20);
            this.lblSoLuongSV.Name = "lblSoLuongSV";
            this.lblSoLuongSV.Size = new System.Drawing.Size(90, 18);
            this.lblSoLuongSV.TabIndex = 4;
            this.lblSoLuongSV.Text = "Số lượng SV";
            // 
            // lblSoLuongSVDK
            // 
            this.lblSoLuongSVDK.AutoSize = true;
            this.lblSoLuongSVDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongSVDK.Location = new System.Drawing.Point(881, 20);
            this.lblSoLuongSVDK.Name = "lblSoLuongSVDK";
            this.lblSoLuongSVDK.Size = new System.Drawing.Size(145, 18);
            this.lblSoLuongSVDK.TabIndex = 5;
            this.lblSoLuongSVDK.Text = "Số lượng SV đăng ký";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1067, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(59, 56);
            this.panel3.TabIndex = 9;
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::GUI.Properties.Resources.pencil;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.Location = new System.Drawing.Point(19, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(20, 25);
            this.btnSua.TabIndex = 0;
            this.btnSua.TabStop = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // UCLopHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblSoLuongSVDK);
            this.Controls.Add(this.lblSoLuongSV);
            this.Controls.Add(this.lblPhongHoc);
            this.Controls.Add(this.lblTenGiaoVien);
            this.Controls.Add(this.lblTenMonHoc);
            this.Controls.Add(this.lblMaHocPhan);
            this.Name = "UCLopHocPhan";
            this.Size = new System.Drawing.Size(1126, 56);
            this.Load += new System.EventHandler(this.UCLopHocPhan_Load);
            this.Click += new System.EventHandler(this.UCLopHocPhan_Click);
            this.MouseEnter += new System.EventHandler(this.UCLopHocPhan_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCLopHocPhan_MouseLeave);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaHocPhan;
        private System.Windows.Forms.Label lblTenMonHoc;
        private System.Windows.Forms.Label lblTenGiaoVien;
        private System.Windows.Forms.Label lblPhongHoc;
        private System.Windows.Forms.Label lblSoLuongSV;
        private System.Windows.Forms.Label lblSoLuongSVDK;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnSua;
    }
}
