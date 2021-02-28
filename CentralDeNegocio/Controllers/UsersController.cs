using CentralDeNegocio.Application.Interfaces;
using CentralDeNegocio.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CentralDeNegocio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this.userService.Get());
        }

        [HttpPost]
        public IActionResult Post(UserViewModel userViewModel)
        {
            return Ok(this.userService.Post(userViewModel));
        }
    }
}
