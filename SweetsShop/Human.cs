using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetsShop
{
    abstract class Human
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public Human(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
        }
        abstract public void DisplayInfo();
    }
    class Employee : Human
    {
        public string Position { get; private set; }
        public Employee(string name, string lastname, string position) : base(name, lastname)
        {
            Position = position;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{ Name}, { LastName}, { Position}");
        }

    }

    class Buyer : Human
    {
        public string Preferences { get; private set; }
        public Buyer(string name, string lastname, string preferences) : base(name, lastname)
        {
            Preferences = preferences;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"{Name}, {LastName}, {Preferences}");
        }
    }
}
