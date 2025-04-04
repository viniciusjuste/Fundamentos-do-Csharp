public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        DrawScreen();
        WriteOptions();

        var option = short.Parse(Console.ReadLine());
        
        HandleMenuOption(option);
    }

    public static void WriteOptions()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Editor HTML");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("===========================");
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("Escolha uma opcao:");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("1 - Novo arquivo");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("2 - Abrir arquivo");
        Console.SetCursorPosition(3, 9);
        Console.WriteLine("0 - Sair");
        Console.SetCursorPosition(3, 10);
        Console.WriteLine("Opcao: ");
    }

    public static void HandleMenuOption(short option)
    {
        switch (option)
        {
            case 1: Editor.Show(); break;
            case 2: Console.WriteLine("View"); break;
            case 0:
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
                ; break;
            default: Show(); break;
        }
    }

    public static void GenerateLine(int characters)
    {
        Console.Write("+");
        for (int i = 0; i <= characters; i++)
        {
            Console.Write("-");
        }

        Console.Write("+");
        Console.WriteLine("\n");
    }

    public static void GenerateCols(int cols, int characters)
    {
        for (int i = 0; i <= cols; i++)
        {
            Console.Write("|");
            for (int j = 0; j <= characters; j++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            Console.WriteLine("\n");
        }
    }

    public static void DrawScreen()
    {
        GenerateLine(60);
        GenerateCols(10, 60);
        GenerateLine(60);
    }
}