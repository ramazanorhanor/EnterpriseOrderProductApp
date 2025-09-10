// Path: EnterpriseOrderProductApp.Validation.OrderValidator.cs
// Type: Class
// Implements: AbstractValidator<OrderDto>
// Pattern: FluentValidation RuleSet
// Purpose: OrderDto için doğrulama kurallarını tanımlar.
// SOLID: SRP – Sadece doğrulama sorumluluğu taşır.
// AOP Etkileşimi: OrderService.Create() çağrısından önce ValidationInterceptor ile tetiklenir.

using FluentValidation;
using MVC_Pipeline_Kurumsal.Application.DTOs;

namespace MVC_Pipeline_Kurumsal.Validation
{
    public class OrderValidator : AbstractValidator<OrderDto>
    {
        public OrderValidator()
        {
            RuleFor(x => x.ProductId)
                .GreaterThan(0).WithMessage("Geçerli bir ürün seçilmelidir.");

            RuleFor(x => x.Quantity)
                .GreaterThan(0).WithMessage("Adet en az 1 olmalıdır.");

            RuleFor(x => x.CustomerName)
                .NotEmpty().WithMessage("Müşteri adı zorunludur.")
                .MaximumLength(250).WithMessage("Müşteri adı en fazla 250 karakter olabilir.");

            RuleFor(x => x.CustomerEmail)
                .EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz.");
        }
    }
}
