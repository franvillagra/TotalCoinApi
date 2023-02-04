using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TotalCoinApi.Interfaces;
using TotalCoinApi.Models;

namespace TotalCoinApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendendorController : ControllerBase
    {
        private readonly IVendedorService _vendedorService;
        public VendendorController(IVendedorService service)
        {
            _vendedorService = service;
        }


        // POST: MascotaController/Edit/5
        [HttpGet]
        public async Task<IActionResult> GetVendedores()
        {
            var vendedores = await _vendedorService.GetVendedoresAsync();

            return Ok(vendedores);
        }
        [HttpPost]
        public async Task<IActionResult> CrearVendedor(VendedorDTO mascotadto)
        {
            var mascota = await _vendedorService.CrearVendedor(mascotadto);

            return Ok(mascota);
        }

    }
}
