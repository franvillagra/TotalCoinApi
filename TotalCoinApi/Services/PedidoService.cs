using TotalCoinApi.Interfaces;
using TotalCoinApi.Models;

namespace TotalCoinApi.Services
{
    public class PedidoService : IPedidoService
    {
        List<Pedido> Pedidos;
        public PedidoService()
        {
            Pedidos = new List<Pedido>()
            {
                new Pedido(1, "Pedido 1",true, new Combo(1,3.4,1,false)),
                 new Pedido(2, "Pedido 2",false, new Combo(2,2.1,1,false))
             };

        }

        public Task<int> CrearPedido(PedidoDTO pedido)
        {
            var index = Pedidos.Max(p => p.Id);
            Pedidos.Add(new Pedido(index++, pedido.Name, false, pedido.Combo));
            return Task.FromResult(index++);
        }

        public async Task<List<Pedido>> GetPedidosAsync()
        {
            return this.Pedidos.ToList();
        }
    }
}
