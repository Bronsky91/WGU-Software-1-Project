namespace C968
{
    partial class mainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.addPart = new System.Windows.Forms.Button();
            this.modifyPart = new System.Windows.Forms.Button();
            this.deletePart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.productsTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.modifyProduct = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.searchProductBar = new System.Windows.Forms.TextBox();
            this.searchProducts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.partsTable = new System.Windows.Forms.DataGridView();
            this.searchPartsBar = new System.Windows.Forms.TextBox();
            this.searchParts = new System.Windows.Forms.Button();
            this.Parts = new System.Windows.Forms.Label();
            this.exitMainForm = new System.Windows.Forms.Button();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partInvLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventory Management System";
            // 
            // addPart
            // 
            this.addPart.Location = new System.Drawing.Point(101, 211);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(116, 37);
            this.addPart.TabIndex = 4;
            this.addPart.Text = "Add";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.addPartsButton_Click);
            // 
            // modifyPart
            // 
            this.modifyPart.Location = new System.Drawing.Point(239, 211);
            this.modifyPart.Name = "modifyPart";
            this.modifyPart.Size = new System.Drawing.Size(108, 36);
            this.modifyPart.TabIndex = 5;
            this.modifyPart.Text = "Modify";
            this.modifyPart.UseVisualStyleBackColor = true;
            // 
            // deletePart
            // 
            this.deletePart.Location = new System.Drawing.Point(373, 210);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(96, 36);
            this.deletePart.TabIndex = 6;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.productsTable);
            this.groupBox1.Controls.Add(this.deleteProduct);
            this.groupBox1.Controls.Add(this.modifyProduct);
            this.groupBox1.Controls.Add(this.addProduct);
            this.groupBox1.Controls.Add(this.searchProductBar);
            this.groupBox1.Controls.Add(this.searchProducts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(573, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 267);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // productsTable
            // 
            this.productsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.inStock,
            this.price});
            this.productsTable.Location = new System.Drawing.Point(28, 62);
            this.productsTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productsTable.Name = "productsTable";
            this.productsTable.RowTemplate.Height = 33;
            this.productsTable.Size = new System.Drawing.Size(434, 132);
            this.productsTable.TabIndex = 6;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "Product ID";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Product Name";
            this.name.Name = "name";
            // 
            // inStock
            // 
            this.inStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inStock.HeaderText = "Inventory Level";
            this.inStock.Name = "inStock";
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.HeaderText = "Price per Unit";
            this.price.Name = "price";
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(352, 210);
            this.deleteProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(104, 36);
            this.deleteProduct.TabIndex = 5;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = true;
            // 
            // modifyProduct
            // 
            this.modifyProduct.Location = new System.Drawing.Point(224, 210);
            this.modifyProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modifyProduct.Name = "modifyProduct";
            this.modifyProduct.Size = new System.Drawing.Size(100, 38);
            this.modifyProduct.TabIndex = 4;
            this.modifyProduct.Text = "Modify";
            this.modifyProduct.UseVisualStyleBackColor = true;
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(92, 211);
            this.addProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(112, 35);
            this.addProduct.TabIndex = 3;
            this.addProduct.Text = "Add";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // searchProductBar
            // 
            this.searchProductBar.Location = new System.Drawing.Point(334, 19);
            this.searchProductBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchProductBar.Name = "searchProductBar";
            this.searchProductBar.Size = new System.Drawing.Size(134, 20);
            this.searchProductBar.TabIndex = 2;
            // 
            // searchProducts
            // 
            this.searchProducts.Location = new System.Drawing.Point(236, 17);
            this.searchProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchProducts.Name = "searchProducts";
            this.searchProducts.Size = new System.Drawing.Size(76, 23);
            this.searchProducts.TabIndex = 1;
            this.searchProducts.Text = "Search";
            this.searchProducts.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Products";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.partsTable);
            this.groupBox2.Controls.Add(this.searchPartsBar);
            this.groupBox2.Controls.Add(this.searchParts);
            this.groupBox2.Controls.Add(this.Parts);
            this.groupBox2.Controls.Add(this.deletePart);
            this.groupBox2.Controls.Add(this.addPart);
            this.groupBox2.Controls.Add(this.modifyPart);
            this.groupBox2.Location = new System.Drawing.Point(29, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 267);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // partsTable
            // 
            this.partsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partID,
            this.partName,
            this.partInvLevel,
            this.partPrice});
            this.partsTable.Location = new System.Drawing.Point(29, 62);
            this.partsTable.Name = "partsTable";
            this.partsTable.Size = new System.Drawing.Size(444, 132);
            this.partsTable.TabIndex = 11;
            // 
            // searchPartsBar
            // 
            this.searchPartsBar.Location = new System.Drawing.Point(353, 19);
            this.searchPartsBar.Name = "searchPartsBar";
            this.searchPartsBar.Size = new System.Drawing.Size(141, 20);
            this.searchPartsBar.TabIndex = 10;
            // 
            // searchParts
            // 
            this.searchParts.Location = new System.Drawing.Point(256, 17);
            this.searchParts.Name = "searchParts";
            this.searchParts.Size = new System.Drawing.Size(75, 23);
            this.searchParts.TabIndex = 9;
            this.searchParts.Text = "Search";
            this.searchParts.UseVisualStyleBackColor = true;
            this.searchParts.Click += new System.EventHandler(this.searchParts_Click);
            // 
            // Parts
            // 
            this.Parts.AutoSize = true;
            this.Parts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parts.Location = new System.Drawing.Point(26, 25);
            this.Parts.Name = "Parts";
            this.Parts.Size = new System.Drawing.Size(40, 15);
            this.Parts.TabIndex = 8;
            this.Parts.Text = "Parts";
            // 
            // exitMainForm
            // 
            this.exitMainForm.Location = new System.Drawing.Point(856, 352);
            this.exitMainForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitMainForm.Name = "exitMainForm";
            this.exitMainForm.Size = new System.Drawing.Size(118, 34);
            this.exitMainForm.TabIndex = 10;
            this.exitMainForm.Text = "Exit";
            this.exitMainForm.UseVisualStyleBackColor = true;
            this.exitMainForm.Click += new System.EventHandler(this.exitMainForm_Click);
            // 
            // partID
            // 
            this.partID.HeaderText = "Part ID";
            this.partID.Name = "partID";
            // 
            // partName
            // 
            this.partName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partName.HeaderText = "Part Name";
            this.partName.Name = "partName";
            // 
            // partInvLevel
            // 
            this.partInvLevel.HeaderText = "Inventory Level";
            this.partInvLevel.Name = "partInvLevel";
            // 
            // partPrice
            // 
            this.partPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partPrice.HeaderText = "Price per Unit";
            this.partPrice.Name = "partPrice";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 392);
            this.Controls.Add(this.exitMainForm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.Button modifyPart;
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchParts;
        private System.Windows.Forms.Label Parts;
        private System.Windows.Forms.TextBox searchPartsBar;
        private System.Windows.Forms.DataGridView partsTable;
        private System.Windows.Forms.DataGridView productsTable;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button modifyProduct;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.TextBox searchProductBar;
        private System.Windows.Forms.Button searchProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitMainForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn partID;
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn partInvLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn partPrice;
    }
}

