using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domeni
{
    public class StavkaEvidencijeNastave
    {
        public int idStavkeEvidencije { get; set; }
        public Ucenik Ucenik { get; set; }
        public int RedniBrojCasa { get; set; }
       
        public bool Prisustvo { get; set; }
        public string Komentar { get; set; }
        public bool UradjenDomaci { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public EvidencijaNastave Evidencija { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is StavkaEvidencijeNastave stavka
                && stavka.idStavkeEvidencije == idStavkeEvidencije
                && stavka.Evidencija.IdEvidencijeNastave == Evidencija.IdEvidencijeNastave
                && stavka.RedniBrojCasa == RedniBrojCasa
                && stavka.Ucenik.IdUcenika == Ucenik.IdUcenika;
        }

        public override int GetHashCode()
        {
            return idStavkeEvidencije.GetHashCode();
        }
        public BindingList<StavkaEvidencijeNastave> popuniListu(SqlDataReader reader)
        {
            BindingList<StavkaEvidencijeNastave> result = new BindingList<StavkaEvidencijeNastave>();

            while (reader.Read())
            {
                StavkaEvidencijeNastave s = new StavkaEvidencijeNastave
                {
                    Evidencija = new EvidencijaNastave
                    {
                        IdEvidencijeNastave = (int)reader["idEvidencijeNastave"],
                        Ucitelj = new Ucitelj()
                        {
                            Id = (int)reader["idUcitelja"],
                            ImeUcitelja = (string)reader["imeUcitelja"],
                            PrezimeUcitelja = (string)reader["prezimeUcitelja"]
                        },
                        Grupa = new GrupaUcenika()
                        {
                            IdGrupe = (int)reader["idGrupa"],
                            OznakaGrupe = (string)reader["oznakaGrupe"],
                            Kurs = new Kurs() { IdKursa = (int)reader["idKurs"] }
                            
                        }

                    },
                    idStavkeEvidencije = (int)reader["idStavkaEvidencije"],
                    Prisustvo = (bool)reader["prisustvo"],
                    Komentar = (string)reader["komentar"],
                    DatumOdrzavanja = (DateTime)reader["datumOdrzavanja"],
                    UradjenDomaci = (bool)reader["uradjenDomaci"],
                    RedniBrojCasa = (int)reader["redniBrojCasa"],
                    Ucenik = new Ucenik
                    {
                        IdUcenika = (int)reader["idUcenik"],
                        ImeUcenika = (string)reader["imeUcenika"],
                        PrezimeUcenika = (string)reader["prezimeUcenika"],
                        ImeRoditelja = (string)reader["imeRoditelja"]
                    }
                };

                result.Add(s);
            }

            return result;
        }
    }
}
