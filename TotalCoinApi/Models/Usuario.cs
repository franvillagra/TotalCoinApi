namespace TotalCoinApi.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Nombre { get; set; }
        public string Pass { get; set; }
        public bool EsVendedor { get; set; }
        public Usuario(int id, string user, string name,string pass, bool esvendedor)
        {
            Id = id;
            User = user;
            Nombre = name;
            Pass = pass;
            EsVendedor = esvendedor;
        }
    }
}
