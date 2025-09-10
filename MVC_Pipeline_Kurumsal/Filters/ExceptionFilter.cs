// Path: EnterpriseOrderProductApp.Web.Filters.ExceptionFilter.cs
// Type: Class
// Pattern: ExceptionFilter (AOP)
// Purpose: Controller action’larında oluşan hataları yakalar ve loglar.
// SOLID: SRP – Sadece hata yönetimi sorumluluğu taşır.
// AOP Etkileşimi: MVC pipeline’da exception oluştuğunda tetiklenir.

using System.Web.Mvc;
using MVC_Pipeline_Kurumsal.Domain.Interfaces;

namespace MVC_Pipeline_Kurumsal.Filters
{
    public class ExceptionFilter : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            var logger = DependencyResolver.Current.GetService<ILogService>();
            logger.Error($"[Filter] Hata oluştu: {filterContext.Exception.Message}");
        }
    }
}
