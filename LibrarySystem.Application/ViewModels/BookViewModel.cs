using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Application.ViewModels
{
    public class BookViewModel
    {
        public string Title { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int PublicationYear { get; set; }
    }
}