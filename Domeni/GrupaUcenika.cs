using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domeni
{
    public class GrupaUcenika
    {
        public int IdGrupe{ get; set; }
        public string OznakaGrupe{ get; set; }
        public int BrojUcenika{ get; set; }
        public string Termin { get; set; }
        public Kurs Kurs { get; set; }

        public override string ToString()
        {
            return $"{OznakaGrupe}";
        }

        public override bool Equals(object? obj)
        {
            return obj is GrupaUcenika grupa
                && grupa.IdGrupe == IdGrupe
                && grupa.OznakaGrupe == OznakaGrupe;
        }

        public BindingList<GrupaUcenika> popuniListu(SqlDataReader reader)
        {
            BindingList<GrupaUcenika> res = new BindingList<GrupaUcenika>();
            while (reader.Read())
            {
                GrupaUcenika gu = new GrupaUcenika()
                {
                    IdGrupe = (int)reader["idGrupa"],
                    OznakaGrupe = (string)reader["oznakaGrupe"],
                    BrojUcenika = (int)reader["brojUcenika"],
                    Termin = (string)reader["termin"],
                    Kurs = new Kurs()
                    {
                        IdKursa = (int)reader["idKurs"],
                        NazivKursa = (string)reader["nazivKursa"],
                        OznakaKursa = (string)reader["oznakaKursa"],
                        TezinaKursa = Enum.Parse<TezinaKursa>((string)reader["tezinaKursa"]),
                        UzrastKursa = Enum.Parse<Uzrast>((string)reader["uzrastKursa"]),
                        TrajanjeKursa = (int)reader["trajanjeKursa"]
                    }
                };

                res.Add(gu);
            }
            return res;
        }
    }
}
