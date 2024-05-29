namespace GUI
{
    partial class UCMonHoc
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
            this.lblTenMon = new System.Windows.Forms.Label();
            this.lblMaMon = new System.Windows.Forms.Label();
            this.ckBoxKichHoatMon = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.Location = new System.Drawing.Point(274, 22);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(71, 20);
            this.lblTenMon.TabIndex = 1;
            this.lblTenMon.Text = "Tên môn";
            // 
            // lblMaMon
            // 
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMon.Location = new System.Drawing.Point(40, 24);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(66, 20);
            this.lblMaMon.TabIndex = 4;
            this.lblMaMon.Text = "Mã môn";
            // 
            // ckBoxKichHoatMon
            // 
            this.ckBoxKichHoatMon.AutoSize = true;
            this.ckBoxKichHoatMon.Enabled = false;
            this.ckBoxKichHoatMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBoxKichHoatMon.Location = new System.Drawing.Point(12, 22);
            this.ckBoxKichHoatMon.Name = "ckBoxKichHoatMon";
            this.ckBoxKichHoatMon.Size = new System.Drawing.Size(49, 22);
            this.ckBoxKichHoatMon.TabIndex = 5;
            this.ckBoxKichHoatMon.Text = "Mở";
            this.ckBoxKichHoatMon.UseVisualStyleBackColor = true;
            this.ckBoxKichHoatMon.CheckedChanged += new System.EventHandler(this.ckBoxKichHoatMon_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(814, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(54, 62);
            this.panel1.TabIndex = 6;
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::GUI.Properties.Resources.bin;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Location = new System.Drawing.Point(16, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(20, 25);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.TabStop = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(755, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(59, 62);
            this.panel3.TabIndex = 7;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.ckBoxKichHoatMon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(679, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 62);
            this.panel2.TabIndex = 8;
            // 
            // UCMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMaMon);
            this.Controls.Add(this.lblTenMon);
            this.Name = "UCMonHoc";
            this.Size = new System.Drawing.Size(868, 62);
            this.Load += new System.EventHandler(this.UCMonHoc_Load);
            this.MouseEnter += new System.EventHandler(this.UCMonHoc_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCMonHoc_MouseLeave_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.CheckBox ckBoxKichHoatMon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnXoa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnSua;
        private System.Windows.Forms.Panel panel2;
    }
}
