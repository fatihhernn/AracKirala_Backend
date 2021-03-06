
using log4net;
using log4net.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;

namespace Core.CrossCuttingConcerns.Logging.Log4Net
{
    //log4net implemente edelim
    public class LoggerServiceBase //süper class alacaz, inheritance alacağımız bir base olacak.
    {
        private ILog _log;
        public LoggerServiceBase(string name) //string name => loglama tipini vercez. json vs database
        {
            //config dosyasını okumak gerekiyor
            XmlDocument xmlDocument = new XmlDocument();

            //dosyayı okuyacağımızı söylüyoruz
            xmlDocument.Load(File.OpenRead("log4net.config")); //=> çalışan proje içinde arar bunu

            //ILoggerRepository sayesinde reposiyory oluşturcaz, "assembly" ver daha sonra "repository type" ver
            ILoggerRepository loggerRepository = LogManager.CreateRepository(Assembly.GetEntryAssembly(), typeof(log4net.Repository.Hierarchy.Hierarchy));

            //configurasyon yapalım
            log4net.Config.XmlConfigurator.Configure(loggerRepository, xmlDocument["log4net"]);

            //ilgili config içerisindeki ilgili "name" parametsindeki gönderilen Logger'ı al
            _log = LogManager.GetLogger(loggerRepository.Name, name);
        }

        //levels
        public bool IsInfoEnabled => _log.IsInfoEnabled;
        public bool IsDebugEnabled => _log.IsDebugEnabled;
        public bool IsWarnEnabled => _log.IsWarnEnabled;
        public bool IsFatalEnabled => _log.IsFatalEnabled;
        public bool IsErrorEnabled => _log.IsErrorEnabled;


        public void Info(object logMessage)
        {
            if (IsInfoEnabled)
            {
                _log.Info(logMessage);
            }            
        }
        public void Debug(object logMessage)
        {
            if (IsDebugEnabled)
            {
                _log.Debug(logMessage);
            }
        }
        public void Warn(object logMessage)
        {
            if (IsDebugEnabled)
            {
                _log.Warn(logMessage);
            }
        }
        public void Fatal(object logMessage)
        {
            if (IsDebugEnabled)
            {
                _log.Fatal(logMessage);
            }
        }
        public void Error(object logMessage)
        {
            if (IsDebugEnabled)
            {
                _log.Error(logMessage);
            }
        }
    }
}
