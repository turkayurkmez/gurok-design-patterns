// See https://aka.ms/new-console-template for more information
using Inheritance;

Console.WriteLine("Hello, World!");

TepsiKebabi tepsiKebabi = new TepsiKebabi() { PismeSuresi=30};
Corba domatesCorbasi = new Corba() { PismeSuresi = 10};
Tulumba tulumba = new Tulumba() {  PismeSuresi = 15};

Asci asci = new Asci();
asci.Pisir(domatesCorbasi);
asci.Pisir(tepsiKebabi);
asci.Pisir(tulumba);

//dikkat::
tulumba.SunumYap();