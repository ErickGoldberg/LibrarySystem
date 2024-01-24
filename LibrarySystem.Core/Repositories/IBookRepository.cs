using LibrarySystem.Core.DTOs;
using LibrarySystem.Core.Entities;

namespace LibrarySystem.Core.Repositories
{
    public interface IBookRepository
    {
        Task<List<BookDto>> GetAllAsync();
        Task<BookDto> GetByIdAsync(int id);
        Task<int> RegisterAsync(BookDto book);
        Task DeleteAsync(Book book);
    }
}
