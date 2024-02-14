using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ElementoNegocio
    {
        private AccesoDatos datos;
        public List<Elemento> listar()
        {
            datos = new AccesoDatos();
            List<Elemento> lista = new List<Elemento>();    
            try
            {
                datos.setearConsulta("select id,descripcion from ELEMENTOS");
                datos.ejecutarConsulta();
                while (datos.Lector.Read())
                {
                    Elemento elemento = new Elemento();
                    elemento.Descripcion = (string)datos.Lector["descripcion"];
                    elemento.Id = (int)datos.Lector["id"];
                    lista.Add(elemento);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
    }
}
