using LibrarySystem.Application.Commands.RegisterLoan;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoanController : ControllerBase
    {
        private IMediator _mediator;

        public LoanController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterLoan([FromBody] RegisterLoanCommand command)
        {
            var loanId = await _mediator.Send(command);

            return Created("Loan made successfully!", loanId);
        }
    }
}
