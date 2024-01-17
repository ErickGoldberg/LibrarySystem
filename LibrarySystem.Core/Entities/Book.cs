using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Core.Entities
{
    public class Book : BaseEntity
    {
        public Book() { }

        public string Title { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int PublicationYear { get; set; }
    }
}
