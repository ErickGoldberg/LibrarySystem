using LibrarySystem.Application.InputModels;
using LibrarySystem.Application.Services.Interfaces;
using LibrarySystem.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Register")]
        public IActionResult RegisterUser([FromBody] CreateUserInputModel userInputModel)
        {   
            _userService.RegisterUser(userInputModel);

            return Created("User created successfully!", _userService);
        }
    }
}
