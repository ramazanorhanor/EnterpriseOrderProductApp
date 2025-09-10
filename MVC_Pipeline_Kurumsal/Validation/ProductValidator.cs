// Path: EnterpriseOrderProductApp.Validation.ProductValidator.cs
// Type: Class
// Implements: AbstractValidator<ProductDto>
// Pattern: FluentValidation RuleSet
// Purpose: ProductDto için doğrulama kurallarını tanımlar.
// SOLID: SRP – Sadece doğrulama sorumluluğu taşır.
// AOP Etkileşimi: ProductService.Create() çağrısından önce ValidationInterceptor ile tetiklenir.

using FluentValidation;
using MVC_Pipeline_Kurumsal.Application.DTOs;

namespace MVC_Pipeline_Kurumsal.Validation
{
    public class ProductValidator : AbstractValidator<ProductDto>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Ürün adı boş olamaz.")
                .MaximumLength(100).WithMessage("Ürün adı en fazla 100 karakter olabilir.");

            RuleFor(x => x.Price)
                .GreaterThan(0).WithMessage("Fiyat sıfırdan büyük olmalıdır.");

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Açıklama en fazla 500 karakter olabilir.");
        }
    }
}
