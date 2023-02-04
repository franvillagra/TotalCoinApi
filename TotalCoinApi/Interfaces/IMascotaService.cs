using TotalCoinApi.Models;

namespace TotalCoinApi.Interfaces
{
    public interface IMascotaService
    {
        Task<List<Mascota>> GetMascotasAsync();
        Task<int> CrearMascota(MascotaDTO pedido);

    }
}
