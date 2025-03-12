namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = 10.2;
            // var text = "O preço do produto é: " + price + " reais";
            // var text = string.Format("O preço do produto é: {0} reais", price);
            var text = $"O preço do produto é: {price} reais";
        }
    }
}