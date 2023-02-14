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
        private readonly IDuenioService _duenioService;
        public MascotaController(IMascotaService service, IDuenioService duenioService)
        {
            _mascotaService = service;
            _duenioService = duenioService; 
        }


        // POST: MascotaController/Edit/5
        [HttpGet]
        public async Task<IActionResult> GetMascotas()
        {
            var mascotas = await _mascotaService.GetMascotasAsync();
            mascotas = await _duenioService.SetearDuenios(mascotas);
            return Ok(mascotas);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMascotasDuenio([FromRoute]string id)
        {
            var mascotas = await _mascotaService.GetMascotasDuenio(id);

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
