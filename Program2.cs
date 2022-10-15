using System;

namespace OpinionPoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of family members:");
            int numberOfFamilyMembers = int.Parse(Console.ReadLine());

            int biggestAge = 0;
            var People = new Dictionary<string, int>();

            Console.WriteLine("Name and age:");

            for (int i = 0; i < numberOfFamilyMembers; i++)
            {
                string[] info = Console.ReadLine().Split();
                Person1 person = new Person1();

                if (info[0] != "" && info.Length == 1)
                {
                    person.Age = int.Parse(info[0]);
                }

                if (info.Length == 2)
                {
                    person.Name = info[0];
                    person.Age = int.Parse(info[1]);
                }

                if (person.Age > 30)
                {
                    People[person.Name] = person.Age;
                }
            }
            
            foreach(var item in People.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}