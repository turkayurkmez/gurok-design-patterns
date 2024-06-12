// See https://aka.ms/new-console-template for more information
using AbstractFactory;

Console.WriteLine("Hello, World!");
/*
 * Concrete sınıfları bilmeden, nesne aileleri üretmenizi sağlayan tasarım deseni.
 * 
 * Nesne aileleri: Bir işlem için kullanılan bir arada olması gereken ama birbirinden bağımsız nesneler....
 * 
 */
DbFactoryCreator<MSSQLDbFactory> sqlDbFactory = new DbFactoryCreator<MSSQLDbFactory>();
sqlDbFactory.ExecuteCommand();

DbFactoryCreator<OracleDbFactory> oracleFactory = new DbFactoryCreator<OracleDbFactory>();
oracleFactory.ExecuteCommand();