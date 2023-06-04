using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal_shelter
{
    interface IAnimal
    {
        string GetInfo();
        void MakeSound();
    }
    abstract class AnimalShelter : IAnimal
    {
        public int ID { get; internal set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public AnimalShelter(string name, int age, int id)
        {
            ID = id;
            Name = name;
            Age = age;
        }

        public abstract string GetInfo();
        public abstract void MakeSound();
    }
}
