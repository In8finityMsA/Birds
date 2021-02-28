using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    sealed class Budgie : Bird, IFlyable
    {
        public Budgie(string name, int age, ColorTypes color) : base(name, age, Bird.FoodTypes.Herbivore)
        {
            Color = color;
        }

        public enum ColorTypes { Green, White, Blue, Yellow };
        public ColorTypes Color { get; private set; }

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

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying all around the room.");
        }

        public override void Print()
        {
            Console.WriteLine($"This is a {Color} budgie called {Name}.\n It's {Age} years old.\n Budgie is a {FoodType} bird.\n " +
                "Note: Silence your budgie if you are a lecturer, please.");
        }

    }
}
