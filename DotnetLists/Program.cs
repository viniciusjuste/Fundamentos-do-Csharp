Console.Clear();

var array = new int[3];

try
{
    Salvar("");
}

catch (ArgumentNullException ex)
{
    Console.WriteLine("Algo está errado com o texto: " + ex.Message);
}

catch (MinhaExceptions ex)
{
    Console.WriteLine("Algo aconteceu: " + ex.QuandoAconteceu);
}

catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Não encontrou o indice: " + ex.Message);
}

catch (Exception ex)
{
    Console.WriteLine("Ops, algo deu errado: " + ex.Message);
}

finally
{
    Console.WriteLine("Chegou ao fim");
}


static void Salvar(string texto)
{
    if (string.IsNullOrEmpty(texto))
        throw new MinhaExceptions(DateTime.Now);
}

public class MinhaExceptions : Exception
{
    public MinhaExceptions(DateTime date)
    {
        QuandoAconteceu = date;
    }
    public DateTime QuandoAconteceu { get; set; }
}
