using System.Text.RegularExpressions;

public static class Viewer
{
    public static void Show(string text)
    {
        Console.Clear();
        Console.WriteLine("Modo de Visualizacao");
        Console.WriteLine("---------------------------");
        Replace(text);
        Console.WriteLine("---------------------------");
        Console.ReadKey();
        Menu.Show();
    }

    public static void Replace(string text)
    {
        var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
        var words = text.Split(' ');

        for (int i = 0; i < words.Length; i++){
            if(strong.IsMatch(words[i])){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(words[i].Replace("<strong>", "").Replace("</strong>", ""));
                Console.ResetColor();
            }
        }
    }
}