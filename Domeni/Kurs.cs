using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public BindingList<Kurs> popuniListu(SqlDataReader reader)
        {
            BindingList<Kurs> result = new BindingList<Kurs>();

            while (reader.Read())
            {
                Kurs k = new Kurs
                {
                    IdKursa = (int)reader["idKurs"],
                    NazivKursa = (string)reader["nazivKursa"],
                    TezinaKursa = Enum.Parse<TezinaKursa>((string)reader["tezinaKursa"]),
                    UzrastKursa = Enum.Parse<Uzrast>((string)reader["uzrastKursa"]),
                    TrajanjeKursa = (int)reader["trajanjeKursa"],
                    OznakaKursa = (string)reader["oznakaKursa"]
                };
                result.Add(k);
            }


            return result;
        }

        public void validiraj()
        {
            if (string.IsNullOrWhiteSpace(NazivKursa))
            {
                throw new Exception("Morate uneti naziv kursa!");
            }
            if (TrajanjeKursa > 0)
            {
                throw new Exception("Trajanje kursa mora biti vece od 0!");
            }
        }
    }
}
