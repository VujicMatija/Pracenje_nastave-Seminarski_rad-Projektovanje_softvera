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

        public BindingList<Ucitelj> vratiListuUcitelja(Ucitelj u)
        {
            Ucitelj ucitelj = new Ucitelj();
            BindingList<Ucitelj> res = new BindingList<Ucitelj>();

            try
            {
                connection.Open();

                string query = "Select * from Ucitelj where imeUcitelja like @Ime and prezimeUcitelja like @Prezime";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Ime", '%' + u.ImeUcitelja + '%');
                command.Parameters.AddWithValue("@Prezime", '%' + u.PrezimeUcitelja + '%');
                SqlDataReader reader = command.ExecuteReader();
                res = ucitelj.popuniListu(reader);

                return res;
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

        public BindingList<Ucitelj> vratiListuUcitelja(Sertifikat s)
        {
            Ucitelj ucitelj = new Ucitelj();
            BindingList<Ucitelj> res = new BindingList<Ucitelj>();

            try
            {
                connection.Open();

                string query = "Select u.* from Ucitelj u join Licenca l on (u.idUcitelj = l.idUcitelj) where l.idSertifikat = @Sertifikat";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Sertifikat", s.IdSertifikata);
                SqlDataReader reader = command.ExecuteReader();
                res = ucitelj.popuniListu(reader);
                return res;
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

        public List<Ucitelj> vratiListuUcitelja(Ucitelj u, Sertifikat s)
        {
            List<Ucitelj> res =  vratiListuSviUcitelji().Intersect(vratiListuUcitelja(s).Intersect(vratiListuUcitelja(u))).ToList();
            return res;
        }
         

        public BindingList<Sertifikat> vratiListuSertifikata(Ucitelj u)
        {
            BindingList<Sertifikat> result = new BindingList<Sertifikat>();

            try
            {
                connection.Open();

                string query = "Select s.* from licenca l join sertifikat s on(l.idSertifikat = s.idSertifikat) where l.idUcitelj = @UciteljID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UciteljID", u.Id);
                SqlDataReader reader = command.ExecuteReader();
                Sertifikat s = new Sertifikat();
                result = s.popuniListu(reader);
                return result;


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

        public BindingList<Sertifikat> vratiListuSviSertifikati()
        {
            BindingList<Sertifikat> result = new BindingList<Sertifikat>();

            try
            {
                connection.Open();

                string query = "Select * from sertifikat";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();
                Sertifikat s = new Sertifikat();
                result = s.popuniListu(reader);
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
                Ucitelj u = new Ucitelj();
                result = u.popuniListu(reader);
                
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
                
                string query = "Select * from EvidencijaNastave ev join GrupaUcenika  gu on (ev.idGrupa =  gu.idGrupa) join Ucitelj u on (u.idUcitelj = ev.idEvidencijaNastave) where gu.idGrupa = @Grupa";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Grupa", grupaUcenika.IdGrupe);
                SqlDataReader reader = command.ExecuteReader();
                EvidencijaNastave ev = new EvidencijaNastave();
                result = ev.popuniListu(reader);

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

        public BindingList<EvidencijaNastave> vratiListuEvidencijaNastave(Kurs kurs)
        {
            BindingList<EvidencijaNastave> result = new BindingList<EvidencijaNastave>();

            if (kurs == null)
            {
                return vratiListuSveEvidencijaNastave();
            }

            try
            {
                connection.Open();

                string query = "Select * from EvidencijaNastave ev join GrupaUcenika  gu on (ev.idGrupa =  gu.idGrupa) join Ucitelj u on (u.idUcitelj = ev.idEvidencijaNastave) join Kurs k on (gu.idKurs = k.idKurs) where k.idKurs = @IdKurs";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdKurs", kurs.IdKursa);
                SqlDataReader reader = command.ExecuteReader();
                EvidencijaNastave ev = new EvidencijaNastave();
                result = ev.popuniListu(reader);
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

        public BindingList<EvidencijaNastave> vratiListuSveEvidencijaNastave()
        {
            BindingList<EvidencijaNastave> result = new BindingList<EvidencijaNastave>();

            try
            {
                connection.Open();

                string query = "select * from EvidencijaNastave ev join Ucitelj u on(ev.idUcitelja = u.idUcitelj) join GrupaUcenika gu on (gu.idGrupa = ev.idGrupa)";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();
                EvidencijaNastave ev = new EvidencijaNastave();
                result = ev.popuniListu(reader);

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
                EvidencijaNastave ev = new EvidencijaNastave();
                result = ev.popuniListu(reader);

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
                EvidencijaNastave ev = new EvidencijaNastave();
                result = ev.popuniListu(reader);

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

                string query = "Select distinct ev.*, gu.*, u.*,  uc.*  from EvidencijaNastave ev join GrupaUcenika  gu on (ev.idGrupa =  gu.idGrupa) join Ucitelj u on (u.idUcitelj = ev.idEvidencijaNastave) " +
                    "join StavkaEvidencijeNastave sev on (sev.idEvidencijeNastave = ev.idEvidencijaNastave) join Ucenik uc on (uc.idUcenik = sev.idUcenik) where uc.idUcenik = @Ucenik";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Ucenik", ucenik.IdUcenika);
                SqlDataReader reader = command.ExecuteReader();
                EvidencijaNastave ev = new EvidencijaNastave();
                result = ev.popuniListu(reader);

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

        public List<EvidencijaNastave> vratiListuEvidencijaNastave(GrupaUcenika gu, Ucitelj u, Ucenik ucenik, EvidencijaNastave ev, Kurs k)
        {
            List<EvidencijaNastave> res = vratiListuEvidencijaNastave(gu).Intersect(vratiListuEvidencijaNastave(u)).Intersect(vratiListuEvidencijaNastave(ucenik).Intersect(vratiListuEvidencijaNastave(k))).ToList();
            return res;
        }

        public BindingList<Ucenik> vratiListuSviUcenici()
        {
            BindingList<Ucenik> result = new BindingList<Ucenik>();
            Ucenik u = new Ucenik();
            try
            {
                connection.Open();

                string query = "Select * from ucenik";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                result = u.popuniListu(reader);

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
            Ucenik u = new Ucenik();

            try
            {
                connection.Open();

                string query = "select u.* from Ucenik u join UcenikGrupa ug on (u.idUcenik = ug.idUcenik) join GrupaUcenika gu on (gu.idGrupa = ug.idGrupaUcenika) where gu.idGrupa = @IdGrupe";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdGrupe", gu.IdGrupe);
                SqlDataReader reader = command.ExecuteReader();
                result = u.popuniListu(reader);
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
                Kurs k = new Kurs();
                result = k.popuniListu(reader);
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
    
        public void kreirajUcitelja(Ucitelj u)
        {
            try
            {
                connection.Open();
                string query = "Insert into ucitelj values(@ImeUcitelja, @PrezimeUcitelja, @Email, @Telefon, @KorisnickoIme, @Lozinka, @Datum)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ImeUcitelja", u.ImeUcitelja);
                command.Parameters.AddWithValue("@PrezimeUcitelja", u.PrezimeUcitelja);
                command.Parameters.AddWithValue("@Email", u.Email);
                command.Parameters.AddWithValue("@Telefon", u.Telefon);
                command.Parameters.AddWithValue("@KorisnickoIme", u.KorisnickoIme);
                command.Parameters.AddWithValue("@Lozinka", u.Lozinka);
                command.Parameters.AddWithValue("@Datum", u.DatumPocetkaRada);
                command.ExecuteNonQuery();

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
        
        public void promeniUcitelja(Ucitelj ucitelj)
        {
            try
            {
                connection.Open();
                string query = "Update Ucitelj set imeUcitelja = @Ime, prezimeUcitelja = @Prezime, email = @Email, telefon = @Telefon, datumPocetkaRada = @Datum where idUcitelj = @IdUcitelj";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Ime", ucitelj.ImeUcitelja);
                command.Parameters.AddWithValue("@Prezime", ucitelj.PrezimeUcitelja);
                command.Parameters.AddWithValue("@Email", ucitelj.Email);
                command.Parameters.AddWithValue("@Telefon", ucitelj.Telefon);
                command.Parameters.AddWithValue("@Datum", ucitelj.DatumPocetkaRada);
                command.Parameters.AddWithValue("@IdUcitelj", ucitelj.Id);
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
    
        public void kreirajLicencu(Licenca licenca)
        {
            try
            {
                connection.Open();
                string query = "Insert into Licenca values(@IdUcitelj, @IdSertifikat, @Datum)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdUcitelj", licenca.ucitelj.Id);
                command.Parameters.AddWithValue("@IdSertifikat", licenca.sertifikat.IdSertifikata);
                command.Parameters.AddWithValue("@Datum", licenca.DatumDobijanja);
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


        public void obrisiUcitelja(Ucitelj u)
        {
            try
            {
                connection.Open();
                string query = "Delete from Ucitelj where idUcitelj = @Ucitelj";
                SqlCommand command = new SqlCommand(query,connection);
                command.Parameters.AddWithValue("@Ucitelj", u.Id);
                command.ExecuteNonQuery();
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
    

        public Ucenik pretraziUcenika(Ucenik ucenik)
        {
            Ucenik u = new Ucenik();
            try
            {
                connection.Open();
                string query = "Select * from ucenik where idUcenik = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", ucenik.IdUcenika);
                SqlDataReader reader = command.ExecuteReader();
                u = u.popuniListu(reader)[0];

                return u;
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            
        }

        public void kreirajUcenika(Ucenik ucenik)
        {
            try
            {
                connection.Open();
                string query = "Insert into Ucenik values(@ImeUcenika, @PrezimeUcenika, @PolUcenika, @ImeRoditelja, @PrezimeRoditelja, @TelefonRoditelja,@DatumRodjenja, @TelefonUcenika, @EmailUcenika)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ImeUcenika", ucenik.ImeUcenika);
                command.Parameters.AddWithValue("@PrezimeUcenika", ucenik.PrezimeUcenika);
                command.Parameters.AddWithValue("@PolUcenika", ucenik.PolUcenika.ToString());
                command.Parameters.AddWithValue("@ImeRoditelja", ucenik.ImeRoditelja);
                command.Parameters.AddWithValue("@PrezimeRoditelja", ucenik.PrezimeRoditelja);
                command.Parameters.AddWithValue("@TelefonRoditelja", ucenik.TelefonRoditelja);
                command.Parameters.AddWithValue("@DatumRodjenja", ucenik.DatumRodjenjaUcenika);
                command.Parameters.AddWithValue("@TelefonUcenika", ucenik.TelefonUcenika);
                command.Parameters.AddWithValue("@EmailUcenika", ucenik.EmailUcenika);
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

        public BindingList<Ucenik> pretraziUcenikaPoImenu(Ucenik ucenik)
        {
            
            BindingList<Ucenik> res = new BindingList<Ucenik>();

            try
            {
                connection.Open();

                string query = "Select * from Ucenik where imeUcenika like @Ime and prezimeUcenika like @Prezime";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Ime", '%' + ucenik.ImeUcenika + '%');
                command.Parameters.AddWithValue("@Prezime", '%' + ucenik.PrezimeUcenika + '%');
                SqlDataReader reader = command.ExecuteReader();
                res = ucenik.popuniListu(reader);

                return res;
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

        public void PromeniUcenika(Ucenik ucenik)
        {
            try
            {
                connection.Open();

                string query = "Update Ucenik set imeUcenika = @ImeUcenika, prezimeUcenika = @PrezimeUcenika, " +
                    "polUcenika = @PolUcenika, imeRoditelja = @ImeRoditelja, prezimeRoditelja = @PrezimeRoditelja," +
                    " telefonRoditelja = @TelefonRoditelja, datumRodjenjaUcenika = @DatumRodjenja," +
                    " telefonUcenika = @TelefonUcenika, emailUcenika = @EmailUcenika where idUcenik = @IdUcenika";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ImeUcenika", ucenik.ImeUcenika);
                command.Parameters.AddWithValue("@PrezimeUcenika", ucenik.PrezimeUcenika);
                command.Parameters.AddWithValue("@PolUcenika", ucenik.PolUcenika.ToString());
                command.Parameters.AddWithValue("@ImeRoditelja", ucenik.ImeRoditelja);
                command.Parameters.AddWithValue("@PrezimeRoditelja", ucenik.PrezimeRoditelja);
                command.Parameters.AddWithValue("@TelefonRoditelja", ucenik.TelefonRoditelja);
                command.Parameters.AddWithValue("@DatumRodjenja", ucenik.DatumRodjenjaUcenika);
                command.Parameters.AddWithValue("@TelefonUcenika", ucenik.TelefonUcenika);
                command.Parameters.AddWithValue("@EmailUcenika", ucenik.EmailUcenika);
                command.Parameters.AddWithValue("@IdUcenika", ucenik.IdUcenika);
                command.ExecuteNonQuery();
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

        public void obrisiUcenika(Ucenik ucenik)
        {
            try
            {
                connection.Open();
                string query = "Delete from ucenik where idUcenik = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", ucenik.IdUcenika);
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
    
        public void ubaciSertifikat(Sertifikat sertifikat)
        {
            try
            {
                connection.Open();
                string query = "Insert into sertifikat values(@Naziv)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Naziv", sertifikat.NazivSertifikata);
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

        public void promeniSertifikat(Sertifikat sertifikat)
        {
            try
            {
                connection.Open();
                string query = "Update sertifikat set nazivSertifikata = @Naziv where idSertifikat = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Naziv", sertifikat.NazivSertifikata);
                command.Parameters.AddWithValue("@Id", sertifikat.IdSertifikata);
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

        public void obrisiSertikat(Sertifikat sertifikat)
        {
            try
            {
                connection.Open();
                string query = "delete from sertifikat where idSertifikat = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", sertifikat.IdSertifikata);
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

        public BindingList<Sertifikat> vratiListuSertifikata(Sertifikat sertifikat)
        {
            BindingList<Sertifikat> result = new BindingList<Sertifikat>();
            try
            {

                connection.Open();
                string query = "Select * from sertifikat where nazivSertifikata like @Naziv";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Naziv", "%" + sertifikat.NazivSertifikata + "%");
                SqlDataReader reader = command.ExecuteReader();
                result = sertifikat.popuniListu(reader);
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

        public void kreirajKurs(Kurs k)
        {
            try
            {
                connection.Open();
                string query = "Insert into Kurs values(@NazivKursa, @TezinaKursa, @Uzrast, @Trajanje, @Oznaka)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NazivKursa", k.NazivKursa);
                command.Parameters.AddWithValue("@TezinaKursa", k.TezinaKursa);
                command.Parameters.AddWithValue("@Uzrast", k.UzrastKursa);
                command.Parameters.AddWithValue("@Trajanje", k.TrajanjeKursa);
                command.Parameters.AddWithValue("@Oznaka", k.OznakaKursa);
                command.ExecuteNonQuery();
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

        public BindingList<Kurs> vratiListuKurseva(Kurs zaPretragu)
        {
            BindingList<Kurs> result = new BindingList<Kurs>();
            try
            {
                connection.Open();
                string query = "Select * from Kurs where nazivKursa like @Naziv";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Naziv", "%" + zaPretragu.NazivKursa + "%");
                SqlDataReader reader = command.ExecuteReader();
                result = zaPretragu.popuniListu(reader);
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

        public void promeniKurs(Kurs kurs)
        {
            try
            {
                connection.Open();
                string query = "Update Kurs set nazivKursa = @Naziv, tezinaKursa = @Tezina, uzrastKursa = @Uzrast, trajanjeKursa = @Trajanje where idKurs = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Naziv", kurs.NazivKursa);
                command.Parameters.AddWithValue("@Tezina", kurs.TezinaKursa);
                command.Parameters.AddWithValue("@Uzrast", kurs.UzrastKursa);
                command.Parameters.AddWithValue("@Trajanje", kurs.TrajanjeKursa);
                command.Parameters.AddWithValue("@Id", kurs.IdKursa);
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

        public Kurs pretraziKurs(Kurs kurs)
        {
            try
            {
                connection.Open();
                string query = "Select * from Kurs where idKurs = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", kurs.IdKursa);
                SqlDataReader reader = command.ExecuteReader();
                return kurs.popuniListu(reader)[0];
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

        public void kreirajStavkuEvidencijeNastave(StavkaEvidencijeNastave stavka)
        {
            try
            {
                connection.Open();
                string query = "Insert into StavkaEvidencijeNastave values(@IdEvidencije, @Prisustvo, @Komentar, @Datum, @Domaci, @RB, @Ucenik)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdEvidencije", stavka.Evidencija.IdEvidencijeNastave);
                command.Parameters.AddWithValue("@Prisustvo", stavka.Prisustvo);
                command.Parameters.AddWithValue("@Komentar", stavka.Komentar);
                command.Parameters.AddWithValue("@Datum", stavka.DatumOdrzavanja);
                command.Parameters.AddWithValue("@Domaci", stavka.UradjenDomaci);
                command.Parameters.AddWithValue("@RB", stavka.RedniBrojCasa);
                command.Parameters.AddWithValue("@Ucenik", stavka.Ucenik.IdUcenika);
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

        public BindingList<StavkaEvidencijeNastave> vratiListuSveStavkeEvidencijeNastave()
        {
            BindingList<StavkaEvidencijeNastave> result = new BindingList<StavkaEvidencijeNastave>();
            try
            {
                connection.Open();
                string query = "select sen.*, u.* ,ev.*, gu.*, uc.*  " +
                    "from StavkaEvidencijeNastave sen join Ucenik u on(sen.idUcenik = u.idUcenik) " +
                    "join EvidencijaNastave ev on (ev.idEvidencijaNastave = sen.idEvidencijeNastave) " +
                    "join GrupaUcenika gu on (ev.idGrupa = gu.idGrupa) " +
                    "join Ucitelj uc on(ev.idUcitelja = uc.idUcitelj)";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                StavkaEvidencijeNastave stavka = new StavkaEvidencijeNastave();
                result = stavka.popuniListu(reader);
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

        public BindingList<StavkaEvidencijeNastave> vratiListuStavkiEvidencijeNastave(EvidencijaNastave evidencija)
        {
            BindingList<StavkaEvidencijeNastave> result = new BindingList<StavkaEvidencijeNastave>();

            try
            {
                connection.Open();
                string query = "select sen.*, u.* ,ev.*, gu.*, uc.*  " +
                    "from StavkaEvidencijeNastave sen join Ucenik u on(sen.idUcenik = u.idUcenik) " +
                    "join EvidencijaNastave ev on (ev.idEvidencijaNastave = sen.idEvidencijeNastave) " +
                    "join GrupaUcenika gu on (ev.idGrupa = gu.idGrupa) " +
                    "join Ucitelj uc on(ev.idUcitelja = uc.idUcitelj) " +
                    "where sen.idEvidencijeNastave = @IdEvidencije Order by sen.redniBrojCasa";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("IdEvidencije", evidencija.IdEvidencijeNastave);
                SqlDataReader reader = command.ExecuteReader();
                StavkaEvidencijeNastave stavka = new StavkaEvidencijeNastave();
                result = stavka.popuniListu(reader);
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

        public BindingList<StavkaEvidencijeNastave> vratiListuStavkiEvidencijeNastave(Ucenik ucenik)
        {
            BindingList<StavkaEvidencijeNastave> result = new BindingList<StavkaEvidencijeNastave>();

            try
            {
                connection.Open();
                string query = "select sen.*, u.* ,ev.*, gu.*, uc.*  from StavkaEvidencijeNastave sen" +
                    " join Ucenik u on(sen.idUcenik = u.idUcenik) " +
                    "join EvidencijaNastave ev on (ev.idEvidencijaNastave = sen.idEvidencijeNastave) join " +
                    "GrupaUcenika gu on (ev.idGrupa = gu.idGrupa) join Ucitelj uc on(ev.idUcitelja = uc.idUcitelj) where u.idUcenik = @IdUcenik";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdUcenik", ucenik.IdUcenika);
                SqlDataReader reader = command.ExecuteReader();
                StavkaEvidencijeNastave stavka = new StavkaEvidencijeNastave();
                result = stavka.popuniListu(reader);
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

        public List<StavkaEvidencijeNastave> vratiListuStavkiEvidencijeNastave(EvidencijaNastave en, Ucenik ucenik)
        {
            return vratiListuStavkiEvidencijeNastave(en).Intersect(vratiListuStavkiEvidencijeNastave(ucenik)).ToList();
        }


        public void promeniStavkuEvidencijeNastave(StavkaEvidencijeNastave stavka)
        {
            try
            {
                connection.Open();
                string query = "Update StavkaEvidencijeNastave set prisustvo = @Prisustvo, komentar = @Komentar, " +
                    "datumOdrzavanja = @Datum, uradjenDomaci = @Domaci, redniBrojCasa = @rbCasa where idStavkaEvidencije = @idStavke";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Prisustvo", stavka.Prisustvo);
                command.Parameters.AddWithValue("@Komentar", stavka.Komentar);
                command.Parameters.AddWithValue("@Datum", stavka.DatumOdrzavanja);
                command.Parameters.AddWithValue("@Domaci", stavka.UradjenDomaci);
                command.Parameters.AddWithValue("@rbCasa", stavka.RedniBrojCasa);
                command.Parameters.AddWithValue("@idStavke", stavka.idStavkeEvidencije);
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

        public BindingList<Licenca> vratiListuSveLicence()
        {
            BindingList<Licenca> result = new BindingList<Licenca>();

            try
            {
                connection.Open();
                string query = "select * from licenca l join Ucitelj u on (l.idUcitelj = u.idUcitelj) join Sertifikat s on (s.idSertifikat = l.idSertifikat)";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                Licenca l = new Licenca();
                result = l.popuniListu(reader);
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

        public BindingList<Licenca> vratiListuLicence(Ucitelj ucitelj)
        {
            BindingList<Licenca> result = new BindingList<Licenca>();

            try
            {
                connection.Open();
                string query = "select * from licenca l join Ucitelj u on (l.idUcitelj = u.idUcitelj) join Sertifikat s on (s.idSertifikat = l.idSertifikat) where u.idUcitelj = @IdUcitelj";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdUcitelj", ucitelj.Id);
                SqlDataReader reader = command.ExecuteReader();
                Licenca l = new Licenca();
                result = l.popuniListu(reader);
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

        public BindingList<Licenca> vratiListuLicence(Sertifikat sertifikat)
        {
            BindingList<Licenca> result = new BindingList<Licenca>();

            try
            {
                connection.Open();
                string query = "select * from licenca l join Ucitelj u on (l.idUcitelj = u.idUcitelj) join Sertifikat s on (s.idSertifikat = l.idSertifikat) where s.idSertifikat = @IdSertifikat";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdSertifikat", sertifikat.IdSertifikata);
                SqlDataReader reader = command.ExecuteReader();
                Licenca l = new Licenca();
                result = l.popuniListu(reader);
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


        public List<Licenca> vratiListuLicence(Ucitelj ucitelj, Sertifikat sertifikat)
        {
            return vratiListuLicence(ucitelj).Intersect(vratiListuLicence(sertifikat)).ToList();
        }

        public void promeniLicencu(Licenca licenca)
        {
            try
            {
                connection.Open();
                string query = "Update licenca set datumDobijanja = @Datum where idUcitelj = @IdUcitelj and idSertifikat = @IdSertifikat";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Datum", licenca.DatumDobijanja);
                command.Parameters.AddWithValue("@IdUcitelj", licenca.ucitelj.Id);
                command.Parameters.AddWithValue("@IdSertifikat", licenca.sertifikat.IdSertifikata);
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


        public void kreirajUcenikGrupa(Ucenik ucenik, GrupaUcenika grupa)
        {
            try
            {
                connection.Open();
                string query = "Insert into UcenikGrupa values(@UcenikId, @GrupaId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UcenikId", ucenik.IdUcenika);
                command.Parameters.AddWithValue("@GrupaId", grupa.IdGrupe);
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
