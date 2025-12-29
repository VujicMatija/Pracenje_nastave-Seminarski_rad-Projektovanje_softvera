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
            evidencijaNastaveToolStripMenuItem = new ToolStripMenuItem();
            kreiranjeEvidencijanNastaveToolStripMenuItem = new ToolStripMenuItem();
            promenaEvidencijeNastaveToolStripMenuItem = new ToolStripMenuItem();
            pretražiEvidencijuNastaveToolStripMenuItem = new ToolStripMenuItem();
            učeniciToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            kreirajGrupuUčenikaToolStripMenuItem = new ToolStripMenuItem();
            pretražiGrupuUčenikaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            panel = new Panel();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 26);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(32, 32);
            menuStrip2.Items.AddRange(new ToolStripItem[] { učiteljToolStripMenuItem, evidencijaNastaveToolStripMenuItem, učeniciToolStripMenuItem, toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(4, 1, 0, 1);
            menuStrip2.Size = new Size(800, 26);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // učiteljToolStripMenuItem
            // 
            učiteljToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { prikažiUčiteljaToolStripMenuItem });
            učiteljToolStripMenuItem.Name = "učiteljToolStripMenuItem";
            učiteljToolStripMenuItem.Size = new Size(65, 24);
            učiteljToolStripMenuItem.Text = "Učitelj";
            // 
            // prikažiUčiteljaToolStripMenuItem
            // 
            prikažiUčiteljaToolStripMenuItem.Name = "prikažiUčiteljaToolStripMenuItem";
            prikažiUčiteljaToolStripMenuItem.Size = new Size(187, 26);
            prikažiUčiteljaToolStripMenuItem.Text = "Prikaži učitelja";
            prikažiUčiteljaToolStripMenuItem.Click += prikažiUčiteljaToolStripMenuItem_Click;
            // 
            // evidencijaNastaveToolStripMenuItem
            // 
            evidencijaNastaveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kreiranjeEvidencijanNastaveToolStripMenuItem, promenaEvidencijeNastaveToolStripMenuItem, pretražiEvidencijuNastaveToolStripMenuItem });
            evidencijaNastaveToolStripMenuItem.Name = "evidencijaNastaveToolStripMenuItem";
            evidencijaNastaveToolStripMenuItem.Size = new Size(144, 24);
            evidencijaNastaveToolStripMenuItem.Text = "Evidencija nastave";
            // 
            // kreiranjeEvidencijanNastaveToolStripMenuItem
            // 
            kreiranjeEvidencijanNastaveToolStripMenuItem.Name = "kreiranjeEvidencijanNastaveToolStripMenuItem";
            kreiranjeEvidencijanNastaveToolStripMenuItem.Size = new Size(276, 26);
            kreiranjeEvidencijanNastaveToolStripMenuItem.Text = "Kreiranje evidencije nastave";
            kreiranjeEvidencijanNastaveToolStripMenuItem.Click += kreiranjeEvidencijanNastaveToolStripMenuItem_Click;
            // 
            // promenaEvidencijeNastaveToolStripMenuItem
            // 
            promenaEvidencijeNastaveToolStripMenuItem.Name = "promenaEvidencijeNastaveToolStripMenuItem";
            promenaEvidencijeNastaveToolStripMenuItem.Size = new Size(276, 26);
            promenaEvidencijeNastaveToolStripMenuItem.Text = "Promena evidencije nastave";
            // 
            // pretražiEvidencijuNastaveToolStripMenuItem
            // 
            pretražiEvidencijuNastaveToolStripMenuItem.Name = "pretražiEvidencijuNastaveToolStripMenuItem";
            pretražiEvidencijuNastaveToolStripMenuItem.Size = new Size(276, 26);
            pretražiEvidencijuNastaveToolStripMenuItem.Text = "Pretraži evidenciju nastave";
            pretražiEvidencijuNastaveToolStripMenuItem.Click += pretražiEvidencijuNastaveToolStripMenuItem_Click;
            // 
            // učeniciToolStripMenuItem
            // 
            učeniciToolStripMenuItem.Name = "učeniciToolStripMenuItem";
            učeniciToolStripMenuItem.Size = new Size(71, 24);
            učeniciToolStripMenuItem.Text = "Učenici";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 24);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { kreirajGrupuUčenikaToolStripMenuItem, pretražiGrupuUčenikaToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(117, 24);
            toolStripMenuItem2.Text = "Grupe učenika";
            // 
            // kreirajGrupuUčenikaToolStripMenuItem
            // 
            kreirajGrupuUčenikaToolStripMenuItem.Name = "kreirajGrupuUčenikaToolStripMenuItem";
            kreirajGrupuUčenikaToolStripMenuItem.Size = new Size(239, 26);
            kreirajGrupuUčenikaToolStripMenuItem.Text = "Kreiraj grupu učenika";
            kreirajGrupuUčenikaToolStripMenuItem.Click += kreirajGrupuUčenikaToolStripMenuItem_Click;
            // 
            // pretražiGrupuUčenikaToolStripMenuItem
            // 
            pretražiGrupuUčenikaToolStripMenuItem.Name = "pretražiGrupuUčenikaToolStripMenuItem";
            pretražiGrupuUčenikaToolStripMenuItem.Size = new Size(239, 26);
            pretražiGrupuUčenikaToolStripMenuItem.Text = "Pretraži grupu učenika";
            pretražiGrupuUčenikaToolStripMenuItem.Click += pretražiGrupuUčenikaToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(14, 24);
            // 
            // panel
            // 
            panel.Location = new Point(0, 50);
            panel.Margin = new Padding(2);
            panel.Name = "panel";
            panel.Size = new Size(800, 400);
            panel.TabIndex = 2;
            // 
            // Glavna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Glavna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Glavna";
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
        private ToolStripMenuItem promenaEvidencijeNastaveToolStripMenuItem;
        private ToolStripMenuItem pretražiEvidencijuNastaveToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem kreirajGrupuUčenikaToolStripMenuItem;
        private ToolStripMenuItem pretražiGrupuUčenikaToolStripMenuItem;
    }
}
