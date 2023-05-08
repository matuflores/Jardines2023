using Jardines2023.Datos.Comun.Interfases;
using Jardines2023.Datos.Sql.Repositorios;
using Jardines2023.Entidades.Entidades;
using Jardines2023.Servicios.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardines2023.Servicios.Servicios
{
    public class ServiciosPaises : IServiciosPaises
    {
        private readonly IRepositorioPaises _repositorioPaises;
        public ServiciosPaises()
        {
            _repositorioPaises=new RepositorioPaises();
        }
        public List<Pais> GetPaises()
        {
            try
            {
                return _repositorioPaises.GetPaises();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Pais pais)
        {
            throw new NotImplementedException();
        }
    }
}
