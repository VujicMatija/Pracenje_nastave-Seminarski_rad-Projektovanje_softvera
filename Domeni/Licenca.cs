using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domeni
{
    public class Licenca
    {
        public Ucitelj ucitelj { get; set; }
        public Sertifikat sertifikat { get; set; }
        public DateTime DatumDobijanja{ get; set; }

        public override string ToString()
        {
            return $"{ucitelj.ToString} - {sertifikat.ToString}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Licenca l
                && l.ucitelj.Id == ucitelj.Id
                && l.sertifikat.IdSertifikata == sertifikat.IdSertifikata
                && l.DatumDobijanja == DatumDobijanja;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(
            ucitelj?.Id,
            sertifikat?.IdSertifikata,
            DatumDobijanja
            );  
        }

        public BindingList<Licenca> popuniListu(SqlDataReader reader)
        {
            BindingList<Licenca> result = new BindingList<Licenca>();

            while (reader.Read())
            {
                Licenca l = new Licenca()
                {
                    ucitelj = new Ucitelj()
                    {
                        Id = (int)reader["idUcitelj"],
                        ImeUcitelja = (string)reader["imeUcitelja"],
                        PrezimeUcitelja = (string)reader["prezimeUcitelja"],
                        Email = (string)reader["email"],
                        Telefon = (string)reader["telefon"],
                        DatumPocetkaRada = (DateTime)reader["datumPocetkaRada"],
                        KorisnickoIme = (string)reader["korisnickoIme"],
                        Lozinka = (string)reader["lozinka"]
                    },

                    sertifikat = new Sertifikat()
                    {
                        IdSertifikata = (int)reader["idSertifikat"],
                        NazivSertifikata = (string)reader["nazivSertifikata"]
                    },
                    DatumDobijanja = (DateTime)reader["datumDobijanja"]

                };

                result.Add(l);
            }

            return result;
        }
     
    }
}
