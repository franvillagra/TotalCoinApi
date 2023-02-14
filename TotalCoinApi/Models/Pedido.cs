namespace TotalCoinApi.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Despachado { get; set; }
        public Combo Combo { get; set; }
        public Mascota Mascota { get; set; }

        public Pedido(int id, string name,bool despachado, Mascota combo)
        {
            Id = id;
            Name = name;
            Despachado = despachado;
            Mascota = combo;
        }
    }
}
