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
                new Mascota(1, "Maiko",true,5.7,3,false,1),
                 new Mascota(2, "Laila",false,3.2,5,true,2)
             };

        }

        public async Task<List<Mascota>> GetMascotasAsync()
        {
            return this.Mascotas.ToList();
        }

        public Task<int> CrearMascota(MascotaDTO mascota)
        {
            var index = Mascotas.Max(p => p.Id);
            Mascotas.Add(new Mascota(index++, mascota.Name, mascota.EsPerro,mascota.Peso,mascota.Edad,mascota.Castrado,mascota.Duenio));
            return Task.FromResult(index++);
        }

        public async Task<List<Mascota>> GetMascotasDuenio(int duenio)
        {
            return this.Mascotas.Where(x => x.DuenioId == duenio).ToList();
        }

    }
}
