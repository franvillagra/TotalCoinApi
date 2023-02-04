namespace TotalCoinApi.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool EsPerro { get; set; }
        public double Peso { get; set; }
        public int Edad { get; set; }
        public bool Castrado { get; set; }

        public Mascota(int id, string name, bool esPerro,double peso,int edad,bool castrado)
        {
            Id = id;
            Name = name;
            EsPerro = esPerro;
            Edad = edad;
            Castrado = castrado;
            Peso = peso;
        }
    }
}
