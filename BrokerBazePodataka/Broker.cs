using Domeni;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
namespace BrokerBazePodataka
{
    public class Broker
    {

        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=evidencija_nastave;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        public Ucitelj? PrijaviUcitelja(Ucitelj u)
        {
            Ucitelj logovani = null;
            try
            {
                connection.Open();
                string query = "Select * from Ucitelj where korisnickoIme = @kIme and lozinka = @lozinka";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@kIme", u.KorisnickoIme);
                command.Parameters.AddWithValue("@lozinka", u.Lozinka);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Ucitelj pom = new Ucitelj
                    {
                        ImeUcitelja = (string)reader[1],
                        PrezimeUcitelja = (string)reader[2],
                        Email = (string)reader[3],
                        Telefon = (string)reader[4],
                        KorisnickoIme = (string)reader[5],
                        Lozinka = (string)reader[6],
                        DatumPocetkaRada = (DateTime)reader[7]
                    };

                    logovani = pom;

                }

                return logovani;
            }catch(Exception ex)
            {
                return null;
                throw new Exception("Greška prilokom rada sa bazom podataka!");
            }
            finally
            {
                connection.Close();
            }
        }


        public Ucitelj pretraziUcitelja(Ucitelj u)
        {
            Ucitelj ucitelj = new Ucitelj();

            try
            {
                connection.Open();

                string query = "Select * from Ucitelj where imeUcitelja = @Ime and prezimeUcitelja = @Prezime";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Ime", u.ImeUcitelja);
                command.Parameters.AddWithValue("@Prezime", u.PrezimeUcitelja);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ucitelj = new Ucitelj
                    {
                        Id = (int)reader[0],
                        ImeUcitelja = (string)reader[1],
                        PrezimeUcitelja = (string)reader[2],
                        Email = (string)reader[3],
                        Telefon = (string)reader[4],
                        DatumPocetkaRada = (DateTime)reader[7]

                    };

                }

                return ucitelj;
            }
            catch
            {
                throw new Exception("Greska prilikom rada sa bazom");
            }
            finally
            {
                connection.Close();
            }

        }

        public BindingList<Sertifikat> vratiListuSertifikata(Ucitelj u)
        {
            BindingList<Sertifikat> result = new BindingList<Sertifikat>();

            try
            {
                connection.Open();

                string query = "Select s.nazivSertifikata from licenca l join sertifikat s on(l.idSertifikat = s.idSertifikat) where l.idUcitelj = @UciteljID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UciteljID", u.Id);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Sertifikat s = new Sertifikat
                    {
                        NazivSertifikata = (string)reader[0]
                    };
                    result.Add(s);
                }
                

                return result;
            }
            catch
            {
                return null;
                throw new Exception("Greska prilikom rada sa bazom");
            }
            finally
            {
                connection.Close();
            }
        }



        public BindingList<GrupaUcenika> vratiGrupeUcenika(Ucitelj u)
        {
            BindingList<GrupaUcenika> result = new BindingList<GrupaUcenika>();
            try
            {
                connection.Open();
                string query = "Select gu.*, k.* from EvidencijaNastave ev join GrupaUcenika gu on (ev.idGrupa = gu.idGrupa) join Kurs k on(gu.idKurs = k.idKurs) where idUcitelja = @Ucitelj";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Ucitelj", u.Id);
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    GrupaUcenika gu = new GrupaUcenika
                    {
                        IdGrupe = (int)reader[0],
                        OznakaGrupe = (string)reader[1],
                        BrojUcenika = (int)reader[2],
                        Termin = (string)reader[3],
                        Kurs = new Kurs
                        {
                            IdKursa = (int)reader[5],
                            NazivKursa = (string)reader[6],
                            TezinaKursa = Enum.Parse<TezinaKursa>((string)reader[7]),
                            UzrastKursa = Enum.Parse<Uzrast>((string)reader[8]),
                            TrajanjeKursa = (int)reader[9],
                            OznakaKursa = (string)reader[10]
                        }
                    };

                    result.Add(gu);
                }

                return result;

            }
            catch(Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }


        public BindingList<Ucitelj> vratiListuSviUcitelji()
        {
            BindingList<Ucitelj> result = new BindingList<Ucitelj>();

            try
            {
                connection.Open();

                string query = "Select * from ucitelj";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Ucitelj u = new Ucitelj
                    {
                        Id = (int)reader[0],
                        ImeUcitelja = (string)reader[1],
                        PrezimeUcitelja = (string)reader[2],
                        Email = (string)reader[3],
                        Telefon = (string)reader[4],
                        KorisnickoIme = (string)reader[5],
                        DatumPocetkaRada = (DateTime)reader[7]
                    };

                    result.Add(u);
                }
                
                return result;

            }catch(Exception ex)
            {
                throw new Exception("Greska prilikom rada sa bazom");
            }
            finally
            {
                connection.Close();
            }
        }
        
        public BindingList<GrupaUcenika> vratiListuSveGrupeUcenika()
        {
            BindingList<GrupaUcenika> result = new BindingList<GrupaUcenika>();

            try
            {
                connection.Open();

                string query = "Select * from GrupaUcenika gu join Kurs k on (gu.idKurs = k.idKurs);";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    GrupaUcenika gu = new GrupaUcenika
                    {
                        IdGrupe = (int)reader[0],
                        OznakaGrupe = (string)reader[1],
                        BrojUcenika = (int)reader[2],
                        Termin = (string)reader[3],
                        Kurs = new Kurs
                        {
                            IdKursa = (int)reader[5],
                            NazivKursa = (string)reader[6],
                            TezinaKursa = Enum.Parse<TezinaKursa>((string)reader[7]),
                            UzrastKursa = Enum.Parse<Uzrast>((string)reader[8]),
                            TrajanjeKursa = (int)reader[9],
                            OznakaKursa = (string)reader[10]
                        }
                    };

                    result.Add(gu);
                }
                
                return result;
            }
            catch
            {
                throw new Exception("Greska prilikom rada sa bazom");
            }
            finally
            {
                connection.Close();
            }
        }
    
        public void KreirajEvidencijuNastave(EvidencijaNastave evidencija) 
        {
            try
            {
                connection.Open();
                string query = "Insert into EvidencijaNastave values(@StatusAkitvnosti, @Datum, @Ucitelj, @Grupa)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StatusAkitvnosti", evidencija.StatusAktivnosti);
                command.Parameters.AddWithValue("@Datum", evidencija.DatumPocetkaRada);
                command.Parameters.AddWithValue("@Ucitelj", evidencija.Ucitelj.Id);
                command.Parameters.AddWithValue("@Grupa", evidencija.Grupa.IdGrupe);
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }    
   
        public BindingList<EvidencijaNastave> vratiListuEvidencijaNastave(GrupaUcenika grupaUcenika)
        {
            BindingList<EvidencijaNastave> result = new BindingList<EvidencijaNastave>();

            if (grupaUcenika == null)
            {
                return vratiListuSveEvidencijaNastave();
            }

            try
            {
                connection.Open();

                string query = "Select * from EvidencijaNastave ev join GrupaUcenika  gu on (ev.idGrupa =  gu.idGrupa) join Ucitelj u on (u.idUcitelj = ev.idEvidencijaNastave) where idGrupe = @Grupa";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Grupa", grupaUcenika.IdGrupe);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EvidencijaNastave ev = new EvidencijaNastave
                    {
                        IdEvidencijeNastave = (int)reader[0],
                        StatusAktivnosti = (bool)reader[1],
                        DatumPocetkaRada = (DateTime)reader[2],
                        Ucitelj = new Ucitelj
                        {
                            Id = (int)reader[10],
                            ImeUcitelja = (string)reader[11],
                            PrezimeUcitelja = (string)reader[12],
                        },
                        Grupa = new GrupaUcenika
                        {
                            IdGrupe = (int)reader[5],
                            OznakaGrupe = (string)reader[6],
                            BrojUcenika = (int)reader[7],
                            Termin = (string)reader[8],
                            Kurs = new Kurs
                            {
                                IdKursa = (int)reader[9]
                            }
                        }
                    };

                    result.Add(ev);
                }

                return result;

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public BindingList<EvidencijaNastave> vratiListuSveEvidencijaNastave()
        {
            BindingList<EvidencijaNastave> result = new BindingList<EvidencijaNastave>();

            try
            {
                connection.Open();

                string query = "Select * from EvidencijaNastave ev join GrupaUcenika  gu on (ev.idGrupa =  gu.idGrupa) join Ucitelj u on (u.idUcitelj = ev.idEvidencijaNastave)";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EvidencijaNastave ev = new EvidencijaNastave
                    {
                        IdEvidencijeNastave = (int)reader[0],
                        StatusAktivnosti = (bool)reader[1],
                        DatumPocetkaRada = (DateTime)reader[2],
                        Ucitelj = new Ucitelj
                        {
                            Id = (int)reader[10],
                            ImeUcitelja = (string)reader[11],
                            PrezimeUcitelja = (string)reader[12],
                        },
                        Grupa = new GrupaUcenika
                        {
                            IdGrupe = (int)reader[5],
                            OznakaGrupe = (string)reader[6],
                            BrojUcenika = (int)reader[7],
                            Termin = (string)reader[8],
                            Kurs = new Kurs
                            {
                                IdKursa = (int)reader[9]
                            }
                        }
                    };

                    result.Add(ev);
                }

                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public BindingList<EvidencijaNastave> vratiListuEvidencijaNastave(Ucitelj ucitelj)
        {
            BindingList<EvidencijaNastave> result = new BindingList<EvidencijaNastave>();
            if(ucitelj == null)
            {
                return vratiListuSveEvidencijaNastave();
            }
            try
            {
                connection.Open();

                string query = "Select * from EvidencijaNastave ev join GrupaUcenika  gu on (ev.idGrupa =  gu.idGrupa) join Ucitelj u on (u.idUcitelj = ev.idEvidencijaNastave) where idUcitelja = @Ucitelj";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Ucitelj", ucitelj.Id);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EvidencijaNastave ev = new EvidencijaNastave
                    {
                        IdEvidencijeNastave = (int)reader[0],
                        StatusAktivnosti = (bool)reader[1],
                        DatumPocetkaRada = (DateTime)reader[2],
                        Ucitelj = new Ucitelj
                        {
                            Id = (int)reader[10],
                            ImeUcitelja = (string)reader[11],
                            PrezimeUcitelja = (string)reader[12],
                        },
                        Grupa = new GrupaUcenika
                        {
                            IdGrupe = (int)reader[5],
                            OznakaGrupe = (string)reader[6],
                            BrojUcenika = (int)reader[7],
                            Termin = (string)reader[8],
                            Kurs = new Kurs
                            {
                                IdKursa = (int)reader[9]
                            }
                        }
                    };

                    result.Add(ev);
                }

                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public BindingList<EvidencijaNastave> vratiListuEvidencijaNastave(EvidencijaNastave evd)
        {
            BindingList<EvidencijaNastave> result = new BindingList<EvidencijaNastave>();
            if (evd == null)
            {
                return vratiListuSveEvidencijaNastave();
            }
            try
            {
                connection.Open();

                string query = "Select * from EvidencijaNastave ev join GrupaUcenika  gu on (ev.idGrupa =  gu.idGrupa) join Ucitelj u on (u.idUcitelj = ev.idEvidencijaNastave) where ev.idEvidencijaNastave = @Evidencija";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Evidencija", evd.IdEvidencijeNastave);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EvidencijaNastave ev = new EvidencijaNastave
                    {
                        IdEvidencijeNastave = (int)reader[0],
                        StatusAktivnosti = (bool)reader[1],
                        DatumPocetkaRada = (DateTime)reader[2],
                        Ucitelj = new Ucitelj
                        {
                            Id = (int)reader[10],
                            ImeUcitelja = (string)reader[11],
                            PrezimeUcitelja = (string)reader[12],
                        },
                        Grupa = new GrupaUcenika
                        {
                            IdGrupe = (int)reader[5],
                            OznakaGrupe = (string)reader[6],
                            BrojUcenika = (int)reader[7],
                            Termin = (string)reader[8],
                            Kurs = new Kurs
                            {
                                IdKursa = (int)reader[9]
                            }
                        }
                    };

                    result.Add(ev);
                }

                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public BindingList<EvidencijaNastave> vratiListuEvidencijaNastave(Ucenik ucenik)
        {
            BindingList<EvidencijaNastave> result = new BindingList<EvidencijaNastave>();
            if (ucenik == null)
            {
                return vratiListuSveEvidencijaNastave();
            }
            try
            {
                connection.Open();

                string query = "Select ev.*, gu.*, u.*,  uc.*  from EvidencijaNastave ev join GrupaUcenika  gu on (ev.idGrupa =  gu.idGrupa) join Ucitelj u on (u.idUcitelj = ev.idEvidencijaNastave) " +
                    "join StavkaEvidencijeNastave sev on (sev.idEvidencijeNastave = ev.idEvidencijaNastave) join Ucenik uc on (uc.idUcenik = sev.idUcenik) where uc.idUcenik = @Ucenik";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Ucenik", ucenik.IdUcenika);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EvidencijaNastave ev = new EvidencijaNastave
                    {
                        IdEvidencijeNastave = (int)reader[0],
                        StatusAktivnosti = (bool)reader[1],
                        DatumPocetkaRada = (DateTime)reader[2],
                        Ucitelj = new Ucitelj
                        {
                            Id = (int)reader[10],
                            ImeUcitelja = (string)reader[11],
                            PrezimeUcitelja = (string)reader[12],
                        },
                        Grupa = new GrupaUcenika
                        {
                            IdGrupe = (int)reader[5],
                            OznakaGrupe = (string)reader[6],
                            BrojUcenika = (int)reader[7],
                            Termin = (string)reader[8],
                            Kurs = new Kurs
                            {
                                IdKursa = (int)reader[9]
                            }
                        }
                    };

                    result.Add(ev);
                }

                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<EvidencijaNastave> vratiListuEvidencijaNastave(GrupaUcenika gu, Ucitelj u, Ucenik ucenik, EvidencijaNastave ev)
        {
            List<EvidencijaNastave> res = vratiListuEvidencijaNastave(gu).Intersect(vratiListuEvidencijaNastave(u)).Intersect(vratiListuEvidencijaNastave(ucenik)).ToList();
            return res;
        }

        public BindingList<Ucenik> vratiListuSviUcenici()
        {
            BindingList<Ucenik> result = new BindingList<Ucenik>();
            try
            {
                connection.Open();

                string query = "Select * from ucenik";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Ucenik u = new Ucenik
                    {
                        IdUcenika = (int)reader[0],
                        ImeUcenika = (string)reader[1],
                        PrezimeUcenika = (string)reader[2],
                        ImeRoditelja = (string)reader[4],
                        PrezimeRoditelja = (string)reader[5],
                        PolUcenika = Enum.Parse<Pol>((string)reader[3]),
                        TelefonRoditelja = (string)reader[6],
                        DatumRodjenjaUcenika = (DateTime)reader[7],
                        TelefonUcenika = (string)reader[8],
                        EmailUcenika = (string)reader[9]
                    };

                    result.Add(u);
                }


                return result;
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public BindingList<Ucenik> vratiListuUcenika(GrupaUcenika gu)
        {
            BindingList<Ucenik> result = new BindingList<Ucenik>();

            try
            {
                connection.Open();

                string query = "select u.* from GrupaUcenika gu join EvidencijaNastave en on (gu.idGrupa = en.idGrupa) join StavkaEvidencijeNastave s on (en.idEvidencijaNastave = s.idEvidencijeNastave) join Ucenik u on (u.idUcenik = s.idUcenik) where gu.idGrupa = @IdGrupe";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdGrupe", gu.IdGrupe);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Ucenik u = new Ucenik
                    {
                        IdUcenika = (int)reader[0],
                        ImeUcenika = (string)reader[1],
                        PrezimeUcenika = (string)reader[2],
                        ImeRoditelja = (string)reader[4],
                        PrezimeRoditelja = (string)reader[5],
                        PolUcenika = Enum.Parse<Pol>((string)reader[3]),
                        TelefonRoditelja = (string)reader[6],
                        DatumRodjenjaUcenika = (DateTime)reader[7],
                        TelefonUcenika = (string)reader[8],
                        EmailUcenika = (string)reader[9]
                    };

                    result.Add(u);
                }

                return result;
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public BindingList<StavkaEvidencijeNastave> vratiListuStavkeEvidencijeNastave(EvidencijaNastave evidencija)
        {
            BindingList<StavkaEvidencijeNastave> result = new BindingList<StavkaEvidencijeNastave>();

            try
            {
                connection.Open();
                string query = "select * from StavkaEvidencijeNastave sen join Ucenik u on (sen.idUcenik = u.idUcenik) where sen.idEvidencijeNastave = @IdEvidencije";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("IdEvidencije", evidencija.IdEvidencijeNastave);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    StavkaEvidencijeNastave s = new StavkaEvidencijeNastave
                    {
                        rbStavkeEvidencijeNastave = (int)reader[1],
                        Prisustvo = (bool)reader[2],
                        Komentar = (string)reader[3],
                        DatumOdrzavanja = (DateTime)reader[4],
                        UradjenDomaci = (bool)reader[5],
                        RedniBrojCasa = (int)reader[6],
                        Ucenik = new Ucenik
                        {
                            IdUcenika = (int)reader[8],
                            ImeUcenika = (string)reader[9],
                            PrezimeUcenika = (string)reader[10],
                            ImeRoditelja = (string)reader[12]
                        }
                    };

                    result.Add(s);
                }

                return result;
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    
        public void PromeniEvidencijuNastave(EvidencijaNastave evidencija)
        {
            try
            {
                connection.Open();
                string query = "Update EvidencijaNastave set datumPocetkaRada = @Datum, statusAktivnosti = @StatusAktivnosti, idUcitelja = @idUcitelja where idEvidencijaNastave = @IdEvidencije";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Datum", evidencija.DatumPocetkaRada);
                command.Parameters.AddWithValue("StatusAktivnosti", evidencija.StatusAktivnosti);
                command.Parameters.AddWithValue("@IdUcitelja", evidencija.Ucitelj.Id);
                command.Parameters.AddWithValue("@IdEvidencije", evidencija.IdEvidencijeNastave);
                command.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
   
        public BindingList<Kurs> vratiListuSviKursevi()
        {
            BindingList<Kurs> result = new BindingList<Kurs>();

            try
            {
                connection.Open();

                string query = "Select * from Kurs";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Kurs k = new Kurs
                    {
                        IdKursa = (int)reader[0],
                        NazivKursa = (string)reader[1],
                        TezinaKursa = Enum.Parse<TezinaKursa>((string)reader[2]),
                        UzrastKursa = Enum.Parse<Uzrast>((string)reader[3]),
                        TrajanjeKursa = (int)reader[4],
                        OznakaKursa = (string)reader[5]
                    };
                    result.Add(k);
                }


                return result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        
        public void KreirajGrupuUcenika(GrupaUcenika grupa)
        {
            try
            {
                connection.Open();
                string query = "insert into GrupaUcenika values(@Oznaka, @Broj, @Termin, @Kurs)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Oznaka", grupa.OznakaGrupe);
                command.Parameters.AddWithValue("@Broj", grupa.BrojUcenika);
                command.Parameters.AddWithValue("@Termin", grupa.Termin);
                command.Parameters.AddWithValue("@Kurs", grupa.Kurs.IdKursa);
                command.ExecuteNonQuery();


            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        
        public BindingList<GrupaUcenika> vratiListuGrupaUcenika(Kurs k)
        {
            BindingList<GrupaUcenika> result = new BindingList<GrupaUcenika>();
            try
            {
                connection.Open();

                string query = "Select * from GrupaUcenika gu join Kurs k on (k.idKurs = gu.idKurs) where k.idKurs = @KursId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KursId", k.IdKursa);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    GrupaUcenika gu = new GrupaUcenika
                    {

                        IdGrupe = (int)reader[0],
                        OznakaGrupe = (string)reader[1],
                        BrojUcenika = (int)reader[2],
                        Termin = (string)reader[3],
                        Kurs = new Kurs
                        {
                            IdKursa = (int)reader[5],
                            NazivKursa = (string)reader[6],
                            TezinaKursa = Enum.Parse<TezinaKursa>((string)reader[7]),
                            UzrastKursa = Enum.Parse<Uzrast>((string)reader[8]),
                            TrajanjeKursa = (int)reader[9],
                            OznakaKursa = (string)reader[10]
                        }

                    };

                    result.Add(gu);
                }

                return result;
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    
        public void PromeniGrupuUcenika(GrupaUcenika grupa)
        {
            try
            {
                connection.Open();
                string query = "Update GrupaUcenika set oznakagrupe = @Oznaka, termin = @Termin, brojUcenika = @Broj, idKurs = @Kurs where idGrupa = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Oznaka", grupa.OznakaGrupe);
                command.Parameters.AddWithValue("@Termin", grupa.Termin);
                command.Parameters.AddWithValue("@Broj", grupa.BrojUcenika);
                command.Parameters.AddWithValue("@Kurs", grupa.Kurs.IdKursa);
                command.Parameters.AddWithValue("@ID", grupa.IdGrupe);
                command.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally{
                connection.Close();
            }
        }

        public void ObrisiGrupuUcenika(GrupaUcenika grupa)
        {
            try
            {
                connection.Open();
                string query = "Delete from GrupaUcenika where idGrupa = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", grupa.IdGrupe);
                command.ExecuteNonQuery();
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    
    }

    
}
