// Path: EnterpriseOrderProductApp.Web.Filters.LogActionFilter.cs
// Type: Class
// Pattern: ActionFilter (AOP)
// Purpose: Action method çağrısı öncesi ve sonrası loglama yapar.
// SOLID: SRP – Sadece loglama sorumluluğu taşır.
// AOP Etkileşimi: MVC pipeline’da action methodlar çalışmadan önce ve sonra tetiklenir.

using System.Web.Mvc;
using MVC_Pipeline_Kurumsal.Domain.Interfaces;

namespace MVC_Pipeline_Kurumsal.Filters
{
    public class LogActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var logger = DependencyResolver.Current.GetService<ILogService>();
            var action = filterContext.ActionDescriptor.ActionName;
            logger.Info($"[Filter] Action başlıyor: {action}");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var logger = DependencyResolver.Current.GetService<ILogService>();
            var action = filterContext.ActionDescriptor.ActionName;
            logger.Info($"[Filter] Action tamamlandı: {action}");
        }
    }
}
