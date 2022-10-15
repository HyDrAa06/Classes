using System;
using System.Runtime.Serialization.Formatters;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of family members:");
            int numberOfFamilyMembers=int.Parse(Console.ReadLine());

            int biggestAge = 0;
            string[] temp = new string[2];

            for(int i=0; i<numberOfFamilyMembers; i++)
            {
                string[] info = Console.ReadLine().Split();
                Person person = new Person();

                if (info[0] != "" && info.Length == 1)
                {
                    person.Age = int.Parse(info[0]);
                }

                if(info.Length == 2)
                {
                    person.Name = info[0];
                    person.Age = int.Parse(info[1]);
                }
                

                if(person.Age > biggestAge)
                {
                    biggestAge = person.Age;
                    temp[0] = person.Name;
                    temp[1] = person.Age.ToString();
                }
            }
            
            Console.WriteLine(string.Join(", ", temp));

            
        }
    }
}