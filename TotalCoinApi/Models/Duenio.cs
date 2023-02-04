namespace TotalCoinApi.Models
{
    public class Duenio
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Duenio(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
