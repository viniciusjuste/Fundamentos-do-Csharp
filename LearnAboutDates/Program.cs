class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var customDate = new DateTime(2025, 03, 17);
        Console.WriteLine(customDate);

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