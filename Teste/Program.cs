internal class Program
{
    private static void Main(string[] args)
    {
        MeuMetodo();
        Console.WriteLine(RetornaNome("Vinicius"));
        string nome = RetornaNome("Joao");
        Console.WriteLine(nome);
    }

    static void MeuMetodo()
    {
        Console.WriteLine("Meu Metodo");
    }

    static string RetornaNome(string nome, int idade = 0)
    {
        return nome;
    }
}