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
                new Duenio(1, "Francisco"),
                 new Duenio(2, "Pedro")
             };

        }

        public async Task<List<Duenio>> GetDueniosAsync()
        {
            return this.Duenios.ToList();
        }
    }
}
