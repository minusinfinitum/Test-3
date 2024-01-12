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
