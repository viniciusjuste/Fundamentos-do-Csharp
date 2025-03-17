class Program
{
    static void Main(string[] args)
    {
      DateTime date = DateTime.Now;
      Console.WriteLine(date);

     var day = date.DayOfWeek;
     Console.WriteLine(day);

     var year = date.Year;
     Console.WriteLine(year);

     var month = date.Month;
     Console.WriteLine(month);
    }
}