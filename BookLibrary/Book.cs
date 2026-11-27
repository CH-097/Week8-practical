namespace BookLibrary
{
    public class Book : IPrintable
    {
        private string author;
        private string name;
        private int ISBN;


        public Book(string author, string name, int ISBN)
        {
            this.author = author;
            this.name = name;
            this.ISBN = ISBN;
        }


        public void Print()
        {
            Console.WriteLine($"Book details:\nAuthor: {author}, Name: {name}, ISBN: {ISBN}");
        }
    }
}
 