using TotalCoinApi.Interfaces;
using TotalCoinApi.Models;

namespace TotalCoinApi.Services
{
    public class VendedorService : IVendedorService
    {
        List<Vendedor> Vendedores;
        public VendedorService()
        {
            Vendedores = new List<Vendedor>()
            {
                new Vendedor(1, "Juan Carlos"),
                 new Vendedor(2, "Jose Gomez")
             };

        }
        public async Task<List<Vendedor>> GetVendedoresAsync()
        {
            return this.Vendedores.ToList();
        }
        public Task<int> CrearVendedor(VendedorDTO vendedor)
        {
            var index = Vendedores.Max(p => p.Id);
            Vendedores.Add(new Vendedor(index++, vendedor.Name));
            return Task.FromResult(index++);
        }
    }
}
