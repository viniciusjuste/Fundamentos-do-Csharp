class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine(DateTime.DaysInMonth(2025, 2));
        Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
        Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
    }

    public static bool IsWeekend(DayOfWeek today)
    {
        return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
    }
}