using NorthwindBusiness.Abstract;
using NorthwindBusiness.Concrete;
using NorthwindBusiness.DependencyResolvers.Ninject;
using NorthwindDataAccess.Concrete.EntityFramework;
using NorthwindDataAccess.Concrete.NHibernate;
using NorthwindEntities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindWebFormsUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			_productService = InstanceFactory.GetInstance<IProductService>();
			_categoryService = InstanceFactory.GetInstance<ICategoryService>();
		}

		private IProductService _productService;
		private ICategoryService _categoryService;

		private void Form1_Load(object sender, EventArgs e)
		{
			//ProductManager productManager = new ProductManager(new NhProductDal());
			LoadProducts();
			LoadCategories();

		}

		private void LoadCategories() //Generate Method
		{
			cbxCategory.DataSource = _categoryService.GetAll();
			cbxCategory.DisplayMember = "CategoryName";
			cbxCategory.ValueMember = "CategoryId";

			cbxCategory2.DataSource = _categoryService.GetAll();
			cbxCategory2.DisplayMember = "CategoryName";
			cbxCategory2.ValueMember = "CategoryId";

			cbxUpdateCategory2.DataSource = _categoryService.GetAll();
			cbxUpdateCategory2.DisplayMember = "CategoryName";
			cbxUpdateCategory2.ValueMember = "CategoryId";
		}

		private void LoadProducts()
		{
			dgwProduct.DataSource = _productService.GetAll();
		}

		private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
			}
			catch
			{


			}
		}

		private void tbxProductName_TextChanged(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(tbxProductName.Text))
			{
				dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
			}
			else
			{
				LoadProducts();
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				_productService.Add(new Product
				{
					CategoryId = Convert.ToInt32(cbxCategory2.SelectedValue),
					ProductName = tbxProductName2.Text,
					QuantityPerUnit = tbxQuantityPerUnit.Text,
					UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
					UnitsInStock = Convert.ToInt16(tbxUnitsInStock.Text)
				});
				MessageBox.Show("Ürün Eklendi!");
				LoadProducts();
			}
			catch (Exception exception)
			{

				MessageBox.Show(exception.Message);
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				_productService.Update(new Product
				{
					ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
					ProductName = tbxUpdateProductName2.Text,
					CategoryId = Convert.ToInt32(cbxUpdateCategory2.SelectedValue),
					QuantityPerUnit = tbxUpdateQuantityPerUnit.Text,
					UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
					UnitsInStock = Convert.ToInt16(tbxUpdateUnitsInStock.Text),

				});
				MessageBox.Show("Ürün Güncellendi!");
				LoadProducts();
			}
			catch (Exception exception)
			{

				MessageBox.Show(exception.Message);
			}
		}

		private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var row = dgwProduct.CurrentRow;
			tbxUpdateProductName2.Text = row.Cells[2].Value.ToString();
			cbxUpdateCategory2.SelectedValue = row.Cells[1].Value.ToString();
			tbxUpdateQuantityPerUnit.Text = row.Cells[4].Value.ToString();
			tbxUpdateUnitPrice.Text = row.Cells[3].Value.ToString();
			tbxUpdateUnitsInStock.Text = row.Cells[5].Value.ToString();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgwProduct.CurrentRow!=null)
			{
				try
				{
					_productService.Delete(new Product
					{
						ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
					});
					MessageBox.Show("Ürün Silindi!");
					LoadProducts();
				}
				catch (Exception exception)
				{
					MessageBox.Show(exception.Message);
				}				
			}			
		}
	}
}
