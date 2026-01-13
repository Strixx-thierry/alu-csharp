using System;

class Program
{
    static void Main(string[] args)
    {
        for (int a = 0; a < 100; a++)
        {
            if (a == 99){
                Console.Write($"{a}\n");
            }
            else{
                Console.Write($"{a.ToString("D2")}, ");
            }
        }
    }

}

