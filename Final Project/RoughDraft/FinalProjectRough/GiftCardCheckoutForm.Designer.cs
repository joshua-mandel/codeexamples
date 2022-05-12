namespace FinalProjectRough
{
    partial class GiftCardCheckoutForm
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
            this.lblRemainingBalance = new System.Windows.Forms.Label();
            this.txtGiftCardNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcessGiftCard = new System.Windows.Forms.Button();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCheckout = new System.Windows.Forms.ListBox();
            this.lblTotalDue = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.txtGiftCardCheckBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRemainingBalance
            // 
            this.lblRemainingBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRemainingBalance.AutoSize = true;
            this.lblRemainingBalance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblRemainingBalance.Location = new System.Drawing.Point(6, 486);
            this.lblRemainingBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemainingBalance.Name = "lblRemainingBalance";
            this.lblRemainingBalance.Size = new System.Drawing.Size(352, 32);
            this.lblRemainingBalance.TabIndex = 70;
            this.lblRemainingBalance.Text = "Remaining Balance: $0.00";
            // 
            // txtGiftCardNum
            // 
            this.txtGiftCardNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiftCardNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiftCardNum.Location = new System.Drawing.Point(841, 44);
            this.txtGiftCardNum.Name = "txtGiftCardNum";
            this.txtGiftCardNum.Size = new System.Drawing.Size(348, 35);
            this.txtGiftCardNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(1018, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 22);
            this.label2.TabIndex = 68;
            this.label2.Text = "Gift Card Number";
            // 
            // btnProcessGiftCard
            // 
            this.btnProcessGiftCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessGiftCard.AutoSize = true;
            this.btnProcessGiftCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnProcessGiftCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcessGiftCard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessGiftCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProcessGiftCard.Location = new System.Drawing.Point(841, 148);
            this.btnProcessGiftCard.Name = "btnProcessGiftCard";
            this.btnProcessGiftCard.Size = new System.Drawing.Size(348, 61);
            this.btnProcessGiftCard.TabIndex = 3;
            this.btnProcessGiftCard.Text = "Process Payment";
            this.btnProcessGiftCard.UseVisualStyleBackColor = false;
            this.btnProcessGiftCard.Click += new System.EventHandler(this.btnProcessGiftCard_Click);
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaymentAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentAmount.Location = new System.Drawing.Point(1009, 107);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(180, 35);
            this.txtPaymentAmount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(1018, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 71;
            this.label1.Text = "Payment Amount";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::FinalProjectRough.Properties.Resources.autozone_png_logo_6233;
            this.pictureBox1.Location = new System.Drawing.Point(841, 523);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // lbCheckout
            // 
            this.lbCheckout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCheckout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckout.FormattingEnabled = true;
            this.lbCheckout.ItemHeight = 15;
            this.lbCheckout.Location = new System.Drawing.Point(13, 12);
            this.lbCheckout.Name = "lbCheckout";
            this.lbCheckout.Size = new System.Drawing.Size(820, 454);
            this.lbCheckout.TabIndex = 73;
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.AutoSize = true;
            this.lblTotalDue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotalDue.Location = new System.Drawing.Point(378, 566);
            this.lblTotalDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(476, 43);
            this.lblTotalDue.TabIndex = 76;
            this.lblTotalDue.Text = "Total Payment Due: $0.00";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSubtotal.Location = new System.Drawing.Point(599, 522);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(148, 22);
            this.lblSubtotal.TabIndex = 74;
            this.lblSubtotal.Text = "Subtotal: $0.00";
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTaxAmount.Location = new System.Drawing.Point(580, 544);
            this.lblTaxAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(167, 22);
            this.lblTaxAmount.TabIndex = 75;
            this.lblTaxAmount.Text = "Tax (8.5%): $0.00";
            // 
            // txtGiftCardCheckBalance
            // 
            this.txtGiftCardCheckBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiftCardCheckBalance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiftCardCheckBalance.Location = new System.Drawing.Point(836, 333);
            this.txtGiftCardCheckBalance.Name = "txtGiftCardCheckBalance";
            this.txtGiftCardCheckBalance.Size = new System.Drawing.Size(348, 35);
            this.txtGiftCardCheckBalance.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(1013, 308);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 22);
            this.label3.TabIndex = 77;
            this.label3.Text = "Gift Card Number";
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckBalance.AutoSize = true;
            this.btnCheckBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCheckBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckBalance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBalance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckBalance.Location = new System.Drawing.Point(836, 374);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(348, 41);
            this.btnCheckBalance.TabIndex = 5;
            this.btnCheckBalance.Text = "Check Balance";
            this.btnCheckBalance.UseVisualStyleBackColor = false;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // GiftCardCheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 673);
            this.Controls.Add(this.btnCheckBalance);
            this.Controls.Add(this.txtGiftCardCheckBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalDue);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblTaxAmount);
            this.Controls.Add(this.lbCheckout);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRemainingBalance);
            this.Controls.Add(this.txtGiftCardNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnProcessGiftCard);
            this.Name = "GiftCardCheckoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gift Card Checkout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemainingBalance;
        private System.Windows.Forms.TextBox txtGiftCardNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProcessGiftCard;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbCheckout;
        private System.Windows.Forms.Label lblTotalDue;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.TextBox txtGiftCardCheckBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheckBalance;
    }
}