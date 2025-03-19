class Program
{
    static void Main(string[] args)
    {
        var date = DateTime.Now;
        // var formato = string.Format("{0:s}", date);
        // var formato = string.Format("{0:r}", date);
        var formato = string.Format("{0:u}", date);

        Console.Clear();
        Console.WriteLine(formato);
    }
}