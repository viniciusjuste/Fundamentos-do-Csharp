using System.Text;

public static class Editor
{
    public static void Show()
    {
        Console.Clear();
        Console.WriteLine("Modo Editor");
        Console.WriteLine("---------------------------");
        Start();
    }

    public static void Start()
    {
        var file = new StringBuilder();

        do
        {
            file.Append(Console.ReadLine());
            file.Append(Environment.NewLine);
        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        Console.WriteLine("---------------------------");
        Viewer.Show(file.ToString());
        // Console.WriteLine("Deseja salvar o arquivo? ");
        // var response = Console.ReadLine();

        // if (response.ToLower() == "sim")
        // {
        //     Save(file.ToString());
        // }
        // else
        // {
        //     System.Environment.Exit(0);
        // }
    }

    // public static void Save(string file)
    // {
    //     var textToSave = file;

    //     Console.WriteLine("Digite o caminho para salvar o arquivo: ");
    //     var path = Console.ReadLine();

    //     using var fileWriter = new StreamWriter(path);
    //     fileWriter.Write(textToSave);

    //     Console.WriteLine($"Arquivo {path} salvo com sucesso.");
    // }
}