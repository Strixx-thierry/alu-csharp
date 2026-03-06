using System;
using System.Collections.Generic;
using System.Reflection;

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
        PropertyInfo[] properties = t.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
        foreach (PropertyInfo prop in properties)
        {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine("{0} Methods:", t.Name);
        MethodInfo[] methods = t.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}
