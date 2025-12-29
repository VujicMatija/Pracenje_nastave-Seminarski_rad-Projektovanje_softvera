using System.Reflection.PortableExecutable;

namespace Domeni
{
    public class Ucitelj
    {
        public int Id { get; set; }

        public string ImeUcitelja { get; set; }

        public string PrezimeUcitelja { get; set; }

        public string Email { get; set; }

        public string Telefon { get; set; }

        public string KorisnickoIme { get; set; }

        public string Lozinka { get; set; }
        public DateTime DatumPocetkaRada { get; set; }

        public override string ToString()
        {
            return $"{ImeUcitelja} {PrezimeUcitelja}";
        }
    }
}
