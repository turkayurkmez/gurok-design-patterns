// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using Singleton;

Console.WriteLine("Hello, World!");
//Problem: Uygulamanızda SADECE 1 adet olmasını bir instance var. Bunu nasıl sağlarsınız?
MailConfigurator mailConfigurator = MailConfigurator.CreateInstance();
mailConfigurator.Host = "gmail";

MailConfigurator mailConfigurator2 = MailConfigurator.CreateInstance();
Console.WriteLine(mailConfigurator2.Host);