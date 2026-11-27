using MyInheritanceLibrary;

// Task: Create a list that stores objects of type Animal. Create an object from each of the
//derived classes(Dog, Cat and Bird) and add them to the list of animals.
//Now loop through the list (using a foreach loop) and call the Speak() method on each object


namespace AnimalLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Dog dog = new Dog("Rex", 7, 4);
            animals.Add(dog);
            animals.Add(new Cat("Whiskers", 3, 4));
            animals.Add(new Bird("Flappy", 6, 2, 2.5));
            animals.Add(new Animal("Jack", 6, 8));

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Speak());
            }
        }
    }
}