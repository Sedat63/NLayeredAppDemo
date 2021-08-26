using FluentValidation;
using NorthwindEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBusiness.Concrete.ValidationRules.FluentValidatio
{
	public class ProductValidator:AbstractValidator<Product>
	{
		public ProductValidator()
		{
			RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün ismi boş olamaz!");
			RuleFor(p => p.CategoryId).NotEmpty();
			RuleFor(p => p.UnitPrice).NotEmpty();
			RuleFor(p => p.QuantityPerUnit).NotEmpty();
			RuleFor(p => p.UnitsInStock).NotEmpty();

			RuleFor(p => p.UnitPrice).GreaterThan(0);
			RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);
			RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2);

			//kendi kuralımızı oluşturuyoruz.
			RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürün Adı A ile başlamalı");
		}

		private bool StartWithA(string arg)
		{
			return arg.StartsWith("A");
		}
	}
}
