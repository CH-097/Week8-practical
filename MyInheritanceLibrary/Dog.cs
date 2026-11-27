using System;
using System.Collections.Generic;
using System.Text;

namespace MyInheritanceLibrary
{
    internal class Dog : Animal
    {
        public Dog(string name, int age, int legs) : base(name, age, legs)
        {
        }

        public override void Speak()
        {
            Console.WriteLine("Woof");
        }
    }
}
