using System.Collections.Generic;

using projek.api.Entidades;

namespace projek.api.Interfaces
{
    public interface IProjeto
    {
        List<Projeto> GetAll();
        Projeto GetId(int id);
        Projeto Create(Projeto usuario);
        void Delete(Projeto usuario);
        void Update(Projeto usuario);
    }
}