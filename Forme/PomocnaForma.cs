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
    public partial class PomocnaForma : Form
    {
        public PomocnaForma()
        {
            InitializeComponent();
        }

        public PomocnaForma(UCPrikazEvidencijeNastave uc)
        {
            InitializeComponent();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }
        public PomocnaForma(UCPrikazUcitelja uc)
        {
            InitializeComponent();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        public PomocnaForma(UCradSaUcenikom uc)
        {
            InitializeComponent();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        public PomocnaForma(UCKreirajGrupuUčenika uc)
        {
            InitializeComponent();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        public PomocnaForma(UcRadSaSertifikatima uc)
        {
            InitializeComponent();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        public PomocnaForma(UCradSaKursom uc)
        {
            InitializeComponent();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        public PomocnaForma(UCdodajUcenikGrupa uc)
        {
            InitializeComponent();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        public PomocnaForma(UCradSaStavkomEvidencijeNastave uc)
        {
            InitializeComponent();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }
    }
}
