using Jardines2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardines2023.Datos.Comun.Interfases
{
    public interface IRepositorioPaises
    {
        List<Pais> GetPaises();
        Pais GetPais(int id);
        void Agregar(Pais pais);
        void Editar(Pais pais);
    }
}
