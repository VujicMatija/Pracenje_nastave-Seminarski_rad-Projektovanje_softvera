using Domeni;
using Forme.User_controlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class DodajLicencuForma : Form
    {
        public DodajLicencuForma(Ucitelj ucitelj)
        {
            InitializeComponent();
            panel1.Controls.Clear();
            UCkreirajLicencu ucKreirajLicencu = new UCkreirajLicencu(ucitelj);
            panel1.Controls.Add(ucKreirajLicencu);
        }

        public DodajLicencuForma(Licenca licenca)
        {
            InitializeComponent();
            panel1.Controls.Clear();
            UCkreirajLicencu ucKreirajLicencu = new UCkreirajLicencu(licenca);
            panel1.Controls.Add(ucKreirajLicencu);
        }
    }
}
