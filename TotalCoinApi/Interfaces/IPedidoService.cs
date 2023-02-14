using TotalCoinApi.Models;

namespace TotalCoinApi.Interfaces
{
    public interface IPedidoService
    {
        Task<List<Pedido>> GetPedidosAsync();
        Task<List<Pedido>> CrearPedido(PedidoDTO pedido);
        Task<bool> DespacharPedido(int pedido);
    }
}
