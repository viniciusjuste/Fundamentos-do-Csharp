namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Este texto é um teste";
            Console.WriteLine(text.IndexOf("é"));
            Console.WriteLine(text.LastIndexOf("s"));
        }
    }
}