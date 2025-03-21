Console.Clear();

var array = new int[3];

try
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(array[i]);
    }
}
catch (IndexOutOfRangeException ex){
    Console.WriteLine("Não encontrou o indice: " + ex.Message);
}

catch (Exception ex)
{
    Console.WriteLine("Ops, algo deu errado: " + ex.Message);
    Console.WriteLine(ex.InnerException?.Message);
}
// finally
// {
//     Console.WriteLine("Finalizando a execucao");
// }

