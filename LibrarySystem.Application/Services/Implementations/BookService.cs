using LibrarySystem.Application.InputModels;
using LibrarySystem.Application.Services.Interfaces;
using LibrarySystem.Application.ViewModels;
using LibrarySystem.Core.Entities;
using LibrarySystem.Infrastructure.Persistence;

namespace LibrarySystem.Application.Services.Implementations
{
    public class BookService : IBookService
    {
        private readonly LibrarySystemDbContext _dbContext;

        public BookService(LibrarySystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<BookViewModel> GetAllBooks()
        {
            var books = _dbContext.Books.Select(book => new BookViewModel
            {
                Autor = book.Autor,
                Title = book.Title,
                ISBN = book.ISBN,
                PublicationYear = book.PublicationYear
            }).ToList();

            return books;
        }

        public BookViewModel GetBookById(int id)
        {
            var book = _dbContext.Books.SingleOrDefault(i => i.Id == id);

            return book != null ? new BookViewModel
            {
                Autor = book.Autor,
                Title = book.Title,
                ISBN = book.ISBN,
                PublicationYear = book.PublicationYear
            } : null;
        }

        public int RegisterBook(RegisterBookInputModel registerBookInputModel)
        {
            var book = new Book(registerBookInputModel.Title,
                                registerBookInputModel.Autor,
                                registerBookInputModel.ISBN,
                                registerBookInputModel.PublicationYear);

            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();

            return book.Id;
        }

        public void DeleteBook(int id)
        {
            var book = _dbContext.Books.SingleOrDefault(i => i.Id == id);

            if (book != null)
            {
                _dbContext.Books.Remove(book);
                _dbContext.SaveChanges();
            }

            return;
        }
    }
}
