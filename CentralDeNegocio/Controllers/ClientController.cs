using CentralDeNegocio.Application.Interfaces;
using CentralDeNegocio.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CentralDeNegocio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService clientService;

        public ClientController(IClientService clientService)
        {
            this.clientService = clientService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this.clientService.Get());
        }

        [HttpPost]
        public IActionResult Post(ClientViewModel clientViewModel)
        {
            return Ok(this.clientService.Post(clientViewModel));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            return Ok(this.clientService.GetById(id));
        }

        [HttpPut]
        public IActionResult Put(ClientViewModel clientViewModel)
        {
            return Ok(this.clientService.Put(clientViewModel));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            return Ok(this.clientService.Delete(id));
        }
    }
}
