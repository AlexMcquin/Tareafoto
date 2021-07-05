using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Tareafoto
{
   public class BaseDatos
    {

        readonly SQLiteAsyncConnection db;

        public BaseDatos(String dbpath)
        {
            db = new SQLiteAsyncConnection(dbpath);
            // Creacion de las tablas de la base de datos

            db.CreateTableAsync<Sitios>().Wait();
            db.CreateTableAsync<Imagenes>().Wait();

        }
        // Metodos del CRUD

        // Select
        public Task<List<Sitios>> ObtenerSitios()
        {
            return db.Table<Sitios>().ToListAsync();
        }


        public Task<List<Imagenes>> ObtenerImagen()
        {
            return db.Table<Imagenes>().ToListAsync();
        }


        // Insert
        public Task<int> InsertarSitio(Sitios ubicacion)
        {
           if (ubicacion.id != 0)
            {
               return db.UpdateAsync(ubicacion); // UPDATE
            }
            else
            {
                return db.InsertAsync(ubicacion); // INSERT
            }
        }

        public Task<int> InsertarImagen(Imagenes foto)
        {
            if (foto.id != 0)
            {
                return db.UpdateAsync(foto); // UPDATE
            }
            else
            {
                return db.InsertAsync(foto); // INSERT
            }
        }


        public Task<Sitios> ObtenerSitio(int pid)
        {
            return db.Table<Sitios>()
            .Where(i => i.id == pid)
            .FirstOrDefaultAsync();   
        }


        public Task<Imagenes> ObtenerImagen(int fid)
        {
            return db.Table<Imagenes>()
            .Where(i => i.id == fid)
            .FirstOrDefaultAsync();
        }

        // Delete
        public Task<int> EliminarSitio(Sitios ubicacion)
        {
            return db.DeleteAsync(ubicacion);
        }

        public Task<int> EliminarImagen(Imagenes foto)
        {
            return db.DeleteAsync(foto);
        }



    }
}
