using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TotalCoinApi.Interfaces;
using TotalCoinApi.Models;

namespace TotalCoinApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutenticacionController : ControllerBase
    {
        private readonly IAutenticacionService _autenticacionService;
        public AutenticacionController(IAutenticacionService service)
        {
            _autenticacionService = service;
        }


        [HttpPost]
        public async Task<IActionResult> Login(UsuarioDTO usuario)
        {
            var response = await _autenticacionService.Login(usuario);
          
            return Ok(response);
        }

        [HttpPost("/signup")]
        public async Task<IActionResult> Registrar(UsuarioDTO usuario)
        {
            var response = await _autenticacionService.Registrar(usuario);

            return Ok(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var response = await _autenticacionService.GetUsuarios();

            return Ok(response);
        }


    }
}
