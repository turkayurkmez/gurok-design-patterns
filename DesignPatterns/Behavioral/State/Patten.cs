using System;
using System.Drawing;

namespace State
{
    //Bir nesnesin stok değerine göre farklı davranışlar sergilemesini istiyoruz. Bunu sağlamak için State pattern kullanırız.

    public abstract class State
    {
        public Product Product { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }

        public int CurrentStock { get; set; }
        public abstract int AddStock(int count);
        public abstract int RemoveStock(int count);

        public abstract void CheckState();

        public Color  Color { get; set; }

    }

    public class LowStockState : State
    {
        public LowStockState(State state) : this(state.CurrentStock, state.Product)
        {

        }
        public LowStockState(int currentStock, Product product)
        {
            this.CurrentStock = currentStock;
            this.Product = product;
            this.
            Initialize();
        }

        private void Initialize()
        {
            Color = Color.Red;
            this.MinStock = 30;
            this.MaxStock = 500;
        }

        public override int AddStock(int count)
        {

            this.CurrentStock += count;
            CheckState();
            return CurrentStock;
        }

        public override void CheckState()
        {
            if (CurrentStock > MaxStock)
            {
                this.Product.State = new NormalStock(this);
            }
        }

        public override int RemoveStock(int count)
        {
            this.CurrentStock -= count;
            CheckState();
            return CurrentStock;
        }
    }

    internal class NormalStock : State
    {


        public NormalStock(State lowStockState) : this(lowStockState.CurrentStock, lowStockState.Product)
        {

        }
        public NormalStock(int currentStock, Product product)
        {
            this.CurrentStock = currentStock;
            this.Product = product;
            Initialize();
        }

        public override int AddStock(int count)
        {
            this.CurrentStock += count;
            CheckState();
            return CurrentStock;
        }

        public override void CheckState()
        {
            if (CurrentStock > MaxStock)
            {
                this.Product.State = new MaxStock(this);
            }
            else if (CurrentStock < MinStock)
            {
                this.Product.State = new LowStockState(this);
            }
        }

        public override int RemoveStock(int count)
        {
            this.CurrentStock -= count;
            CheckState();
            return CurrentStock;
        }

        private void Initialize()
        {
            MinStock = 501;
            MaxStock = 1000;
            Color = Color.Black;
        }
    }

    internal class MaxStock : State
    {
        private State stock;

        public MaxStock(int currentStock, Product product)
        {
            this.CurrentStock = currentStock;
            this.Product = product;
            Initialize();
        }
        public MaxStock(State stock) : this(stock.CurrentStock, stock.Product)
        {
            this.stock = stock;
            Initialize();
        }

        private void Initialize()
        {
            Color = Color.Green;
            this.MinStock = 1001;
            this.MaxStock = int.MaxValue;
        }

        public override int AddStock(int count)
        {
            this.CurrentStock += count;
            CheckState();
            return CurrentStock;
        }

        public override void CheckState()
        {
            if (CurrentStock < MinStock)
            {

                if (this.Product != null)
                {
                    this.Product.State = new NormalStock(this.stock);
                }

            }
        }

        public override int RemoveStock(int count)
        {
            this.CurrentStock -= count;
            CheckState();
            return CurrentStock;
        }
    }

    public class Product
    {
        public State State { get; set; }
        public Product()
        {
            State = new LowStockState(100, this);
        }

        public void AddStock(int stock)
        {
            var newStock = this.State.AddStock(stock);
            Console.WriteLine($"{stock} eklendi. Yeni stok:{newStock} ");
            Console.WriteLine($"yeni durum:{this.State.GetType().Name}");

        }
        public void RemoveStock(int stock)
        {
            var newStock = this.State.RemoveStock(stock);
            Console.WriteLine($"{stock} çıkarıldı. Yeni stok:{newStock} ");
            Console.WriteLine($"yeni durum:{this.State.GetType().Name}");

        }
    }
}
