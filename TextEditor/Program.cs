﻿namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("o quê você deseja fazer ?");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: Environment.Exit(0); break;
                case 1: OpenFile(); break;
                case 2: EditFile(); break;
                default: Menu(); break;
            }
        }

        static void OpenFile()
        {

        }

        static void EditFile()
        {

        }
    }
}
