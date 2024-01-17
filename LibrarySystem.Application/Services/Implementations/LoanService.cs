using LibrarySystem.Application.InputModels;
using LibrarySystem.Application.Services.Interfaces;
using LibrarySystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Application.Services.Implementations
{
    public class LoanService : ILoanService
    {
        public void RegisterLoan(RegisterLoanInputModel registerLoanInputModel)
        {
            var loan = new Loan(registerLoanInputModel.UserId, registerLoanInputModel.BookId, registerLoanInputModel.LoanDate);

            // Logic to add in database
        }
    }
}
