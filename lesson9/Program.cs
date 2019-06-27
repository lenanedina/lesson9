using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
                   
                Console.WriteLine("обобщенная коллекция List:");

                Library library = new Library();
                Book book1 = new Book("Алиса в стране чуде", "Люис Кэрролл", "Англия");
                Book book2 = new Book("Сказки братьев Гримм", "Братья Гримм", "Германия");
                Book book3 = new Book("Питер Пен", "Барри Джеймс", "Шотландия");
                Book book4 = new Book("Хроники Нарнии", "Клайв Стэйплз Льюис", "Ирландия");
                Book book5 = new Book("Как приручить дракона", "Крессида Коуэлл", "Великобритания");
                library.Add(book1);
                library.Add(book2);
                library.Add(book3);
                library.Add(book4);
                library.Add(book5);
                Book book6 = new Book("Фердинанд", "Мунро Лиф", "США");
                library.Add(book6);
                
                foreach (var item in library.Lst)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Количество книг:" + library.Lst.Count);

                Console.WriteLine("-------------------:");
                library.Remove (book1);
                library.Remove(2);
                for (int i = 0; i < library.Lst.Count; i++)
                Console.WriteLine(library.Lst[i]);
                Console.WriteLine("Количество книг:" + library.Lst.Count);


            
        }
            

        
    }
}
