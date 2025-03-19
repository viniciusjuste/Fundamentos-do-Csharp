class Program
{
    static void Main(string[] args)
    {
        var date = DateTime.Now;
        var formato = string.Format("{0: dd/MM/yyyy}", date);
        Console.WriteLine(formato);
    }
}