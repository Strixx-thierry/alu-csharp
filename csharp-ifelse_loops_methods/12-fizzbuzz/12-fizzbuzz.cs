using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            string output = "";
            if (i % 3 == 0)
                output += "Fizz";
            if (i % 5 == 0)
                output += "Buzz";
            
            if (output == "")
                output = i.ToString();
            
            Console.Write(output);
            
            if (i < 100)
                Console.Write(" ");
            else
                Console.WriteLine();
        }
    }
}
