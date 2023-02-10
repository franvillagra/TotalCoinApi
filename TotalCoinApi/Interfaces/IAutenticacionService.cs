using TotalCoinApi.Models;

namespace TotalCoinApi.Interfaces
{
    public interface IAutenticacionService
    {
        Task<Usuario> Login(UsuarioDTO usuario);
        Task<bool> Registrar(UsuarioDTO usuario);
    }
}
