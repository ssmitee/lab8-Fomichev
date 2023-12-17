class Program
{
    static void Main()
    {
        int hours, minutes, seconds, milliseconds;
        Console.WriteLine("Введите часы:");
        hours = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите минуты:");
        minutes = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите секунды:");
        seconds = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите миллисекунды:");
        milliseconds = int.Parse(Console.ReadLine());
        TimeSpan time = new TimeSpan(hours, minutes, seconds, milliseconds);
        Console.WriteLine($"Объединенное время: {time}");
        Console.WriteLine("Введите год:");
        int year = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("Введенный год - високосный.");
        }
        else
        {
            int nextLeapYear = year;
            while (!DateTime.IsLeapYear(nextLeapYear))
            {
                nextLeapYear++;
            }
            int yearsUntilNextLeapYear = nextLeapYear - year;
            Console.WriteLine($"До ближайшего високосного года осталось {yearsUntilNextLeapYear} лет.");
        }
    }
}