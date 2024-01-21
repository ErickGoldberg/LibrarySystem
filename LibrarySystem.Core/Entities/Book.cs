namespace LibrarySystem.Core.Entities
{
    public class Book : BaseEntity
    {
        private Book() { }
        public Book(string title, string autor, string isbn, int publicationYear) 
        {
            Title = title;
            Autor = autor;
            ISBN = isbn;
            PublicationYear = publicationYear;
        }

        public string Title { get; private set; }
        public string Autor { get; private set; }
        public string ISBN { get; private init; }
        public int PublicationYear { get; private set; }
        public ICollection<Loan> Loans { get; private set; } = new List<Loan>();
    }
}
