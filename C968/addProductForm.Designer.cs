namespace C968
{
    partial class addProductForm
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
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.invTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchPart = new System.Windows.Forms.Button();
            this.partsSearch = new System.Windows.Forms.TextBox();
            this.addPartsTable = new System.Windows.Forms.DataGridView();
            this.AddPart = new System.Windows.Forms.Button();
            this.currentPartsTable = new System.Windows.Forms.DataGridView();
            this.deletePart = new System.Windows.Forms.Button();
            this.cancelAddProductForm = new System.Windows.Forms.Button();
            this.saveProduct = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.addPartsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPartsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(266, 284);
            this.minTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(52, 20);
            this.minTextBox.TabIndex = 29;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(132, 236);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(105, 20);
            this.priceTextBox.TabIndex = 28;
            // 
            // invTextBox
            // 
            this.invTextBox.Location = new System.Drawing.Point(132, 196);
            this.invTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.invTextBox.Name = "invTextBox";
            this.invTextBox.Size = new System.Drawing.Size(105, 20);
            this.invTextBox.TabIndex = 27;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(132, 152);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(105, 20);
            this.nameTextBox.TabIndex = 26;
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(132, 284);
            this.maxTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(52, 20);
            this.maxTextBox.TabIndex = 25;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(132, 110);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(105, 20);
            this.idTextBox.TabIndex = 24;
            this.idTextBox.Text = "Auto Gen - Disabled";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 284);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 284);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Price/Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Inv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID";
            // 
            // searchPart
            // 
            this.searchPart.Location = new System.Drawing.Point(506, 30);
            this.searchPart.Margin = new System.Windows.Forms.Padding(2);
            this.searchPart.Name = "searchPart";
            this.searchPart.Size = new System.Drawing.Size(84, 29);
            this.searchPart.TabIndex = 30;
            this.searchPart.Text = "Search";
            this.searchPart.UseVisualStyleBackColor = true;
            this.searchPart.Click += new System.EventHandler(this.searchPart_Click);
            // 
            // partsSearch
            // 
            this.partsSearch.Location = new System.Drawing.Point(622, 36);
            this.partsSearch.Margin = new System.Windows.Forms.Padding(2);
            this.partsSearch.Name = "partsSearch";
            this.partsSearch.Size = new System.Drawing.Size(174, 20);
            this.partsSearch.TabIndex = 31;
            // 
            // addPartsTable
            // 
            this.addPartsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addPartsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.addPartsTable.Location = new System.Drawing.Point(408, 76);
            this.addPartsTable.Margin = new System.Windows.Forms.Padding(2);
            this.addPartsTable.Name = "addPartsTable";
            this.addPartsTable.RowTemplate.Height = 33;
            this.addPartsTable.Size = new System.Drawing.Size(478, 113);
            this.addPartsTable.TabIndex = 32;
            // 
            // AddPart
            // 
            this.AddPart.Location = new System.Drawing.Point(782, 201);
            this.AddPart.Margin = new System.Windows.Forms.Padding(2);
            this.AddPart.Name = "AddPart";
            this.AddPart.Size = new System.Drawing.Size(84, 33);
            this.AddPart.TabIndex = 33;
            this.AddPart.Text = "Add";
            this.AddPart.UseVisualStyleBackColor = true;
            this.AddPart.Click += new System.EventHandler(this.AddPart_Click);
            // 
            // currentPartsTable
            // 
            this.currentPartsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentPartsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.currentPartsTable.Location = new System.Drawing.Point(408, 248);
            this.currentPartsTable.Margin = new System.Windows.Forms.Padding(2);
            this.currentPartsTable.Name = "currentPartsTable";
            this.currentPartsTable.RowTemplate.Height = 33;
            this.currentPartsTable.Size = new System.Drawing.Size(478, 120);
            this.currentPartsTable.TabIndex = 34;
            // 
            // deletePart
            // 
            this.deletePart.Location = new System.Drawing.Point(782, 381);
            this.deletePart.Margin = new System.Windows.Forms.Padding(2);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(84, 33);
            this.deletePart.TabIndex = 35;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
            this.deletePart.Click += new System.EventHandler(this.deletePart_Click);
            // 
            // cancelAddProductForm
            // 
            this.cancelAddProductForm.Location = new System.Drawing.Point(782, 434);
            this.cancelAddProductForm.Margin = new System.Windows.Forms.Padding(2);
            this.cancelAddProductForm.Name = "cancelAddProductForm";
            this.cancelAddProductForm.Size = new System.Drawing.Size(84, 33);
            this.cancelAddProductForm.TabIndex = 36;
            this.cancelAddProductForm.Text = "Cancel";
            this.cancelAddProductForm.UseVisualStyleBackColor = true;
            this.cancelAddProductForm.Click += new System.EventHandler(this.cancelAddProductForm_Click);
            // 
            // saveProduct
            // 
            this.saveProduct.Location = new System.Drawing.Point(672, 434);
            this.saveProduct.Margin = new System.Windows.Forms.Padding(2);
            this.saveProduct.Name = "saveProduct";
            this.saveProduct.Size = new System.Drawing.Size(84, 33);
            this.saveProduct.TabIndex = 37;
            this.saveProduct.Text = "Save";
            this.saveProduct.UseVisualStyleBackColor = true;
            this.saveProduct.Click += new System.EventHandler(this.saveProduct_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Part ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Part Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Inventory Level";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Price per Unit";
            this.Column4.Name = "Column4";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Part Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Inventory Level";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Price per Unit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // addProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 491);
            this.Controls.Add(this.saveProduct);
            this.Controls.Add(this.cancelAddProductForm);
            this.Controls.Add(this.deletePart);
            this.Controls.Add(this.currentPartsTable);
            this.Controls.Add(this.AddPart);
            this.Controls.Add(this.addPartsTable);
            this.Controls.Add(this.partsSearch);
            this.Controls.Add(this.searchPart);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.invTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addProductForm";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.addProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addPartsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPartsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox invTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchPart;
        private System.Windows.Forms.TextBox partsSearch;
        private System.Windows.Forms.DataGridView addPartsTable;
        private System.Windows.Forms.Button AddPart;
        private System.Windows.Forms.DataGridView currentPartsTable;
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.Button cancelAddProductForm;
        private System.Windows.Forms.Button saveProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}