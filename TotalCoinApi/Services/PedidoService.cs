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
                new Pedido(1, "Pedido 1",false, new Combo(1,3.4,1,false)),
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

        public async Task<bool> DespacharPedido(int pedido)
        {
            var pedidoEncontrado = this.Pedidos.Where(x => x.Id == pedido).ToList().FirstOrDefault();
            if (pedido == null)
                return false;

            pedidoEncontrado.Despachado = true;
            return true;
        }
    }
}
