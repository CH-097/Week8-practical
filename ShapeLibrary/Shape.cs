
namespace ShapeLibrary
{
    public abstract class Shape
    {
        private string name;
        private string color;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        public Shape()
        {
            name = "";
            color = "";
        }

        public Shape(string name, string color)
        {
            this.Name = name;
            this.Color = color;
        }

        public abstract double Area();
        public abstract double Perimeter();

    }
}