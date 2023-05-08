using Jardines2023.Datos.Comun.Interfases;
using Jardines2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardines2023.Datos.Sql.Repositorios
{
    public class RepositorioPaises : IRepositorioPaises
    {
        private string cadenaConexion;
        public RepositorioPaises()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        public void Agregar(Pais pais)
        {
            throw new NotImplementedException();
        }

        public void Editar(Pais pais)
        {
            throw new NotImplementedException();
        }

        public Pais GetPais(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pais> GetPaises()
        {
            List<Pais> lista= new List<Pais>();
            using (var _conn=new SqlConnection(cadenaConexion))
            {
                _conn.Open();
                var selectQuery = "SELECT * FROM Paises ORDER BY NombrePais";
                using (var comando=new SqlCommand(selectQuery,_conn))
                {
                    using (var reader=comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var pais = new Pais()
                            {
                                PaisId = reader.GetInt32(0),
                                NombrePais=reader.GetString(1)
                            };
                            lista.Add(pais);
                        }
                    }
                }
                return lista;
            }
        }
    }
}
