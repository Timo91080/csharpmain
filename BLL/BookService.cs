using BiblioWorld.DAL;
using BiblioWorld.Models;
using System.Collections.Generic;
using System.Linq;

namespace BiblioWorld.BLL
{
    public class BookService
    {
        private readonly BookRepository _repository;

        public BookService()
        {
            _repository = new BookRepository();
        }

        public List<Book> GetBooks()
        {
            return _repository.GetAllBooks();
        }

        public void AddBook(Book book)
        {
            _repository.AddBook(book);
        }

        public void DeleteBook(int bookId)
        {
            _repository.DeleteBook(bookId);
        }

        public List<string> GetAuthors()
        {
            return _repository.GetAuthors();
        }

        public List<string> GetGenres()
        {
            return _repository.GetGenres();
        }


        public List<Book> FilterBooks(string authorName, string genreName)
            => _repository.FilterBooks(authorName, genreName);

    }
}
