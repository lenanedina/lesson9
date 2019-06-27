using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    public class Book
    {
        string name, author,country;

        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public string Country { get => country; set => country = value; }

        public Book(string name, string author, string country)
        {
            Name = name;
            Author = author;
            Country = country;
        }

        public override string ToString()
        {
            return $"Название книги:{Name},\nАвтор:{Author},\n Страна:{Country}\n";
        }
    }



}
