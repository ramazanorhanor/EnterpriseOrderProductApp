// Path: EnterpriseOrderProductApp.Web.Attributes.LogActionAttribute.cs
// Type: Attribute
// Pattern: Decorator (AOP)
// Purpose: Action method çağrısını loglar.
// SOLID: OCP – Yeni loglama davranışı eklenebilir.
// AOP Etkileşimi: Controller action’larına uygulandığında loglama sağlar.

using System;
using System.Web.Mvc;
using MVC_Pipeline_Kurumsal.Domain.Interfaces;

namespace MVC_Pipeline_Kurumsal.Attributes
{
    public class LogActionAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var logger = DependencyResolver.Current.GetService<ILog>();
            var actionName = filterContext.ActionDescriptor.ActionName;
            logger.Info($"Action başlıyor: {actionName}");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var logger = DependencyResolver.Current.GetService<ILog>();
            var actionName = filterContext.ActionDescriptor.ActionName;
            logger.Info($"Action tamamlandı: {actionName}");
        }
    }
}