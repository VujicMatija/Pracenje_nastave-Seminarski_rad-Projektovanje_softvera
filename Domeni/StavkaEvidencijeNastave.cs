using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domeni
{
    public class StavkaEvidencijeNastave
    {
        public int rbStavkeEvidencijeNastave { get; set; }
        public Ucenik Ucenik { get; set; }
        public int RedniBrojCasa { get; set; }
       
        public bool Prisustvo { get; set; }
        public string Komentar { get; set; }
        public bool UradjenDomaci { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public EvidencijaNastave Evidencija { get; set; }
    }
}
