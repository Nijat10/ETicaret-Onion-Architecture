using ETicaretAPI.Application.ViewModels.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Product name must have value.")
                .MaximumLength(150)
                .MinimumLength(5)
                    .WithMessage("Product name length must be between 5 and 150.")
                ;

            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Product stock must have value.")
                .Must(s => s >= 0)
                    .WithMessage("Product stock must have non-negative value !");

            RuleFor(p => p.Price)
               .NotEmpty()
               .NotNull()
                   .WithMessage("Product price must have value.")
               .Must(s => s >= 0)
                   .WithMessage("Product price must have non-negative value !");
        }
    }
}
