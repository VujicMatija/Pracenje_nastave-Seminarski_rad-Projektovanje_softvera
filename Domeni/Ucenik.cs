using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public BindingList<Ucenik> popuniListu(SqlDataReader reader)
        {
            BindingList<Ucenik> result = new BindingList<Ucenik>();
            while (reader.Read())
            {
                Ucenik u = new Ucenik
                {
                    IdUcenika = (int)reader["idUcenik"],
                    ImeUcenika = (string)reader["imeUcenika"],
                    PrezimeUcenika = (string)reader["prezimeUcenika"],
                    ImeRoditelja = (string)reader["imeRoditelja"],
                    PrezimeRoditelja = (string)reader["prezimeRoditelja"],
                    PolUcenika = Enum.Parse<Pol>((string)reader["polUcenika"]),
                    TelefonRoditelja = (string)reader["telefonRoditelja"],
                    DatumRodjenjaUcenika = (DateTime)reader["datumRodjenjaUcenika"],
                    TelefonUcenika = (string)reader["telefonUcenika"],
                    EmailUcenika = (string)reader["emailUcenika"]
                };

                result.Add(u);
            }
            return result;
        }

        public void validiraj()
        {
            if(ImeUcenika.Length < 3)
            {
                throw new Exception("Ime ucenika mora biti duze od dva karaktera");
            }
            if (PrezimeUcenika.Length < 3)
            {
                throw new Exception("Prezime ucenika mora biti duze od dva karaktera");
            }
            if (DatumRodjenjaUcenika > DateTime.Today)
            {
                throw new Exception("Morati uneti datum u proslosti");
            }
            if (ImeUcenika.Length < 3)
            {
                throw new Exception("Ime mora biti duze od dva karaktera");
            }
            if (EmailUcenika.Contains("@") == false || EmailUcenika.Contains(".com") == false)
            {
                throw new Exception("Email mora da sadrzi @ i .com");
            }

            if (ImeRoditelja.Length < 3)
            {
                throw new Exception("Ime roditelja mora biti duze od dva karaktera");
            }
            if (PrezimeRoditelja.Length < 3)
            {
                throw new Exception("Prezime roditelja mora biti duze od dva karaktera");
            }
            if(TelefonRoditelja == TelefonUcenika)
            {
                throw new Exception("Telefon roditelja i ucenika mora da se razlikuje!");
            }
        }

    }
}
