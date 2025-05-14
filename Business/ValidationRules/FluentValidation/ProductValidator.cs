using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThan(9).When(p => p.CategoryId == 1);
            RuleFor(p => p.UnitsInStock).NotEmpty();
            RuleFor(p => (int)p.UnitsInStock).GreaterThanOrEqualTo(1).WithMessage("Stok adedi 1'den küçük olamaz");
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.ProductName).Must(StartWithA);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A") || arg.StartsWith("a");
        }
    }
}
