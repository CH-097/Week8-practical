namespace MyInheritanceLibrary
{
    public class Animal
    {
        private string name;
        private int age;
        private int legs;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int Legs
        {
            get { return legs; }
            set { legs = value; }
        }



        //constructor method
        public Animal(string name, int age, int legs)
        {
            this.Name = name;
            this.Age = age;
            this.Legs = legs;
        }



        //method to display 'Hello'
        public virtual void Speak()    //'virtual' keyowrd means can be overwritten
        {
            Console.WriteLine("Hello");
        }
    }
}
