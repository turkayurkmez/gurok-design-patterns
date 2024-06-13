// See https://aka.ms/new-console-template for more information
using Command;

Console.WriteLine("Hello, World!");
/*
 * İstemciden sürekli olarak aksiyon alan (dosya işlemleri, db işlemleri, hesaplamalar vs) bir uygulamada bu aksiyonları düzenli bir biçimde yönetmek istiyorsanız, nasıl bir tasarım yapmalısınız?
 */

DatabaseCommandReceiver commandReceiver = new DatabaseCommandReceiver();
DiscountProductCommand discountProductCommand = new DiscountProductCommand(8, .25m, commandReceiver);
RaiseProductCommand raiseProductCommand = new RaiseProductCommand(16,0.53m, commandReceiver);

CommandInvoker commandInvoker = new CommandInvoker();
commandInvoker.Add(discountProductCommand);
commandInvoker.Add(raiseProductCommand);
commandInvoker.Execute();