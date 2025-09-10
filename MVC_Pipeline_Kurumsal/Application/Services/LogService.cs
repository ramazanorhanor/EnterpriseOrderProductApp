// Path: EnterpriseOrderProductApp.Infrastructure.Logging.LogService.cs
// Purpose: ILog interface’ini NLog ile uygular
// SOLID: Open/Closed – farklı log altyapılarına açık, mevcut davranışa kapalı
// AOP Etkileşimi: Interceptor’lar bu sınıfı kullanabilir
// Gerçek Dünya Karşılığı: NLog, Serilog gibi altyapılarla loglama sağlar
using MVC_Pipeline_Kurumsal.Domain.Interfaces;
using NLog;
namespace MVC_Pipeline_Kurumsal.Application.Services
{
    public class LogService : ILog
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public void Info(string message)
        {
            _logger.Info(message); // Bilgilendirme logu
        }

        public void Warn(string message)
        {
            _logger.Warn(message); // Uyarı logu
        }

        public void Error(string message)
        {
            _logger.Error(message); // Hata logu
        }
    }
}
// Path: EnterpriseOrderProductApp.Infrastructure.Logging.LogService.cs
// Purpose: ILog interface’ini NLog ile uygular
// SOLID: Open/Closed – farklı log altyapılarına açık, mevcut davranışa kapalı
// AOP Etkileşimi: Interceptor’lar bu sınıfı kullanabilir
// Gerçek Dünya Karşılığı: NLog, Serilog gibi altyapılarla loglama sağlar

