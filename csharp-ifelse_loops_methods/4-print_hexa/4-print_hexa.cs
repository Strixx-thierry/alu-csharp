using System;

class Program
{
    static void Main(string[] args)
    {
        for (int a = 0; a <= 98; a++)
        {
            Console.WriteLine($"{a} = 0x{a:x}");
        }
    }
}
