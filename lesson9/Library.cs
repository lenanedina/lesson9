using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    class Library
    {

        List<Book> lst;

        public Library()
        {
            Lst = new List<Book>();
        }

        internal List<Book> Lst { get => lst; set => lst = value; }

        public void Add(Book book)
        {
            Lst.Add(book);

        }
        public void Remove (Book book)
        {
            Lst.Remove(book);
        }
        public void Remove(int n)
        {
            Lst.RemoveAt(n);
        }
       
    }
}




    


