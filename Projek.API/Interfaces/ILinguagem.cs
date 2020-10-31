using System.Collections.Generic;

using projek.api.Entidades;

namespace projek.api.Interfaces
{
    public interface ILinguagem
    {
        List<Linguagem> GetAll();
        Linguagem GetId(int id);
        Linguagem Create(Linguagem usuario);
        void Delete(Linguagem usuario);
        void Update(Linguagem usuario);
    }
}