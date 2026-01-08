using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public override string ToString()
        {
            if (Ucitelj != null && Grupa != null)
                return $"{Ucitelj.ToString()} - {Grupa.ToString()}";
            else return "";
        }

        public override bool Equals(object? obj)
        {

            return obj is EvidencijaNastave evd 
                && IdEvidencijeNastave == evd.IdEvidencijeNastave
                &&  Ucitelj.Id == evd.Ucitelj.Id 
                && Grupa.IdGrupe == evd.Grupa.IdGrupe;
        }

        public override int GetHashCode()
        {
            return IdEvidencijeNastave.GetHashCode();
        }

        public BindingList<EvidencijaNastave> popuniListu(SqlDataReader reader)
        {
            BindingList<EvidencijaNastave> res = new BindingList<EvidencijaNastave>();

            while (reader.Read())
            {
                EvidencijaNastave ev = new EvidencijaNastave
                {
                    IdEvidencijeNastave = (int)reader["idEvidencijaNastave"],
                    StatusAktivnosti = (bool)reader["statusAktivnosti"],
                    DatumPocetkaRada = (DateTime)reader["datumPocetkaRada"],
                    Ucitelj = new Ucitelj
                    {
                        Id = (int)reader["idUcitelja"],
                        ImeUcitelja = (string)reader["imeUcitelja"],
                        PrezimeUcitelja = (string)reader["prezimeUcitelja"],
                        Email = (string)reader["email"],
                        Telefon = (string)reader["telefon"],
                        KorisnickoIme = (string)reader["korisnickoIme"],
                        Lozinka = (string)reader["lozinka"],
                        //DatumPocetkaRada = (DateTime)reader[17]
                    },
                    Grupa = new GrupaUcenika
                    {
                        IdGrupe = (int)reader["idGrupa"],
                        OznakaGrupe = (string)reader["oznakaGrupe"],
                        BrojUcenika = (int)reader["brojUcenika"],
                        Termin = (string)reader["termin"],
                        Kurs = new Kurs
                        {
                            IdKursa = (int)reader["idKurs"],
                        }
                    }
                };

                res.Add(ev);
            }

            return res;
        }
    }
}
