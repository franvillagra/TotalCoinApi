namespace TotalCoinApi.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EsPerro { get; set; }
        public string Peso { get; set; }
        public string Edad { get; set; }
        public string Castrado { get; set; }
        public string DuenioId { get; set; }
        public string? DuenioName { get; set; }

        public Mascota(int id, string name, string esPerro, string peso, string edad, string castrado, string duenioId)
        {
            Id = id;
            Name = name;
            EsPerro = esPerro;
            Edad = edad;
            Castrado = castrado;
            Peso = peso;
            DuenioId = duenioId;    
        }
    }
}
