namespace TotalCoinApi.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Despachado { get; set; }
        public Combo Combo { get; set; }

        public Pedido(int id, string name,bool despachado, Combo combo)
        {
            Id = id;
            Name = name;
            Despachado = despachado;
            Combo = combo;
        }
    }
}
