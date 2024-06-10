using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractANDInterface
{

    public interface IPrintable
    {
        void Print();
    }
    public abstract class Document
    {
        public abstract void Save();
        public abstract void Open();
      

        public string Title { get; set; }
        public void Copy(string from, string to)
        {
            Console.WriteLine("Dosya kopyalandı");
        }
    }



    public class WordDocument : Document, IPrintable
    {
        public override void Open()
        {
            Console.WriteLine("Word açıldı");
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        //public override void Print()
        //{
        //    Console.WriteLine("Word çıktısı alındı");

        //}

        public override void Save()
        {
            Console.WriteLine("Word kaydedildi");

        }
    }

    public class ExcelDocument : Document , IPrintable
    {
        public override void Open()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        //public override void Print()
        //{
        //    Console.WriteLine("Excel çıktısı alındı");

        //}

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class PDFDocument : Document
    {
        public override void Open()
        {
            throw new NotImplementedException();
        }
       

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class DocumentPrinter
    {
        public void Print(IPrintable  document)
        {
            document.Print();
        }
    }
}
