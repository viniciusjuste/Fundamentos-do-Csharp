using System.Text;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new StringBuilder();
            text.Append("Este texto é um teste");
            text.Append("Este texto é um teste");
            text.Append("Este texto é um teste");
            text.Append("Este texto é um teste");
            text.Append("Este texto é um teste");

            Console.WriteLine(text);
        }
    }
}