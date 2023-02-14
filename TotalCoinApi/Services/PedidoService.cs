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
                new Pedido(1, "Pedido 1",false, new Mascota(1,"Carlos","true","13","3","false","1")),
                 new Pedido(2, "Pedido 2",false, new Mascota(2,"Piters","false","11","6","false","2"))
             };

        }

        public Task<List<Pedido>> CrearPedido(PedidoDTO pedido)
        {
            var index = Pedidos.Max(p => p.Id);
            Pedidos.Add(new Pedido(index++, pedido.Name, false, pedido.Mascota));
            return Task.FromResult(Pedidos.ToList());
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
