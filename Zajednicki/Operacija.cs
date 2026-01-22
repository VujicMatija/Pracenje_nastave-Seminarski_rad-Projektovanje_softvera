using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki
{
    public enum Operacija
    {

        //Evidencija nastave
        KreirajEvidencujuNastave,
        VratiListuSveEvidencijeNastave,
        VratiListuEvidencijaNastave,
        PromeniEvidencijuNastave,

        //Stavke evidencije nastave
        VratiListuStavkiEvidencijeNastave,
        KreirajStavkuEvidencijeNastave,
        PromeniStavkuEvidencijeNastave,

        //Ucitelj
        PrijaviUcitelja,
        PretraziUcitelja,
        PromeniUcitelja,
        ObrisiUcitelja,
        KreirajUcitelja,
        VratiListuSviUcitelji,
        VratiListuUcitelji,

        //Ucenici
        KreirajUcenika,
        PromeniUcenika,
        ObrisiUcenika,
        VratiListuUcenika,
        VratiListuSviUcenici,


       //GrupeUcenika
        KreirajGrupuUcenika,
        PromeniGrupuUcenika,
        ObrisiGrupuUcenika,
        VratiListuSlobodneGrupe,
        VratiListuSveGrupeUcenika,
        VratiZauzeteTermine,
        VratiListuGrupeUcenika,

        //Kurs
        KreirajKurs,
        PromeniKurs,
        PretraziKurs,
        VratiListuSviKursevi,
        VratiListuKurseva,

        //Sertifikati
        
        VratiListuSviSertifikati,
        UbaciSertifikat,
        PromeniSertifikat,
        ObrisiSertifikat,
        VratiListuSertifikata,

        //LICENECE
        KreirajLicencu,
        PromeniLicencu,
        VratiListuSveLicence,
        VratiListuLicence,

        //UCENIK GRUPA
        KreirajUcenikGrupa


        //VratiListuEvidencijeNastavePoKursu,
        //VratiListuLicencePoSertifikatu,
        //VratiListuLicencePoUcitelju,
        //VratiListuSertifikataPoNazivu,
        //VratiListuSertifikataPoUcitelju,
        //vratiListuGrupeUcenikaPoUcitelju,
        // VratiListuGrupeUcenikaPoUceniku,
        //VratiListuGrupeUcenikaPoKursu,
        // PretraziUcenikaPoImenu,
        //VratiListuUciteljaPoSertifikatu,
        //VratiListuUciteljaPoUcitelju,
        // VratiListuStavkiEvidencijeNastavePoUceniku,


    }
}
