using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domeni
{
    public class Kurs
    {
        public int IdKursa { get; set; }
        public string NazivKursa { get; set; }
        public TezinaKursa TezinaKursa { get; set; }
        public Uzrast UzrastKursa { get; set; }
        public int TrajanjeKursa{ get; set; }
        public string OznakaKursa { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Kurs k && k.NazivKursa == NazivKursa;
        }
        public override string ToString()
        {
            return NazivKursa;
        }
    }
}
