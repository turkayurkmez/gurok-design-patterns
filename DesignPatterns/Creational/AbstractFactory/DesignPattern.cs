using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
   /*
    *  Bir uygulama ADO.NET ile db ile konuşmaktadır. Db sağlayıcısı Oracle ve MSSQL'dir. Bu durumda hangi nesneler ile çalışacağımızı BELİRTMEDEN doğru business nesnelerini nasıl üretebiliriz? 
    */ 

    //1. Nesne ailesinin elementlerini, önce interface olarak tanımla:
    public interface IConnection
    {
        void Open();
        void Close();
    }

    public interface ICommand
    {
        void Execute();
    }

    //2. Elementleri somut nesnelere dönüştür.
    public class MssqlConnection : IConnection
    {
        public void Close()
        {
            Console.WriteLine("MS SQL bağlantısı kapandı!");
        }

        public void Open()
        {
            Console.WriteLine("MS SQL bağlantısı açıldı!");
        }
    }
    public class OracleConnection : IConnection
    {
        public void Close()
        {
            Console.WriteLine("Oracle bağlantısı kapandı!");
        }

        public void Open()
        {
            Console.WriteLine("Oracle bağlantısı açıldı!");
        }
    }

    public class MSSqlCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Komut mssql'de çalıştı");
        }
    }

    public class OracleCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Komut oracle'da çalıştı");
        }
    }

    //3. Bu somut nesneleri "aile" olarak bir arada oluşturan factory tasarla:
    public interface IDbFactory
    {
        ICommand CreateCommand();
        IConnection CreateConnection();
    }

    public class MSSQLDbFactory : IDbFactory
    {
        public ICommand CreateCommand()
        {
           return new MSSqlCommand();
        }

        public IConnection CreateConnection()
        {
            return new MssqlConnection();
        }
    }
    public class OracleDbFactory : IDbFactory
    {
        public ICommand CreateCommand()
        {
            return new OracleCommand();
        }

        public IConnection CreateConnection()
        {
            return new OracleConnection();
        }
    }

    public class DbFactoryCreator<T> where T: class, IDbFactory, new()
    {
        private T factory = new T();

        public void ExecuteCommand()
        {
            var connection = factory.CreateConnection();
            var command = factory.CreateCommand();
            connection.Open();
            command.Execute();
            connection.Close();

        }
             
    }
}
