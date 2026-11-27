using BookLibrary;

namespace BookLibraryTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPrintable> list = new List<IPrintable>();
            list.Add(new Book("Dan Brown", "The Hobbit", 123334));
            list.Add(new Newspaper("Belfast Telegraph", "Has good puzzles", "DUP back in stormont"));



            foreach (var item in list)
            {
                item.Print();
            }
        }
    }
}
