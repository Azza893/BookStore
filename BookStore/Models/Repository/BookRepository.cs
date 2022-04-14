using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repository
{
    public class BookRepository:IBookStoreRepository<Book>
    {
        List<Book> books;
        public BookRepository()
        {
            books = new List<Book>()
            {
                new Book
                {
                    Id=1,Title="C#",Description="NO"
                },
                new Book
                {
                    Id=2,Title="C++",Description="NO"
                },
                new Book
                {
                    Id=3,Title="C",Description="NO"
                }
            };

        }
        public void Add(Book entity)
        {
            books.Add(entity);

        }

        public void Delete(int id)
        {
            var book = Find(id);
            books.Remove(book);

        }

        public Book Find(int id)
        {
            var book = books.SingleOrDefault(x => x.Id == id);
            return book;
        }

        public IList<Book> List()
        {
            return books;
        }

        public void Update(int id, Book entity)
        {
            var book = Find(id);
            book.Title = entity.Title;
            book.Description = entity.Description;
        }
    }
}
