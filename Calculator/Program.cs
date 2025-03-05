using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soma();
            // Subtracao();
            // Divisao();
            Multiplicacao();
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {result}");
            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 - v2;
            Console.WriteLine($"O resultado da subtracao e: {result}");
            Console.ReadKey();
        }

        static void Divisao(){
            Console.Clear();

            Console.WriteLine("Valor que sera dividido: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Divisor: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 / v2;
            Console.WriteLine($"O resultado da divisao e: {result}");
            Console.ReadKey();
        }

        static void Multiplicacao(){
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 * v2;
            Console.WriteLine($"O resultado da multiplicacao e: {result}");
            Console.ReadKey();
        }
    }
}
