using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// This class contains methods for object information printing.
/// </summary>
public class Obj
{
    /// <summary>
    /// Prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param name="myObj">The object to inspect.</param>
    public static void Print(object myObj)
    {
        Type t = myObj.GetType();

        Console.WriteLine("{0} Properties:", t.Name);
        var properties = t.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
        foreach (var prop in properties)
        {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine("{0} Methods:", t.Name);
        var methods = t.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
        foreach (var method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}
