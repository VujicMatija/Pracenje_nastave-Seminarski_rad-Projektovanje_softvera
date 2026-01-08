using Domeni;

using Forme.User_controlers;
using Forme.Utils;

namespace Forme
{
    public partial class Glavna : Form
    {
        Ucitelj uciteljGlobalna = new Ucitelj();
        public Glavna(Ucitelj ucitelj)
        {
            InitializeComponent();
            uciteljGlobalna = ucitelj;
            UCPrikazUcitelja prikazUcitelja = new UCPrikazUcitelja(ucitelj);
            panel.Controls.Clear();
            panel.Controls.Add(prikazUcitelja);
        }

        private void kreiranjeEvidencijanNastaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCRadSaEvidencijomNastave uCRadSaEvidencijomNastave = new UCRadSaEvidencijomNastave();
            panel.Controls.Clear();
            panel.Controls.Add(uCRadSaEvidencijomNastave);
        }

        private void prikažiUčiteljaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCPrikazUcitelja prikazUcitelja = new UCPrikazUcitelja(uciteljGlobalna);
            panel.Controls.Clear();
            panel.Controls.Add(prikazUcitelja);
        }

        private void prikazEvidencijanNastaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pretražiEvidencijuNastaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            UCPretraziEvidencijuNastave ucPretrazi = new UCPretraziEvidencijuNastave();
            panel.Controls.Add(ucPretrazi);
        }

        private void kreirajGrupuUčenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCKreirajGrupuUčenika uCKreirajGrupuUčenika = new UCKreirajGrupuUčenika();
            panel.Controls.Clear();
            panel.Controls.Add(uCKreirajGrupuUčenika);
        }

        private void pretražiGrupuUčenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            UCpretraziGrupuUcenika ucPretraziGrupuUcenika = new UCpretraziGrupuUcenika();
            panel.Controls.Add(ucPretraziGrupuUcenika);
        }

        private void promeniGrupuUčenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            UCKreirajGrupuUčenika ucPromeniGrupuUcenika = new UCKreirajGrupuUčenika(WorkMode.UPDATE);
            panel.Controls.Add(ucPromeniGrupuUcenika);
        }

        private void kreirajUčiteljaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            UCradSaUciteljem ucUcitelj = new UCradSaUciteljem();
            panel.Controls.Add(ucUcitelj);

        }

        private void pretražiUčiteljaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            UCpretraziUcitelja uCpretraziUcitelja = new UCpretraziUcitelja();
            panel.Controls.Add(uCpretraziUcitelja);
        }

        private void kreirajUčenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            UCradSaUcenikom uCradSaUcenikom = new UCradSaUcenikom();
            panel.Controls.Add(uCradSaUcenikom);
        }

        private void pretražiUčenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            UCpretraziUcenika uCpretraziUcenika = new UCpretraziUcenika();
            panel.Controls.Add(uCpretraziUcenika);
        }

        private void radSaSertifikatimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UcRadSaSertifikatima ucSertifikati = new UcRadSaSertifikatima();
            panel.Controls.Clear();
            panel.Controls.Add(ucSertifikati);
        }

        private void kurseviToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void radSaKursevimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            UCradSaKursom ucRadSaKursevima = new UCradSaKursom();
            panel.Controls.Add(ucRadSaKursevima);
        }

        private void pretraziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            UCpretragaStavkiEvidencijeNastave uCpretragaStavkiEvidencijeNastave = new UCpretragaStavkiEvidencijeNastave();
            panel.Controls.Add(uCpretragaStavkiEvidencijeNastave);
        }

        private void stavkeEvidencijeNastaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void licenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            UCpretraziLicencu uCpretraziLicencu = new UCpretraziLicencu();
            panel.Controls.Add(uCpretraziLicencu);
        }
    }
}
