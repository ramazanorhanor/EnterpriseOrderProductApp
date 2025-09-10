// Path: EnterpriseOrderProductApp.Web.Filters.CustomHeaderFilter.cs
// Type: Class
// Pattern: ResultFilter (AOP)
// Purpose: Response’a özel header ekler.
// SOLID: SRP – Sadece response manipülasyonu sorumluluğu taşır.
// AOP Etkileşimi: MVC pipeline’da result render edilmeden önce ve sonra tetiklenir.

using System.Web.Mvc;

namespace MVC_Pipeline_Kurumsal.Filters
{
    public class CustomHeaderFilter : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Headers.Add("X-Audit-Trace", "Enabled");
        }
    }
}
