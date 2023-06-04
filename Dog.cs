﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal_shelter
{
    class Dog : AnimalShelter
    {
        public string Zvuk = "гав!!! ";
        public Dog(string name, int age, int id) : base(name, age, id)
        {

        }

        public override string GetInfo()
        {
            return $"ID: {ID}, Кличка животного : {Name}, Вазраст животоного: {Age}";
        }
        public override void MakeSound()
        {
            Console.WriteLine($" Издает звук: {Zvuk}");
        }

    }
}
