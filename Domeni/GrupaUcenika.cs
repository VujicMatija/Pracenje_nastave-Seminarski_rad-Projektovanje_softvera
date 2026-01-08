using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domeni
{
    public class GrupaUcenika
    {
        public int IdGrupe{ get; set; }
        public string OznakaGrupe{ get; set; }
        public int BrojUcenika{ get; set; }
        public string Termin { get; set; }
        public Kurs Kurs { get; set; }

        public override string ToString()
        {
            return $"{OznakaGrupe}";
        }

        public override bool Equals(object? obj)
        {
            return obj is GrupaUcenika grupa
                && grupa.IdGrupe == IdGrupe
                && grupa.OznakaGrupe == OznakaGrupe;
        }
    }
}
