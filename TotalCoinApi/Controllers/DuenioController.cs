using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TotalCoinApi.Interfaces;
using TotalCoinApi.Models;

namespace TotalCoinApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DuenioController : ControllerBase
    {
        private readonly IDuenioService _duenioService;
        public DuenioController(IDuenioService service)
        {
            _duenioService = service;
        }


        [HttpGet]
        public async Task<IActionResult> GetDuenios()
        {
            var duenios = await _duenioService.GetDueniosAsync();

            return Ok(duenios);
        }



    }
}
