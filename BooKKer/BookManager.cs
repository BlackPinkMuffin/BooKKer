using System;
using System.Collections.Generic;
using System.Linq;

namespace BooKKer
{
    public class BookManager
    {
        private List<Book> books = new List<Book>();

        public void SetBooks(List<Book> loadedBooks) => books = loadedBooks;
        public void AddBook(Book book) => books.Add(book);
        public bool RemoveBook(Book book) => books.Remove(book);
        public List<Book> FindBookByName(string name) =>
            books.Where(b => b.Title.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        public List<Book> FindBookByAuthor(string author) =>
            books.Where(b => b.Author.Contains(author, StringComparison.OrdinalIgnoreCase)).ToList();
        public List<Book> GetAllBooks() => books;
    }
}
