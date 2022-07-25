using Modelos;

namespace Blazor.Interfaces
{
    public interface IUsuarioServicio
    {
        Task<bool> Nuevo(Usuario usuario);
        Task<bool> Actualizar(Usuario usuario);
        Task<bool> Eliminar(Usuario usuario);
        Task<IEnumerable<Usuario>> GetLista(Usuario usuario);
        Task<Usuario> GetPorCodigo(string codigo);
    }
}
