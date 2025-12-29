using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domeni
{
    public class Licenca
    {
        public Ucitelj Ucitelj { get; set; }
        public Sertifikat Sertifikat { get; set; }
        public DateTime DatumDobijanja{ get; set; }
        public string NazivLicence { get; set; }
    }
}
