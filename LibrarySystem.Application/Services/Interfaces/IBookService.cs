using LibrarySystem.Application.InputModels;
using LibrarySystem.Application.ViewModels;
using LibrarySystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Application.Services.Interfaces
{
    public interface IBookService
    {
        List<BookViewModel> GetAllBooks();
        BookViewModel GetBookById(int id);
        void RegisterBook(RegisterBookInputModel registerBookInputModel);
        void DeleteBook(int id);
    }
}
