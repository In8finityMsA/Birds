using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    sealed class Penguin : Bird, ISwimable
    {
        public Penguin(string name, int age, SpeciesTypes species) : base(name, age, Bird.FoodTypes.Carnivore)
        {
            Species = species;
        }

        public enum SpeciesTypes { Emperor, King, Little, YellowEyed };
        public SpeciesTypes Species { get; private set; }
        public override int Age
        {
            get => age_;
            protected set
            {
                if (value >= 0 || value <= 25)
                    age_ = value;
                else
                    throw new ArgumentException("Wrong age range.");
            }
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is very good at swiming. Look how it is diving!");
        }

        public override void Print()
        {
            Console.WriteLine($"This is a {Species} penguin called {Name}.\n It's {Age} years old.\n Penguin is a {FoodType} bird.\n" +
                " You must have seen penguins in the zoo.");
        }
    }
}
