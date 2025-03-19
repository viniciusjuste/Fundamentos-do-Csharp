class Program
{
    static void Main(string[] args)
    {
        var data = DateTime.Now;

        if (data.Date == DateTime.Now.Date)
        {
            Console.WriteLine("Igual");
        }

        Console.Clear();
        Console.WriteLine(data);
    }
}