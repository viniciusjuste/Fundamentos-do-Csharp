class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var pt = System.Globalization.CultureInfo.GetCultureInfo("pt-PT");
        var br = System.Globalization.CultureInfo.GetCultureInfo("pt-BR");
        var en = System.Globalization.CultureInfo.GetCultureInfo("en-US");
        var de = System.Globalization.CultureInfo.GetCultureInfo("de-DE");
        var current = System.Globalization.CultureInfo.CurrentCulture;

        Console.WriteLine(DateTime.Now.ToString("D", current));
    }
}