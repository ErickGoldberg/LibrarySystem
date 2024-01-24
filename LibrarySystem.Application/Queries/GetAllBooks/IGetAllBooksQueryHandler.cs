using LibrarySystem.Application.ViewModels;

namespace LibrarySystem.Application.Queries.GetAllBooks
{
    public interface IGetAllBooksQueryHandler
    {
        Task<List<BookViewModel>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken);
    }
}