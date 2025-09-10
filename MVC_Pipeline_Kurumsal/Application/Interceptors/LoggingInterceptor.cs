// Path: EnterpriseOrderProductApp.Application.Interceptors.LoggingInterceptor.cs
// Type: Class
// Pattern: Interceptor (AOP)
// Purpose: Tüm servis methodlarını çağrı öncesi ve sonrası loglar.
// SOLID: OCP – Yeni loglama davranışı eklenebilir.
// AOP Etkileşimi: DI Container üzerinden servis methodlarını sarar.

using Castle.Core.Interceptor;
//using Castle.DynamicProxy;
using MVC_Pipeline_Kurumsal.Domain.Interfaces;

namespace MVC_Pipeline_Kurumsal.Application.Interceptors
{
    public class LoggingInterceptor : IInterceptor
    {
        private readonly ILog _logger;

        public LoggingInterceptor(ILog logger)
        {
            _logger = logger;
        }

        public void Intercept(IInvocation invocation)
        {
            _logger.Info($"Method başlıyor: {invocation.Method.Name}");
            invocation.Proceed();
            _logger.Info($"Method tamamlandı: {invocation.Method.Name}");
        }
    }
}
