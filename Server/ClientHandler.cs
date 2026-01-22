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

                        //case Operacija.VratiListuSertifikataPoUcitelju:
                        //    HandleVratiListuSertifikataPoUcitelju(zahtev);
                        //    break;
                        //case Operacija.vratiListuGrupeUcenikaPoUcitelju:
                        //    HandleVratiListuGrupaUcenikaPoUceitelju(zahtev);
                        //    break;
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
                        //case Operacija.VratiListuUciteljaPoSertifikatu:
                        //    HandleVratiListuUciteljaPoSertifikatu(zahtev);
                        //    break;
                        //case Operacija.VratiListuUciteljaPoUcitelju:
                        //    HandleVratiListuUciteljaPoUcitelju(zahtev);
                        //    break;
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
                        //case Operacija.VratiListuLicencePoSertifikatu:
                        //    HandleVratiListuLicencaPoSertifikatu(zahtev);
                        //    break;
                        //case Operacija.VratiListuLicencePoUcitelju:
                        //    HandleVratiListuLicencaPoUcitelju(zahtev);
                        //    break;
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
                        case Operacija.PromeniEvidencijuNastave:
                            HandlePromeniEvidencijuNastave(zahtev);
                            break;
                        case Operacija.KreirajStavkuEvidencijeNastave:
                            HandleKreirajStavkuEvidencijeNastave(zahtev);
                            break;
                        case Operacija.PromeniStavkuEvidencijeNastave:
                            HandlePromeniStavkuEvidencijeNastave(zahtev);
                            break;
                        //case Operacija.VratiListuGrupeUcenikaPoUceniku:
                        //    HandleVratiGrupuUcenikaPoUceniku(zahtev);
                        //    break;
                        case Operacija.KreirajUcenika:
                            HandleKreirajUcenika(zahtev);
                            break;
                        case Operacija.ObrisiUcenika:
                            HandleObrisiUcenika(zahtev);
                            break;
                        case Operacija.PromeniUcenika:
                            HandlePromeniUcenika(zahtev);
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
                        //case Operacija.VratiListuGrupeUcenikaPoKursu:
                        //    HandleVratiListuGrupaUcenikaPoKursu(zahtev);
                        //    break;
                        //case Operacija.VratiListuEvidencijeNastavePoKursu:
                        //    HandleVratiListuEvidencijeNastavePoKursu(zahtev);
                        //    break;
                        case Operacija.KreirajKurs:
                            HandleKreirajKurs(zahtev);
                            break;
                        case Operacija.PromeniKurs:
                            HandlePromeniKurs(zahtev);
                            break;
                        case Operacija.VratiListuKurseva:
                            HandleVratiListuKurseva(zahtev);
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
                        //case Operacija.VratiListuSertifikataPoNazivu:
                        //    HandleVratiListuSertifikataPoImenu(zahtev);
                        //    break;
                        case Operacija.KreirajUcenikGrupa:
                            HandleKreirajUcenikGrupa(zahtev);
                            break;
                        case Operacija.VratiListuGrupeUcenika:
                            HandleVratiListuGrupaUcenika(zahtev);
                            break;
                        case Operacija.VratiListuSertifikata:
                            HandleVratiListuSertifikata(zahtev);
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


        //UCITELJ

        private void HandlePrijaviUcitelja(Zahtev zahtev)
        {
            Ucitelj ucitelj = JsonSerializer.Deserialize<Ucitelj>(zahtev.Objekat.ToString());
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
            Ucitelj ucitelj = JsonSerializer.Deserialize<Ucitelj>(zahtev.Objekat.ToString());
            try
            {
                Ucitelj res = broker.PretraziUcitelja(ucitelj);
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
        private void HandlePromeniUcitelja(Zahtev zahtev)
        {
            Ucitelj u = new Ucitelj();
            u = JsonSerializer.Deserialize<Ucitelj>(zahtev.Objekat.ToString());
            Debug.WriteLine(">>>>>>" + u.ToString());
            try
            {
                broker.PromeniUcitelja(u);
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
            u = JsonSerializer.Deserialize<Ucitelj>(zahtev.Objekat.ToString());
            Debug.WriteLine(">>>>>>" + u.ToString());
            try
            {
                broker.ObrisiUcitelja(u);
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
            u = JsonSerializer.Deserialize<Ucitelj>(zahtev.Objekat.ToString());
            Debug.WriteLine(">>>>>>" + u.ToString());
            try
            {
                broker.KreirajUcitelja(u);
                Odgovor odg = new Odgovor() { Uspesno = true };
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
                BindingList<Ucitelj> res = broker.VratiListuSviUcitelji();
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
            List<object> paket = JsonSerializer.Deserialize<List<object>>(zahtev.Objekat.ToString());
            Ucitelj ucitelj = null;
            Sertifikat sertifikat = null;
            if (paket[0] != null)
            {
                ucitelj = JsonSerializer.Deserialize<Ucitelj>(paket[0].ToString());
            }
            if (paket[1] != null)
            {
                sertifikat = JsonSerializer.Deserialize<Sertifikat>(paket[1].ToString());
            }



            try
            {
                BindingList<Ucitelj> res = broker.VratiListuUcitelja(ucitelj, sertifikat);
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }


        }



        //UCENIK
        private void HandleVratiListuUcenika(Zahtev zahtev)
        {
            GrupaUcenika grupaUcenika = null;
            Ucenik ucenik = null;
            List<object> paket = JsonSerializer.Deserialize<List<object>>(zahtev.Objekat.ToString());
            if (paket[0] != null)
                grupaUcenika = JsonSerializer.Deserialize<GrupaUcenika>(paket[0].ToString());
            if (paket[1] != null)
                ucenik = JsonSerializer.Deserialize<Ucenik>(paket[1].ToString());
            try
            {
                BindingList<Ucenik> res = broker.VratiListuUcenika(grupaUcenika, ucenik);
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
                BindingList<Ucenik> res = broker.VratiListuSviUcenici();
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
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
                Ucenik ucenik = JsonSerializer.Deserialize<Ucenik>(zahtev.Objekat.ToString());
                broker.KreirajUcenika(ucenik);
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
                Ucenik ucenik = JsonSerializer.Deserialize<Ucenik>(zahtev.Objekat.ToString());
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
                Ucenik ucenik = JsonSerializer.Deserialize<Ucenik>(zahtev.Objekat.ToString());
                broker.ObrisiUcenika(ucenik);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }


        //GRUPA UCENIKA
        private void HandleVratiListuSveGrupeUcenika(Zahtev zahtev)
        {
            try
            {
                BindingList<GrupaUcenika> res = broker.VratiListuSveGrupeUcenika();
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }

        }
        private void HandleVratiListuGrupaUcenika(Zahtev zahtev)
        {
            Ucitelj ucitelj = null;
            Ucenik ucenik = null;
            Kurs kurs = null;
            List<object> paket = JsonSerializer.Deserialize<List<object>>(zahtev.Objekat.ToString());
            if (paket[0] != null)
            {
                ucitelj = JsonSerializer.Deserialize<Ucitelj>(paket[0].ToString());
            }
            if (paket[1] != null)
            {
                ucenik = JsonSerializer.Deserialize<Ucenik>(paket[1].ToString());
            }
            if (paket[2] != null)
            {
                kurs = new Kurs();
                kurs = JsonSerializer.Deserialize<Kurs>(paket[2].ToString());
            }


            try
            {
                BindingList<GrupaUcenika> res = broker.VratiListuGrupaUcenika(ucenik: ucenik, ucitelj: ucitelj, kurs: kurs);
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }

        }
        private void HandleVratiZauzeteTermine(Zahtev zahtev)
        {
            try
            {
                List<string> res = broker.VratiZauzeteTermine();
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
                GrupaUcenika grupa = JsonSerializer.Deserialize<GrupaUcenika>(zahtev.Objekat.ToString());
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
                GrupaUcenika grupa = JsonSerializer.Deserialize<GrupaUcenika>(zahtev.Objekat.ToString());
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
                GrupaUcenika grupa = JsonSerializer.Deserialize<GrupaUcenika>(zahtev.Objekat.ToString());
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
        private void HandleVratiListuSlobodneGrupe(Zahtev zahtev)
        {
            try
            {

                BindingList<GrupaUcenika> res = broker.VratiListuSlobodneGrupe();
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

        //EVIDENCIJA NASTAVE
        private void HandleKreirajEvidencijuNastave(Zahtev zahtev)
        {
            EvidencijaNastave evidencija = new EvidencijaNastave();
            BindingList<StavkaEvidencijeNastave> stavke = new BindingList<StavkaEvidencijeNastave>();
            //evidencija = JsonSerializer.Deserialize<EvidencijaNastave>(zahtev.Objekat1.ToString());
            //stavke = JsonSerializer.Deserialize<BindingList<StavkaEvidencijeNastave>>(zahtev.Objekat2.ToString());
            List<object> paket = JsonSerializer.Deserialize<List<object>>(zahtev.Objekat.ToString());
            Debug.Write(">>>> " + paket);
            Debug.WriteLine(zahtev.Objekat.ToString());
            evidencija = JsonSerializer.Deserialize<EvidencijaNastave>(paket[0].ToString());
            stavke = JsonSerializer.Deserialize<BindingList<StavkaEvidencijeNastave>>(paket[1].ToString());

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
        private void HandleVratiListuSveEvidencijeNastave(Zahtev zahtev)
        {
            try
            {
                BindingList<EvidencijaNastave> res = broker.VratiListuSveEvidencijaNastave();
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
            EvidencijaNastave evidencija = null;
            Kurs kurs = null;

            List<object> paket = JsonSerializer.Deserialize<List<object>>(zahtev.Objekat.ToString());
            if (paket[0] != null)
                grupaUcenika = JsonSerializer.Deserialize<GrupaUcenika>(paket[0].ToString());

            if (paket[1] != null)
                ucitelj = JsonSerializer.Deserialize<Ucitelj>(paket[1].ToString());

            if (paket[2] != null)
                ucenik = JsonSerializer.Deserialize<Ucenik>(paket[2].ToString());
            if (paket[3] != null)
                evidencija = JsonSerializer.Deserialize<EvidencijaNastave>(paket[3].ToString());
            if (paket[4] != null)
                kurs = JsonSerializer.Deserialize<Kurs>(paket[4].ToString());



            try
            {
                List<EvidencijaNastave> res = broker.VratiListuEvidencijaNastave(grupaUcenika: grupaUcenika, ucitelj: ucitelj, ucenik: ucenik, evidencijaNastave: evidencija, kurs: kurs);
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }

        }


        //STAVKA EVIDENCIJE NASTAVE
        private void HandleVratiListuStavkiEvidencijeNastave(Zahtev zahtev)
        {
            Ucenik ucenik = null;
            EvidencijaNastave evidencija = null;
            List<object> paket = JsonSerializer.Deserialize<List<object>>(zahtev.Objekat.ToString());
            if (paket[0] != null)
            {
                evidencija = JsonSerializer.Deserialize<EvidencijaNastave>(paket[0].ToString());
            }
            if (paket[1] != null)
            {
                ucenik = JsonSerializer.Deserialize<Ucenik>(paket[1].ToString());
            }


            try
            {
                BindingList<StavkaEvidencijeNastave> res = broker.VratiListuStavkiEvidencijeNastave(evidencija, ucenik);
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
            evidencija = JsonSerializer.Deserialize<EvidencijaNastave>(zahtev.Objekat.ToString());
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
                StavkaEvidencijeNastave stavka = JsonSerializer.Deserialize<StavkaEvidencijeNastave>(zahtev.Objekat.ToString());
                broker.KreirajStavkuEvidencijeNastave(stavka);
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
                StavkaEvidencijeNastave stavka = JsonSerializer.Deserialize<StavkaEvidencijeNastave>(zahtev.Objekat.ToString());
                broker.PromeniStavkuEvidencijeNastave(stavka);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));

            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));

            }
        }

        //SERTIFIKAT

        private void HandleVratiListuSviSertifikati(Zahtev zahtev)
        {
            try
            {
                BindingList<Sertifikat> res = broker.VratiListuSviSertifikati();
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }
        private void HandleUbaciSertifikat(Zahtev zahtev)
        {
            try
            {
                Sertifikat sertifikat = JsonSerializer.Deserialize<Sertifikat>(zahtev.Objekat.ToString());
                broker.UbaciSertifikat(sertifikat);
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
                Sertifikat sertifikat = JsonSerializer.Deserialize<Sertifikat>(zahtev.Objekat.ToString());
                broker.PromeniSertifikat(sertifikat);
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
                Sertifikat sertifikat = JsonSerializer.Deserialize<Sertifikat>(zahtev.Objekat.ToString());
                broker.ObrisiSertikat(sertifikat);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }
        private void HandleVratiListuSertifikata(Zahtev zahtev)
        {

            List<object> paket = JsonSerializer.Deserialize<List<object>>(zahtev.Objekat.ToString());
            Ucitelj ucitelj = null;
            Sertifikat sertifikat = null;
            if (paket[0] != null)
            {
                ucitelj = JsonSerializer.Deserialize<Ucitelj>(paket[0].ToString());
            }
            if (paket[1] != null)
            {
                sertifikat = JsonSerializer.Deserialize<Sertifikat>(paket[1].ToString());
            }

            try
            {
                BindingList<Sertifikat> res = broker.VratiListuSertifikata(ucitelj, sertifikat);
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>>>>>>" + ex.Message);
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        //LICENCA
        private void HandleKreirajLicencu(Zahtev zahtev)
        {
            Licenca licenca = JsonSerializer.Deserialize<Licenca>(zahtev.Objekat.ToString());
            try
            {
                broker.KreirajLicencu(licenca);
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
            Licenca licenca = JsonSerializer.Deserialize<Licenca>(zahtev.Objekat.ToString());
            try
            {
                broker.PromeniLicencu(licenca);
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
                BindingList<Licenca> res = broker.VratiListuSveLicence();
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
            List<object> paket = JsonSerializer.Deserialize<List<object>>(zahtev.Objekat.ToString());
            Sertifikat sertifikat = null;
            Ucitelj ucitelj = null;
            if (paket[0] != null)
            {
                ucitelj = JsonSerializer.Deserialize<Ucitelj>(paket[0].ToString());
            }
            if (paket[1] != null)
            {
                sertifikat = JsonSerializer.Deserialize<Sertifikat>(paket[1].ToString());
            }

            try
            {

                BindingList<Licenca> res = broker.VratiListuLicence(ucitelj, sertifikat);
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {

                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }

        }


        //KURS
        private void HandlePretraziKurs(Zahtev zahtev)
        {
            Kurs kurs = JsonSerializer.Deserialize<Kurs>(zahtev.Objekat.ToString());
            try
            {
                Kurs res = broker.PretraziKurs(kurs);
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
        private void HandleVratiListuSviKursevi(Zahtev zahtev)
        {
            try
            {
                BindingList<Kurs> res = broker.VratiListuSviKursevi();
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }

        }
        private void HandleKreirajKurs(Zahtev zahtev)
        {
            try
            {
                Kurs kurs = JsonSerializer.Deserialize<Kurs>(zahtev.Objekat.ToString());
                broker.KreirajKurs(kurs);
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
                Kurs kurs = JsonSerializer.Deserialize<Kurs>(zahtev.Objekat.ToString());
                broker.PromeniKurs(kurs);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }
        private void HandleVratiListuKurseva(Zahtev zahtev)
        {
            try
            {

                Kurs kurs = JsonSerializer.Deserialize<Kurs>(zahtev.Objekat.ToString());
                BindingList<Kurs> res = broker.VratiListuKurseva(kurs);
                Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
                writer.WriteLine(JsonSerializer.Serialize(odg));

            }
            catch (Exception ex)
            {
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }

        //UCENIKGRUPA
        private void HandleKreirajUcenikGrupa(Zahtev zahtev)
        {
            try
            {
                List<object> paket = JsonSerializer.Deserialize<List<object>>(zahtev.Objekat.ToString());
                GrupaUcenika grupa = JsonSerializer.Deserialize<GrupaUcenika>(paket[1].ToString());
                Ucenik ucenik = JsonSerializer.Deserialize<Ucenik>(paket[0].ToString());
                broker.KreirajUcenikGrupa(ucenik, grupa);
                Odgovor odg = new Odgovor() { Uspesno = true };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>>>>>>" + ex.Message);
                Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
                writer.WriteLine(JsonSerializer.Serialize(odg));
            }
        }




















        //private void HandleVratiListuStavkiEvidencijeNastave(Zahtev zahtev)
        //{
        //    EvidencijaNastave evidencija = JsonSerializer.Deserialize<EvidencijaNastave>(zahtev.Objekat.ToString());
        //    try
        //    {
        //        BindingList<StavkaEvidencijeNastave> res = broker.vratiListuStavkiEvidencijeNastave(evidencija);
        //        Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }
        //    catch (Exception ex)
        //    {
        //        Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }

        //}










        //private void HandlePretraziUcenikaPoImenu(Zahtev zahtev)
        //{
        //    try
        //    {
        //        Ucenik ucenik = JsonSerializer.Deserialize<Ucenik>(zahtev.Objekat.ToString());
        //        BindingList<Ucenik> res = broker.pretraziUcenikaPoImenu(ucenik);
        //        Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }catch(Exception ex)
        //    {
        //        Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }
        //}






        //private void HandleVratiListuEvidencijeNastavePoKursu(Zahtev zahtev)
        //{
        //    try
        //    {
        //        Kurs k = JsonSerializer.Deserialize<Kurs>(zahtev.Objekat.ToString());
        //        List<EvidencijaNastave> res = broker.vratiListuEvidencijaNastave(null, null, null, null,k);
        //        Odgovor odg = new Odgovor() { Uspesno = true,  Objekat = res};
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }catch(Exception ex)
        //    {
        //        Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }
        //}



       



        //private void HandleVratiListuSertifikataPoImenu(Zahtev zahtev)
        //{
        //    try
        //    {

        //        Sertifikat sertifikat = JsonSerializer.Deserialize<Sertifikat>(zahtev.Objekat.ToString());
        //        BindingList<Sertifikat> res = broker.VratiListuSertifikata(sertifikat);
        //        Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
        //        writer.WriteLine(JsonSerializer.Serialize(odg));

        //    }
        //    catch (Exception ex)
        //    {
        //        Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }
        //}





        //private void HandleVratiListuSertifikataPoUcitelju(Zahtev zahtev)
        //{
        //    Ucitelj u = new Ucitelj();
        //    u = JsonSerializer.Deserialize<Ucitelj>(zahtev.Objekat.ToString());
        //    try
        //    {

        //        BindingList<Sertifikat> res = broker.vratiListuSertifikata(u);
        //        Odgovor odg = new Odgovor { Uspesno = true, Objekat = res };
        //        Debug.WriteLine(JsonSerializer.Serialize(res));
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }
        //    catch (Exception ex)
        //    {
        //        Odgovor odg = new Odgovor
        //        {
        //            Uspesno = false,
        //            Greska = ex.Message
        //        };
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }
        //}

        //private void HandleVratiListuGrupaUcenikaPoUceitelju(Zahtev zahtev)
        //{
        //    Ucitelj u = new Ucitelj();
        //    u = JsonSerializer.Deserialize<Ucitelj>(zahtev.Objekat.ToString());
        //    try
        //    {

        //        BindingList<GrupaUcenika> res = broker.VratiListuGrupaUcenika(u);
        //        Odgovor odg = new Odgovor { Uspesno = true, Objekat = res };
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }
        //    catch (Exception ex)
        //    {
        //        Odgovor odg = new Odgovor
        //        {
        //            Uspesno = false,
        //            Greska = ex.Message
        //        };
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }
        //}

        //private void HandleVratiListuGrupaUcenikaPoKursu(Zahtev zahtev)
        //{

        //    Kurs kurs = JsonSerializer.Deserialize<Kurs>(zahtev.Objekat.ToString());
        //    try
        //    {

        //        BindingList<GrupaUcenika> res = broker.VratiListuGrupaUcenika(kurs);
        //        Odgovor odg = new Odgovor { Uspesno = true, Objekat = res };
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }
        //    catch (Exception ex)
        //    {
        //        Odgovor odg = new Odgovor
        //        {
        //            Uspesno = false,
        //            Greska = ex.Message
        //        };
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }
        //}

        //private void HandleVratiGrupuUcenikaPoUceniku(Zahtev zahtev)
        //{
        //    Ucenik u = new Ucenik();
        //    u = JsonSerializer.Deserialize<Ucenik>(zahtev.Objekat.ToString());
        //    try
        //    {

        //        BindingList<GrupaUcenika> res = broker.VratiListuGrupaUcenika(u);
        //        Odgovor odg = new Odgovor { Uspesno = true, Objekat = res };
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }
        //    catch (Exception ex)
        //    {
        //        Odgovor odg = new Odgovor
        //        {
        //            Uspesno = false,
        //            Greska = ex.Message
        //        };
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }
        //}





        //private void HandleVratiListuUciteljaPoSertifikatu(Zahtev zahtev)
        //{
        //    Sertifikat s = JsonSerializer.Deserialize<Sertifikat>(zahtev.Objekat.ToString());
        //    try
        //    {
        //        BindingList<Ucitelj> res = broker.vratiListuUcitelja(s);
        //        Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }
        //    catch (Exception ex)
        //    {
        //        Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }

        //}

        //private void HandleVratiListuUciteljaPoUcitelju(Zahtev zahtev)
        //{
        //    Ucitelj ucitelj = JsonSerializer.Deserialize<Ucitelj>(zahtev.Objekat.ToString());
        //    try
        //    {
        //        BindingList<Ucitelj> res = broker.vratiListuUcitelja(ucitelj);
        //        Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }
        //    catch (Exception ex)
        //    {
        //        Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }

        //}



        //private void HandleVratiListuLicencaPoUcitelju(Zahtev zahtev)
        //{
        //    Ucitelj ucitelj = JsonSerializer.Deserialize<Ucitelj>(zahtev.Objekat.ToString());
        //    try
        //    {
        //        BindingList<Licenca> res = broker.vratiListuLicence(ucitelj);
        //        Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }
        //    catch (Exception ex)
        //    {
        //        Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }

        //}

        //private void HandleVratiListuLicencaPoSertifikatu(Zahtev zahtev)
        //{
        //    Sertifikat sertifikat = JsonSerializer.Deserialize<Sertifikat>(zahtev.Objekat.ToString());
        //    try
        //    {
        //        BindingList<Licenca> res = broker.vratiListuLicence(sertifikat);
        //        Odgovor odg = new Odgovor() { Uspesno = true, Objekat = res };
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }
        //    catch (Exception ex)
        //    {
        //        Odgovor odg = new Odgovor() { Uspesno = false, Greska = ex.Message };
        //        writer.WriteLine(JsonSerializer.Serialize(odg));
        //    }

        //}


    }
}






