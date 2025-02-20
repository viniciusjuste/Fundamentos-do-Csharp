internal class Program
{
    private static void Main(string[] args)
    {
        int inteiro = 100;
        Console.WriteLine(inteiro);

        float real = 25.5f;
        Console.WriteLine(real);

        // Conversão implicita
        //  real = inteiro;
        //  Console.WriteLine(real);

        //  inteiro = (int)real;

        inteiro = Convert.ToInt32(real);
        Console.WriteLine(inteiro);
    }
}