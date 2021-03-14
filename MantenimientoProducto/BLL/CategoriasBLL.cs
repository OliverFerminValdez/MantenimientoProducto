using MantenimientoProducto.DAL;
using MantenimientoProducto.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoProducto.BLL
{
    public class CategoriasBLL
    {

        public static bool Guardar(Categorias producto)
        {
            Contexto db = new Contexto();
            bool Guardado = false;

            try
            {
                db.Categorias.Add(producto);
                Guardado = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Guardado;
        }
        public static Categorias Buscar(int id)
        {
            Contexto db = new Contexto();
            Categorias producto = new Categorias();

            try
            {
                producto = db.Categorias.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return producto;
        }
        public static bool Eliminar(int id)
        {
            Contexto db = new Contexto();
            bool Eliminado = false;

            try
            {
                Categorias AEliminar = db.Categorias.Find(id);
                db.Entry(AEliminar).State = EntityState.Deleted;
                Eliminado = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Eliminado;
        }

        public static bool Modificar(Categorias producto)
        {
            Contexto db = new Contexto();
            bool Modificado = false;

            try
            {
                db.Entry(producto).State = EntityState.Modified;
                Modificado = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Modificado;
        }
        public static List<Categorias> GetCategorias()
        {
            Contexto db = new Contexto();
            List<Categorias> Categorias = new List<Categorias>();

            try
            {
                Categorias = db.Categorias.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Categorias;
        }
    }
}
