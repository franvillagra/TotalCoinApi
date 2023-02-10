using TotalCoinApi.Models;

namespace TotalCoinApi.Interfaces
{
    public interface IDuenioService
    {
        Task<List<Duenio>> GetDueniosAsync();
        Task<List<Mascota>> SetearDuenios(List<Mascota> mascotas);
    }
}
