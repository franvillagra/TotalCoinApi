namespace TotalCoinApi.Models
{
    public class Duenio
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Duenio(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
