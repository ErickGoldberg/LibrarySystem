using LibrarySystem.Application.Commands.CreateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterUser([FromBody] CreateUserCommand command)
        {
            await _mediator.Send(command);

            return Created("User created successfully!", command.Name);
        }
    }
}
