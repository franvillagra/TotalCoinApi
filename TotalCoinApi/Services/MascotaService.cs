using TotalCoinApi.Interfaces;
using TotalCoinApi.Models;

namespace TotalCoinApi.Services
{
    public class MascotaService : IMascotaService
    {
        List<Mascota> Mascotas;
        public MascotaService()
        {
            Mascotas = new List<Mascota>()
            {
                new Mascota(1, "Maiko",true,5.7,3,false),
                 new Mascota(2, "Laila",false,3.2,5,true)
             };

        }

        public async Task<List<Mascota>> GetMascotasAsync()
        {
            return this.Mascotas.ToList();
        }

        public Task<int> CrearMascota(MascotaDTO mascota)
        {
            var index = Mascotas.Max(p => p.Id);
            Mascotas.Add(new Mascota(index++, mascota.Name, mascota.EsPerro,mascota.Peso,mascota.Edad,mascota.Castrado));
            return Task.FromResult(index++);
        }
    }
}
