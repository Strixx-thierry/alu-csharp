#!/usr/bin/env bash
dotnet new console -o 2-new_project --force
echo 'using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}' > 2-new_project/Program.cs
dotnet build 2-new_project
dotnet run --project 2-new_project
