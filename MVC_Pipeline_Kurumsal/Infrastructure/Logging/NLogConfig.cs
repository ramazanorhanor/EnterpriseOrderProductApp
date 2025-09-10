// Path: EnterpriseOrderProductApp.Infrastructure.Logging.NLogConfig.cs
// Type: Class
// Pattern: Logging Configuration
// Purpose: NLog yapılandırmasını başlatır.
// AOP Etkileşimi: Interceptor’lar bu yapı üzerinden loglama yapar.

using NLog;
using NLog.Config;
using NLog.Targets;

namespace MVC_Pipeline_Kurumsal.Infrastructure.Logging
{
    public static class NLogConfig
    {
        public static void Configure()
        {
            var config = new LoggingConfiguration();

            var fileTarget = new FileTarget("logfile")
            {
                FileName = "${basedir}/logs/app.log",
                Layout = "${longdate} ${level} ${message} ${exception}"
            };

            config.AddTarget(fileTarget);
            config.AddRule(LogLevel.Info, LogLevel.Fatal, fileTarget);

            LogManager.Configuration = config;
        }
    }
}
