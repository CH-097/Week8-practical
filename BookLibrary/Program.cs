using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BookLibrary
{
    internal class Program
    {
        public static void Main(string[] args)
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
