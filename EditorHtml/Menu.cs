public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        DrawScreen();
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