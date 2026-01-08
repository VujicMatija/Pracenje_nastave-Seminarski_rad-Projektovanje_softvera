namespace Forme
{
    partial class Glavna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            učiteljToolStripMenuItem = new ToolStripMenuItem();
            prikažiUčiteljaToolStripMenuItem = new ToolStripMenuItem();
            kreirajUčiteljaToolStripMenuItem = new ToolStripMenuItem();
            pretražiUčiteljaToolStripMenuItem = new ToolStripMenuItem();
            evidencijaNastaveToolStripMenuItem = new ToolStripMenuItem();
            kreiranjeEvidencijanNastaveToolStripMenuItem = new ToolStripMenuItem();
            pretražiEvidencijuNastaveToolStripMenuItem = new ToolStripMenuItem();
            učeniciToolStripMenuItem = new ToolStripMenuItem();
            kreirajUčenikaToolStripMenuItem = new ToolStripMenuItem();
            pretražiUčenikaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            kreirajGrupuUčenikaToolStripMenuItem = new ToolStripMenuItem();
            pretražiGrupuUčenikaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            sertifiakatiToolStripMenuItem = new ToolStripMenuItem();
            radSaSertifikatimaToolStripMenuItem = new ToolStripMenuItem();
            kurseviToolStripMenuItem = new ToolStripMenuItem();
            radSaKursevimaToolStripMenuItem = new ToolStripMenuItem();
            stavkeEvidencijeNastaveToolStripMenuItem = new ToolStripMenuItem();
            pretraziToolStripMenuItem = new ToolStripMenuItem();
            panel = new Panel();
            licenceToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 42);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(1300, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(32, 32);
            menuStrip2.Items.AddRange(new ToolStripItem[] { učiteljToolStripMenuItem, evidencijaNastaveToolStripMenuItem, učeniciToolStripMenuItem, toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, sertifiakatiToolStripMenuItem, kurseviToolStripMenuItem, stavkeEvidencijeNastaveToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1300, 42);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            menuStrip2.ItemClicked += menuStrip2_ItemClicked;
            // 
            // učiteljToolStripMenuItem
            // 
            učiteljToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { prikažiUčiteljaToolStripMenuItem, kreirajUčiteljaToolStripMenuItem, pretražiUčiteljaToolStripMenuItem, licenceToolStripMenuItem });
            učiteljToolStripMenuItem.Name = "učiteljToolStripMenuItem";
            učiteljToolStripMenuItem.Size = new Size(100, 38);
            učiteljToolStripMenuItem.Text = "Učitelj";
            // 
            // prikažiUčiteljaToolStripMenuItem
            // 
            prikažiUčiteljaToolStripMenuItem.Name = "prikažiUčiteljaToolStripMenuItem";
            prikažiUčiteljaToolStripMenuItem.Size = new Size(309, 44);
            prikažiUčiteljaToolStripMenuItem.Text = "Prikaži učitelja";
            prikažiUčiteljaToolStripMenuItem.Click += prikažiUčiteljaToolStripMenuItem_Click;
            // 
            // kreirajUčiteljaToolStripMenuItem
            // 
            kreirajUčiteljaToolStripMenuItem.Name = "kreirajUčiteljaToolStripMenuItem";
            kreirajUčiteljaToolStripMenuItem.Size = new Size(309, 44);
            kreirajUčiteljaToolStripMenuItem.Text = "Kreiraj učitelja";
            kreirajUčiteljaToolStripMenuItem.Click += kreirajUčiteljaToolStripMenuItem_Click;
            // 
            // pretražiUčiteljaToolStripMenuItem
            // 
            pretražiUčiteljaToolStripMenuItem.Name = "pretražiUčiteljaToolStripMenuItem";
            pretražiUčiteljaToolStripMenuItem.Size = new Size(309, 44);
            pretražiUčiteljaToolStripMenuItem.Text = "Pretraži učitelja";
            pretražiUčiteljaToolStripMenuItem.Click += pretražiUčiteljaToolStripMenuItem_Click;
            // 
            // evidencijaNastaveToolStripMenuItem
            // 
            evidencijaNastaveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kreiranjeEvidencijanNastaveToolStripMenuItem, pretražiEvidencijuNastaveToolStripMenuItem });
            evidencijaNastaveToolStripMenuItem.Name = "evidencijaNastaveToolStripMenuItem";
            evidencijaNastaveToolStripMenuItem.Size = new Size(228, 38);
            evidencijaNastaveToolStripMenuItem.Text = "Evidencija nastave";
            // 
            // kreiranjeEvidencijanNastaveToolStripMenuItem
            // 
            kreiranjeEvidencijanNastaveToolStripMenuItem.Name = "kreiranjeEvidencijanNastaveToolStripMenuItem";
            kreiranjeEvidencijanNastaveToolStripMenuItem.Size = new Size(444, 44);
            kreiranjeEvidencijanNastaveToolStripMenuItem.Text = "Kreiranje evidencije nastave";
            kreiranjeEvidencijanNastaveToolStripMenuItem.Click += kreiranjeEvidencijanNastaveToolStripMenuItem_Click;
            // 
            // pretražiEvidencijuNastaveToolStripMenuItem
            // 
            pretražiEvidencijuNastaveToolStripMenuItem.Name = "pretražiEvidencijuNastaveToolStripMenuItem";
            pretražiEvidencijuNastaveToolStripMenuItem.Size = new Size(444, 44);
            pretražiEvidencijuNastaveToolStripMenuItem.Text = "Pretraži evidenciju nastave";
            pretražiEvidencijuNastaveToolStripMenuItem.Click += pretražiEvidencijuNastaveToolStripMenuItem_Click;
            // 
            // učeniciToolStripMenuItem
            // 
            učeniciToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kreirajUčenikaToolStripMenuItem, pretražiUčenikaToolStripMenuItem });
            učeniciToolStripMenuItem.Name = "učeniciToolStripMenuItem";
            učeniciToolStripMenuItem.Size = new Size(111, 38);
            učeniciToolStripMenuItem.Text = "Učenici";
            // 
            // kreirajUčenikaToolStripMenuItem
            // 
            kreirajUčenikaToolStripMenuItem.Name = "kreirajUčenikaToolStripMenuItem";
            kreirajUčenikaToolStripMenuItem.Size = new Size(315, 44);
            kreirajUčenikaToolStripMenuItem.Text = "Kreiraj učenika";
            kreirajUčenikaToolStripMenuItem.Click += kreirajUčenikaToolStripMenuItem_Click;
            // 
            // pretražiUčenikaToolStripMenuItem
            // 
            pretražiUčenikaToolStripMenuItem.Name = "pretražiUčenikaToolStripMenuItem";
            pretražiUčenikaToolStripMenuItem.Size = new Size(315, 44);
            pretražiUčenikaToolStripMenuItem.Text = "Pretraži učenika";
            pretražiUčenikaToolStripMenuItem.Click += pretražiUčenikaToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(20, 38);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { kreirajGrupuUčenikaToolStripMenuItem, pretražiGrupuUčenikaToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(188, 38);
            toolStripMenuItem2.Text = "Grupe učenika";
            // 
            // kreirajGrupuUčenikaToolStripMenuItem
            // 
            kreirajGrupuUčenikaToolStripMenuItem.Name = "kreirajGrupuUčenikaToolStripMenuItem";
            kreirajGrupuUčenikaToolStripMenuItem.Size = new Size(386, 44);
            kreirajGrupuUčenikaToolStripMenuItem.Text = "Kreiraj grupu učenika";
            kreirajGrupuUčenikaToolStripMenuItem.Click += kreirajGrupuUčenikaToolStripMenuItem_Click;
            // 
            // pretražiGrupuUčenikaToolStripMenuItem
            // 
            pretražiGrupuUčenikaToolStripMenuItem.Name = "pretražiGrupuUčenikaToolStripMenuItem";
            pretražiGrupuUčenikaToolStripMenuItem.Size = new Size(386, 44);
            pretražiGrupuUčenikaToolStripMenuItem.Text = "Pretraži grupu učenika";
            pretražiGrupuUčenikaToolStripMenuItem.Click += pretražiGrupuUčenikaToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(20, 38);
            // 
            // sertifiakatiToolStripMenuItem
            // 
            sertifiakatiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { radSaSertifikatimaToolStripMenuItem });
            sertifiakatiToolStripMenuItem.Name = "sertifiakatiToolStripMenuItem";
            sertifiakatiToolStripMenuItem.Size = new Size(146, 38);
            sertifiakatiToolStripMenuItem.Text = "Sertifiakati";
            // 
            // radSaSertifikatimaToolStripMenuItem
            // 
            radSaSertifikatimaToolStripMenuItem.Name = "radSaSertifikatimaToolStripMenuItem";
            radSaSertifikatimaToolStripMenuItem.Size = new Size(353, 44);
            radSaSertifikatimaToolStripMenuItem.Text = "Rad sa sertifikatima";
            radSaSertifikatimaToolStripMenuItem.Click += radSaSertifikatimaToolStripMenuItem_Click;
            // 
            // kurseviToolStripMenuItem
            // 
            kurseviToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { radSaKursevimaToolStripMenuItem });
            kurseviToolStripMenuItem.Name = "kurseviToolStripMenuItem";
            kurseviToolStripMenuItem.Size = new Size(111, 38);
            kurseviToolStripMenuItem.Text = "Kursevi";
            kurseviToolStripMenuItem.Click += kurseviToolStripMenuItem_Click;
            // 
            // radSaKursevimaToolStripMenuItem
            // 
            radSaKursevimaToolStripMenuItem.Name = "radSaKursevimaToolStripMenuItem";
            radSaKursevimaToolStripMenuItem.Size = new Size(331, 44);
            radSaKursevimaToolStripMenuItem.Text = "Rad sa kursevima";
            radSaKursevimaToolStripMenuItem.Click += radSaKursevimaToolStripMenuItem_Click;
            // 
            // stavkeEvidencijeNastaveToolStripMenuItem
            // 
            stavkeEvidencijeNastaveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pretraziToolStripMenuItem });
            stavkeEvidencijeNastaveToolStripMenuItem.Name = "stavkeEvidencijeNastaveToolStripMenuItem";
            stavkeEvidencijeNastaveToolStripMenuItem.Size = new Size(306, 38);
            stavkeEvidencijeNastaveToolStripMenuItem.Text = "Stavke evidencije nastave";
            stavkeEvidencijeNastaveToolStripMenuItem.Click += stavkeEvidencijeNastaveToolStripMenuItem_Click;
            // 
            // pretraziToolStripMenuItem
            // 
            pretraziToolStripMenuItem.Name = "pretraziToolStripMenuItem";
            pretraziToolStripMenuItem.Size = new Size(359, 44);
            pretraziToolStripMenuItem.Text = "Pretrazi";
            pretraziToolStripMenuItem.Click += pretraziToolStripMenuItem_Click;
            // 
            // panel
            // 
            panel.Location = new Point(0, 80);
            panel.Name = "panel";
            panel.Size = new Size(1300, 640);
            panel.TabIndex = 2;
            // 
            // licenceToolStripMenuItem
            // 
            licenceToolStripMenuItem.Name = "licenceToolStripMenuItem";
            licenceToolStripMenuItem.Size = new Size(359, 44);
            licenceToolStripMenuItem.Text = "Licence";
            licenceToolStripMenuItem.Click += licenceToolStripMenuItem_Click;
            // 
            // Glavna
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(panel);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "Glavna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Softverski sistem za praćenje nastave";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem učiteljToolStripMenuItem;
        private ToolStripMenuItem prikažiUčiteljaToolStripMenuItem;
        private ToolStripMenuItem evidencijaNastaveToolStripMenuItem;
        private ToolStripMenuItem učeniciToolStripMenuItem;
        private Panel panel;
        private ToolStripMenuItem prikazEvidencijanNastaveToolStripMenuItem;
        private ToolStripMenuItem kreiranjeEvidencijanNastaveToolStripMenuItem;
        private ToolStripMenuItem pretražiEvidencijuNastaveToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem kreirajGrupuUčenikaToolStripMenuItem;
        private ToolStripMenuItem pretražiGrupuUčenikaToolStripMenuItem;
        private ToolStripMenuItem kreirajUčiteljaToolStripMenuItem;
        private ToolStripMenuItem pretražiUčiteljaToolStripMenuItem;
        private ToolStripMenuItem kreirajUčenikaToolStripMenuItem;
        private ToolStripMenuItem pretražiUčenikaToolStripMenuItem;
        private ToolStripMenuItem sertifiakatiToolStripMenuItem;
        private ToolStripMenuItem radSaSertifikatimaToolStripMenuItem;
        private ToolStripMenuItem kurseviToolStripMenuItem;
        private ToolStripMenuItem radSaKursevimaToolStripMenuItem;
        private ToolStripMenuItem stavkeEvidencijeNastaveToolStripMenuItem;
        private ToolStripMenuItem pretraziToolStripMenuItem;
        private ToolStripMenuItem licenceToolStripMenuItem;
    }
}
