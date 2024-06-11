// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");
/*
 * Dependency Inversion
 * 
 * Büyük sistemler (matkap) küçük sistemlere (uç) bağlı olmak yerine
 * küçükler büyük olanlara aktarılmalıdır.
 */

ReportNotifier reportNotifier = new ReportNotifier();
reportNotifier.sender = new MailSender();

reportNotifier.sender = 