using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public class Circle : Shape
    {
        private int x;
        private int y;
        private double radius;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }


        public Circle() : base()
        {
            x = 0;
            y = 0;
            radius = 0.0;
        }

        public Circle(string name, string color, int x, int y, double radius) : base(name, color)
        {
            this.X = x;
            this.Y = y;
            this.Radius = radius;
        }

        public override double Area()
        {
            return radius * radius * Math.PI;
        }

        public override double Perimeter()
        {
            return 2 * radius * Math.PI;
        }
    }
}
