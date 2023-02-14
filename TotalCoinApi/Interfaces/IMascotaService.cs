using TotalCoinApi.Models;

namespace TotalCoinApi.Interfaces
{
    public interface IMascotaService
    {
        Task<List<Mascota>> GetMascotasDuenio(string id);
        Task<List<Mascota>> GetMascotasAsync();
        Task<List<Mascota>> CrearMascota(MascotaDTO pedido);

    }
}
