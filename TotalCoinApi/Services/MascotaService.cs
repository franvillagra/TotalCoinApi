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
                new Mascota(1, "Maiko","false","5.7","3","false","1"),
                 new Mascota(2, "Laila","false","3.2","5","false","2"),
                   new Mascota(3, "Piter","false","3.2","5","false","1")
             };

        }

        public async Task<List<Mascota>> GetMascotasAsync()
        {
            return this.Mascotas.ToList();
        }

        public Task<List<Mascota>> CrearMascota(MascotaDTO mascota)
        {
            var index = Mascotas.Max(p => p.Id);
            Mascotas.Add(new Mascota(index++, mascota.Name, mascota.EsPerro,mascota.Peso,mascota.Edad,mascota.Castrado,mascota.Duenio));
            return GetMascotasAsync();
        }

        public async Task<List<Mascota>> GetMascotasDuenio(string duenio)
        {
            return this.Mascotas.Where(x => x.DuenioId == duenio).ToList();
        }

    }
}
