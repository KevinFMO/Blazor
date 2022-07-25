using Blazor.Interfaces;
using Modelos;

namespace Blazor.Servicios
{
    public class UsuarioServicio : IUsuarioServicio
    {
        public Task<bool> Actualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> GetLista(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> GetPorCodigo(string codigo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Nuevo(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
