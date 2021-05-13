using System;

namespace datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear);

        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());

        // Math
        Console.WriteLine(Math.Abs(-25));
        Console.WriteLine(Math.Ceiling(22.3));
        Console.WriteLine(Math.Round(22.3));
        Console.WriteLine(Math.Floor(22.7));
        Console.WriteLine(Math.Pow(3,4));
        Console.WriteLine(Math.Sqrt(9));
        Console.WriteLine(Math.Log(90));
        Console.WriteLine(Math.Exp(3));
        }


        
    }
}
