using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.ViewModels
{
    public class BookAuthorViewModel
    {
        public int bookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int authorId { get; set; }
        public List<Author> authors { get; set; }
    }
}
