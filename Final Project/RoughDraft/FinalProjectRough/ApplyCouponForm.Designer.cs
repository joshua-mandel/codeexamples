namespace FinalProjectRough
{
    partial class ApplyCouponForm
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
            this.txtCouponNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnApplyCoupon = new System.Windows.Forms.Button();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCheckout = new System.Windows.Forms.ListBox();
            this.lblTotalDue = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCouponNum
            // 
            this.txtCouponNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCouponNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCouponNum.Location = new System.Drawing.Point(818, 318);
            this.txtCouponNum.Name = "txtCouponNum";
            this.txtCouponNum.Size = new System.Drawing.Size(362, 35);
            this.txtCouponNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(1022, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 55;
            this.label2.Text = "Coupon Number";
            // 
            // btnApplyCoupon
            // 
            this.btnApplyCoupon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyCoupon.AutoSize = true;
            this.btnApplyCoupon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnApplyCoupon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyCoupon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyCoupon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApplyCoupon.Location = new System.Drawing.Point(818, 359);
            this.btnApplyCoupon.Name = "btnApplyCoupon";
            this.btnApplyCoupon.Size = new System.Drawing.Size(363, 61);
            this.btnApplyCoupon.TabIndex = 2;
            this.btnApplyCoupon.Text = "Apply Coupon";
            this.btnApplyCoupon.UseVisualStyleBackColor = false;
            this.btnApplyCoupon.Click += new System.EventHandler(this.btnApplyCoupon_Click);
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDiscountAmount.Location = new System.Drawing.Point(13, 469);
            this.lblDiscountAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(325, 32);
            this.lblDiscountAmount.TabIndex = 63;
            this.lblDiscountAmount.Text = "Discount Amount: $0.00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::FinalProjectRough.Properties.Resources.autozone_png_logo_6233;
            this.pictureBox1.Location = new System.Drawing.Point(819, 478);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // lbCheckout
            // 
            this.lbCheckout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCheckout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckout.FormattingEnabled = true;
            this.lbCheckout.ItemHeight = 15;
            this.lbCheckout.Location = new System.Drawing.Point(12, 12);
            this.lbCheckout.Name = "lbCheckout";
            this.lbCheckout.Size = new System.Drawing.Size(800, 454);
            this.lbCheckout.TabIndex = 64;
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.AutoSize = true;
            this.lblTotalDue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotalDue.Location = new System.Drawing.Point(336, 548);
            this.lblTotalDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(476, 43);
            this.lblTotalDue.TabIndex = 79;
            this.lblTotalDue.Text = "Total Payment Due: $0.00";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSubtotal.Location = new System.Drawing.Point(557, 504);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(148, 22);
            this.lblSubtotal.TabIndex = 77;
            this.lblSubtotal.Text = "Subtotal: $0.00";
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTaxAmount.Location = new System.Drawing.Point(538, 526);
            this.lblTaxAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(167, 22);
            this.lblTaxAmount.TabIndex = 78;
            this.lblTaxAmount.Text = "Tax (8.5%): $0.00";
            // 
            // ApplyCouponForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 641);
            this.Controls.Add(this.lblTotalDue);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblTaxAmount);
            this.Controls.Add(this.lbCheckout);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.txtCouponNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnApplyCoupon);
            this.Name = "ApplyCouponForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apply Coupon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCouponNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnApplyCoupon;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.ListBox lbCheckout;
        private System.Windows.Forms.Label lblTotalDue;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTaxAmount;
    }
}