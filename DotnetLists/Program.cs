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

catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Não encontrou o indice: " + ex.Message);
}

catch (Exception ex)
{
    Console.WriteLine("Ops, algo deu errado: " + ex.Message);
}


static void Salvar(string texto)
{
    if (string.IsNullOrEmpty(texto))
        throw new ArgumentNullException("O texto precisa ser preenchido");
}
