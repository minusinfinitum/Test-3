using System;

class Program
{
    static void Main()
    {
        Console.Write("X qiymati : ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Str: ");
        string str = Console.ReadLine();

        string result = x > str.Length ? str.ToUpper() : str.ToLower();

        Console.WriteLine(result);
    }
}


using System;

class Program
{
    static void Main()
    {
        int x = 15;
        int y = 18;
        string result;

        if (x > y)
        {
            result = "x is greater than y";
        }
        else if (x == y)
        {
            result = "x is equal to y";
        }
        else
        {
            result = "x and y are not comparable";
        }

        Console.WriteLine(result);
    }
}


using System;

class Program
{
    static void Main()
    {
        Console.Write("Hafta kunini kiriting (jum = juma, shan = shanba, yak = yakshanba, dush = dushanba, sesh = seshanba, chor = chorshanba, pay = payshanba): ");
        string haftaKuni = Console.ReadLine().ToLower();

        string dayInEnglish = haftaKuni switch
        {
            "yak" => "Sunday",
            "dush" => "Monday",
            "sesh" => "Tuesday",
            "chor" => "Wednesday",
            "pay" => "Thursday",
            "jum" => "Friday",
            "shan" => "Saturday",
            _ => "Invalid input"
        };

        Console.WriteLine($"Ingliz tilida: {dayInEnglish}");
    }
}
