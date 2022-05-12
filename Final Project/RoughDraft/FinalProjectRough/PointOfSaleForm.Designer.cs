namespace FinalProjectRough
{
    partial class PointOfSaleForm
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
            this.cbMenuNavigation = new System.Windows.Forms.ComboBox();
            this.cbProductCategories = new System.Windows.Forms.ComboBox();
            this.bthCashCheckout = new System.Windows.Forms.Button();
            this.btnCreditCheckout = new System.Windows.Forms.Button();
            this.btnGiftCardCheckout = new System.Windows.Forms.Button();
            this.btnApplyCoupon = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearCheckout = new System.Windows.Forms.Button();
            this.txtManagerOverride = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnManagerOverride = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCart = new System.Windows.Forms.ListBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbProducts = new System.Windows.Forms.GroupBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.lblTotalDue = new System.Windows.Forms.Label();
            this.lblCouponApplied = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMenuNavigation
            // 
            this.cbMenuNavigation.BackColor = System.Drawing.Color.White;
            this.cbMenuNavigation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMenuNavigation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMenuNavigation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbMenuNavigation.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMenuNavigation.FormattingEnabled = true;
            this.cbMenuNavigation.Location = new System.Drawing.Point(12, 21);
            this.cbMenuNavigation.Name = "cbMenuNavigation";
            this.cbMenuNavigation.Size = new System.Drawing.Size(192, 28);
            this.cbMenuNavigation.TabIndex = 1;
            this.cbMenuNavigation.SelectedIndexChanged += new System.EventHandler(this.cbMenuNavigation_SelectedIndexChanged);
            // 
            // cbProductCategories
            // 
            this.cbProductCategories.BackColor = System.Drawing.Color.White;
            this.cbProductCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbProductCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductCategories.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbProductCategories.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductCategories.FormattingEnabled = true;
            this.cbProductCategories.Location = new System.Drawing.Point(12, 220);
            this.cbProductCategories.Name = "cbProductCategories";
            this.cbProductCategories.Size = new System.Drawing.Size(506, 33);
            this.cbProductCategories.TabIndex = 2;
            this.cbProductCategories.SelectedIndexChanged += new System.EventHandler(this.cbProductCategories_SelectedIndexChanged);
            // 
            // bthCashCheckout
            // 
            this.bthCashCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bthCashCheckout.AutoSize = true;
            this.bthCashCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bthCashCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bthCashCheckout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthCashCheckout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bthCashCheckout.Location = new System.Drawing.Point(1371, 104);
            this.bthCashCheckout.Name = "bthCashCheckout";
            this.bthCashCheckout.Size = new System.Drawing.Size(464, 98);
            this.bthCashCheckout.TabIndex = 6;
            this.bthCashCheckout.Text = "CASH";
            this.bthCashCheckout.UseVisualStyleBackColor = false;
            this.bthCashCheckout.Click += new System.EventHandler(this.bthCashCheckout_Click);
            // 
            // btnCreditCheckout
            // 
            this.btnCreditCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreditCheckout.AutoSize = true;
            this.btnCreditCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCreditCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreditCheckout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditCheckout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreditCheckout.Location = new System.Drawing.Point(1371, 208);
            this.btnCreditCheckout.Name = "btnCreditCheckout";
            this.btnCreditCheckout.Size = new System.Drawing.Size(464, 98);
            this.btnCreditCheckout.TabIndex = 7;
            this.btnCreditCheckout.Text = "CREDIT/\r\nDEBIT";
            this.btnCreditCheckout.UseVisualStyleBackColor = false;
            this.btnCreditCheckout.Click += new System.EventHandler(this.btnCreditCheckout_Click);
            // 
            // btnGiftCardCheckout
            // 
            this.btnGiftCardCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGiftCardCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGiftCardCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiftCardCheckout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiftCardCheckout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGiftCardCheckout.Location = new System.Drawing.Point(1371, 312);
            this.btnGiftCardCheckout.Name = "btnGiftCardCheckout";
            this.btnGiftCardCheckout.Size = new System.Drawing.Size(464, 98);
            this.btnGiftCardCheckout.TabIndex = 8;
            this.btnGiftCardCheckout.Text = "GIFT CARD";
            this.btnGiftCardCheckout.UseVisualStyleBackColor = false;
            this.btnGiftCardCheckout.Click += new System.EventHandler(this.btnGiftCardCheckout_Click);
            // 
            // btnApplyCoupon
            // 
            this.btnApplyCoupon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyCoupon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnApplyCoupon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyCoupon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyCoupon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApplyCoupon.Location = new System.Drawing.Point(1371, 416);
            this.btnApplyCoupon.Name = "btnApplyCoupon";
            this.btnApplyCoupon.Size = new System.Drawing.Size(464, 98);
            this.btnApplyCoupon.TabIndex = 9;
            this.btnApplyCoupon.Text = "APPLY COUPON";
            this.btnApplyCoupon.UseVisualStyleBackColor = false;
            this.btnApplyCoupon.Click += new System.EventHandler(this.btnApplyCoupon_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(533, 21);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(618, 35);
            this.txtSearchBox.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(1157, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 35);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Product Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClearCheckout
            // 
            this.btnClearCheckout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClearCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClearCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearCheckout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCheckout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearCheckout.Location = new System.Drawing.Point(1125, 663);
            this.btnClearCheckout.Name = "btnClearCheckout";
            this.btnClearCheckout.Size = new System.Drawing.Size(232, 47);
            this.btnClearCheckout.TabIndex = 12;
            this.btnClearCheckout.Text = "Clear Checkout Cart";
            this.btnClearCheckout.UseVisualStyleBackColor = false;
            this.btnClearCheckout.Click += new System.EventHandler(this.btnClearCheckout_Click);
            // 
            // txtManagerOverride
            // 
            this.txtManagerOverride.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtManagerOverride.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerOverride.Location = new System.Drawing.Point(1478, 666);
            this.txtManagerOverride.Name = "txtManagerOverride";
            this.txtManagerOverride.PasswordChar = '*';
            this.txtManagerOverride.Size = new System.Drawing.Size(357, 35);
            this.txtManagerOverride.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(1610, 635);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Manager Override";
            // 
            // btnManagerOverride
            // 
            this.btnManagerOverride.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManagerOverride.BackColor = System.Drawing.Color.DarkRed;
            this.btnManagerOverride.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManagerOverride.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerOverride.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnManagerOverride.Location = new System.Drawing.Point(1615, 707);
            this.btnManagerOverride.Name = "btnManagerOverride";
            this.btnManagerOverride.Size = new System.Drawing.Size(221, 37);
            this.btnManagerOverride.TabIndex = 11;
            this.btnManagerOverride.Text = "OVERRIDE";
            this.btnManagerOverride.UseVisualStyleBackColor = false;
            this.btnManagerOverride.Click += new System.EventHandler(this.btnLoyaltyRewards_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(1418, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 80);
            this.label1.TabIndex = 20;
            this.label1.Text = "CHOOSE A PAYMENT\r\nMETHOD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox5.Image = global::FinalProjectRough.Properties.Resources.firestone_autozone_sponsor;
            this.pictureBox5.Location = new System.Drawing.Point(533, 771);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(222, 109);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::FinalProjectRough.Properties.Resources.harley_davidson_autozone_sponsor;
            this.pictureBox4.Location = new System.Drawing.Point(957, 771);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(400, 109);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::FinalProjectRough.Properties.Resources.ford_autozone_sponsor;
            this.pictureBox3.Location = new System.Drawing.Point(1470, 771);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(365, 109);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::FinalProjectRough.Properties.Resources.penzoil_autozone_sponsor;
            this.pictureBox2.Location = new System.Drawing.Point(12, 771);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(338, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProjectRough.Properties.Resources.autozone_logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lbCart
            // 
            this.lbCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCart.ForeColor = System.Drawing.Color.Navy;
            this.lbCart.FormattingEnabled = true;
            this.lbCart.ItemHeight = 18;
            this.lbCart.Location = new System.Drawing.Point(533, 70);
            this.lbCart.Name = "lbCart";
            this.lbCart.ScrollAlwaysVisible = true;
            this.lbCart.Size = new System.Drawing.Size(824, 598);
            this.lbCart.TabIndex = 25;
            this.lbCart.SelectedIndexChanged += new System.EventHandler(this.lbCart_SelectedIndexChanged);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Navy;
            this.lblResult.Location = new System.Drawing.Point(53, 299);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 28);
            this.lblResult.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(13, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "Product Categories";
            // 
            // gbProducts
            // 
            this.gbProducts.Location = new System.Drawing.Point(2, 260);
            this.gbProducts.Name = "gbProducts";
            this.gbProducts.Size = new System.Drawing.Size(544, 583);
            this.gbProducts.TabIndex = 3;
            this.gbProducts.TabStop = false;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.Navy;
            this.lblSubtotal.Location = new System.Drawing.Point(819, 633);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(148, 22);
            this.lblSubtotal.TabIndex = 30;
            this.lblSubtotal.Text = "Subtotal: $0.00";
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxAmount.ForeColor = System.Drawing.Color.Navy;
            this.lblTaxAmount.Location = new System.Drawing.Point(800, 655);
            this.lblTaxAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(167, 22);
            this.lblTaxAmount.TabIndex = 31;
            this.lblTaxAmount.Text = "Tax (8.5%): $0.00";
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotalDue.AutoSize = true;
            this.lblTotalDue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDue.ForeColor = System.Drawing.Color.Navy;
            this.lblTotalDue.Location = new System.Drawing.Point(553, 677);
            this.lblTotalDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(476, 43);
            this.lblTotalDue.TabIndex = 32;
            this.lblTotalDue.Text = "Total Payment Due: $0.00";
            // 
            // lblCouponApplied
            // 
            this.lblCouponApplied.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCouponApplied.AutoSize = true;
            this.lblCouponApplied.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouponApplied.ForeColor = System.Drawing.Color.Navy;
            this.lblCouponApplied.Location = new System.Drawing.Point(557, 633);
            this.lblCouponApplied.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCouponApplied.Name = "lblCouponApplied";
            this.lblCouponApplied.Size = new System.Drawing.Size(184, 22);
            this.lblCouponApplied.TabIndex = 33;
            this.lblCouponApplied.Text = "COUPON APPLIED";
            this.lblCouponApplied.Visible = false;
            // 
            // PointOfSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 892);
            this.Controls.Add(this.lblCouponApplied);
            this.Controls.Add(this.lblTotalDue);
            this.Controls.Add(this.gbProducts);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTaxAmount);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lbCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnManagerOverride);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtManagerOverride);
            this.Controls.Add(this.btnClearCheckout);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.btnApplyCoupon);
            this.Controls.Add(this.btnGiftCardCheckout);
            this.Controls.Add(this.btnCreditCheckout);
            this.Controls.Add(this.bthCashCheckout);
            this.Controls.Add(this.cbProductCategories);
            this.Controls.Add(this.cbMenuNavigation);
            this.Name = "PointOfSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTOZONE | Point of Sale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PointOfSaleForm_FormClosing);
            this.Load += new System.EventHandler(this.PointOfSaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbProductCategories;
        private System.Windows.Forms.Button bthCashCheckout;
        private System.Windows.Forms.Button btnCreditCheckout;
        private System.Windows.Forms.Button btnGiftCardCheckout;
        private System.Windows.Forms.Button btnApplyCoupon;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearCheckout;
        private System.Windows.Forms.TextBox txtManagerOverride;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnManagerOverride;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.ComboBox cbMenuNavigation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbCart;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbProducts;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.Label lblTotalDue;
        private System.Windows.Forms.Label lblCouponApplied;
    }
}