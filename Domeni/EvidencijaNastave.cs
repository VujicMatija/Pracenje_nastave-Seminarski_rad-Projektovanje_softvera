using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domeni
{
    public class EvidencijaNastave
    {
        public int IdEvidencijeNastave { get; set; }
        public bool StatusAktivnosti { get; set; }
        public DateTime DatumPocetkaRada { get; set; }
        public Ucitelj Ucitelj { get; set; }
        public GrupaUcenika Grupa { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is EvidencijaNastave evd && IdEvidencijeNastave == evd.IdEvidencijeNastave && StatusAktivnosti == evd.StatusAktivnosti
                && DatumPocetkaRada == evd.DatumPocetkaRada && Ucitelj.Id == evd.Ucitelj.Id && Grupa.IdGrupe == evd.Grupa.IdGrupe;
        }

        public override int GetHashCode()
        {
            return IdEvidencijeNastave.GetHashCode();
        }
    }
}
