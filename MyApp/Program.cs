namespace Name
{
    class Program {
        static void Main(string[] args){
            var id = Guid.NewGuid();
            id.ToString().Substring(0, 8);
            Console.WriteLine(id);
        }
    }
}