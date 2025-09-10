// Path: EnterpriseOrderProductApp.Web.Attributes.PermissionAttribute.cs
// Type: Attribute
// Pattern: Decorator (AOP)
// Purpose: Action method’a erişim yetkisi kontrolü ekler.
// SOLID: OCP – Yeni yetki kontrol davranışları eklenebilir.
// AOP Etkileşimi: Controller action’larına uygulandığında kullanıcı rolü kontrol edilir.

using System;
using System.Web.Mvc;
namespace MVC_Pipeline_Kurumsal.Attributes
{
    public class PermissionAttribute : AuthorizeAttribute
    {
        private readonly string _role;

        public PermissionAttribute(string role)
        {
            _role = role;
        }

        protected override bool AuthorizeCore(System.Web.HttpContextBase httpContext)
        {
            // Gerçek projede oturumdan rol alınır
            var userRole = "User"; // örnek
            return userRole == _role;
        }
    }
}