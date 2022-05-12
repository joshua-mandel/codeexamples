namespace FinalProjectRough
{
    partial class ManagerModeForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbProductCategoryAdd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductNameAdd = new System.Windows.Forms.TextBox();
            this.txtProductNumAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductPriceAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbProductCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbProductNameUpdate = new System.Windows.Forms.ComboBox();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInventoryAdd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProductDescriptionAdd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.cbMenuNavigation.Location = new System.Drawing.Point(57, 23);
            this.cbMenuNavigation.Name = "cbMenuNavigation";
            this.cbMenuNavigation.Size = new System.Drawing.Size(222, 28);
            this.cbMenuNavigation.TabIndex = 1;
            this.cbMenuNavigation.SelectedIndexChanged += new System.EventHandler(this.cbMenuNavigation_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(51, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Add a Product";
            // 
            // cbProductCategoryAdd
            // 
            this.cbProductCategoryAdd.BackColor = System.Drawing.Color.White;
            this.cbProductCategoryAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbProductCategoryAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductCategoryAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbProductCategoryAdd.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductCategoryAdd.FormattingEnabled = true;
            this.cbProductCategoryAdd.Location = new System.Drawing.Point(57, 138);
            this.cbProductCategoryAdd.Name = "cbProductCategoryAdd";
            this.cbProductCategoryAdd.Size = new System.Drawing.Size(312, 31);
            this.cbProductCategoryAdd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(53, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Product Name";
            // 
            // txtProductNameAdd
            // 
            this.txtProductNameAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductNameAdd.Location = new System.Drawing.Point(57, 197);
            this.txtProductNameAdd.Name = "txtProductNameAdd";
            this.txtProductNameAdd.Size = new System.Drawing.Size(312, 35);
            this.txtProductNameAdd.TabIndex = 3;
            // 
            // txtProductNumAdd
            // 
            this.txtProductNumAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductNumAdd.Location = new System.Drawing.Point(57, 325);
            this.txtProductNumAdd.Name = "txtProductNumAdd";
            this.txtProductNumAdd.Size = new System.Drawing.Size(312, 35);
            this.txtProductNumAdd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(53, 300);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Product Number";
            // 
            // txtProductPriceAdd
            // 
            this.txtProductPriceAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPriceAdd.Location = new System.Drawing.Point(57, 388);
            this.txtProductPriceAdd.Name = "txtProductPriceAdd";
            this.txtProductPriceAdd.Size = new System.Drawing.Size(222, 35);
            this.txtProductPriceAdd.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(53, 363);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Product Price";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AutoSize = true;
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddProduct.Location = new System.Drawing.Point(57, 492);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(312, 47);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(53, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 22);
            this.label5.TabIndex = 67;
            this.label5.Text = "Product Category";
            // 
            // cbProductCategoryUpdate
            // 
            this.cbProductCategoryUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProductCategoryUpdate.BackColor = System.Drawing.Color.White;
            this.cbProductCategoryUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbProductCategoryUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductCategoryUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbProductCategoryUpdate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductCategoryUpdate.FormattingEnabled = true;
            this.cbProductCategoryUpdate.Location = new System.Drawing.Point(551, 138);
            this.cbProductCategoryUpdate.Name = "cbProductCategoryUpdate";
            this.cbProductCategoryUpdate.Size = new System.Drawing.Size(354, 31);
            this.cbProductCategoryUpdate.TabIndex = 9;
            this.cbProductCategoryUpdate.SelectedIndexChanged += new System.EventHandler(this.cbProductCategoryUpdate_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(545, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 32);
            this.label6.TabIndex = 69;
            this.label6.Text = "Modify a Product";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(547, 113);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 22);
            this.label7.TabIndex = 70;
            this.label7.Text = "Choose Product Category";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(547, 172);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 22);
            this.label8.TabIndex = 71;
            this.label8.Text = "Choose Product";
            // 
            // cbProductNameUpdate
            // 
            this.cbProductNameUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProductNameUpdate.BackColor = System.Drawing.Color.White;
            this.cbProductNameUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbProductNameUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductNameUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbProductNameUpdate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductNameUpdate.FormattingEnabled = true;
            this.cbProductNameUpdate.Location = new System.Drawing.Point(551, 197);
            this.cbProductNameUpdate.Name = "cbProductNameUpdate";
            this.cbProductNameUpdate.Size = new System.Drawing.Size(354, 31);
            this.cbProductNameUpdate.TabIndex = 10;
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifyProduct.AutoSize = true;
            this.btnModifyProduct.BackColor = System.Drawing.Color.Yellow;
            this.btnModifyProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifyProduct.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModifyProduct.Location = new System.Drawing.Point(551, 234);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(354, 47);
            this.btnModifyProduct.TabIndex = 11;
            this.btnModifyProduct.Text = "Modify Product";
            this.btnModifyProduct.UseVisualStyleBackColor = false;
            this.btnModifyProduct.Click += new System.EventHandler(this.btnModifyProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProduct.AutoSize = true;
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteProduct.Location = new System.Drawing.Point(551, 287);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(354, 47);
            this.btnDeleteProduct.TabIndex = 12;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(20, 388);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 32);
            this.label9.TabIndex = 77;
            this.label9.Text = "$";
            // 
            // txtInventoryAdd
            // 
            this.txtInventoryAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventoryAdd.Location = new System.Drawing.Point(57, 451);
            this.txtInventoryAdd.Name = "txtInventoryAdd";
            this.txtInventoryAdd.Size = new System.Drawing.Size(105, 35);
            this.txtInventoryAdd.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(53, 426);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 22);
            this.label10.TabIndex = 78;
            this.label10.Text = "Product Inventory";
            // 
            // txtProductDescriptionAdd
            // 
            this.txtProductDescriptionAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductDescriptionAdd.Location = new System.Drawing.Point(57, 260);
            this.txtProductDescriptionAdd.Name = "txtProductDescriptionAdd";
            this.txtProductDescriptionAdd.Size = new System.Drawing.Size(312, 35);
            this.txtProductDescriptionAdd.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(53, 235);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 22);
            this.label11.TabIndex = 80;
            this.label11.Text = "Product Description";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::FinalProjectRough.Properties.Resources.autozone_logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(551, 403);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // ManagerModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 567);
            this.Controls.Add(this.txtProductDescriptionAdd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtInventoryAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnModifyProduct);
            this.Controls.Add(this.cbProductNameUpdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbProductCategoryUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtProductPriceAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductNumAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductNameAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProductCategoryAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMenuNavigation);
            this.Name = "ManagerModeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Mode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbMenuNavigation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProductCategoryAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductNameAdd;
        private System.Windows.Forms.TextBox txtProductNumAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductPriceAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbProductCategoryUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbProductNameUpdate;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInventoryAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProductDescriptionAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}