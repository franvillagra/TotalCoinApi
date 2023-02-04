using TotalCoinApi.Models;

namespace TotalCoinApi.Interfaces
{
    public interface IVendedorService
    {
        Task<List<Vendedor>> GetVendedoresAsync();
        Task<int> CrearVendedor(VendedorDTO vendedor);
    }
}
