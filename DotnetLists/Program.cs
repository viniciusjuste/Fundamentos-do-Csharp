Console.Clear();

var array = new int[3];

try
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
catch (Exception ex)
{
    Console.WriteLine("Ops, algo deu errado: " + ex.Message);
}
// finally
// {
//     Console.WriteLine("Finalizando a execucao");
// }

