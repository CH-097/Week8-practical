using System;
using System.Collections.Generic;
using System.Text;

namespace MyInheritanceLibrary
{
    public class Cat : Animal
    {
        public Cat() : base()
        {

        }

        public Cat(string name, int age, int legs) : base(name, age, legs)
        {
        }

        public override string Speak()
        {
            return "Meaow";
        }
    }
}
