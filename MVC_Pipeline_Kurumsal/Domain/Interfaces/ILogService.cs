// Path: EnterpriseOrderProductApp.Domain.Interfaces.ILogService.cs
// Type: Interface
// Pattern: Logging Abstraction (AOP)
// Purpose: Loglama işlemlerini soyutlar. NLog gibi altyapılara bağımlılığı azaltır.
// SOLID: DIP – Uygulama, loglama altyapısına değil, bu interface’e bağımlıdır.
// AOP Etkileşimi: Interceptor’lar bu interface üzerinden loglama yapar.

namespace MVC_Pipeline_Kurumsal.Domain.Interfaces
{
    public interface ILogService
    {
        void Info(string message);
        void Error(string message);
        void Warn(string message);
    }
}
