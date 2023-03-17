namespace GUI
{
    partial class Home
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
            this.btnDestination = new System.Windows.Forms.Button();
            this.btnAmount = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.pnlDestination = new System.Windows.Forms.Panel();
            this.btnDestLogout = new System.Windows.Forms.Button();
            this.btnDestNext = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboNumber = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboRoad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboWard = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDistrict = new System.Windows.Forms.ComboBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.pnlAmount = new System.Windows.Forms.Panel();
            this.btnAmountReturn = new System.Windows.Forms.Button();
            this.btnAmountNext = new System.Windows.Forms.Button();
            this.cboTicketAmount = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDestinationAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.qrCode = new System.Windows.Forms.PictureBox();
            this.creditCard = new System.Windows.Forms.PictureBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnPaymentBack = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPaymentDestination = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlDestination.SuspendLayout();
            this.pnlAmount.SuspendLayout();
            this.pnlPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCard)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(-2, 0);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(472, 324);
            this.btnDestination.TabIndex = 0;
            this.btnDestination.Text = "Destination";
            this.btnDestination.UseVisualStyleBackColor = true;
            // 
            // btnAmount
            // 
            this.btnAmount.Location = new System.Drawing.Point(-2, 316);
            this.btnAmount.Name = "btnAmount";
            this.btnAmount.Size = new System.Drawing.Size(472, 314);
            this.btnAmount.TabIndex = 1;
            this.btnAmount.Text = "Amount";
            this.btnAmount.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(-2, 623);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(472, 287);
            this.btnPayment.TabIndex = 2;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // pnlDestination
            // 
            this.pnlDestination.Controls.Add(this.btnDestLogout);
            this.pnlDestination.Controls.Add(this.btnDestNext);
            this.pnlDestination.Controls.Add(this.label4);
            this.pnlDestination.Controls.Add(this.cboNumber);
            this.pnlDestination.Controls.Add(this.label3);
            this.pnlDestination.Controls.Add(this.cboRoad);
            this.pnlDestination.Controls.Add(this.label2);
            this.pnlDestination.Controls.Add(this.cboWard);
            this.pnlDestination.Controls.Add(this.label1);
            this.pnlDestination.Controls.Add(this.cboDistrict);
            this.pnlDestination.Controls.Add(this.lblDestination);
            this.pnlDestination.Location = new System.Drawing.Point(483, 12);
            this.pnlDestination.Name = "pnlDestination";
            this.pnlDestination.Size = new System.Drawing.Size(1222, 879);
            this.pnlDestination.TabIndex = 0;
            // 
            // btnDestLogout
            // 
            this.btnDestLogout.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnDestLogout.Location = new System.Drawing.Point(288, 775);
            this.btnDestLogout.Name = "btnDestLogout";
            this.btnDestLogout.Size = new System.Drawing.Size(324, 93);
            this.btnDestLogout.TabIndex = 24;
            this.btnDestLogout.Text = "Logout";
            this.btnDestLogout.UseVisualStyleBackColor = true;
            this.btnDestLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDestNext
            // 
            this.btnDestNext.BackColor = System.Drawing.Color.Fuchsia;
            this.btnDestNext.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnDestNext.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDestNext.Location = new System.Drawing.Point(627, 775);
            this.btnDestNext.Name = "btnDestNext";
            this.btnDestNext.Size = new System.Drawing.Size(293, 93);
            this.btnDestNext.TabIndex = 23;
            this.btnDestNext.Text = "Next";
            this.btnDestNext.UseVisualStyleBackColor = false;
            this.btnDestNext.Click += new System.EventHandler(this.btnDestNext_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(288, 615);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 65);
            this.label4.TabIndex = 22;
            this.label4.Text = "Number";
            // 
            // cboNumber
            // 
            this.cboNumber.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboNumber.FormattingEnabled = true;
            this.cboNumber.Location = new System.Drawing.Point(288, 685);
            this.cboNumber.Name = "cboNumber";
            this.cboNumber.Size = new System.Drawing.Size(632, 67);
            this.cboNumber.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(288, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 65);
            this.label3.TabIndex = 20;
            this.label3.Text = "Road";
            // 
            // cboRoad
            // 
            this.cboRoad.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboRoad.FormattingEnabled = true;
            this.cboRoad.Location = new System.Drawing.Point(288, 515);
            this.cboRoad.Name = "cboRoad";
            this.cboRoad.Size = new System.Drawing.Size(632, 67);
            this.cboRoad.TabIndex = 19;
            this.cboRoad.SelectedIndexChanged += new System.EventHandler(this.cboRoad_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(288, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 65);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ward";
            // 
            // cboWard
            // 
            this.cboWard.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboWard.FormattingEnabled = true;
            this.cboWard.Location = new System.Drawing.Point(288, 342);
            this.cboWard.Name = "cboWard";
            this.cboWard.Size = new System.Drawing.Size(632, 67);
            this.cboWard.TabIndex = 17;
            this.cboWard.SelectedIndexChanged += new System.EventHandler(this.cboWard_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(288, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 65);
            this.label1.TabIndex = 16;
            this.label1.Text = "District";
            // 
            // cboDistrict
            // 
            this.cboDistrict.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboDistrict.FormattingEnabled = true;
            this.cboDistrict.Location = new System.Drawing.Point(288, 172);
            this.cboDistrict.Name = "cboDistrict";
            this.cboDistrict.Size = new System.Drawing.Size(632, 67);
            this.cboDistrict.TabIndex = 15;
            this.cboDistrict.SelectedIndexChanged += new System.EventHandler(this.cboDistrict_SelectedIndexChanged);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDestination.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDestination.Location = new System.Drawing.Point(288, 10);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(647, 86);
            this.lblDestination.TabIndex = 14;
            this.lblDestination.Text = "Choose a destination";
            // 
            // pnlAmount
            // 
            this.pnlAmount.Controls.Add(this.btnAmountReturn);
            this.pnlAmount.Controls.Add(this.btnAmountNext);
            this.pnlAmount.Controls.Add(this.cboTicketAmount);
            this.pnlAmount.Controls.Add(this.label8);
            this.pnlAmount.Controls.Add(this.lblDestinationAmount);
            this.pnlAmount.Controls.Add(this.label6);
            this.pnlAmount.Controls.Add(this.label5);
            this.pnlAmount.Location = new System.Drawing.Point(483, 12);
            this.pnlAmount.Name = "pnlAmount";
            this.pnlAmount.Size = new System.Drawing.Size(1219, 879);
            this.pnlAmount.TabIndex = 1;
            // 
            // btnAmountReturn
            // 
            this.btnAmountReturn.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnAmountReturn.Location = new System.Drawing.Point(288, 656);
            this.btnAmountReturn.Name = "btnAmountReturn";
            this.btnAmountReturn.Size = new System.Drawing.Size(324, 93);
            this.btnAmountReturn.TabIndex = 26;
            this.btnAmountReturn.Text = "Back";
            this.btnAmountReturn.UseVisualStyleBackColor = true;
            this.btnAmountReturn.Click += new System.EventHandler(this.btnAmountReturn_Click);
            // 
            // btnAmountNext
            // 
            this.btnAmountNext.BackColor = System.Drawing.Color.Fuchsia;
            this.btnAmountNext.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnAmountNext.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAmountNext.Location = new System.Drawing.Point(627, 656);
            this.btnAmountNext.Name = "btnAmountNext";
            this.btnAmountNext.Size = new System.Drawing.Size(293, 93);
            this.btnAmountNext.TabIndex = 25;
            this.btnAmountNext.Text = "Next";
            this.btnAmountNext.UseVisualStyleBackColor = false;
            this.btnAmountNext.Click += new System.EventHandler(this.btnAmountNext_Click);
            // 
            // cboTicketAmount
            // 
            this.cboTicketAmount.FormattingEnabled = true;
            this.cboTicketAmount.Location = new System.Drawing.Point(87, 533);
            this.cboTicketAmount.Name = "cboTicketAmount";
            this.cboTicketAmount.Size = new System.Drawing.Size(242, 40);
            this.cboTicketAmount.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(87, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 65);
            this.label8.TabIndex = 19;
            this.label8.Text = "Amount";
            // 
            // lblDestinationAmount
            // 
            this.lblDestinationAmount.AutoSize = true;
            this.lblDestinationAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDestinationAmount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDestinationAmount.Location = new System.Drawing.Point(87, 247);
            this.lblDestinationAmount.Name = "lblDestinationAmount";
            this.lblDestinationAmount.Size = new System.Drawing.Size(448, 65);
            this.lblDestinationAmount.TabIndex = 18;
            this.lblDestinationAmount.Text = "Dummy Destination";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(87, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 65);
            this.label6.TabIndex = 17;
            this.label6.Text = "Destination";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(288, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(673, 86);
            this.label5.TabIndex = 15;
            this.label5.Text = "Choose ticket amount";
            // 
            // pnlPayment
            // 
            this.pnlPayment.Controls.Add(this.label15);
            this.pnlPayment.Controls.Add(this.label14);
            this.pnlPayment.Controls.Add(this.qrCode);
            this.pnlPayment.Controls.Add(this.creditCard);
            this.pnlPayment.Controls.Add(this.lblTotalPrice);
            this.pnlPayment.Controls.Add(this.btnPaymentBack);
            this.pnlPayment.Controls.Add(this.label9);
            this.pnlPayment.Controls.Add(this.lblPaymentDestination);
            this.pnlPayment.Controls.Add(this.label11);
            this.pnlPayment.Controls.Add(this.label12);
            this.pnlPayment.Location = new System.Drawing.Point(483, 12);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(1222, 879);
            this.pnlPayment.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(775, 670);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(335, 59);
            this.label15.TabIndex = 38;
            this.label15.Text = "Online Payment";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(275, 670);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(247, 59);
            this.label14.TabIndex = 37;
            this.label14.Text = "Credit Card";
            // 
            // qrCode
            // 
            this.qrCode.Image = global::GUI.Properties.Resources.qr_code;
            this.qrCode.Location = new System.Drawing.Point(811, 389);
            this.qrCode.Name = "qrCode";
            this.qrCode.Size = new System.Drawing.Size(256, 256);
            this.qrCode.TabIndex = 36;
            this.qrCode.TabStop = false;
            // 
            // creditCard
            // 
            this.creditCard.Image = global::GUI.Properties.Resources.atm_card;
            this.creditCard.Location = new System.Drawing.Point(266, 389);
            this.creditCard.Name = "creditCard";
            this.creditCard.Size = new System.Drawing.Size(256, 256);
            this.creditCard.TabIndex = 35;
            this.creditCard.TabStop = false;
            this.creditCard.Click += new System.EventHandler(this.creditCard_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalPrice.Location = new System.Drawing.Point(90, 304);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(82, 50);
            this.lblTotalPrice.TabIndex = 34;
            this.lblTotalPrice.Text = "15$";
            // 
            // btnPaymentBack
            // 
            this.btnPaymentBack.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnPaymentBack.Location = new System.Drawing.Point(489, 758);
            this.btnPaymentBack.Name = "btnPaymentBack";
            this.btnPaymentBack.Size = new System.Drawing.Size(324, 93);
            this.btnPaymentBack.TabIndex = 33;
            this.btnPaymentBack.Text = "Back";
            this.btnPaymentBack.UseVisualStyleBackColor = true;
            this.btnPaymentBack.Click += new System.EventHandler(this.btnPaymentBack_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(90, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 65);
            this.label9.TabIndex = 30;
            this.label9.Text = "Total Price";
            // 
            // lblPaymentDestination
            // 
            this.lblPaymentDestination.AutoSize = true;
            this.lblPaymentDestination.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPaymentDestination.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPaymentDestination.Location = new System.Drawing.Point(90, 173);
            this.lblPaymentDestination.Name = "lblPaymentDestination";
            this.lblPaymentDestination.Size = new System.Drawing.Size(349, 50);
            this.lblPaymentDestination.TabIndex = 29;
            this.lblPaymentDestination.Text = "Dummy Destination";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(90, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(279, 65);
            this.label11.TabIndex = 28;
            this.label11.Text = "Destination";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(291, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(770, 86);
            this.label12.TabIndex = 27;
            this.label12.Text = "Choose Payment Method";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1717, 903);
            this.Controls.Add(this.pnlPayment);
            this.Controls.Add(this.pnlAmount);
            this.Controls.Add(this.pnlDestination);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnAmount);
            this.Controls.Add(this.btnDestination);
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnlDestination.ResumeLayout(false);
            this.pnlDestination.PerformLayout();
            this.pnlAmount.ResumeLayout(false);
            this.pnlAmount.PerformLayout();
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDestination;
        private Button btnAmount;
        private Button btnPayment;
        private Panel pnlDestination;
        private Button btnDestLogout;
        private Button btnDestNext;
        private Label label4;
        private ComboBox cboNumber;
        private Label label3;
        private ComboBox cboRoad;
        private Label label2;
        private ComboBox cboWard;
        private Label label1;
        private ComboBox cboDistrict;
        private Label lblDestination;
        private Panel pnlAmount;
        private Label label8;
        private Label lblDestinationAmount;
        private Label label6;
        private Label label5;
        private ComboBox cboTicketAmount;
        private Button btnAmountReturn;
        private Button btnAmountNext;
        private Panel pnlPayment;
        private Label lblTotalPrice;
        private Button btnPaymentBack;
        private Label label9;
        private Label lblPaymentDestination;
        private Label label11;
        private Label label12;
        private PictureBox qrCode;
        private PictureBox creditCard;
        private Label label15;
        private Label label14;
    }
}