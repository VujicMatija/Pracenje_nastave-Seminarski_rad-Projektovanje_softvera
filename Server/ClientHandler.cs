using BrokerBazePodataka;
using Domeni;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Zajednicki;

namespace Server
{
    internal class ClientHandler
    {

        private Socket soket;
        private NetworkStream stream;
        private StreamWriter writer;
        private StreamReader reader;

        private Broker broker = new Broker();

        public ClientHandler(Socket soket)
        {
            this.soket = soket;
            stream = new NetworkStream(soket);
            writer = new StreamWriter(stream) { AutoFlush = true };
            reader = new StreamReader(stream);
        }

        public void Handle()
        {
            try
            {

                while (true)
                {
                    Zahtev zahtev = JsonSerializer.Deserialize<Zahtev>(reader.ReadLine());

                    switch (zahtev.Operacija)
                    {

                        case Operacija.PrijaviUcitelja:
                            HandlePrijaviUcitelja(zahtev);

                            break;

                        case Operacija.PretraziUcitelja:
                            HandlePretraziUcitelja(zahtev);
                            break;

                        case Operacija.VratiListuSertifikataPoUcitelju:
                            HandleVratiListuSertifikataPoUcitelju(zahtev);
                            break;
                        case Operacija.vratiListuGrupeUcenikaPoUcitelju:
                            HandleVratiListuGrupaUcenikaPoUceitelju(zahtev);
                            break;
                        case Operacija.PromeniUcitelja:
                            HandlePromeniUcitelja(zahtev);
                            break;
                        case Operacija.ObrisiUcitelja:
                            HandleObrisiUcitelja(zahtev);
                            break;
                        case Operacija.KreirajUcitelja:
                            HandleKreirajiUcitelja(zahtev);
                            break;
                        case Operacija.VratiListuSviSertifikati:
                            HandleVratiListuSviSertifikati(zahtev);
                            break;
                        case Operacija.VratiListuSviUcitelji:
                            HandleVratiListuSviUcitelji(zahtev);
                            break;
                        case Operacija.VratiListuUciteljaPoSertifikatu:
                            HandleVratiListuUciteljaPoSertifikatu(zahtev);
                            break;
                        case Operacija.VratiListuUciteljaPoUcitelju:
                            HandleVratiListuUciteljaPoUcitelju(zahtev);
                            break;
                        case Operacija.VratiListuUcitelji:
                            HandleVratiListuUcitelja(zahtev);
                            break;
                        case Operacija.KreirajLicencu:
                            HandleKreirajLicencu(zahtev);
                            break;
                        case Operacija.PromeniLicencu:
                            HandlePromeniLicencu(zahtev);
                            break;
                        case Operacija.VratiListuSveLicence:
                            HandleVratiListuSveLicence(zahtev);
                            break;
                        case Operacija.VratiListuLicencePoSertifikatu:
                            HandleVratiListuLicencaPoSertifikatu(zahtev);
                            break;
                        case Operacija.VratiListuLicencePoUcitelju:
                            HandleVratiListuLicencaPoUcitelju(zahtev);
                            break;
                        case Operacija.VratiListuLicence:
                            HandleVratiListuLicenca(zahtev);
                            break;
                        case Operacija.VratiListuSlobodneGrupe:
                            HandleVratiListuSlobodneGrupe(zahtev);
                            break;
                        case Operacija.KreirajEvidencujuNastave:
                            HandleKreirajEvidencijuNastave(zahtev);
                            break;
                        case Operacija.VratiListuUcenika:
                            HandleVratiListuUcenika(zahtev);
                            break;
                        case Operacija.PretraziKurs:
                            HandlePretraziKurs(zahtev);
                            break;
                        case Operacija.VratiListuSveGrupeUcenika:
                            HandleVratiListuSveGrupeUcenika(zahtev);
                            break;
                        case Operacija.VratiListuSviUcenici:
                            HandleVratiListuSviUcenici(zahtev);
                            break;
                        case Operacija.VratiListuSveEvidencijeNastave:
                            HandleVratiListuSveEvidencijeNastave(zahtev);
                            break;
                        case Operacija.VratiListuEvidencijaNastave:
                            HandleVratiListuEvidencijaNastave(zahtev);
                            break;
                        case Operacija.VratiListuStavkiEvidencijeNastave:
                            HandleVratiListuStavkiEvidencijeNastave(zahtev);
                            break;
                        case Operacija.VratiListuStavkiEvidencijeNastavePoUceniku:
                            HandleVratiListuStavkiEvidencijeNastavePoUceniku(zahtev);
                            break;
                        case Operacija.PromeniEvidencijuNastave:
                            HandlePromeniEvidencijuNastave(zahtev);
                            break;
                        case Operacija.KreirajStavkuEvidencijeNastave:
                            HandleKreirajStavkuEvidencijeNastave(zahtev);
                            break;
                        case Operacija.PromeniStavkuEvidencijeNastave:
                            HandlePromeniStavkuEvidencijeNastave(zahtev);
                            break;
                        case Operacija.VratiListuGrupeUcenikaPoUceniku:
                            HandleVratiGrupuUcenikaPoUceniku(zahtev);
                            break;
                        case Operacija.KreirajUcenika:
                            HandleKreirajUcenika(zahtev);
                            break;
                        case Operacija.ObrisiUcenika:
                            HandleObrisiUcenika(zahtev);
                            break;
                        case Operacija.PromeniUcenika:
                            HandlePromeniUcenika(zahtev);
                            break;
                        case Operacija.PretraziUcenikaPoImenu:
                            HandlePretraziUcenikaPoImenu(zahtev);
                            break;
                        case Operacija.VratiZauzeteTermine:
                            HandleVratiZauzeteTermine(zahtev);
                            break;
                        case Operacija.VratiListuSviKursevi:
                            HandleVratiListuSviKursevi(zahtev);
                            break;
                        case Operacija.KreirajGrupuUcenika:
                            HandleKreirajGrupuUcenika(zahtev);
                            break;
                        case Operacija.PromeniGrupuUcenika:
                            HandlePromeniGrupuUcenika(zahtev);
                            break;
                        case Operacija.ObrisiGrupuUcenika:
                            HandleObrisiGrupuUcenika(zahtev);
                            break;
                        case Operacija.VratiListuGrupeUcenikaPoKursu:
                            HandleVratiListuGrupaUcenikaPoKursu(zahtev);
                            break;
                        case Operacija.VratiListuEvidencijeNastavePoKursu:
                            HandleVratiListuEvidencijeNastavePoKursu(zahtev);
                            break;
                        case Operacija.KreirajKurs:
                            HandleKreirajKurs(zahtev);
                            break;
                        case Operacija.PromeniKurs:
                            HandlePromeniKurs(zahtev);
                            break;
                        case Operacija.VratiListuKursevaPoImenu:
                            HandleVratiListuKursevaPoImenu(zahtev);
                            break;
                        case Operacija.UbaciSertifikat:
                            HandleUbaciSertifikat(zahtev);
                            break;
                        case Operacija.PromeniSertifikat:
                            HandlePromeniSertifikat(zahtev);
                            break;
                        case Operacija.ObrisiSertifikat:
                            HandleObrisiSertifikat(zahtev);
                            break;
                        case Operacija.VratiListuSertifikataPoNazivu:
                            HandleVratiListuSertifikataPoImenu(zahtev);
                            break;
                        case Operacija.KreirajUcenikGrupa:
                            HandleKreirajUcenikGrupa(zahtev);
                            break;
                    }


                }


            }
            catch (IOException ie)
            {
                Debug.Write(">>>>> IE: " + ie.Message);
            }
            catch (SocketException se)
            {
                Debug.Write(">>>>> SE: " + se.Message);
            }
            catch (Exception ex)
            {
                Debug.Write(">>>>> EX: " + ex.Message);
            }
        }

