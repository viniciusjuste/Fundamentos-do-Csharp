namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Este texto é um teste";
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.Insert(5, "Aqui "));
            Console.WriteLine(text.Remove(5, 5));
            Console.WriteLine(text.Length);
        }
    }
}