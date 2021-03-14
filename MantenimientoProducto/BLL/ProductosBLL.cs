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
    public class ProductosBLL
    {
        
        public static bool Guardar(Productos producto)
        {
            Contexto db = new Contexto();
            bool Guardado = false;

            try
            {
                db.Productos.Add(producto);
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
        public static Productos Buscar(int id)
        {
            Contexto db = new Contexto();
            Productos producto = new Productos();

            try
            {
                producto = db.Productos.Find(id);
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
                Productos AEliminar = db.Productos.Find(id);
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

        public static bool Modificar(Productos producto)
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
        public static List<Productos> GetProductos()
        {
            Contexto db = new Contexto();
            List<Productos> Productos = new List<Productos>();

            try
            {
                Productos = db.Productos.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Productos;
        }
    }
}
