using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
   public interface ICommand
    {
        void Execute();
    }

    public class DatabaseCommandReceiver
    {
        public void IncreasePrice(ICommand command)
        {
            Console.WriteLine("Ürün fiyatı arttırıldı");
        }

        public void DecreasePrice(ICommand command)
        {
            Console.WriteLine("Ürün fiyatı azaltıldı");
        }
    }

    public class DiscountProductCommand : ICommand
    {
        public int ProductId { get; set; }
        public decimal DiscountRate { get; set; }

        private readonly DatabaseCommandReceiver receiver;

        public DiscountProductCommand(int productId, decimal discountRate, DatabaseCommandReceiver receiver)
        {
            ProductId = productId;
            DiscountRate = discountRate;
            this.receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine($"{this.ProductId} id'li ürünün fiyatı {this.DiscountRate.ToString("P1")} oranında azalacak.");
            receiver.DecreasePrice(this);
        }
    }
    public class RaiseProductCommand : ICommand
    {
        public int ProductId { get; set; }
        public decimal RaiseRate { get; set; }

        private readonly DatabaseCommandReceiver receiver;

        public RaiseProductCommand(int productId, decimal raiseRate, DatabaseCommandReceiver receiver)
        {
            ProductId = productId;
            RaiseRate = raiseRate;
            this.receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine($"{this.ProductId} ürününe {this.RaiseRate.ToString("P1")} oranında zam yapıldı");
            receiver.IncreasePrice(this);
        }

    }

    public class  CommandInvoker
    {
        private Queue<ICommand> commands = new Queue<ICommand>();
        public void Add(ICommand command) => commands.Enqueue(command);
        public void Clear()=>commands.Clear();
        public void Execute()
        {
            while (commands.Count >0)
            {
                commands.Dequeue().Execute();
            }
        }
    }
}
