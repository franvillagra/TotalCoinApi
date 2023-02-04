using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TotalCoinApi.Interfaces;
using TotalCoinApi.Models;

namespace TotalCoinApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MascotaController : ControllerBase
    {
        private readonly IMascotaService _mascotaService;
        public MascotaController(IMascotaService service)
        {
            _mascotaService = service;
        }


        // POST: MascotaController/Edit/5
        [HttpGet]
        public async Task<IActionResult> GetMascotas()
        {
            var mascotas = await _mascotaService.GetMascotasAsync();

            return Ok(mascotas);
        }
        [HttpPost]
        public async Task<IActionResult> CrearMascota(MascotaDTO mascotadto)
        {
            var mascota = await _mascotaService.CrearMascota(mascotadto);

            return Ok(mascota);
        }

    }
}
