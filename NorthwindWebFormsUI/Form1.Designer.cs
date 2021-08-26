
namespace NorthwindWebFormsUI
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
			this.lblCategory = new System.Windows.Forms.Label();
			this.cbxCategory = new System.Windows.Forms.ComboBox();
			this.gbxProductName = new System.Windows.Forms.GroupBox();
			this.tbxProductName = new System.Windows.Forms.TextBox();
			this.lblProductName = new System.Windows.Forms.Label();
			this.gbxAddProduct = new System.Windows.Forms.GroupBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
			this.tbxUnitsInStock = new System.Windows.Forms.TextBox();
			this.tbxUnitPrice = new System.Windows.Forms.TextBox();
			this.tbxProductName2 = new System.Windows.Forms.TextBox();
			this.cbxCategory2 = new System.Windows.Forms.ComboBox();
			this.lblQuantityPerUnit = new System.Windows.Forms.Label();
			this.lblUnitsInStock = new System.Windows.Forms.Label();
			this.lblUnitPrice = new System.Windows.Forms.Label();
			this.lblCategory2 = new System.Windows.Forms.Label();
			this.lblProductName2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.tbxUpdateQuantityPerUnit = new System.Windows.Forms.TextBox();
			this.tbxUpdateUnitsInStock = new System.Windows.Forms.TextBox();
			this.tbxUpdateUnitPrice = new System.Windows.Forms.TextBox();
			this.tbxUpdateProductName2 = new System.Windows.Forms.TextBox();
			this.cbxUpdateCategory2 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
			this.gbxCategory.SuspendLayout();
			this.gbxProductName.SuspendLayout();
			this.gbxAddProduct.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgwProduct
			// 
			this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwProduct.Location = new System.Drawing.Point(8, 169);
			this.dgwProduct.Name = "dgwProduct";
			this.dgwProduct.Size = new System.Drawing.Size(656, 220);
			this.dgwProduct.TabIndex = 0;
			this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
			// 
			// gbxCategory
			// 
			this.gbxCategory.Controls.Add(this.lblCategory);
			this.gbxCategory.Controls.Add(this.cbxCategory);
			this.gbxCategory.Location = new System.Drawing.Point(8, 12);
			this.gbxCategory.Name = "gbxCategory";
			this.gbxCategory.Size = new System.Drawing.Size(656, 65);
			this.gbxCategory.TabIndex = 1;
			this.gbxCategory.TabStop = false;
			this.gbxCategory.Text = "Kategoriye Göre Ara";
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Location = new System.Drawing.Point(6, 27);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(52, 13);
			this.lblCategory.TabIndex = 1;
			this.lblCategory.Text = "Kategori :";
			// 
			// cbxCategory
			// 
			this.cbxCategory.FormattingEnabled = true;
			this.cbxCategory.Location = new System.Drawing.Point(88, 24);
			this.cbxCategory.Name = "cbxCategory";
			this.cbxCategory.Size = new System.Drawing.Size(306, 21);
			this.cbxCategory.TabIndex = 0;
			this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
			// 
			// gbxProductName
			// 
			this.gbxProductName.Controls.Add(this.tbxProductName);
			this.gbxProductName.Controls.Add(this.lblProductName);
			this.gbxProductName.Location = new System.Drawing.Point(8, 87);
			this.gbxProductName.Name = "gbxProductName";
			this.gbxProductName.Size = new System.Drawing.Size(656, 62);
			this.gbxProductName.TabIndex = 2;
			this.gbxProductName.TabStop = false;
			this.gbxProductName.Text = "Ürün Adına Göre Ara";
			// 
			// tbxProductName
			// 
			this.tbxProductName.Location = new System.Drawing.Point(88, 21);
			this.tbxProductName.Name = "tbxProductName";
			this.tbxProductName.Size = new System.Drawing.Size(306, 20);
			this.tbxProductName.TabIndex = 2;
			this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Location = new System.Drawing.Point(6, 24);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(54, 13);
			this.lblProductName.TabIndex = 1;
			this.lblProductName.Text = "Ürün Adı :";
			// 
			// gbxAddProduct
			// 
			this.gbxAddProduct.Controls.Add(this.btnAdd);
			this.gbxAddProduct.Controls.Add(this.tbxQuantityPerUnit);
			this.gbxAddProduct.Controls.Add(this.tbxUnitsInStock);
			this.gbxAddProduct.Controls.Add(this.tbxUnitPrice);
			this.gbxAddProduct.Controls.Add(this.tbxProductName2);
			this.gbxAddProduct.Controls.Add(this.cbxCategory2);
			this.gbxAddProduct.Controls.Add(this.lblQuantityPerUnit);
			this.gbxAddProduct.Controls.Add(this.lblUnitsInStock);
			this.gbxAddProduct.Controls.Add(this.lblUnitPrice);
			this.gbxAddProduct.Controls.Add(this.lblCategory2);
			this.gbxAddProduct.Controls.Add(this.lblProductName2);
			this.gbxAddProduct.Location = new System.Drawing.Point(8, 406);
			this.gbxAddProduct.Name = "gbxAddProduct";
			this.gbxAddProduct.Size = new System.Drawing.Size(656, 143);
			this.gbxAddProduct.TabIndex = 3;
			this.gbxAddProduct.TabStop = false;
			this.gbxAddProduct.Text = "Yeni Ürün Ekle";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(452, 97);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(172, 34);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Ekle";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// tbxQuantityPerUnit
			// 
			this.tbxQuantityPerUnit.Location = new System.Drawing.Point(434, 67);
			this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
			this.tbxQuantityPerUnit.Size = new System.Drawing.Size(205, 20);
			this.tbxQuantityPerUnit.TabIndex = 2;
			// 
			// tbxUnitsInStock
			// 
			this.tbxUnitsInStock.Location = new System.Drawing.Point(434, 24);
			this.tbxUnitsInStock.Name = "tbxUnitsInStock";
			this.tbxUnitsInStock.Size = new System.Drawing.Size(205, 20);
			this.tbxUnitsInStock.TabIndex = 2;
			// 
			// tbxUnitPrice
			// 
			this.tbxUnitPrice.Location = new System.Drawing.Point(73, 105);
			this.tbxUnitPrice.Name = "tbxUnitPrice";
			this.tbxUnitPrice.Size = new System.Drawing.Size(205, 20);
			this.tbxUnitPrice.TabIndex = 2;
			// 
			// tbxProductName2
			// 
			this.tbxProductName2.Location = new System.Drawing.Point(73, 24);
			this.tbxProductName2.Name = "tbxProductName2";
			this.tbxProductName2.Size = new System.Drawing.Size(205, 20);
			this.tbxProductName2.TabIndex = 2;
			// 
			// cbxCategory2
			// 
			this.cbxCategory2.FormattingEnabled = true;
			this.cbxCategory2.Location = new System.Drawing.Point(73, 67);
			this.cbxCategory2.Name = "cbxCategory2";
			this.cbxCategory2.Size = new System.Drawing.Size(205, 21);
			this.cbxCategory2.TabIndex = 1;
			// 
			// lblQuantityPerUnit
			// 
			this.lblQuantityPerUnit.AutoSize = true;
			this.lblQuantityPerUnit.Location = new System.Drawing.Point(360, 70);
			this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
			this.lblQuantityPerUnit.Size = new System.Drawing.Size(65, 13);
			this.lblQuantityPerUnit.TabIndex = 0;
			this.lblQuantityPerUnit.Text = "Birim Adedi :";
			// 
			// lblUnitsInStock
			// 
			this.lblUnitsInStock.AutoSize = true;
			this.lblUnitsInStock.Location = new System.Drawing.Point(360, 27);
			this.lblUnitsInStock.Name = "lblUnitsInStock";
			this.lblUnitsInStock.Size = new System.Drawing.Size(68, 13);
			this.lblUnitsInStock.TabIndex = 0;
			this.lblUnitsInStock.Text = "Stok Adedi : ";
			// 
			// lblUnitPrice
			// 
			this.lblUnitPrice.AutoSize = true;
			this.lblUnitPrice.Location = new System.Drawing.Point(15, 108);
			this.lblUnitPrice.Name = "lblUnitPrice";
			this.lblUnitPrice.Size = new System.Drawing.Size(35, 13);
			this.lblUnitPrice.TabIndex = 0;
			this.lblUnitPrice.Text = "Fiyat :";
			// 
			// lblCategory2
			// 
			this.lblCategory2.AutoSize = true;
			this.lblCategory2.Location = new System.Drawing.Point(15, 70);
			this.lblCategory2.Name = "lblCategory2";
			this.lblCategory2.Size = new System.Drawing.Size(52, 13);
			this.lblCategory2.TabIndex = 0;
			this.lblCategory2.Text = "Kategori :";
			// 
			// lblProductName2
			// 
			this.lblProductName2.AutoSize = true;
			this.lblProductName2.Location = new System.Drawing.Point(15, 27);
			this.lblProductName2.Name = "lblProductName2";
			this.lblProductName2.Size = new System.Drawing.Size(54, 13);
			this.lblProductName2.TabIndex = 0;
			this.lblProductName2.Text = "Ürün Adı :";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnDelete);
			this.groupBox1.Controls.Add(this.btnUpdate);
			this.groupBox1.Controls.Add(this.tbxUpdateQuantityPerUnit);
			this.groupBox1.Controls.Add(this.tbxUpdateUnitsInStock);
			this.groupBox1.Controls.Add(this.tbxUpdateUnitPrice);
			this.groupBox1.Controls.Add(this.tbxUpdateProductName2);
			this.groupBox1.Controls.Add(this.cbxUpdateCategory2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Location = new System.Drawing.Point(8, 559);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(656, 148);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ürün Güncelle";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(513, 97);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(126, 28);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// tbxUpdateQuantityPerUnit
			// 
			this.tbxUpdateQuantityPerUnit.Location = new System.Drawing.Point(434, 67);
			this.tbxUpdateQuantityPerUnit.Name = "tbxUpdateQuantityPerUnit";
			this.tbxUpdateQuantityPerUnit.Size = new System.Drawing.Size(205, 20);
			this.tbxUpdateQuantityPerUnit.TabIndex = 2;
			// 
			// tbxUpdateUnitsInStock
			// 
			this.tbxUpdateUnitsInStock.Location = new System.Drawing.Point(434, 24);
			this.tbxUpdateUnitsInStock.Name = "tbxUpdateUnitsInStock";
			this.tbxUpdateUnitsInStock.Size = new System.Drawing.Size(205, 20);
			this.tbxUpdateUnitsInStock.TabIndex = 2;
			// 
			// tbxUpdateUnitPrice
			// 
			this.tbxUpdateUnitPrice.Location = new System.Drawing.Point(73, 105);
			this.tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
			this.tbxUpdateUnitPrice.Size = new System.Drawing.Size(205, 20);
			this.tbxUpdateUnitPrice.TabIndex = 2;
			// 
			// tbxUpdateProductName2
			// 
			this.tbxUpdateProductName2.Location = new System.Drawing.Point(73, 24);
			this.tbxUpdateProductName2.Name = "tbxUpdateProductName2";
			this.tbxUpdateProductName2.Size = new System.Drawing.Size(205, 20);
			this.tbxUpdateProductName2.TabIndex = 2;
			// 
			// cbxUpdateCategory2
			// 
			this.cbxUpdateCategory2.FormattingEnabled = true;
			this.cbxUpdateCategory2.Location = new System.Drawing.Point(73, 67);
			this.cbxUpdateCategory2.Name = "cbxUpdateCategory2";
			this.cbxUpdateCategory2.Size = new System.Drawing.Size(205, 21);
			this.cbxUpdateCategory2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(360, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Birim Adedi :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(360, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Stok Adedi : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Fiyat :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Kategori :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 27);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Ürün Adı :";
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(363, 100);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(124, 23);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(674, 737);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gbxAddProduct);
			this.Controls.Add(this.gbxProductName);
			this.Controls.Add(this.gbxCategory);
			this.Controls.Add(this.dgwProduct);
			this.Name = "Form1";
			this.Text = "Ürünler";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
			this.gbxCategory.ResumeLayout(false);
			this.gbxCategory.PerformLayout();
			this.gbxProductName.ResumeLayout(false);
			this.gbxProductName.PerformLayout();
			this.gbxAddProduct.ResumeLayout(false);
			this.gbxAddProduct.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwProduct;
		private System.Windows.Forms.GroupBox gbxCategory;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.ComboBox cbxCategory;
		private System.Windows.Forms.GroupBox gbxProductName;
		private System.Windows.Forms.TextBox tbxProductName;
		private System.Windows.Forms.Label lblProductName;
		private System.Windows.Forms.GroupBox gbxAddProduct;
		private System.Windows.Forms.Label lblQuantityPerUnit;
		private System.Windows.Forms.Label lblUnitsInStock;
		private System.Windows.Forms.Label lblUnitPrice;
		private System.Windows.Forms.Label lblCategory2;
		private System.Windows.Forms.Label lblProductName2;
		private System.Windows.Forms.ComboBox cbxCategory2;
		private System.Windows.Forms.TextBox tbxQuantityPerUnit;
		private System.Windows.Forms.TextBox tbxUnitsInStock;
		private System.Windows.Forms.TextBox tbxUnitPrice;
		private System.Windows.Forms.TextBox tbxProductName2;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.TextBox tbxUpdateQuantityPerUnit;
		private System.Windows.Forms.TextBox tbxUpdateUnitsInStock;
		private System.Windows.Forms.TextBox tbxUpdateUnitPrice;
		private System.Windows.Forms.TextBox tbxUpdateProductName2;
		private System.Windows.Forms.ComboBox cbxUpdateCategory2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnDelete;
	}
}

