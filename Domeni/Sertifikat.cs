using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domeni
{
    public class Sertifikat
    {
        public int IdSertifikata { get; set; }
        public string NazivSertifikata{ get; set; }

        public override string ToString()
        {
            return $"{NazivSertifikata}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Sertifikat s && s.NazivSertifikata == NazivSertifikata && s.IdSertifikata == IdSertifikata; 
        }

        public override int GetHashCode()
        {
            return IdSertifikata.GetHashCode();
        }

        public BindingList<Sertifikat> popuniListu(SqlDataReader reader)
        {
            BindingList<Sertifikat> result = new BindingList<Sertifikat>();
            while (reader.Read())
            {
                Sertifikat s = new Sertifikat
                {
                    IdSertifikata = (int)reader["idSertifikat"],
                    NazivSertifikata = (string)reader["nazivSertifikata"]
                };
                result.Add(s);
            }

            return result;
        }

        
    }
}
