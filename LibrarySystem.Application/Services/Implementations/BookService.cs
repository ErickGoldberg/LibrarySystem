using LibrarySystem.Application.InputModels;
using LibrarySystem.Application.Services.Interfaces;
using LibrarySystem.Application.ViewModels;
using LibrarySystem.Core.Entities;

namespace LibrarySystem.Application.Services.Implementations
{
    public class BookService : IBookService
    {
        public List<BookViewModel> GetAllBooks()
        {
            //Get no banco para retornar book var book

            // atribuir book a bookViewModel

            throw new NotImplementedException();
        }

        public BookViewModel GetBookById(int id)
        {
            //Get no banco para retornar book var book

            // atribuir book a bookViewModel

            throw new NotImplementedException();
        }

        public void RegisterBook(RegisterBookInputModel registerBookInputModel)
        {
            var book = new Book(registerBookInputModel.Title,
                                registerBookInputModel.Autor,
                                registerBookInputModel.ISBN,
                                registerBookInputModel.PublicationYear);

            // add to database

            throw new NotImplementedException();
        }

        public void DeleteBook(int id)
        {
            // 
            throw new NotImplementedException();
        }
    }
}
