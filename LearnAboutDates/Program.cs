class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // var dateTime = DateTime.UtcNow;
        // Console.WriteLine(dateTime);
        // Console.WriteLine(dateTime.ToLocalTime());

        // var timeZonaAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
        // Console.WriteLine(timeZonaAustralia);

        // var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timeZonaAustralia);
        // Console.WriteLine(horaAustralia);

        var timeZones = TimeZoneInfo.GetSystemTimeZones();

        foreach (var timeZone in timeZones)
        {
            Console.WriteLine(timeZone);
            Console.WriteLine(timeZone.Id);
            Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZone));
            Console.WriteLine("------------------");
        }
    }
}