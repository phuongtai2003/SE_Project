namespace GUI
{
    partial class OnlinePayment
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
            this.pnlStartAgain = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBuyAgain = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlQRCode = new System.Windows.Forms.Panel();
            this.qrCodeScan = new System.Windows.Forms.PictureBox();
            this.pnlStartAgain.SuspendLayout();
            this.pnlQRCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodeScan)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlStartAgain
            // 
            this.pnlStartAgain.Controls.Add(this.btnLogout);
            this.pnlStartAgain.Controls.Add(this.btnBuyAgain);
            this.pnlStartAgain.Controls.Add(this.label7);
            this.pnlStartAgain.Controls.Add(this.label6);
            this.pnlStartAgain.Location = new System.Drawing.Point(377, 12);
            this.pnlStartAgain.Name = "pnlStartAgain";
            this.pnlStartAgain.Size = new System.Drawing.Size(1059, 832);
            this.pnlStartAgain.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(160, 647);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(331, 93);
            this.btnLogout.TabIndex = 53;
            this.btnLogout.Text = "No";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBuyAgain
            // 
            this.btnBuyAgain.BackColor = System.Drawing.Color.Fuchsia;
            this.btnBuyAgain.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnBuyAgain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuyAgain.Location = new System.Drawing.Point(567, 647);
            this.btnBuyAgain.Name = "btnBuyAgain";
            this.btnBuyAgain.Size = new System.Drawing.Size(322, 93);
            this.btnBuyAgain.TabIndex = 52;
            this.btnBuyAgain.Text = "Yes";
            this.btnBuyAgain.UseVisualStyleBackColor = false;
            this.btnBuyAgain.Click += new System.EventHandler(this.btnBuyAgain_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(140, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(764, 172);
            this.label7.TabIndex = 42;
            this.label7.Text = "Do you want to purchase\r\n another destination ?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(195, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(628, 86);
            this.label6.TabIndex = 41;
            this.label6.Text = "Payment Completed";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(167, 731);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(331, 93);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Fuchsia;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirm.Location = new System.Drawing.Point(574, 731);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(322, 93);
            this.btnConfirm.TabIndex = 50;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(410, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(294, 86);
            this.label12.TabIndex = 40;
            this.label12.Text = "QR Code";
            // 
            // pnlQRCode
            // 
            this.pnlQRCode.Controls.Add(this.qrCodeScan);
            this.pnlQRCode.Controls.Add(this.btnCancel);
            this.pnlQRCode.Controls.Add(this.btnConfirm);
            this.pnlQRCode.Controls.Add(this.label12);
            this.pnlQRCode.Location = new System.Drawing.Point(377, 12);
            this.pnlQRCode.Name = "pnlQRCode";
            this.pnlQRCode.Size = new System.Drawing.Size(1062, 835);
            this.pnlQRCode.TabIndex = 3;
            // 
            // qrCodeScan
            // 
            this.qrCodeScan.Location = new System.Drawing.Point(281, 155);
            this.qrCodeScan.Name = "qrCodeScan";
            this.qrCodeScan.Size = new System.Drawing.Size(512, 512);
            this.qrCodeScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrCodeScan.TabIndex = 52;
            this.qrCodeScan.TabStop = false;
            // 
            // OnlinePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1761, 871);
            this.Controls.Add(this.pnlStartAgain);
            this.Controls.Add(this.pnlQRCode);
            this.Name = "OnlinePayment";
            this.Text = "OnlinePayment";
            this.Load += new System.EventHandler(this.OnlinePayment_Load);
            this.pnlStartAgain.ResumeLayout(false);
            this.pnlStartAgain.PerformLayout();
            this.pnlQRCode.ResumeLayout(false);
            this.pnlQRCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodeScan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlStartAgain;
        private Button btnLogout;
        private Button btnBuyAgain;
        private Label label7;
        private Label label6;
        private Button btnCancel;
        private Button btnConfirm;
        private Label label12;
        private Panel pnlQRCode;
        private PictureBox qrCodeScan;
    }
}