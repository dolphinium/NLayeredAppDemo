namespace Northwind.WebFormsUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.lblQuantityPerUnitAdd = new System.Windows.Forms.Label();
            this.lblStockAmountAdd = new System.Windows.Forms.Label();
            this.lblUnitPriceAdd = new System.Windows.Forms.Label();
            this.lblCategoryIdAdd = new System.Windows.Forms.Label();
            this.lblProductNameAdd = new System.Windows.Forms.Label();
            this.tbxProductNameAdd = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceAdd = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnitAdd = new System.Windows.Forms.TextBox();
            this.tbxStockAmountAdd = new System.Windows.Forms.TextBox();
            this.cbxCategoryIdAdd = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(26, 152);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(736, 268);
            this.dgwProduct.TabIndex = 0;
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(26, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(736, 56);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Search for Categories";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(102, 22);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(254, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(18, 25);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category: ";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Location = new System.Drawing.Point(26, 90);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(736, 56);
            this.gbxProductName.TabIndex = 2;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Search for Product Name";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(102, 26);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(254, 20);
            this.tbxProductName.TabIndex = 3;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(18, 29);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(78, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name:";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.cbxCategoryIdAdd);
            this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnitAdd);
            this.gbxProductAdd.Controls.Add(this.tbxStockAmountAdd);
            this.gbxProductAdd.Controls.Add(this.tbxUnitPriceAdd);
            this.gbxProductAdd.Controls.Add(this.tbxProductNameAdd);
            this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnitAdd);
            this.gbxProductAdd.Controls.Add(this.lblStockAmountAdd);
            this.gbxProductAdd.Controls.Add(this.lblUnitPriceAdd);
            this.gbxProductAdd.Controls.Add(this.lblCategoryIdAdd);
            this.gbxProductAdd.Controls.Add(this.lblProductNameAdd);
            this.gbxProductAdd.Location = new System.Drawing.Point(26, 444);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(736, 216);
            this.gbxProductAdd.TabIndex = 3;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Add New Product";
            // 
            // lblQuantityPerUnitAdd
            // 
            this.lblQuantityPerUnitAdd.AutoSize = true;
            this.lblQuantityPerUnitAdd.Location = new System.Drawing.Point(282, 58);
            this.lblQuantityPerUnitAdd.Name = "lblQuantityPerUnitAdd";
            this.lblQuantityPerUnitAdd.Size = new System.Drawing.Size(87, 13);
            this.lblQuantityPerUnitAdd.TabIndex = 4;
            this.lblQuantityPerUnitAdd.Text = "Quantity Per Unit";
            // 
            // lblStockAmountAdd
            // 
            this.lblStockAmountAdd.AutoSize = true;
            this.lblStockAmountAdd.Location = new System.Drawing.Point(282, 22);
            this.lblStockAmountAdd.Name = "lblStockAmountAdd";
            this.lblStockAmountAdd.Size = new System.Drawing.Size(74, 13);
            this.lblStockAmountAdd.TabIndex = 3;
            this.lblStockAmountAdd.Text = "Stock Amount";
            // 
            // lblUnitPriceAdd
            // 
            this.lblUnitPriceAdd.AutoSize = true;
            this.lblUnitPriceAdd.Location = new System.Drawing.Point(6, 100);
            this.lblUnitPriceAdd.Name = "lblUnitPriceAdd";
            this.lblUnitPriceAdd.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPriceAdd.TabIndex = 2;
            this.lblUnitPriceAdd.Text = "Unit Price";
            // 
            // lblCategoryIdAdd
            // 
            this.lblCategoryIdAdd.AutoSize = true;
            this.lblCategoryIdAdd.Location = new System.Drawing.Point(6, 61);
            this.lblCategoryIdAdd.Name = "lblCategoryIdAdd";
            this.lblCategoryIdAdd.Size = new System.Drawing.Size(49, 13);
            this.lblCategoryIdAdd.TabIndex = 1;
            this.lblCategoryIdAdd.Text = "Category";
            // 
            // lblProductNameAdd
            // 
            this.lblProductNameAdd.AutoSize = true;
            this.lblProductNameAdd.Location = new System.Drawing.Point(6, 25);
            this.lblProductNameAdd.Name = "lblProductNameAdd";
            this.lblProductNameAdd.Size = new System.Drawing.Size(75, 13);
            this.lblProductNameAdd.TabIndex = 0;
            this.lblProductNameAdd.Text = "Product Name";
            // 
            // tbxProductNameAdd
            // 
            this.tbxProductNameAdd.Location = new System.Drawing.Point(87, 22);
            this.tbxProductNameAdd.Name = "tbxProductNameAdd";
            this.tbxProductNameAdd.Size = new System.Drawing.Size(156, 20);
            this.tbxProductNameAdd.TabIndex = 5;
            // 
            // tbxUnitPriceAdd
            // 
            this.tbxUnitPriceAdd.Location = new System.Drawing.Point(87, 93);
            this.tbxUnitPriceAdd.Name = "tbxUnitPriceAdd";
            this.tbxUnitPriceAdd.Size = new System.Drawing.Size(156, 20);
            this.tbxUnitPriceAdd.TabIndex = 7;
            // 
            // tbxQuantityPerUnitAdd
            // 
            this.tbxQuantityPerUnitAdd.Location = new System.Drawing.Point(375, 55);
            this.tbxQuantityPerUnitAdd.Name = "tbxQuantityPerUnitAdd";
            this.tbxQuantityPerUnitAdd.Size = new System.Drawing.Size(156, 20);
            this.tbxQuantityPerUnitAdd.TabIndex = 9;
            // 
            // tbxStockAmountAdd
            // 
            this.tbxStockAmountAdd.Location = new System.Drawing.Point(373, 18);
            this.tbxStockAmountAdd.Name = "tbxStockAmountAdd";
            this.tbxStockAmountAdd.Size = new System.Drawing.Size(156, 20);
            this.tbxStockAmountAdd.TabIndex = 8;
            // 
            // cbxCategoryIdAdd
            // 
            this.cbxCategoryIdAdd.FormattingEnabled = true;
            this.cbxCategoryIdAdd.Location = new System.Drawing.Point(87, 61);
            this.cbxCategoryIdAdd.Name = "cbxCategoryIdAdd";
            this.cbxCategoryIdAdd.Size = new System.Drawing.Size(156, 21);
            this.cbxCategoryIdAdd.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(375, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add!";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 672);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Product Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Label lblQuantityPerUnitAdd;
        private System.Windows.Forms.Label lblStockAmountAdd;
        private System.Windows.Forms.Label lblUnitPriceAdd;
        private System.Windows.Forms.Label lblCategoryIdAdd;
        private System.Windows.Forms.Label lblProductNameAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxCategoryIdAdd;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitAdd;
        private System.Windows.Forms.TextBox tbxStockAmountAdd;
        private System.Windows.Forms.TextBox tbxUnitPriceAdd;
        private System.Windows.Forms.TextBox tbxProductNameAdd;
    }
}

