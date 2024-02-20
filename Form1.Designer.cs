namespace InventoryManager
{
    partial class inventotyManagementStudio
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
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.itemSku = new System.Windows.Forms.TextBox();
            this.inventoryGridView = new System.Windows.Forms.DataGridView();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.itemPrice = new System.Windows.Forms.TextBox();
            this.itemName = new System.Windows.Forms.TextBox();
            this.itemDescription = new System.Windows.Forms.TextBox();
            this.itemQuantity = new System.Windows.Forms.TextBox();
            this.itemCategory = new System.Windows.Forms.ComboBox();
            this.labelSku = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1215, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management Studio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // itemSku
            // 
            this.itemSku.Location = new System.Drawing.Point(12, 102);
            this.itemSku.Name = "itemSku";
            this.itemSku.Size = new System.Drawing.Size(363, 22);
            this.itemSku.TabIndex = 1;
            // 
            // inventoryGridView
            // 
            this.inventoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryGridView.BackgroundColor = System.Drawing.Color.White;
            this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGridView.Location = new System.Drawing.Point(12, 251);
            this.inventoryGridView.Name = "inventoryGridView";
            this.inventoryGridView.RowHeadersWidth = 51;
            this.inventoryGridView.RowTemplate.Height = 24;
            this.inventoryGridView.Size = new System.Drawing.Size(1215, 487);
            this.inventoryGridView.TabIndex = 2;
            this.inventoryGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryGridView_CellDoubleClick);
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(12, 206);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(172, 39);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(436, 206);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(172, 39);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(864, 206);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(172, 39);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // itemPrice
            // 
            this.itemPrice.Location = new System.Drawing.Point(12, 165);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(363, 22);
            this.itemPrice.TabIndex = 6;
            // 
            // itemName
            // 
            this.itemName.Location = new System.Drawing.Point(436, 102);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(363, 22);
            this.itemName.TabIndex = 7;
            // 
            // itemDescription
            // 
            this.itemDescription.Location = new System.Drawing.Point(436, 165);
            this.itemDescription.Name = "itemDescription";
            this.itemDescription.Size = new System.Drawing.Size(363, 22);
            this.itemDescription.TabIndex = 8;
            // 
            // itemQuantity
            // 
            this.itemQuantity.Location = new System.Drawing.Point(864, 165);
            this.itemQuantity.Name = "itemQuantity";
            this.itemQuantity.Size = new System.Drawing.Size(363, 22);
            this.itemQuantity.TabIndex = 10;
            // 
            // itemCategory
            // 
            this.itemCategory.FormattingEnabled = true;
            this.itemCategory.Items.AddRange(new object[] {
            "Produce",
            "Meats",
            "Seafood",
            "Spices"});
            this.itemCategory.Location = new System.Drawing.Point(864, 100);
            this.itemCategory.Name = "itemCategory";
            this.itemCategory.Size = new System.Drawing.Size(363, 24);
            this.itemCategory.TabIndex = 11;
            // 
            // labelSku
            // 
            this.labelSku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSku.Location = new System.Drawing.Point(12, 70);
            this.labelSku.Name = "labelSku";
            this.labelSku.Size = new System.Drawing.Size(454, 29);
            this.labelSku.TabIndex = 12;
            this.labelSku.Text = "SKU:";
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(436, 70);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(363, 29);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Name:";
            // 
            // labelCategory
            // 
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(864, 68);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(363, 29);
            this.labelCategory.TabIndex = 14;
            this.labelCategory.Text = "Category:";
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(12, 133);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(363, 29);
            this.labelPrice.TabIndex = 15;
            this.labelPrice.Text = "Price:";
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(436, 133);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(363, 29);
            this.labelDescription.TabIndex = 16;
            this.labelDescription.Text = "Description:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(864, 133);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(363, 29);
            this.labelQuantity.TabIndex = 17;
            this.labelQuantity.Text = "Quantity:";
            // 
            // inventotyManagementStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(989, 756);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSku);
            this.Controls.Add(this.itemCategory);
            this.Controls.Add(this.itemQuantity);
            this.Controls.Add(this.itemDescription);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.itemPrice);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.inventoryGridView);
            this.Controls.Add(this.itemSku);
            this.Controls.Add(this.label1);
            this.Name = "inventotyManagementStudio";
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.inventoryManagementStudio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TextBox itemSku;
        private System.Windows.Forms.DataGridView inventoryGridView;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox itemPrice;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.TextBox itemDescription;
        private System.Windows.Forms.TextBox itemQuantity;
        private System.Windows.Forms.ComboBox itemCategory;
        private System.Windows.Forms.Label labelSku;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelQuantity;
    }
}

