// Path: EnterpriseOrderProductApp.Web.Config.FilterConfig.cs
// Type: Class
// Purpose: Tüm filtreleri global olarak devreye alır.
// AOP Etkileşimi: MVC pipeline başlangıcında tetiklenir.

using System.Web.Mvc;
using MVC_Pipeline_Kurumsal.Filters;

namespace MVC_Pipeline_Kurumsal.Config
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new LogActionFilter());
            filters.Add(new ExceptionFilter());
            filters.Add(new CustomHeaderFilter());
        }
    }
}
