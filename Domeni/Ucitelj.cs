using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Data.SqlTypes;
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

        public override bool Equals(object? obj)
        {
            return obj is Ucitelj u && u.Id == Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public BindingList<Ucitelj> popuniListu(SqlDataReader reader)
        {
            BindingList<Ucitelj> res = new BindingList<Ucitelj>();

            while (reader.Read())
            {
                Ucitelj ucitelj = new Ucitelj
                {
                    Id = (int)reader["idUcitelj"],
                    ImeUcitelja = (string)reader["imeUcitelja"],
                    PrezimeUcitelja = (string)reader["prezimeUcitelja"],
                    Email = (string)reader["email"],
                    Telefon = (string)reader["telefon"],
                    DatumPocetkaRada = (DateTime)reader["datumPocetkaRada"],
                    KorisnickoIme = (string)reader["korisnickoIme"],
                    Lozinka = (string)reader["lozinka"]

                };

                res.Add(ucitelj);

            }

            return res;
        }
    }
}
