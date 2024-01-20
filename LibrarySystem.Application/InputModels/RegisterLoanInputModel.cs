using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Application.InputModels
{
    public class RegisterLoanInputModel
    {
        public int UserId { get; private set; }
        public int BookId { get; private set; }
    }
}
