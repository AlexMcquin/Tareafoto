using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Tareafoto
{


    [Table("Imagenes")]
    public class Imagenes
    {

        [AutoIncrement, PrimaryKey]
        public int id { get; set; }


        public string FileName { get; set; }

        public string Descripcion { get; set; }

        public byte[] Content { get; set; }
    }
}
