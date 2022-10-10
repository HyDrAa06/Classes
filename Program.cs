using System;

namespace ClassPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Age:");
            int age = int.Parse(Console.ReadLine());

            var person = new Class1();

            person.Age = age;
            person.Name = name;

            Console.WriteLine(person.Name + ", " + person.Age);
        }
    }
}