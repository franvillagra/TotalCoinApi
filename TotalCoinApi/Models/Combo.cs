namespace TotalCoinApi.Models
{
    public class Combo
    {
        public int Id { get; set; }
        public double CantidadAlimento { get; set; }
        public int ComplementoDietario { get; set; }
        public bool ComplementoDietarioExtra { get; set; }

        public Combo(int id, double cantidadalimento, int complementodietario,  bool complementodietarioextra)
        {
            Id = id;
            CantidadAlimento = cantidadalimento;
            ComplementoDietario = complementodietario;
            ComplementoDietarioExtra = complementodietarioextra;
        }
    }
}
