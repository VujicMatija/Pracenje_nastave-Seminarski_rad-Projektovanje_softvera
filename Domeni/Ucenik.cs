using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domeni
{
    public class Ucenik
    {
        public int IdUcenika{ get; set; }
        public string ImeUcenika { get; set; }
        public string PrezimeUcenika { get; set; }
        public Pol PolUcenika { get; set; }
        public string ImeRoditelja{ get; set; }
        public string PrezimeRoditelja { get; set; }
        public string TelefonRoditelja{ get; set; }
        public DateTime DatumRodjenjaUcenika { get; set; }
        public string TelefonUcenika{ get; set; }
        public string EmailUcenika { get; set; }

        public override string ToString()
        {
            return $"{ImeUcenika} {ImeRoditelja.Substring(0,1)}. {PrezimeUcenika}";
        }

    }
}
