class Time1Test
{
    static void Main()
    {
        var time = new Time1();

        Console.WriteLine($"Baslangıctaki evrensel zaman: {time.ToUniversalString()}");
        Console.WriteLine($"Baslangıc ​​standart zamanı: {time.ToString()}");

        Console.WriteLine();

        time.SetTime(13, 27, 6);
        Console.WriteLine($"SetTimedan sonraki evrensel saat: {time.ToUniversalString()}");
        Console.WriteLine($"SetTimedan sonraki standart saat: {time.ToString()}");

        Console.WriteLine();

        try
        {
            time.SetTime(99, 99, 99);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message + "\n");
        }
        Console.WriteLine("Gecersiz ayarları denedikten sonra:");
        Console.WriteLine($"Evrensel zaman: {time.ToUniversalString()}");
        Console.WriteLine($"Standart zaman: {time.ToString()}");
    }
}
public class Time1
{
    public int Hour { get; set; }
    public int Minute { get; set; }
    public int Second { get; set; }

    public void SetTime(int hour, int minute, int second)
    {
        if ((hour < 0 || hour > 23) || (minute < 0 || minute > 59) || (second < 0 || second > 59))
        {
            throw new ArgumentOutOfRangeException();
        }

        Hour = hour;
        Minute = minute;
        Second = second;
    }
    public string ToUniversalString() =>
        $"{Hour:D2}:{Minute:D2}:{Second:D2}";
    public override string ToString() =>
        $"{((Hour == 0 || Hour == 12) ? 12 : Hour % 12)}:" +
        $"{Minute:D2}:{Second:D2} {(Hour < 12 ? "AM" : "PM")}";
}


