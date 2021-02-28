using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    class Duck : Bird, ISwimable, IFlyable
    {
        public Duck(string name, int age, HabitatTypes habitat) : base(name, age, Bird.FoodTypes.Omnivore)
        {
            Habitat = habitat;
        }

        public enum HabitatTypes {Lake, River, Swamp };
        public HabitatTypes Habitat { get; private set; }
        public override int Age
        {
            get => age_;
            protected set
            {
                if (value >= 0 || value <= 10)
                    age_ = value;
                else
                    throw new ArgumentException("Wrong age range.");
            }
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} has flown away.");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is happily swimming.");
        }

        public override void Print()
        {
            Console.WriteLine($"This is a Duck called {Name}.\n It's {Age} years old and it lives in a {Habitat}.\n Duck is a {FoodType} bird.\n" +
                " You can often see ducks near the water in the cities.");
        }
    }
}
