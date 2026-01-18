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
        VratiListuEvidencijeNastavePoKursu,
        PromeniEvidencijuNastave,

        //Stavke evidencije nastave
        VratiListuStavkiEvidencijeNastave,
        VratiListuStavkiEvidencijeNastavePoUceniku,
        KreirajStavkuEvidencijeNastave,
        PromeniStavkuEvidencijeNastave,

        //Ucitelj
        PrijaviUcitelja,
        PretraziUcitelja,
        PromeniUcitelja,
        ObrisiUcitelja,
        KreirajUcitelja,
        VratiListuSviUcitelji,
        VratiListuUciteljaPoSertifikatu,
        VratiListuUciteljaPoUcitelju,
        VratiListuUcitelji,

        //Ucenici
        KreirajUcenika,
        PromeniUcenika,
        ObrisiUcenika,
        VratiListuUcenika,
        VratiListuSviUcenici,
        PretraziUcenikaPoImenu,

       //GrupeUcenika
        KreirajGrupuUcenika,
        PromeniGrupuUcenika,
        ObrisiGrupuUcenika,
        vratiListuGrupeUcenikaPoUcitelju,
        VratiListuGrupeUcenikaPoUceniku,
        VratiListuGrupeUcenikaPoKursu,
        VratiListuSlobodneGrupe,
        VratiListuSveGrupeUcenika,
        VratiZauzeteTermine,

        //Kurs
        KreirajKurs,
        PromeniKurs,
        PretraziKurs,
        VratiListuSviKursevi,
        VratiListuKursevaPoImenu,

        //Sertifikati
        VratiListuSertifikataPoUcitelju,
        VratiListuSviSertifikati,
        UbaciSertifikat,
        PromeniSertifikat,
        ObrisiSertifikat,
        VratiListuSertifikataPoNazivu,

        //LICENECE
        KreirajLicencu,
        PromeniLicencu,
        VratiListuSveLicence,
        VratiListuLicencePoSertifikatu,
        VratiListuLicencePoUcitelju,
        VratiListuLicence,

        //UCENIK GRUPA
        KreirajUcenikGrupa

           



    }
}
