using TotalCoinApi.Interfaces;
using TotalCoinApi.Models;

namespace TotalCoinApi.Services
{
    public class AutenticacionService : IAutenticacionService
    {
        List<Usuario> Usuarios;
        public AutenticacionService()
        {
            Usuarios = new List<Usuario>()
            {
                new Usuario(1, "vendedor1","Martin Rodriguez","123",true),
                 new Usuario(2, "vendedor2","Jimena Gonzalez","234",true),
                  new Usuario(3, "cliente1","Francisco Villagra","aaa",false),
                   new Usuario(4, "cliente2","Joaquin Dominguez","bbb",false),
             };

        }


        public Task<bool> Login(UsuarioDTO usuario)
        {
            return Task.FromResult(Usuarios.Exists(user => user.User == usuario.User && user.Pass == usuario.Pass));
        }

        public Task<int> Registrar(UsuarioDTO usuario)
        {
            var index = Usuarios.Max(p => p.Id);
            Usuarios.Add(new Usuario(index++, usuario.User,usuario.Nombre,usuario.Pass, false));
            return Task.FromResult(index++);
        }
    }
}
