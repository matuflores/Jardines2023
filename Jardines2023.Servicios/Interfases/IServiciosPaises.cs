using Jardines2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardines2023.Servicios.Interfases
{
    public interface IServiciosPaises
    {
        void Guardar(Pais pais);

        List<Pais> GetPaises();
    }
}
