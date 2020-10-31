using System.Collections.Generic;

using projek.api.Entidades;

namespace projek.api.Interfaces
{
    public interface IUsuario
    {
        List<Usuario> GetAll();
        Usuario GetId(int id);
        Usuario Create(Usuario usuario);
        void Delete(Usuario usuario);
        void Update(Usuario usuario);
    }
}