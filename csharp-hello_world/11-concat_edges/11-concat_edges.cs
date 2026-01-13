﻿using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "C# is an elegant and type-safe object-oriented programming language that enables developers to build a variety of secure and robust applications that run on the .NET Framework.";
        str = str.Substring(31,27) + str.Substring(2, 1) + str.Substring(55, 2) + str.Substring(2, 1)+ str.Substring(0, 2);
        Console.WriteLine(str);
    }
}