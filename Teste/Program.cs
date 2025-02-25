internal class Program
{
    private static void Main(string[] args)
    {
        var product = new Product(1, "TV", 500.00);
        product.Price = product.PriceInDolar(5.0);

        Console.WriteLine(product.Id);
        Console.WriteLine(product.Name);
        Console.WriteLine(product.Price);
    }
}

struct Product
{
    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
    public int Id;
    public string Name;
    public double Price;

    public double PriceInDolar(double dolar)
    {
        return Price * dolar;
    }
}

