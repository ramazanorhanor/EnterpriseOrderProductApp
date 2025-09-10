// Path: EnterpriseOrderProductApp.Domain.Interfaces.ILogService.cs
// Type: Interface
// Pattern: Logging Abstraction (AOP)
// Purpose: Loglama işlemlerini soyutlar. NLog gibi altyapılara bağımlılığı azaltır.
// SOLID: DIP – Uygulama, loglama altyapısına değil, bu interface’e bağımlıdır.
// AOP Etkileşimi: Interceptor’lar bu interface üzerinden loglama yapar.

namespace MVC_Pipeline_Kurumsal.Domain.Interfaces
{
    public interface ILog
    {
        void Info(string message);     // Bilgilendirme logu
        void Warn(string message);     // Uyarı logu
        void Error(string message);    // Hata logu
    }
}
// Path: EnterpriseOrderProductApp.Domain.Interfaces.ILog.cs
// Purpose: Tüm loglama işlemlerini soyutlar
// SOLID: Interface Segregation + Dependency Inversion
// Gerçek Dünya Sorunu: Loglama kodu her yere dağılırsa maintainability düşer
// Kullanıldığı Yer: ProductService, OrderService, Interceptor’lar