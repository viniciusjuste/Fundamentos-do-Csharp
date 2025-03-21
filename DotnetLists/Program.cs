Console.Clear();

var meuArray = new int[5] { 1, 2, 3, 4, 5 };
string[] array = new string[5] { "A", "B", "C", "D", "E" };
var funcionarios = new Funcionario[5];

for (int i = 0; i < meuArray.Length; i++)
{
    Console.WriteLine($"Posicao {i}: {meuArray[i]}");
}

foreach (string item in array)
{
    Console.WriteLine(item);
}

foreach (var funcionario in funcionarios)
{
    Console.WriteLine(funcionario.Id);
}

struct Funcionario
{
    public int Id { get; set; }
}
