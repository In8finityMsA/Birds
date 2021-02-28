using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    sealed class Kiwi : Bird
    {

        public Kiwi(string name, int age, SpeciesTypes species) : base (name, age, Bird.FoodTypes.Omnivore)
        {
            Species = species;
        }

        public enum SpeciesTypes { North, South, BigGray, LittleGray, Rovi };
        public SpeciesTypes Species { get; private set; }

        public override int Age { 
            get => age_;
            protected set
            {
                if (value >= 0 || value <= 60)
                    age_ = value;
                else
                    throw new ArgumentException("Wrong age range.");
            }
        }

        public override void Print()
        {
            Console.WriteLine($"This is a {Species} kiwi called {Name}.\n It's {Age} years old.\n Kiwi is a {FoodType} bird.\n" +
                " Kiwies are strange birds!");
        }
    }
}
