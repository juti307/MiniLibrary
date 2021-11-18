using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniLibrary.Models
{
    class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public DateTime Date { get; set; }



        public void AddBook(string name, string author, string genre)
        {
            if (name.Length == 0) { return; }
            using (var db = new BookContext())
            {
                Book book = new Book();
                book.Name = name;
                book.Author = author;
                book.Genre = genre;
                book.Date = DateTime.Today;
                db.Add(book);

                db.SaveChanges();
            }
            return;
        }

        public List<Book> BookList()
        {
            using (var db = new BookContext())
            {
                List<Book> books = new List<Book>();
                Book book = new Book();
                books = (from b in db.Books orderby Date select b).ToList();
                return books;
            }
        }

        public void DeleteBook(List<Book> books)
        {
            if (!books.Any()) { return;  }
            using (var db = new BookContext())
            {
                db.Remove(books[0]);
                db.SaveChanges();
            }
        }
        public List<Book> FindByTitle(string name)
        {
            using (var db = new BookContext())
            {
                List<Book> books = new List<Book>();
                Book book = new Book();
                books = (from b in db.Books where b.Name == name select b).ToList();
                return books;
            }
           
        }
        

        public List<Book> FindByAuthor(string author)
        {
            using (var db = new BookContext())
            {
                List<Book> books = new List<Book>();
                Book book = new Book();
                books = (from b in db.Books where b.Author == author select b).ToList();
                return books;
            }
        }

        public List<Book> FindByGenre(string genre)
        {
            using (var db = new BookContext())
            {
                List<Book> books = new List<Book>();
                Book book = new Book();
                books = (from b in db.Books where b.Genre == genre select b).ToList();
                return books;
            }
        }
    }
}
