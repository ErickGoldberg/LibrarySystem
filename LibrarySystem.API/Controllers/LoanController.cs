using LibrarySystem.Application.InputModels;
using LibrarySystem.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoanController : ControllerBase
    {
        private readonly ILoanService _loanService;

        public LoanController(ILoanService loanService)
        {
            _loanService = loanService;
        }

        [HttpPost]
        public IActionResult RegisterLoan([FromBody] RegisterLoanInputModel registerLoanInputModel)
        {
            _loanService.RegisterLoan(registerLoanInputModel);

            return Created("Loan made successfully!", _loanService);
        }
    }
}
