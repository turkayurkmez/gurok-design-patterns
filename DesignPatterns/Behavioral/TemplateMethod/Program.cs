// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
ProductDataAccessObject productDataAccessObject = new ProductDataAccessObject();
CategoryDataAccessObject categoryDataAccessObject = new CategoryDataAccessObject();

productDataAccessObject.Run();
categoryDataAccessObject.Run();

public interface IRunnable
{
    void Run(); //template method.
}

public abstract class DataAccessObject : IRunnable
{
    public abstract void Connect();
    public bool IsConnected { get; set; } = true;
    public abstract void Select();
    public abstract void Process();
    public abstract void Disconnect();
    public void Run()
    {
        Connect();
        if (IsConnected)
        {
            Select();
            Process();
            Disconnect();
        }
    }
}

public class ProductDataAccessObject : DataAccessObject
{
    public override void Connect()
    {
        Console.WriteLine("Product için Db'ye bağlandı");
        IsConnected = true;
    }

    public override void Disconnect()
    {
        Console.WriteLine("Db'ye bağlantı kapandı");

    }

    public override void Process()
    {
        Console.WriteLine("Ürün Verileri işleniyor");
    }

    public override void Select()
    {
        Console.WriteLine("Ürün Sorgusu çekildi");
    }
}

public class CategoryDataAccessObject : DataAccessObject
{
    public override void Connect()
    {
        Console.WriteLine("Db'ye bağlandı");
        IsConnected = true;
    }

    public override void Disconnect()
    {
        Console.WriteLine("Db'ye bağlantı kapandı");

    }

    public override void Process()
    {
        Console.WriteLine("Kategori Verisi işleniyor");
    }

    public override void Select()
    {
        Console.WriteLine("Kategoriler Sorgusu çekildi");
    }
}