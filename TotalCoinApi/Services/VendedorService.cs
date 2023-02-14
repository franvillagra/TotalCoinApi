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
                new Vendedor(1, "Martin Rodriguez"),
                 new Vendedor(2, "Jimena Gonzalez")
             };

        }
        public async Task<List<Vendedor>> GetVendedoresAsync()
        {
            return this.Vendedores.ToList();
        }
        public Task<List<Vendedor>> CrearVendedor(VendedorDTO vendedor)
        {
            var index = Vendedores.Max(p => p.Id);
            Vendedores.Add(new Vendedor(index++, vendedor.Name));

            return GetVendedoresAsync();
        }
    }
}
