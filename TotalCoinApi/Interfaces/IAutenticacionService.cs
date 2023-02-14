using TotalCoinApi.Models;

namespace TotalCoinApi.Interfaces
{
    public interface IAutenticacionService
    {
        Task<List<Usuario>> GetUsuarios();
        Task<Usuario> Login(UsuarioDTO usuario);
        Task<List<Usuario>> Registrar(UsuarioDTO usuario);
    }
}
