using System;
using System.Collections.Generic;
using System.Text;

namespace MyInheritanceLibrary
{
    public class Dog : Animal
    {
        public Dog(string name, int age, int legs) : base(name, age, legs)
        {
        }

        public override string Speak()
        {
            return "Woof";
        }
    }
}
