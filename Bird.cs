using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    public abstract class Bird
    {

        protected Bird(string name, int age, FoodTypes food)
        {
            Name = name;
            Age = age;
            FoodType = food;
        }

        public enum FoodTypes { Herbivore, Carnivore, Omnivore, Detrivore };

        private string name_;
        public string Name { 
            get => name_;
            set { name_ = String.IsNullOrEmpty(value) ? "Unknown" : value; }
        }
        public FoodTypes FoodType { get; protected set; }

        protected int age_;
        public abstract int Age { get; protected set; }

        abstract public void Print();
    }
}
