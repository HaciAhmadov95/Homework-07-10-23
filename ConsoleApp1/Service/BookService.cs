using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Service
{
    internal class BookService
    {
        private Book[] GetAll()
        {
            Book book1 = new()
            {
                id = 1,
                Name = "Qoca ve Deniz",
                Author = "Ernest",
                PageCount = 100,
            };

            Book book2 = new()
            {
                id = 2,
                Name = "Manga",
                Author = "Anonim",
                PageCount = 200,
            };


            Book book3 = new()
            {
                id = 3,
                Name = "Mor ve Otesi",
                Author = "Cambaz",
                PageCount = 300,
            };

            return new Book[] { book1, book2, book3 };

        }


        public Book[] GetAllByAuthor(string author)
        {
            Book[] books = GetAll();

            Book[] filteredBooks = books.Where(m => m.Author == author).ToArray();

            return filteredBooks;
            //        }

            public Book GetById(int id)
            {
                Book[] books = GetAll();

                Book book = books.FirstOrDefault(m => m.id == id);

                return book;
            }


//        public Book[] SearchByName(string searchtext)
//        {
//            return GetAll().Where(m => m.Name.ToLower().Contains(searchtext.ToLower())).ToArray();
//        }

//    }
//}
