using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PokemonNegocio
    {
        private AccesoDatos datos; 
        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select numero,nombre,P.descripcion,UrlImagen,E.Descripcion Tipo, D.Descripcion Debilidad,idTipo,idDebilidad,P.Id from POKEMONS P , ELEMENTOS E , ELEMENTOS D where E.Id=P.IdTipo and   D.Id=P.IdDebilidad and Activo=1");
                datos.ejecutarConsulta();
                while (datos.Lector.Read())
                {
                    Pokemon poke = new Pokemon();
                    poke.Nombre = (string)datos.Lector["nombre"];
                    poke.Numero = (int)datos.Lector["numero"];
                    poke.Descripcion = (string)datos.Lector["descripcion"];

                    if (!(datos.Lector["UrlImagen"] is DBNull))
                    poke.UrlImagen = (string)datos.Lector["UrlImagen"];
                  
                    poke.Id = (int)datos.Lector["Id"];
                    poke.Tipo = new Elemento();
                    poke.Tipo.Id = (int)datos.Lector["idTipo"];
                    poke.Tipo.Descripcion = (string)datos.Lector["tipo"];
                    poke.Debilidad = new Elemento();
                    poke.Debilidad.Id = (int)datos.Lector["idDebilidad"];
                    poke.Debilidad.Descripcion = (string)datos.Lector["debilidad"];
                    lista.Add(poke);
                }
                return lista;
            }
            catch (Exception ex)
            {
               throw ex;
            }finally
            {
                datos.cerrarConexion();
            }
           
        }
        public void agregar(Pokemon nuevo)
        {
            datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("insert into POKEMONS (Numero,Nombre,Descripcion,Activo,idTipo,idDebilidad,UrlImagen)values(@numero,@nombre,@descripcion,1,@idTipo,@idDebilidad,@urlImagen)");
                datos.setearParametro("@numero",nuevo.Numero);
                datos.setearParametro("@nombre",nuevo.Nombre);
                datos.setearParametro("@descripcion",nuevo.Descripcion);
                datos.setearParametro("@idTipo",nuevo.Tipo.Id);
                datos.setearParametro("@idDebilidad",nuevo.Debilidad.Id);
                datos.setearParametro("@urlImagen",nuevo.UrlImagen);
                datos.ejecutarAccion();

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
        public void modificar(Pokemon modificado)
        {
            datos=new AccesoDatos();
            try
            {
                datos.setearConsulta("update POKEMONS set Numero = @numero , Nombre = @nombre,Descripcion= @descripcion,UrlImagen=@urlImagen,IdTipo=@IdTipo,IdDebilidad=@IdDebilidad where id = @id");
                datos.setearParametro("@numero",modificado.Numero);
                datos.setearParametro("@nombre",modificado.Nombre);
                datos.setearParametro("@descripcion",modificado.Descripcion);
                datos.setearParametro("@urlImagen",modificado.UrlImagen);
                datos.setearParametro("@idTipo",modificado.Tipo.Id);
                datos.setearParametro("@idDebilidad",modificado.Debilidad.Id);
                datos.setearParametro("@id",modificado.Id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }finally { datos.cerrarConexion();}
        }
        public void eliminarFisico(Pokemon eliminado)
        {
            datos =new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from pokemons where id=@id");
                datos.setearParametro("@id",eliminado.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {  datos.cerrarConexion();}
        }
        public void eliminarLogico(Pokemon eliminadoLogico)
        {
            datos=new AccesoDatos();
            try
            {
                datos.setearConsulta("update POKEMONS set Activo = 0 where id=@id");
                datos.setearParametro("@id", eliminadoLogico.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
