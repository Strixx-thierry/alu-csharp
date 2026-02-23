using System; 
using School; 
using Animals.Mammals;
using Animals.Birds;

class Program
{
    static void Main(string[] args)
    {  
        Console.WriteLine("Task 1");
        Student student = new Student();
        student.Name = "john";
        Console.WriteLine($"Student created: {student.Name}");  

        Console.WriteLine("task 2");

        Dog myDog = new Dog();
        myDog.Bark();

        Eagle myEagle = new Eagle();
        myEagle.Fly();

        Console.WriteLine("\n both in our Zoo!");
    }
}
