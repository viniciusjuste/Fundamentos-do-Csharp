Console.Clear();

var array = new int[3];

try
{
    for (int i = 0; i < 10; i++){
    Console.WriteLine(array[i]);
}
} catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Finally");
}

