using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        var product = new Product(1, "TV", 500.00, EproductType.Product);
        product.Price = product.PriceInDolar(5.0);

        Console.WriteLine(product.Id);
        Console.WriteLine(product.Name);
        Console.WriteLine(product.Price);
        Console.WriteLine((int)product.Type);
    }
}

struct Product
{
    public Product(int id, string name, double price, EproductType type)
    {
        Id = id;
        Name = name;
        Price = price;
        Type = type;
    }
    public int Id;
    public string Name;
    public double Price;
    public EproductType Type;

    public double PriceInDolar(double dolar)
    {
        return Price * dolar;
    }
}

enum EproductType
{
    Product = 1,
    Service = 2
}
