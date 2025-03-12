namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Este texto é um teste";
            // Console.WriteLine(text.CompareTo("Testando"));
            // Console.WriteLine(text.Contains("teste", StringComparison.OrdinalIgnoreCase));

             Console.WriteLine(text.StartsWith("Este", StringComparison.OrdinalIgnoreCase));
             Console.WriteLine(text.EndsWith("teste", StringComparison.OrdinalIgnoreCase));
        }
    }
}