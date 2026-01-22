using Domeni;
using Microsoft.IdentityModel.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Zajednicki;

namespace Forme
{
    internal class Komunikacija
    {
        public static Komunikacija instance;

        public static Komunikacija Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Komunikacija();
                }
                return instance;
            }

        }

        private Komunikacija()
        {

        }

        private Socket soket;
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;

        public void PoveziSe()
        {
            soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            soket.Connect("127.0.0.1", 9999);
            stream = new NetworkStream(soket);
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);
            writer.AutoFlush = true;
        }

        //UCITELJ

        internal Ucitelj? PrijaviUcitelja(Ucitelj ucitelj)
        {
            Zahtev zahtev = new Zahtev() 
            { 
                Operacija = Operacija.PrijaviUcitelja,
                Objekat = ucitelj
            };
            writer.WriteLine(JsonSerializer.Serialize(zahtev));
            Odgovor o = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
            if (o.Uspesno)
            {
                Ucitelj prijavljeniUcitelj = JsonSerializer.Deserialize<Ucitelj>(o.Objekat.ToString());
                return prijavljeniUcitelj;
            }
            else
            {
                throw new Exception(o.Greska);
            }
        }

        internal Ucitelj pretraziUcitelja(Ucitelj ucitelj)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.PretraziUcitelja, Objekat = ucitelj };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno)
                {
                    Ucitelj res = JsonSerializer.Deserialize<Ucitelj>(odg.Objekat.ToString());
                    return res;
                }
                else
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch(SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }catch(Exception ex)
            {
                throw new Exception("Greska!");
            }
            
        }

        internal void promeniUcitelja(Ucitelj ucitelj)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.PromeniUcitelja, Objekat = ucitelj };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno == false)
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {
                throw new Exception("Greska!");
            }
        }

        internal void obrisiUcitelja(Ucitelj ucitelj)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.ObrisiUcitelja, Objekat = ucitelj };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno == false)
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {
                throw new Exception("Greska!");
            }
        }

        internal void KreirajUcitelja(Ucitelj ucitelj)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.KreirajUcitelja, Objekat = ucitelj };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno == false)
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {
                throw new Exception("Greska!");
            }
        }

        internal BindingList<Ucitelj> VratiListuSviUcitelji()
        {
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuSviUcitelji };
            writer.WriteLine(JsonSerializer.Serialize(zahtev));
            Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
            if (odg.Uspesno)
            {
                BindingList<Ucitelj> res = JsonSerializer.Deserialize<BindingList<Ucitelj>>(odg.Objekat.ToString());
                return res;
            }
            else
            {
                throw new Exception(odg.Greska);
            }
        }

        //internal BindingList<Ucitelj> VratiListuUcitelja(Sertifikat sertifikat)
        //{
        //    Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuUciteljaPoSertifikatu, Objekat = sertifikat };
        //    writer.WriteLine(JsonSerializer.Serialize(zahtev));
        //    Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
        //    if (odg.Uspesno)
        //    {
        //        BindingList<Ucitelj> res = JsonSerializer.Deserialize<BindingList<Ucitelj>>(odg.Objekat.ToString());
        //        return res;
        //    }
        //    else
        //    {
        //        throw new Exception(odg.Greska);
        //    }
        //}
        //internal BindingList<Ucitelj> VratiListuUcitelja(Ucitelj ucitelj)
        //{
        //    Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuUciteljaPoUcitelju, Objekat = ucitelj };
        //    writer.WriteLine(JsonSerializer.Serialize(zahtev));
        //    Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
        //    if (odg.Uspesno)
        //    {
        //        BindingList<Ucitelj> res = JsonSerializer.Deserialize<BindingList<Ucitelj>>(odg.Objekat.ToString());
        //        return res;
        //    }
        //    else
        //    {
        //        throw new Exception(odg.Greska);
        //    }
        //}

        internal BindingList<Ucitelj> VratiListuUcitelja(Ucitelj ucitelj = null, Sertifikat sertifikat = null)
        {
            try
            {
                List<object> paket = new List<object>() { ucitelj, sertifikat };
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuUcitelji, Objekat = paket };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno)
                {
                    BindingList<Ucitelj> res = JsonSerializer.Deserialize<BindingList<Ucitelj>>(odg.Objekat.ToString());
                    return res;
                }
                else
                {
                    throw new Exception(odg.Greska);
                }

            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        //SERTIFIKAT

        internal BindingList<Sertifikat> VratiListuSviSertifikati()
        {
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuSviSertifikati };
            writer.WriteLine(JsonSerializer.Serialize(zahtev));
            Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
            if (odg.Uspesno)
            {
                BindingList<Sertifikat> res = JsonSerializer.Deserialize<BindingList<Sertifikat>>(odg.Objekat.ToString());
                return res;
            }
            else
            {
                throw new Exception(odg.Greska);
            }
        }

        //internal BindingList<Sertifikat> vratiListuSertifikata(Ucitelj ucitelj)
        //{

        //    try
        //    {
        //        Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuSertifikataPoUcitelju, Objekat = ucitelj };

        //        writer.WriteLine(JsonSerializer.Serialize(zahtev));
        //        Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
        //        if (odg.Uspesno)
        //        {
        //            BindingList<Sertifikat> res = JsonSerializer.Deserialize<BindingList<Sertifikat>>(odg.Objekat.ToString());
        //            return res;
        //        }
        //        else
        //        {
        //            throw new Exception(odg.Greska);
        //        }
        //    }
        //    catch (SocketException se)
        //    {
        //        Debug.WriteLine(">>>>>" + se.Message);
        //        throw new Exception("Problem sa serverom!");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Greska!");
        //    }
            
        //}

        //internal BindingList<Sertifikat> vratiListuSertifikata(Sertifikat sertifikat)
        //{
        //    Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuSertifikataPoUcitelju, Objekat = sertifikat };
        //    writer.WriteLine(JsonSerializer.Serialize(zahtev));
        //    Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
        //    if (odg.Uspesno)
        //    {
        //        BindingList<Sertifikat> res = JsonSerializer.Deserialize<BindingList<Sertifikat>>(odg.Objekat.ToString());
        //        return res;
        //    }
        //    else
        //    {
        //        throw new Exception(odg.Greska);
        //    }
        //}

        internal BindingList<Sertifikat> VratiListuSertifikata(Sertifikat sertifikat, Ucitelj ucitelj)
        {
            List<object> paket = new List<object>() { ucitelj, sertifikat};
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuSertifikata, Objekat = paket};
            writer.WriteLine(JsonSerializer.Serialize(zahtev));
            Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
            if (odg.Uspesno)
            {
                BindingList<Sertifikat> res = JsonSerializer.Deserialize<BindingList<Sertifikat>>(odg.Objekat.ToString());
                return res;
            }
            else
            {
                throw new Exception(odg.Greska);
            }
        }

        internal void PromeniSertifikat(Sertifikat sertifikat)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.PromeniSertifikat, Objekat = sertifikat };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno == false)
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {
                throw new Exception("Greska!");
            }
        }

        internal void ObrisiSertifikat(Sertifikat sertifikat)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.ObrisiSertifikat, Objekat = sertifikat };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno == false)
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {
                throw new Exception("Greska!");
            }
        }

        internal void UbaciSertifikat(Sertifikat sertifikat)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.UbaciSertifikat, Objekat = sertifikat };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno == false)
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {
                throw new Exception("Greska!");
            }
        }

        //internal BindingList<Sertifikat> VratiListuSertifikata(Sertifikat sertifikat)
        //{
        //    try
        //    {
        //        Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuSertifikataPoNazivu, Objekat = sertifikat };
        //        writer.WriteLine(JsonSerializer.Serialize(zahtev));
        //        Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
        //        if (odg.Uspesno)
        //        {
        //            BindingList<Sertifikat> res = JsonSerializer.Deserialize<BindingList<Sertifikat>>(odg.Objekat.ToString());
        //            return res;
        //        }
        //        else
        //        {
        //            throw new Exception(odg.Greska);
        //        }
        //    }
        //    catch (SocketException se)
        //    {
        //        Debug.WriteLine(">>>>>" + se.Message);
        //        throw new Exception("Problem sa serverom!");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Greska!");
        //    }
        //}

        //GRUPA UCENIKA

        //internal BindingList<GrupaUcenika> vratiListuGrupaUcenika(Ucitelj ucitelj)
        //{
        //    try
        //    {
        //        Zahtev zahtev = new Zahtev() { Operacija = Operacija.vratiListuGrupeUcenikaPoUcitelju, Objekat = ucitelj };
        //        writer.WriteLine(JsonSerializer.Serialize(zahtev));
        //        Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
        //        if (odg.Uspesno)
        //        {
        //            BindingList<GrupaUcenika> res = JsonSerializer.Deserialize<BindingList<GrupaUcenika>>(odg.Objekat.ToString());
        //            return res;
        //        }
        //        else
        //        {
        //            throw new Exception(odg.Greska);
        //        }
        //    }
        //    catch (SocketException se)
        //    {
        //        Debug.WriteLine(">>>>>" + se.Message);
        //        throw new Exception("Problem sa serverom!");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Greska!");
        //    }
           
        //}

        //internal BindingList<GrupaUcenika> vratiListuGrupaUcenika(Kurs kurs)
        //{
        //    try
        //    {
        //        Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuGrupeUcenikaPoKursu, Objekat = kurs };
        //        writer.WriteLine(JsonSerializer.Serialize(zahtev));
        //        Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
        //        if (odg.Uspesno)
        //        {
        //            BindingList<GrupaUcenika> res = JsonSerializer.Deserialize<BindingList<GrupaUcenika>>(odg.Objekat.ToString());
        //            return res;
        //        }
        //        else
        //        {
        //            throw new Exception(odg.Greska);
        //        }
        //    }
        //    catch (SocketException se)
        //    {
        //        Debug.WriteLine(">>>>>" + se.Message);
        //        throw new Exception("Problem sa serverom!");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Greska!");
        //    }

        //}

        //internal BindingList<GrupaUcenika> vratiListuGrupaUcenika(Ucenik ucenik)
        //{
        //    try
        //    {
        //        Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuGrupeUcenikaPoUceniku, Objekat = ucenik};
        //        writer.WriteLine(JsonSerializer.Serialize(zahtev));
        //        Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
        //        if (odg.Uspesno)
        //        {
        //            BindingList<GrupaUcenika> res = JsonSerializer.Deserialize<BindingList<GrupaUcenika>>(odg.Objekat.ToString());
        //            return res;
        //        }
        //        else
        //        {
        //            throw new Exception(odg.Greska);
        //        }
        //    }
        //    catch (SocketException se)
        //    {
        //        Debug.WriteLine(">>>>>" + se.Message);
        //        throw new Exception("Problem sa serverom!");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Greska!");
        //    }

        //}

        internal BindingList<GrupaUcenika> vratiListuSlobodneGrupe()
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuSlobodneGrupe };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno)
                {
                    BindingList<GrupaUcenika> res = JsonSerializer.Deserialize<BindingList<GrupaUcenika>>(odg.Objekat.ToString());
                    return res;
                }
                else
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {
                throw new Exception("Greska!");
            }

        }

        internal BindingList<GrupaUcenika> VratiListuSveGrupeUcenika()
        {
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuSveGrupeUcenika };
            writer.WriteLine(JsonSerializer.Serialize(zahtev));
            Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
            if (odg.Uspesno)
            {
                BindingList<GrupaUcenika> res = JsonSerializer.Deserialize<BindingList<GrupaUcenika>>(odg.Objekat.ToString());
                return res;
            }
            else
            {
                throw new Exception(odg.Greska);
            }
        }

        internal List<string> VratiZauzeteTermine()
        {
            try
            {

                Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiZauzeteTermine };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno)
                {
                    List<string> res = JsonSerializer.Deserialize<List<string>>(odg.Objekat.ToString());
                    return res;
                }
                else
                {
                    throw new Exception(odg.Greska);
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        internal void PromeniGrupuUcenika(GrupaUcenika grupa)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.PromeniGrupuUcenika, Objekat = grupa };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno == false)
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {
                throw new Exception("Greska!");
            }
        }

        internal void ObrisiGrupuUcenika(GrupaUcenika grupa)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.ObrisiGrupuUcenika, Objekat = grupa };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno == false)
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {
                throw new Exception("Greska!");
            }
        }

        internal void KreirajGrupuUcenika(GrupaUcenika grupa)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.KreirajGrupuUcenika, Objekat = grupa };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno == false)
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {
                throw new Exception("Greska!");
            }
        }


        internal BindingList<GrupaUcenika> vratiListuGrupaUcenika(Ucitelj ucitelj, Ucenik ucenik, Kurs kurs)
        {
            try
            {
                List<object> paket = new List<object>() { ucitelj, ucenik, kurs };
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuGrupeUcenika, Objekat = paket };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno)
                {
                    BindingList<GrupaUcenika> res = JsonSerializer.Deserialize<BindingList<GrupaUcenika>>(odg.Objekat.ToString());
                    return res;
                }
                else
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {
                throw new Exception("Greska!");
            }

        }


        //LICENCA


        internal void KreirajLicencu(Licenca licenca)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.KreirajLicencu, Objekat = licenca };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if(odg.Uspesno == false)
                {
                    throw new Exception(odg.Greska);
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        internal void PromeniLicencu(Licenca licenca)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.PromeniLicencu, Objekat = licenca };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno == false)
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal BindingList<Licenca> VratiListuSveLicence()
        {
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuSveLicence};
            writer.WriteLine(JsonSerializer.Serialize(zahtev));
            Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
            if (odg.Uspesno)
            {
                BindingList<Licenca> res = JsonSerializer.Deserialize<BindingList<Licenca>>(odg.Objekat.ToString());
                return res;
            }
            else
            {
                throw new Exception(odg.Greska);
            }
        }

        //internal BindingList<Licenca> vratiListuLicence(Sertifikat sertifikat)
        //{
        //    Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuLicencePoSertifikatu, Objekat = sertifikat };
        //    writer.WriteLine(JsonSerializer.Serialize(zahtev));
        //    Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
        //    if (odg.Uspesno)
        //    {
        //        BindingList<Licenca> res = JsonSerializer.Deserialize<BindingList<Licenca>>(odg.Objekat.ToString());
        //        return res;
        //    }
        //    else
        //    {
        //        throw new Exception(odg.Greska);
        //    }
        //}

        //internal BindingList<Licenca> vratiListuLicence(Ucitelj ucitelj)
        //{
        //    Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuLicencePoUcitelju, Objekat = ucitelj };
        //    writer.WriteLine(JsonSerializer.Serialize(zahtev));
        //    Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
        //    if (odg.Uspesno)
        //    {
        //        BindingList<Licenca> res = JsonSerializer.Deserialize<BindingList<Licenca>>(odg.Objekat.ToString());
        //        return res;
        //    }
        //    else
        //    {
        //        throw new Exception(odg.Greska);
        //    }
        //}
        internal BindingList<Licenca> vratiListuLicence(Ucitelj ucitelj, Sertifikat sertifikat)
        {
            List<object> paket = new List<object>() {ucitelj, sertifikat };
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuLicence, Objekat = paket};
            writer.WriteLine(JsonSerializer.Serialize(zahtev));
            Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
            if (odg.Uspesno)
            {
                BindingList<Licenca> res = JsonSerializer.Deserialize<BindingList<Licenca>>(odg.Objekat.ToString());
             
                return res;
            }
            else
            {
                throw new Exception(odg.Greska);
            }
        }

        

        //EVIDENCIJA NASTAVE

        internal void KreirajEvidencijuNastave(EvidencijaNastave evidencija, BindingList<StavkaEvidencijeNastave> stavke)
        {
            try
            {
                //Zahtev zahtev = new Zahtev() { Operacija = Operacija.KreirajEvidencujuNastave, Objekat1 = evidencija , Objekat2 = stavke};
                
                List<object> objekat = new List<object>{ evidencija, stavke };
                MessageBox.Show(JsonSerializer.Serialize(objekat).ToString());
                Zahtev zahtev = new Zahtev { Operacija = Operacija.KreirajEvidencujuNastave , Objekat = objekat};
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno == false)
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal BindingList<EvidencijaNastave> VratiListuSveEvidencijeNastave()
        {
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuSveEvidencijeNastave };
            writer.WriteLine(JsonSerializer.Serialize(zahtev));
            Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
            if (odg.Uspesno)
            {
                BindingList<EvidencijaNastave> res = JsonSerializer.Deserialize<BindingList<EvidencijaNastave>>(odg.Objekat.ToString());
                return res;
            }
            else
            {
                throw new Exception(odg.Greska);
            }
        }

        //internal List<EvidencijaNastave> VratiListuEvidencijaNastave(Kurs kurs)
        //{
        //    try
        //    {
        //        Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuEvidencijeNastavePoKursu, Objekat = kurs };
        //        writer.WriteLine(JsonSerializer.Serialize(zahtev));
        //        Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
        //        if (odg.Uspesno == true)
        //        {
        //            List<EvidencijaNastave> res = JsonSerializer.Deserialize<List<EvidencijaNastave>>(odg.Objekat.ToString());
        //            return res;
        //        }
        //        else
        //        {
        //            throw new Exception(odg.Greska);
        //        }
        //    }
        //    catch (SocketException se)
        //    {
        //        Debug.WriteLine(">>>>>" + se.Message);
        //        throw new Exception("Problem sa serverom!");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Greska!");
        //    }
        //}

        internal List<EvidencijaNastave> VratiListuEvidencijaNastave(GrupaUcenika grupa = null, Ucitelj ucitelj = null, Ucenik ucenik = null, Kurs kurs = null, EvidencijaNastave evidencija = null)
        {

            List<object> paket = new List<object>() { grupa, ucitelj, ucenik, evidencija, kurs };
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuEvidencijaNastave, Objekat = paket };
            writer.WriteLine(JsonSerializer.Serialize(zahtev));
            Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
            if (odg.Uspesno)
            {
                List<EvidencijaNastave> res = JsonSerializer.Deserialize<List<EvidencijaNastave>>(odg.Objekat.ToString());
                return res;
            }
            else
            {
                throw new Exception(odg.Greska);
            }
        }

        internal void PromeniEvidencijuNastave(EvidencijaNastave evidencija)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.PromeniEvidencijuNastave, Objekat = evidencija };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno == false)
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {
                throw new Exception("Greska!");
            }
        }

        //UCENIK

        internal BindingList<Ucenik> VratiListuUcenika(GrupaUcenika grupa, Ucenik ucenik)
        {

            List<object> paket = new List<object>() { grupa, ucenik};
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuUcenika, Objekat = paket};
            writer.WriteLine(JsonSerializer.Serialize(zahtev));
            Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
            if (odg.Uspesno)
            {
                BindingList<Ucenik> res = JsonSerializer.Deserialize<BindingList<Ucenik>>(odg.Objekat.ToString());
                return res;
            }
            else
            {
                throw new Exception(odg.Greska);
            }
        }

        //internal BindingList<Ucenik> PretraziUcenikaPoImenu(Ucenik ucenik)
        //{
        //    try
        //    {
        //        Zahtev zahtev = new Zahtev() { Operacija = Operacija.PretraziUcenikaPoImenu, Objekat = ucenik };
        //        writer.WriteLine(JsonSerializer.Serialize(zahtev));
        //        Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
        //        if (odg.Uspesno)
        //        {
        //            BindingList<Ucenik> res = JsonSerializer.Deserialize<BindingList<Ucenik>>(odg.Objekat.ToString());
        //            return res;
        //        }
        //        else
        //        {
        //            throw new Exception(odg.Greska);
        //        }
        //    }
        //    catch (SocketException se)
        //    {
        //        Debug.WriteLine(">>>>>" + se.Message);
        //        throw new Exception("Problem sa serverom!");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Greska!");
        //    }
        //}

        internal BindingList<Ucenik> VratiListuSviUcenici()
        {
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuSviUcenici };
            writer.WriteLine(JsonSerializer.Serialize(zahtev));
            Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
            if (odg.Uspesno)
            {
                BindingList<Ucenik> res = JsonSerializer.Deserialize<BindingList<Ucenik>>(odg.Objekat.ToString());
                return res;
            }
            else
            {
                throw new Exception(odg.Greska);
            }
        }

        internal void PromeniUcenika(Ucenik ucenik)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.PromeniUcenika, Objekat = ucenik };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno == false)
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {
                throw new Exception("Greska!");
            }
        }

        internal void ObrisiUcenika(Ucenik ucenik)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.ObrisiUcenika, Objekat = ucenik };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno == false)
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {
                throw new Exception("Greska!");
            }
        }

        internal void KreirajUcenika(Ucenik ucenik)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.KreirajUcenika, Objekat = ucenik };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno == false)
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {
                throw new Exception("Greska!");
            }
        }

        

        //KURS

        internal Kurs PretraziKurs(Kurs kurs)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.PretraziKurs, Objekat = kurs };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno)
                {
                    Kurs res = JsonSerializer.Deserialize<Kurs>(odg.Objekat.ToString());
                    return res;
                }
                else
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {
                throw new Exception("Greska!");
            }
        }

        internal BindingList<Kurs> VratiListuSviKursevi()
        {
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuSviKursevi };
            writer.WriteLine(JsonSerializer.Serialize(zahtev));
            Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
            if (odg.Uspesno)
            {
                BindingList<Kurs> res = JsonSerializer.Deserialize<BindingList<Kurs>>(odg.Objekat.ToString());
                return res;
            }
            else
            {
                throw new Exception(odg.Greska);
            }
        }

        internal void KreirajKurs(Kurs kurs)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.KreirajKurs, Objekat = kurs };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno == false)
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {
                throw new Exception("Greska!");
            }
        }

        internal void PromeniKurs(Kurs kurs)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.PromeniKurs, Objekat = kurs };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno == false)
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {
                throw new Exception("Greska!");
            }
        }

        internal BindingList<Kurs> VratiListuKurseva(Kurs k)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuKurseva, Objekat = k };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno)
                {
                    BindingList<Kurs> res = JsonSerializer.Deserialize<BindingList<Kurs>>(odg.Objekat.ToString());
                    return res;
                }
                else
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {
                throw new Exception("Greska!");
            }
        }




        //STAVKE EVIDENCIJE NASTAVE


        //internal BindingList<StavkaEvidencijeNastave> VratiListuStavkiEvidencijeNastave(EvidencijaNastave evidencija)
        //{
        //    Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuStavkiEvidencijeNastave, Objekat = evidencija };
        //    writer.WriteLine(JsonSerializer.Serialize(zahtev));
        //    Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
        //    if (odg.Uspesno)
        //    {
        //        BindingList<StavkaEvidencijeNastave> res = JsonSerializer.Deserialize<BindingList<StavkaEvidencijeNastave>>(odg.Objekat.ToString());
        //        return res;
        //    }
        //    else
        //    {
        //        throw new Exception(odg.Greska);
        //    }
        //}

        internal BindingList<StavkaEvidencijeNastave> VratiListuStavkiEvidencijeNastave(EvidencijaNastave evidencija, Ucenik ucenik= null)
        {
            //Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuStavkiEvidencijeNastavePoUceniku, Objekat1 = evidencija , Objekat2 = ucenik};
            List<object> paket = new List<object>() {evidencija, ucenik};
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiListuStavkiEvidencijeNastave, Objekat = paket};
            writer.WriteLine(JsonSerializer.Serialize(zahtev));
            Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
            if (odg.Uspesno)
            {
                BindingList<StavkaEvidencijeNastave> res = JsonSerializer.Deserialize<BindingList<StavkaEvidencijeNastave>>(odg.Objekat.ToString());
                return res;
            }
            else
            {
                throw new Exception(odg.Greska);
            }
        }

        

        internal void KreirajStavkuEvidencijeNastave(StavkaEvidencijeNastave stavka)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.KreirajStavkuEvidencijeNastave, Objekat = stavka };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if(odg.Uspesno == false)
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>> " + se.Message);
                throw se;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        internal void PromeniStavkuEvidencijeNastave(StavkaEvidencijeNastave stavka)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.PromeniStavkuEvidencijeNastave, Objekat = stavka };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno == false)
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>> " + se.Message);
                throw se;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

       //UCENIK GRUPA

        internal void KreirajUcenikGrupa( Ucenik ucenik, GrupaUcenika grupa)
        {
            
            try
            {
                List<object> paket = new List<object>() { ucenik, grupa};
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.KreirajUcenikGrupa, Objekat = paket };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor odg = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (odg.Uspesno == false)
                {
                    throw new Exception(odg.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {
                throw new Exception("Greska!");
            }
        }

    }

    
}
