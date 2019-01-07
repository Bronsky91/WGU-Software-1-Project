namespace C968
{
    partial class modifyProductForm
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
            this.saveProduct = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.deletePart = new System.Windows.Forms.Button();
            this.currentPartsTable = new System.Windows.Forms.DataGridView();
            this.addPart = new System.Windows.Forms.Button();
            this.addPartsTable = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.partsSearch = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.currentPartsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPartsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // saveProduct
            // 
            this.saveProduct.Location = new System.Drawing.Point(666, 429);
            this.saveProduct.Margin = new System.Windows.Forms.Padding(2);
            this.saveProduct.Name = "saveProduct";
            this.saveProduct.Size = new System.Drawing.Size(84, 33);
            this.saveProduct.TabIndex = 58;
            this.saveProduct.Text = "Save";
            this.saveProduct.UseVisualStyleBackColor = true;
            this.saveProduct.Click += new System.EventHandler(this.saveProduct_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(776, 429);
            this.cancel.Margin = new System.Windows.Forms.Padding(2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(84, 33);
            this.cancel.TabIndex = 57;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // deletePart
            // 
            this.deletePart.Location = new System.Drawing.Point(776, 375);
            this.deletePart.Margin = new System.Windows.Forms.Padding(2);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(84, 33);
            this.deletePart.TabIndex = 56;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
            this.deletePart.Click += new System.EventHandler(this.deletePart_Click);
            // 
            // currentPartsTable
            // 
            this.currentPartsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentPartsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.currentPartsTable.Location = new System.Drawing.Point(402, 243);
            this.currentPartsTable.Margin = new System.Windows.Forms.Padding(2);
            this.currentPartsTable.Name = "currentPartsTable";
            this.currentPartsTable.RowTemplate.Height = 33;
            this.currentPartsTable.Size = new System.Drawing.Size(478, 120);
            this.currentPartsTable.TabIndex = 55;
            // 
            // addPart
            // 
            this.addPart.Location = new System.Drawing.Point(776, 196);
            this.addPart.Margin = new System.Windows.Forms.Padding(2);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(84, 33);
            this.addPart.TabIndex = 54;
            this.addPart.Text = "Add";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.addPart_Click);
            // 
            // addPartsTable
            // 
            this.addPartsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addPartsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.addPartsTable.Location = new System.Drawing.Point(402, 71);
            this.addPartsTable.Margin = new System.Windows.Forms.Padding(2);
            this.addPartsTable.Name = "addPartsTable";
            this.addPartsTable.RowTemplate.Height = 33;
            this.addPartsTable.Size = new System.Drawing.Size(478, 113);
            this.addPartsTable.TabIndex = 53;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(616, 31);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(174, 20);
            this.searchTextBox.TabIndex = 52;
            // 
            // partsSearch
            // 
            this.partsSearch.Location = new System.Drawing.Point(501, 25);
            this.partsSearch.Margin = new System.Windows.Forms.Padding(2);
            this.partsSearch.Name = "partsSearch";
            this.partsSearch.Size = new System.Drawing.Size(84, 29);
            this.partsSearch.TabIndex = 51;
            this.partsSearch.Text = "Search";
            this.partsSearch.UseVisualStyleBackColor = true;
            this.partsSearch.Click += new System.EventHandler(this.partsSearch_Click);
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(260, 279);
            this.minTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(52, 20);
            this.minTextBox.TabIndex = 50;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(127, 230);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(97, 20);
            this.priceTextBox.TabIndex = 49;
            // 
            // invTextBox
            // 
            this.invTextBox.Location = new System.Drawing.Point(127, 191);
            this.invTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.invTextBox.Name = "invTextBox";
            this.invTextBox.Size = new System.Drawing.Size(97, 20);
            this.invTextBox.TabIndex = 48;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(127, 147);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(97, 20);
            this.nameTextBox.TabIndex = 47;
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(127, 279);
            this.maxTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(52, 20);
            this.maxTextBox.TabIndex = 46;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(127, 105);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(97, 20);
            this.idTextBox.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 279);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 233);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Price/Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Inv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Modify Product";
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
            // modifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 485);
            this.Controls.Add(this.saveProduct);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.deletePart);
            this.Controls.Add(this.currentPartsTable);
            this.Controls.Add(this.addPart);
            this.Controls.Add(this.addPartsTable);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.partsSearch);
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
            this.Name = "modifyProductForm";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.modifyProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currentPartsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPartsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveProduct;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.DataGridView currentPartsTable;
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.DataGridView addPartsTable;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button partsSearch;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}