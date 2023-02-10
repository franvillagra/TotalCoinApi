using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TotalCoinApi.Interfaces;
using TotalCoinApi.Models;

namespace TotalCoinApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;
        public PedidoController(IPedidoService service)
        {
            _pedidoService = service;
        }


        [HttpGet]
        public async Task<IActionResult> GetPedidos()
        {
            var pedidos = await _pedidoService.GetPedidosAsync();

            return Ok(pedidos);
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> DespacharPedido([FromRoute] int id)
        {
            var pedidos = await _pedidoService.DespacharPedido(id);

            return Ok(pedidos);
        }

        [HttpPost]
        public async Task<IActionResult> CrearPedido(PedidoDTO pedido)
        {
            var pedidos = await _pedidoService.CrearPedido(pedido);

            return Ok(pedidos);
        }


    }
}
