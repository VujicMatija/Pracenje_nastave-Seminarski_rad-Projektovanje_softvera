using Domeni;

using Forme.User_controlers;

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
    }
}
