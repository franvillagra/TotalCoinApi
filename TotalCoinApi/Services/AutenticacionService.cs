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
                new Usuario(4, "vendedor1","Martin Rodriguez","123",true),
                 new Usuario(3, "vendedor2","Jimena Gonzalez","234",true),
                  new Usuario(1, "cliente1","Francisco Villagra","aaa",false),
                   new Usuario(2, "cliente2","Joaquin Dominguez","bbb",false),
             };

        }

        public Task<List<Usuario>> GetUsuarios()
        {
            return Task.FromResult(Usuarios.ToList());
        }

        public Task<Usuario> Login(UsuarioDTO usuario)
        {
            return Task.FromResult(Usuarios.Where(user => user.User == usuario.User && user.Pass == usuario.Pass).FirstOrDefault());
        }

        public Task<List<Usuario>> Registrar(UsuarioDTO usuario)
        {
            
            var index = Usuarios.Max(p => p.Id);
            if (Usuarios.Exists(x => x.User == usuario.User))
                return Task.FromResult(new List<Usuario>()); ;
            Usuarios.Add(new Usuario(index++, usuario.User,usuario.Nombre,usuario.Pass, false));
            return Task.FromResult(this.Usuarios.ToList());
        }
    }
}
