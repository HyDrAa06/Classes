using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpinionPoll
{
    internal class Person1
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Person1()
        {
            this.name = "no name";
            this.age = 1;
        }

        public Person1(int age) : this()
        {
            Age = age;
        }

        public Person1(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
