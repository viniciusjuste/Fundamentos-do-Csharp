Console.Clear();

var meuArray = new int[5];
var arrb = new int[5];

arrb[0] = meuArray[0];

meuArray[0] = 1;
Console.WriteLine(arrb[0]);

struct Funcionario
{
    public int Id { get; set; }
}