        private void HandlePrijaviUcitelja(Zahtev zahtev)
        {
            Ucitelj ucitelj = JsonSerializer.Deserialize<Ucitelj>(zahtev.Objekat1.ToString());
            try
            {

                Ucitelj ulogovani = broker.PrijaviUcitelja(ucitelj);
                if (ulogovani == null)
                {
                    Odgovor odg = new Odgovor { Uspesno = false, Greska = "Neuspesna prijava" };
                    writer.WriteLine(JsonSerializer.Serialize(odg));
                }
                else
                {
                    Debug.WriteLine(">>>>>>.EVO ME");
                    Odgovor odg = new Odgovor
                    {
                        Uspesno = true,
                        Objekat = ulogovani
                    };
                    writer.WriteLine(JsonSerializer.Serialize(odg));
                }

            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor
                {
                    Uspesno = false,
                    Greska = ex.Message
                };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandlePretraziUcitelja(Zahtev zahtev)
        {
            Ucitelj ucitelj = JsonSerializer.Deserialize<Ucitelj>(zahtev.Objekat1.ToString());
            try
            {
                Ucitelj res = broker.pretraziUcitelja(ucitelj);
                if (res != null)
                {
                    Odgovor odg = new Odgovor { Uspesno = true, Objekat = res };
                    writer.WriteLine(JsonSerializer.Serialize(odg));
                }
                else
                {
                    Odgovor odg = new Odgovor { Uspesno = false, Greska = "Greska prilikom rada sa bazom" };
                    writer.WriteLine(JsonSerializer.Serialize(odg));
                }
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor
                {
                    Uspesno = false,
                    Greska = ex.Message
                };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleVratiListuSertifikataPoUcitelju(Zahtev zahtev)
        {
            Ucitelj u = new Ucitelj();
            u = JsonSerializer.Deserialize<Ucitelj>(zahtev.Objekat1.ToString());
            try
            {

                BindingList<Sertifikat> res = broker.vratiListuSertifikata(u);
                Odgovor odg = new Odgovor { Uspesno = true, Objekat = res };
                Debug.WriteLine(JsonSerializer.Serialize(res));
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor
                {
                    Uspesno = false,
                    Greska = ex.Message
                };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleVratiListuGrupaUcenikaPoUceitelju(Zahtev zahtev)
        {
            Ucitelj u = new Ucitelj();
            u = JsonSerializer.Deserialize<Ucitelj>(zahtev.Objekat1.ToString());
            try
            {

                BindingList<GrupaUcenika> res = broker.vratiListuGrupaUcenika(u);
                Odgovor odg = new Odgovor { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor
                {
                    Uspesno = false,
                    Greska = ex.Message
                };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleVratiListuGrupaUcenikaPoKursu(Zahtev zahtev)
        {
            
            Kurs kurs = JsonSerializer.Deserialize<Kurs>(zahtev.Objekat1.ToString());
            try
            {

                BindingList<GrupaUcenika> res = broker.vratiListuGrupaUcenika(kurs);
                Odgovor odg = new Odgovor { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor
                {
                    Uspesno = false,
                    Greska = ex.Message
                };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleVratiGrupuUcenikaPoUceniku(Zahtev zahtev)
        {
            Ucenik u = new Ucenik();
            u = JsonSerializer.Deserialize<Ucenik>(zahtev.Objekat1.ToString());
            try
            {

                BindingList<GrupaUcenika> res = broker.vratiListuGrupaUcenika(u);
                Odgovor odg = new Odgovor { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor
                {
                    Uspesno = false,
                    Greska = ex.Message
                };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandlePromeniUcitelja(Zahtev zahtev)
        {
            Ucitelj u = new Ucitelj();
            u = JsonSerializer.Deserialize<Ucitelj>(zahtev.Objekat1.ToString());
            Debug.WriteLine(">>>>>>" + u.ToString());
            try
            {
                broker.promeniUcitelja(u);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleObrisiUcitelja(Zahtev zahtev)
        {
            Ucitelj u = new Ucitelj();
            u = JsonSerializer.Deserialize<Ucitelj>(zahtev.Objekat1.ToString());
            Debug.WriteLine(">>>>>>" + u.ToString());
            try
            {
                broker.obrisiUcitelja(u);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleKreirajiUcitelja(Zahtev zahtev)
        {
            Ucitelj u = new Ucitelj();
            u = JsonSerializer.Deserialize<Ucitelj>(zahtev.Objekat1.ToString());
            Debug.WriteLine(">>>>>>" + u.ToString());
            try
            {
                broker.kreirajUcitelja(u);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleVratiListuSviSertifikati(Zahtev zahtev)
        {
            try
            {
                BindingList<Sertifikat> res = broker.vratiListuSviSertifikati();
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleVratiListuSviUcitelji(Zahtev zahtev)
        {
            try
            {
                BindingList<Ucitelj> res = broker.vratiListuSviUcitelji();
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }
        private void HandleVratiListuUciteljaPoSertifikatu(Zahtev zahtev)
        {
            Sertifikat s = JsonSerializer.Deserialize<Sertifikat>(zahtev.Objekat1.ToString());
            try
            {
                BindingList<Ucitelj> res = broker.vratiListuUcitelja(s);
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }

        }

        private void HandleVratiListuUciteljaPoUcitelju(Zahtev zahtev)
        {
            Ucitelj ucitelj = JsonSerializer.Deserialize<Ucitelj>(zahtev.Objekat1.ToString());
            try
            {
                BindingList<Ucitelj> res = broker.vratiListuUcitelja(ucitelj);
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }

        }

        private void HandleVratiListuUcitelja(Zahtev zahtev)
        {
            Ucitelj ucitelj = JsonSerializer.Deserialize<Ucitelj>(zahtev.Objekat1.ToString());
            Sertifikat s = JsonSerializer.Deserialize<Sertifikat>(zahtev.Objekat2.ToString());
            try
            {
                BindingList<Ucitelj> res = broker.vratiListuUcitelja(ucitelj, s);
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            throw new Exception("NE RADI TRENUTNO");

        }

        private void HandleKreirajLicencu(Zahtev zahtev)
        {
            Licenca licenca = JsonSerializer.Deserialize<Licenca>(zahtev.Objekat1.ToString());
            try
            {
                broker.kreirajLicencu(licenca);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandlePromeniLicencu(Zahtev zahtev)
        {
            Licenca licenca = JsonSerializer.Deserialize<Licenca>(zahtev.Objekat1.ToString());
            try
            {
                broker.promeniLicencu(licenca);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleVratiListuSveLicence(Zahtev zahtev)
        {
            try
            {
                BindingList<Licenca> res = broker.vratiListuSveLicence();
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }

        }

        private void HandleVratiListuLicencaPoUcitelju(Zahtev zahtev)
        {
            Ucitelj ucitelj = JsonSerializer.Deserialize<Ucitelj>(zahtev.Objekat1.ToString());
            try
            {
                BindingList<Licenca> res = broker.vratiListuLicence(ucitelj);
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }

        }

        private void HandleVratiListuLicencaPoSertifikatu(Zahtev zahtev)
        {
            Sertifikat sertifikat = JsonSerializer.Deserialize<Sertifikat>(zahtev.Objekat1.ToString());
            try
            {
                BindingList<Licenca> res = broker.vratiListuLicence(sertifikat);
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }

        }

        private void HandleVratiListuLicenca(Zahtev zahtev)
        {
            Ucitelj ucitelj = JsonSerializer.Deserialize<Ucitelj>(zahtev.Objekat1.ToString());
            Sertifikat sertifikat = JsonSerializer.Deserialize<Sertifikat>(zahtev.Objekat2.ToString());
            try
            {
                
                List<Licenca> res = broker.vratiListuLicence(ucitelj, sertifikat);
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }

        }

        private void HandleVratiListuSlobodneGrupe(Zahtev zahtev)
        {
            try
            {

                BindingList<GrupaUcenika> res = broker.vratiListuSlobodneGrupe();
                Odgovor odg = new Odgovor { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor
                {
                    Uspesno = false,
                    Greska = ex.Message
                };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }
        private void HandleKreirajEvidencijuNastave(Zahtev zahtev)
        {
            EvidencijaNastave evidencija = new EvidencijaNastave();
            evidencija = JsonSerializer.Deserialize<EvidencijaNastave>(zahtev.Objekat1.ToString());
            BindingList<StavkaEvidencijeNastave> stavke = JsonSerializer.Deserialize<BindingList<StavkaEvidencijeNastave>>(zahtev.Objekat2.ToString());

            try
            {
                broker.KreirajEvidencijuNastave(evidencija, stavke);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleVratiListuUcenika(Zahtev zahtev)
        {
            GrupaUcenika grupaUcenika = JsonSerializer.Deserialize<GrupaUcenika>(zahtev.Objekat1.ToString());
            try
            {
                BindingList<Ucenik> res = broker.vratiListuUcenika(grupaUcenika);
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }

        }

        private void HandlePretraziKurs(Zahtev zahtev)
        {
            Kurs kurs = JsonSerializer.Deserialize<Kurs>(zahtev.Objekat1.ToString());
            try
            {
                Kurs res = broker.pretraziKurs(kurs);
                if (res != null)
                {
                    Odgovor odg = new Odgovor { Uspesno = true, Objekat = res };
                    writer.WriteLine(JsonSerializer.Serialize(odg));
                }
                else
                {
                    Odgovor odg = new Odgovor { Uspesno = false, Greska = "Greska prilikom rada sa bazom" };
                    writer.WriteLine(JsonSerializer.Serialize(odg));
                }
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor
                {
                    Uspesno = false,
                    Greska = ex.Message
                };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleVratiListuSveGrupeUcenika(Zahtev zahtev)
        {
            try
            {
                BindingList<GrupaUcenika> res = broker.vratiListuSveGrupeUcenika();
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }

        }

        private void HandleVratiListuSviUcenici(Zahtev zahtev)
        {
            try
            {
                BindingList<Ucenik> res = broker.vratiListuSviUcenici();
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }

        }

        private void HandleVratiListuSveEvidencijeNastave(Zahtev zahtev)
        {
            try
            {
                BindingList<EvidencijaNastave> res = broker.vratiListuSveEvidencijaNastave();
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }

        }

        private void HandleVratiListuEvidencijaNastave(Zahtev zahtev)
        {
            GrupaUcenika grupaUcenika = null;
            Ucitelj ucitelj = null;
            Ucenik ucenik = null;

            if (zahtev.Objekat1 != null)
                grupaUcenika = JsonSerializer.Deserialize<GrupaUcenika>(zahtev.Objekat1.ToString());
            if (zahtev.Objekat2 != null)
                ucitelj = JsonSerializer.Deserialize<Ucitelj>(zahtev.Objekat2.ToString());
            if(zahtev.Objekat3 != null)
                ucenik = JsonSerializer.Deserialize<Ucenik>(zahtev.Objekat3.ToString());

            
            
            try
            {
                List<EvidencijaNastave> res = broker.vratiListuEvidencijaNastave(grupaUcenika, ucitelj, ucenik, null);
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }

        }

        private void HandleVratiListuStavkiEvidencijeNastave(Zahtev zahtev)
        {
            EvidencijaNastave evidencija = JsonSerializer.Deserialize<EvidencijaNastave>(zahtev.Objekat1.ToString());
            try
            {
                BindingList<StavkaEvidencijeNastave> res = broker.vratiListuStavkiEvidencijeNastave(evidencija);
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }

        }

        private void HandleVratiListuStavkiEvidencijeNastavePoUceniku(Zahtev zahtev)
        {
            EvidencijaNastave evidencija = JsonSerializer.Deserialize<EvidencijaNastave>(zahtev.Objekat1.ToString());
            Ucenik ucenik = JsonSerializer.Deserialize<Ucenik>(zahtev.Objekat2.ToString());
            try
            {
                List<StavkaEvidencijeNastave> res = broker.vratiListuStavkiEvidencijeNastave(evidencija, ucenik);
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }

        }

        private void HandlePromeniEvidencijuNastave(Zahtev zahtev)
        {
            EvidencijaNastave evidencija = new EvidencijaNastave();
            evidencija = JsonSerializer.Deserialize<EvidencijaNastave>(zahtev.Objekat1.ToString());
            try
            {
                broker.PromeniEvidencijuNastave(evidencija);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleKreirajStavkuEvidencijeNastave(Zahtev zahtev)
        {
            try
            {
                StavkaEvidencijeNastave stavka = JsonSerializer.Deserialize<StavkaEvidencijeNastave>(zahtev.Objekat1.ToString());
                broker.kreirajStavkuEvidencijeNastave(stavka);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));

            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));

            }
        }

        private void HandlePromeniStavkuEvidencijeNastave(Zahtev zahtev)
        {
            try
            {
                StavkaEvidencijeNastave stavka = JsonSerializer.Deserialize<StavkaEvidencijeNastave>(zahtev.Objekat1.ToString());
                broker.promeniStavkuEvidencijeNastave(stavka);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));

            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));

            }
        }

        private void HandleKreirajUcenika(Zahtev zahtev)
        {
            try
            {
                Ucenik ucenik = JsonSerializer.Deserialize<Ucenik>(zahtev.Objekat1.ToString());
                broker.kreirajUcenika(ucenik);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandlePromeniUcenika(Zahtev zahtev)
        {
            try
            {
                Ucenik ucenik = JsonSerializer.Deserialize<Ucenik>(zahtev.Objekat1.ToString());
                broker.PromeniUcenika(ucenik);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleObrisiUcenika(Zahtev zahtev)
        {
            try
            {
                Ucenik ucenik = JsonSerializer.Deserialize<Ucenik>(zahtev.Objekat1.ToString());
                broker.obrisiUcenika(ucenik);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandlePretraziUcenikaPoImenu(Zahtev zahtev)
        {
            try
            {
                Ucenik ucenik = JsonSerializer.Deserialize<Ucenik>(zahtev.Objekat1.ToString());
                BindingList<Ucenik> res = broker.pretraziUcenikaPoImenu(ucenik);
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }catch(Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleVratiZauzeteTermine(Zahtev zahtev)
        {
            try
            { 
                List<string> res = broker.vratiZauzeteTermine();
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleVratiListuSviKursevi(Zahtev zahtev)
        {
            try
            {
                BindingList<Kurs> res = broker.vratiListuSviKursevi();
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }

        }

        private void HandleKreirajGrupuUcenika(Zahtev zahtev)
        {
            try
            {
                GrupaUcenika grupa = JsonSerializer.Deserialize<GrupaUcenika>(zahtev.Objekat1.ToString());
                broker.KreirajGrupuUcenika(grupa);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandlePromeniGrupuUcenika(Zahtev zahtev)
        {
            try
            {
                GrupaUcenika grupa = JsonSerializer.Deserialize<GrupaUcenika>(zahtev.Objekat1.ToString());
                broker.PromeniGrupuUcenika(grupa);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleObrisiGrupuUcenika(Zahtev zahtev)
        {
            try
            {
                GrupaUcenika grupa = JsonSerializer.Deserialize<GrupaUcenika>(zahtev.Objekat1.ToString());
                broker.ObrisiGrupuUcenika(grupa);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleVratiListuEvidencijeNastavePoKursu(Zahtev zahtev)
        {
            try
            {
                Kurs k = JsonSerializer.Deserialize<Kurs>(zahtev.Objekat1.ToString());
                List<EvidencijaNastave> res = broker.vratiListuEvidencijaNastave(null, null, null, null,k);
                Odgovor odg = new Odgovor() { Uspesno = true,  Objekat = res};
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }catch(Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleKreirajKurs(Zahtev zahtev)
        {
            try
            {
                Kurs kurs = JsonSerializer.Deserialize<Kurs>(zahtev.Objekat1.ToString());
                broker.kreirajKurs(kurs);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandlePromeniKurs(Zahtev zahtev)
        {
            try
            {
                Kurs kurs = JsonSerializer.Deserialize<Kurs>(zahtev.Objekat1.ToString());
                broker.promeniKurs(kurs);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleVratiListuKursevaPoImenu(Zahtev zahtev)
        {
            try
            {

                Kurs kurs = JsonSerializer.Deserialize<Kurs>(zahtev.Objekat1.ToString());
                BindingList<Kurs> res = broker.vratiListuKurseva(kurs);
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));

            }catch(Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleUbaciSertifikat(Zahtev zahtev)
        {
            try
            {
                Sertifikat sertifikat = JsonSerializer.Deserialize<Sertifikat>(zahtev.Objekat1.ToString());
                broker.ubaciSertifikat(sertifikat);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandlePromeniSertifikat(Zahtev zahtev)
        {
            try
            {
                Sertifikat sertifikat = JsonSerializer.Deserialize<Sertifikat>(zahtev.Objekat1.ToString());
                broker.promeniSertifikat(sertifikat);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleObrisiSertifikat(Zahtev zahtev)
        {
            try
            {
                Sertifikat sertifikat = JsonSerializer.Deserialize<Sertifikat>(zahtev.Objekat1.ToString());
                broker.obrisiSertikat(sertifikat);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleVratiListuSertifikataPoImenu(Zahtev zahtev)
        {
            try
            {

                Sertifikat sertifikat = JsonSerializer.Deserialize<Sertifikat>(zahtev.Objekat1.ToString());
                BindingList<Sertifikat> res = broker.vratiListuSertifikata(sertifikat);
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));

            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        private void HandleKreirajUcenikGrupa(Zahtev zahtev)
        {
            try
            {
                GrupaUcenika grupa = JsonSerializer.Deserialize<GrupaUcenika>(zahtev.Objekat1.ToString());
                Ucenik ucenik = JsonSerializer.Deserialize<Ucenik>(zahtev.Objekat2.ToString());
                broker.kreirajUcenikGrupa(ucenik, grupa);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }
    }
}
