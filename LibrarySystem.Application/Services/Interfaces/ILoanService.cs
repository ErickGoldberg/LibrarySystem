using LibrarySystem.Application.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Application.Services.Interfaces
{
    public interface ILoanService
    {
        void RegisterLoan(RegisterLoanInputModel registerLoanInputModel);
    }
}
