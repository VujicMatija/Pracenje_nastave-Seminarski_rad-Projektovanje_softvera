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

        public void validiraj()
        {
            if(ImeUcitelja.Length < 3)
            {
                throw new Exception("Ime mora imati vise od 2 slova!");
            }
            if (PrezimeUcitelja.Length < 3)
            {
                throw new Exception("Prezime mora imati vise od 2 slova!");
            }
            if(Email.Contains("@") == false || Email.Contains(".com") == false)
            {
                throw new Exception("Email mora da sadrzi @ i .com");
            }
            if(Telefon.Substring(0,2) != "06")
            {
                throw new Exception("Broj telefona mora da pocinenje sa 06");
            }
            if(KorisnickoIme.Length < 8)
            {
                throw new Exception("Korisnicko ime mora biti duze od 7 karaktera");
            }
            if(Lozinka.Length < 10)
            {
                throw new Exception("Lozinka mora imati minimum 10 karaktera");
            }
            if(DatumPocetkaRada > DateTime.Today)
            {
                throw new Exception("Morate izabrati datum pre danasnjeg");
            }
            if(KorisnickoIme == Lozinka)
            {
                throw new Exception("Korisnicko ime i lozinka se moraju razlikovati");
            }

        }
    }
}
