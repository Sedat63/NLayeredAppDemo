using FluentValidation;
using NorthwindBusiness.Abstract;
using NorthwindBusiness.Concrete.ValidationRules.FluentValidatio;
using NorthwindBusiness.Utilities;
using NorthwindDataAccess.Abstract;
using NorthwindDataAccess.Concrete;
using NorthwindDataAccess.Concrete.EntityFramework;
using NorthwindEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBusiness.Concrete
{
	public class ProductManager: IProductService
	{
		private IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{			
			_productDal = productDal;
		}

		public void Add(Product product)
		{
			ValidationTool.Validate(new ProductValidator(), product);
			_productDal.Add(product);
		}

		public void Update(Product product)
		{
			ValidationTool.Validate(new ProductValidator(), product);
			_productDal.Update(product);
		}

		public void Delete(Product product)
		{
			try
			{
				_productDal.Delete(product);
			}
			catch
			{

				throw new Exception("Silme Gerçekleşmedi");
			}
		}

		public List<Product> GetAll()
		{
			
			return _productDal.GetAll();
		}

		public List<Product> GetProductsByCategory(int categoryId)
		{
			return _productDal.GetAll(p => p.CategoryId == categoryId);
		}

		public List<Product> GetProductsByProductName(string productName)
		{
			return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
		}
		
	}
}
