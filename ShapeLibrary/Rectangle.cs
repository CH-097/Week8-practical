using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }


        public Rectangle() : base()
        {
            length = 0.0;
            width = 0.0;
        }

        public Rectangle(string name, string color, double length, double width) : base(name, color)
        {
            this.Length = length;
            this.Width = width;
        }



        public override double Area()
        {
            return length * width;
        }

        public override double Perimeter()
        {
            return 2 * (length + width);
        }
    }
}
