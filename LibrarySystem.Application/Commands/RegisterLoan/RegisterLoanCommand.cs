using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Application.Commands.RegisterLoan
{
    public class RegisterLoanCommand : IRequest<int>
    {
        public int UserId { get; private set; }
        public int BookId { get; private set; }
    }
}
