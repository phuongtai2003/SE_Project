namespace GUI
{
    partial class CreditCardPayment
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
            this.pnlCardInfo = new System.Windows.Forms.Panel();
            this.pnlStartAgain = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBuyAgain = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecurityCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlPaymentFailed = new System.Windows.Forms.Panel();
            this.btnTryAgainNo = new System.Windows.Forms.Button();
            this.btnTryAgainYes = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlCardInfo.SuspendLayout();
            this.pnlStartAgain.SuspendLayout();
            this.pnlPaymentFailed.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCardInfo
            // 
            this.pnlCardInfo.Controls.Add(this.btnCancel);
            this.pnlCardInfo.Controls.Add(this.btnConfirm);
            this.pnlCardInfo.Controls.Add(this.cboYear);
            this.pnlCardInfo.Controls.Add(this.cboMonth);
            this.pnlCardInfo.Controls.Add(this.label5);
            this.pnlCardInfo.Controls.Add(this.label4);
            this.pnlCardInfo.Controls.Add(this.label3);
            this.pnlCardInfo.Controls.Add(this.label1);
            this.pnlCardInfo.Controls.Add(this.txtSecurityCode);
            this.pnlCardInfo.Controls.Add(this.label2);
            this.pnlCardInfo.Controls.Add(this.txtCardNumber);
            this.pnlCardInfo.Controls.Add(this.label12);
            this.pnlCardInfo.Location = new System.Drawing.Point(290, 12);
            this.pnlCardInfo.Name = "pnlCardInfo";
            this.pnlCardInfo.Size = new System.Drawing.Size(1062, 835);
            this.pnlCardInfo.TabIndex = 0;
            // 
            // pnlStartAgain
            // 
            this.pnlStartAgain.Controls.Add(this.btnLogout);
            this.pnlStartAgain.Controls.Add(this.btnBuyAgain);
            this.pnlStartAgain.Controls.Add(this.label7);
            this.pnlStartAgain.Controls.Add(this.label6);
            this.pnlStartAgain.Location = new System.Drawing.Point(293, 12);
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
            this.btnCancel.Click += new System.EventHandler(this.btnLogout_Click);
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
            // cboYear
            // 
            this.cboYear.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(589, 453);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(307, 67);
            this.cboYear.TabIndex = 49;
            // 
            // cboMonth
            // 
            this.cboMonth.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(167, 453);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(307, 67);
            this.cboMonth.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(589, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 50);
            this.label5.TabIndex = 47;
            this.label5.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(167, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 50);
            this.label4.TabIndex = 46;
            this.label4.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(166, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 65);
            this.label3.TabIndex = 45;
            this.label3.Text = "Valid through";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(167, 554);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 65);
            this.label1.TabIndex = 44;
            this.label1.Text = "Security Code";
            // 
            // txtSecurityCode
            // 
            this.txtSecurityCode.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSecurityCode.Location = new System.Drawing.Point(167, 622);
            this.txtSecurityCode.Name = "txtSecurityCode";
            this.txtSecurityCode.Size = new System.Drawing.Size(729, 65);
            this.txtSecurityCode.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(167, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 65);
            this.label2.TabIndex = 42;
            this.label2.Text = "Card Number";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCardNumber.Location = new System.Drawing.Point(167, 195);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(729, 65);
            this.txtCardNumber.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(167, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(729, 86);
            this.label12.TabIndex = 40;
            this.label12.Text = "Credit Card Information";
            // 
            // pnlPaymentFailed
            // 
            this.pnlPaymentFailed.Controls.Add(this.btnTryAgainNo);
            this.pnlPaymentFailed.Controls.Add(this.btnTryAgainYes);
            this.pnlPaymentFailed.Controls.Add(this.label8);
            this.pnlPaymentFailed.Controls.Add(this.label9);
            this.pnlPaymentFailed.Location = new System.Drawing.Point(293, 9);
            this.pnlPaymentFailed.Name = "pnlPaymentFailed";
            this.pnlPaymentFailed.Size = new System.Drawing.Size(1059, 832);
            this.pnlPaymentFailed.TabIndex = 2;
            // 
            // btnTryAgainNo
            // 
            this.btnTryAgainNo.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnTryAgainNo.Location = new System.Drawing.Point(160, 647);
            this.btnTryAgainNo.Name = "btnTryAgainNo";
            this.btnTryAgainNo.Size = new System.Drawing.Size(331, 93);
            this.btnTryAgainNo.TabIndex = 53;
            this.btnTryAgainNo.Text = "No";
            this.btnTryAgainNo.UseVisualStyleBackColor = true;
            this.btnTryAgainNo.Click += new System.EventHandler(this.btnTryAgainNo_Click);
            // 
            // btnTryAgainYes
            // 
            this.btnTryAgainYes.BackColor = System.Drawing.Color.Fuchsia;
            this.btnTryAgainYes.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnTryAgainYes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTryAgainYes.Location = new System.Drawing.Point(567, 647);
            this.btnTryAgainYes.Name = "btnTryAgainYes";
            this.btnTryAgainYes.Size = new System.Drawing.Size(322, 93);
            this.btnTryAgainYes.TabIndex = 52;
            this.btnTryAgainYes.Text = "Yes";
            this.btnTryAgainYes.UseVisualStyleBackColor = false;
            this.btnTryAgainYes.Click += new System.EventHandler(this.btnTryAgainYes_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(382, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(350, 86);
            this.label8.TabIndex = 42;
            this.label8.Text = "Try again ?";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(317, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(477, 86);
            this.label9.TabIndex = 41;
            this.label9.Text = "Payment Failed";
            // 
            // CreditCardPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1606, 877);
            this.Controls.Add(this.pnlPaymentFailed);
            this.Controls.Add(this.pnlStartAgain);
            this.Controls.Add(this.pnlCardInfo);
            this.Name = "CreditCardPayment";
            this.Text = "CreditCardPayment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreditCardPayment_FormClosed);
            this.Load += new System.EventHandler(this.CreditCardPayment_Load);
            this.pnlCardInfo.ResumeLayout(false);
            this.pnlCardInfo.PerformLayout();
            this.pnlStartAgain.ResumeLayout(false);
            this.pnlStartAgain.PerformLayout();
            this.pnlPaymentFailed.ResumeLayout(false);
            this.pnlPaymentFailed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlCardInfo;
        private Button btnCancel;
        private Button btnConfirm;
        private ComboBox cboYear;
        private ComboBox cboMonth;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtSecurityCode;
        private Label label2;
        private TextBox txtCardNumber;
        private Label label12;
        private Panel pnlStartAgain;
        private Button btnLogout;
        private Button btnBuyAgain;
        private Label label7;
        private Label label6;
        private Panel pnlPaymentFailed;
        private Button btnTryAgainNo;
        private Button btnTryAgainYes;
        private Label label8;
        private Label label9;
    }
}