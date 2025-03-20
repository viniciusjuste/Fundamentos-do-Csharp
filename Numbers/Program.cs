using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        decimal valor = 10.25m;
        var culture = CultureInfo.CreateSpecificCulture("pt-BR");

        Console.Clear();
        Console.WriteLine(valor.ToString("C",culture));
    }
}
