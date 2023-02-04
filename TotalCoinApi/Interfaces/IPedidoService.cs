using TotalCoinApi.Models;

namespace TotalCoinApi.Interfaces
{
    public interface IPedidoService
    {
        Task<List<Pedido>> GetPedidosAsync();
        Task<int> CrearPedido(PedidoDTO pedido);
    }
}
