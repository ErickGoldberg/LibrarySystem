namespace LibrarySystem.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string name, string mail) 
        {
            Name = name;
            Mail = mail;
        }

        public string Name { get; private set; }
        public string Mail { get; private set; }
        public ICollection<Loan> Loans { get; private set; } = new List<Loan>();
    }
}
