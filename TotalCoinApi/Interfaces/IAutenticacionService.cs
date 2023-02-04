using TotalCoinApi.Models;

namespace TotalCoinApi.Interfaces
{
    public interface IAutenticacionService
    {
        Task<bool> Login(UsuarioDTO usuario);
        Task<int> Registrar(UsuarioDTO usuario);
    }
}
