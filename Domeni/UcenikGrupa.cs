using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domeni
{
    public class UcenikGrupa
    {
        public Ucenik ucenik { get; set; }

        public GrupaUcenika grupaUcenika { get; set; }

        public override string ToString()
        {
            return $"{ucenik.ToString} - {grupaUcenika.ToString()}";
        }

        public override bool Equals(object? obj)
        {
            return obj is UcenikGrupa ug 
                && ug.ucenik.IdUcenika == ucenik.IdUcenika 
                && ug.grupaUcenika.IdGrupe == grupaUcenika.IdGrupe; 

        }
    }
}
