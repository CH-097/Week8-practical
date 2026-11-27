using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public abstract class Triangle : Shape
    {
        private double baseLength;
        private double height;

        public double BaseLength
        {
            get { return baseLength; }
            set { baseLength = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public Triangle() : base()
        {
            baseLength = 0.0;
            height = 0.0;
        }

        public Triangle(string name, string color, double baseLength, double height) : base(name, color)
        {
            this.BaseLength = baseLength;
            this.Height = height;
        }

        public override double Area()
        {
            return 0.5 * baseLength * height;
        }


    }
}
