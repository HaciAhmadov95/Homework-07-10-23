using ConsoleApp1.Models;
using ConsoleApp1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controller
{
    internal class BookController
    {
        public void GetAllByAuthor()
        {
            string authorName = "Ernest";

            BookService bookService = new BookService();

            Book[] result = bookService.GetAllByAuthor(authorName);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Author}");
            }
        }

        public void GetById()
        {
            int id = 2;

            BookService bookService = new BookService();

            var result = bookService.GetById(id);

            Console.WriteLine(result.Name + "-" + result.Author);
        }

        public void Search()
        {
            BookService bookService = new BookService();
            var result = bookService.SearchByName("a");
            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
