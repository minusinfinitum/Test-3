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
