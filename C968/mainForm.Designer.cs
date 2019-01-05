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
            this.deleteProduct = new System.Windows.Forms.Button();
            this.modifyProduct = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.searchProductBar = new System.Windows.Forms.TextBox();
            this.searchProducts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.partsTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchPartsBar = new System.Windows.Forms.TextBox();
            this.searchParts = new System.Windows.Forms.Button();
            this.Parts = new System.Windows.Forms.Label();
            this.exitMainForm = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Location = new System.Drawing.Point(50, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventory Management System";
            // 
            // addPart
            // 
            this.addPart.Location = new System.Drawing.Point(202, 406);
            this.addPart.Margin = new System.Windows.Forms.Padding(6);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(232, 71);
            this.addPart.TabIndex = 4;
            this.addPart.Text = "Add";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.addPartsButton_Click);
            // 
            // modifyPart
            // 
            this.modifyPart.Location = new System.Drawing.Point(478, 406);
            this.modifyPart.Margin = new System.Windows.Forms.Padding(6);
            this.modifyPart.Name = "modifyPart";
            this.modifyPart.Size = new System.Drawing.Size(216, 69);
            this.modifyPart.TabIndex = 5;
            this.modifyPart.Text = "Modify";
            this.modifyPart.UseVisualStyleBackColor = true;
            // 
            // deletePart
            // 
            this.deletePart.Location = new System.Drawing.Point(746, 404);
            this.deletePart.Margin = new System.Windows.Forms.Padding(6);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(192, 69);
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
            this.groupBox1.Location = new System.Drawing.Point(1146, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(978, 514);
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
            this.productsTable.Location = new System.Drawing.Point(56, 119);
            this.productsTable.Name = "productsTable";
            this.productsTable.RowTemplate.Height = 33;
            this.productsTable.Size = new System.Drawing.Size(867, 254);
            this.productsTable.TabIndex = 6;
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(703, 403);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(208, 70);
            this.deleteProduct.TabIndex = 5;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = true;
            // 
            // modifyProduct
            // 
            this.modifyProduct.Location = new System.Drawing.Point(449, 403);
            this.modifyProduct.Name = "modifyProduct";
            this.modifyProduct.Size = new System.Drawing.Size(200, 73);
            this.modifyProduct.TabIndex = 4;
            this.modifyProduct.Text = "Modify";
            this.modifyProduct.UseVisualStyleBackColor = true;
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(183, 406);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(224, 68);
            this.addProduct.TabIndex = 3;
            this.addProduct.Text = "Add";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // searchProductBar
            // 
            this.searchProductBar.Location = new System.Drawing.Point(669, 37);
            this.searchProductBar.Name = "searchProductBar";
            this.searchProductBar.Size = new System.Drawing.Size(264, 31);
            this.searchProductBar.TabIndex = 2;
            // 
            // searchProducts
            // 
            this.searchProducts.Location = new System.Drawing.Point(473, 33);
            this.searchProducts.Name = "searchProducts";
            this.searchProducts.Size = new System.Drawing.Size(153, 44);
            this.searchProducts.TabIndex = 1;
            this.searchProducts.Text = "Search";
            this.searchProducts.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
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
            this.groupBox2.Location = new System.Drawing.Point(58, 140);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(1058, 514);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // partsTable
            // 
            this.partsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.partsTable.Location = new System.Drawing.Point(58, 119);
            this.partsTable.Margin = new System.Windows.Forms.Padding(6);
            this.partsTable.Name = "partsTable";
            this.partsTable.Size = new System.Drawing.Size(888, 254);
            this.partsTable.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // searchPartsBar
            // 
            this.searchPartsBar.Location = new System.Drawing.Point(706, 37);
            this.searchPartsBar.Margin = new System.Windows.Forms.Padding(6);
            this.searchPartsBar.Name = "searchPartsBar";
            this.searchPartsBar.Size = new System.Drawing.Size(278, 31);
            this.searchPartsBar.TabIndex = 10;
            // 
            // searchParts
            // 
            this.searchParts.Location = new System.Drawing.Point(512, 33);
            this.searchParts.Margin = new System.Windows.Forms.Padding(6);
            this.searchParts.Name = "searchParts";
            this.searchParts.Size = new System.Drawing.Size(150, 44);
            this.searchParts.TabIndex = 9;
            this.searchParts.Text = "Search";
            this.searchParts.UseVisualStyleBackColor = true;
            // 
            // Parts
            // 
            this.Parts.AutoSize = true;
            this.Parts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parts.Location = new System.Drawing.Point(52, 48);
            this.Parts.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Parts.Name = "Parts";
            this.Parts.Size = new System.Drawing.Size(73, 29);
            this.Parts.TabIndex = 8;
            this.Parts.Text = "Parts";
            // 
            // exitMainForm
            // 
            this.exitMainForm.Location = new System.Drawing.Point(1713, 677);
            this.exitMainForm.Name = "exitMainForm";
            this.exitMainForm.Size = new System.Drawing.Size(235, 65);
            this.exitMainForm.TabIndex = 10;
            this.exitMainForm.Text = "Exit";
            this.exitMainForm.UseVisualStyleBackColor = true;
            this.exitMainForm.Click += new System.EventHandler(this.exitMainForm_Click);
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
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2196, 754);
            this.Controls.Add(this.exitMainForm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
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
    }
}

