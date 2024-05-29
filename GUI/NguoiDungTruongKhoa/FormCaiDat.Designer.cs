namespace GUI
{
    partial class FormCaiDat
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
            this.lblMoDangKyMon = new System.Windows.Forms.Label();
            this.rdoBtnMo = new System.Windows.Forms.RadioButton();
            this.rdoBtnDong = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblMoDangKyMon
            // 
            this.lblMoDangKyMon.AutoSize = true;
            this.lblMoDangKyMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoDangKyMon.Location = new System.Drawing.Point(92, 27);
            this.lblMoDangKyMon.Name = "lblMoDangKyMon";
            this.lblMoDangKyMon.Size = new System.Drawing.Size(226, 31);
            this.lblMoDangKyMon.TabIndex = 0;
            this.lblMoDangKyMon.Text = "Mở đăng ký môn";
            // 
            // rdoBtnMo
            // 
            this.rdoBtnMo.AutoSize = true;
            this.rdoBtnMo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnMo.Location = new System.Drawing.Point(159, 88);
            this.rdoBtnMo.Name = "rdoBtnMo";
            this.rdoBtnMo.Size = new System.Drawing.Size(57, 28);
            this.rdoBtnMo.TabIndex = 2;
            this.rdoBtnMo.TabStop = true;
            this.rdoBtnMo.Text = "Mở";
            this.rdoBtnMo.UseVisualStyleBackColor = true;
            this.rdoBtnMo.CheckedChanged += new System.EventHandler(this.rdoBtnMo_CheckedChanged);
            // 
            // rdoBtnDong
            // 
            this.rdoBtnDong.AutoSize = true;
            this.rdoBtnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnDong.Location = new System.Drawing.Point(159, 122);
            this.rdoBtnDong.Name = "rdoBtnDong";
            this.rdoBtnDong.Size = new System.Drawing.Size(78, 28);
            this.rdoBtnDong.TabIndex = 3;
            this.rdoBtnDong.TabStop = true;
            this.rdoBtnDong.Text = "Đóng";
            this.rdoBtnDong.UseVisualStyleBackColor = true;
            this.rdoBtnDong.CheckedChanged += new System.EventHandler(this.rdoBtnDong_CheckedChanged);
            // 
            // FormCaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 206);
            this.Controls.Add(this.rdoBtnDong);
            this.Controls.Add(this.rdoBtnMo);
            this.Controls.Add(this.lblMoDangKyMon);
            this.Name = "FormCaiDat";
            this.Text = "FormCaiDat";
            this.Load += new System.EventHandler(this.FormCaiDat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMoDangKyMon;
        private System.Windows.Forms.RadioButton rdoBtnMo;
        private System.Windows.Forms.RadioButton rdoBtnDong;
    }
}