using TotalCoinApi.Interfaces;
using TotalCoinApi.Models;

namespace TotalCoinApi.Services
{
    public class DuenioService : IDuenioService
    {
        List<Duenio> Duenios;
        public DuenioService()
        {
            Duenios = new List<Duenio>()
            {
                new Duenio(1, "Francisco Villagra"),
                 new Duenio(2, "Joaquin Dominguez")
             };

        }

        public async Task<List<Duenio>> GetDueniosAsync()
        {
            return this.Duenios.ToList();
        }

        public async Task<List<Mascota>> SetearDuenios(List<Mascota> mascotas)
        {
            foreach (var mascota in mascotas)
            {
                mascota.DuenioName = this.Duenios.Where(x => x.Id == mascota.DuenioId).First().Name;
            }
            return mascotas;
        }
    }
}
