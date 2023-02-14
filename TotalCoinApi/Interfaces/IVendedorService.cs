using TotalCoinApi.Models;

namespace TotalCoinApi.Interfaces
{
    public interface IVendedorService
    {
        Task<List<Vendedor>> GetVendedoresAsync();
        Task<List<Vendedor>> CrearVendedor(VendedorDTO vendedor);
    }
}
