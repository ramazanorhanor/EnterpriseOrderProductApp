// Path: EnterpriseOrderProductApp.Infrastructure.Logging.NLogTarget.cs
// Type: Class
// Pattern: Logging Target Definition
// Purpose: NLog ile dosya tabanlı loglama hedefini tanımlar.
// SOLID: SRP – Sadece log hedefi tanımıyla ilgilenir.
// AOP Etkileşimi: LoggingInterceptor bu hedefe log gönderir.

using NLog;
using NLog.Targets;

namespace MVC_Pipeline_Kurumsal.Infrastructure.Logging
{
    public static class NLogTarget
    {
        public static FileTarget CreateFileTarget()
        {
            return new FileTarget("logfile")
            {
                FileName = "${basedir}/logs/app.log",
                Layout = "${longdate} ${level} ${message} ${exception}"
            };
        }
    }
}
