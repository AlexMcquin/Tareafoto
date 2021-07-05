using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Tareafoto
{


    [Table("Sitios")]

    public class Sitios
    {
        [AutoIncrement, PrimaryKey]

        public int id { set; get; }

        [MaxLength(100)]
        public String nombre {set; get;}
    }
    

}
