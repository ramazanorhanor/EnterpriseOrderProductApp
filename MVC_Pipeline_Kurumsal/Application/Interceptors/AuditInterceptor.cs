// Path: EnterpriseOrderProductApp.Application.Interceptors.AuditInterceptor.cs
// Type: Class
// Pattern: Interceptor (AOP)
// Purpose: Kritik işlemleri kullanıcı ve zaman bilgisiyle izler.
// SOLID: OCP – Yeni audit davranışları eklenebilir.
// AOP Etkileşimi: OrderService.Create() gibi methodlara uygulanır.

//using Castle.DynamicProxy;
using Castle.Core.Interceptor;
using MVC_Pipeline_Kurumsal.Domain.Interfaces;

namespace MVC_Pipeline_Kurumsal.Application.Interceptors
{
    public class AuditInterceptor : IInterceptor
    {
        private readonly ILogService _logger;

        public AuditInterceptor(ILogService logger)
        {
            _logger = logger;
        }

        public void Intercept(IInvocation invocation)
        {
            var user = "system"; // Gerçek projede oturumdan alınır
            _logger.Info($"AUDIT: {user} → {invocation.Method.Name} çağrıldı.");
            invocation.Proceed();
        }
    }
}
