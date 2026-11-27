using System;
using System.Collections.Generic;
using System.Text;



//All classes should override the Speak() method with their own unique print statement



namespace MyInheritanceLibrary
{
    public class Bird : Animal
    {
        private double wingspan;

        public double Wingspan
        {
            get { return wingspan; }
            set { wingspan = value; }
        }

        // constructor method
        public Bird() : base()
        {
            wingspan = 0.0;
        }

        public Bird(string name, int age, int legs, double wingspan) : base(name, age, legs)
        {
            this.Wingspan = wingspan;
        }

        public override string Speak()
        {
            return "Chirp";
        }
    }
}
