namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Este texto é um teste";
            Console.WriteLine(text.Replace("Este", "Isto"));

            var split = text.Split(' ');
            Console.WriteLine(split[0]);

            var result = text.Substring(16, 5);
            Console.WriteLine(result);
        }
    }
}