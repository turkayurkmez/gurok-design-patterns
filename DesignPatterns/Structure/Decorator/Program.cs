// See https://aka.ms/new-console-template for more information
using Decorator;
using System.IO.Compression;
using System.Net.Sockets;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

Stream fStream = new FileStream("deneme.txt", FileMode.Create);
Stream mStream = new MemoryStream();



GZipStream stream = new GZipStream(fStream, CompressionLevel.Optimal);
CryptoStream cryptoStream = new CryptoStream(stream, null, CryptoStreamMode.Write);

/*
 * Problem: Hali hazırda bellekte bulunan bir nesneye yeni özellik ya da fonksiyon kazandırmak isterseniz, nasıl bir yol istersiniz?
 */

Mail mail = new Mail();
SignedDecorator signedDecorator = new SignedDecorator(mail, "Türkay Ürkmez");
CryptedDecorator crypted = new CryptedDecorator(signedDecorator);
crypted.Send();