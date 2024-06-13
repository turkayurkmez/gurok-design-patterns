using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /*
     * Senaryo: 
     * Mail konfigürasyonunun sadece bir instance olması yeterli.
     */

    public class MailConfigurator
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public bool EnableSSL { get; set; }

        private MailConfigurator()
        {
            
        }
        private static MailConfigurator instance;
        public static MailConfigurator CreateInstance()
        {
            if (instance == null)
            {
                instance = new MailConfigurator();
            }
            return instance;
        }

    }

    //public interface IMailConf 
    //{ }

    //public static class StaticMailConfigurator : IMailConf
    //{
    //    public static string Host { get; set; }
    //    public static int Port { get; set; }
    //}
}
