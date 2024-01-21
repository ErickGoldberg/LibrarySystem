namespace LibrarySystem.Core.Entities
{
    public class Loan : BaseEntity
    {
        public Loan(int userId, int bookId) 
        {
            UserId = userId;
            BookId = bookId;

            LoanDate = DateTime.Now;
        }

        public int UserId { get; private set; }
        public int BookId { get; private set; }
        public DateTime LoanDate { get; private set; }
        public User User { get; set; }
        public Book Book { get; set; }
    }
}
