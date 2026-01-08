namespace Forme.User_controlers
{
    partial class UCKreirajGrupuUčenika
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCKreirajGrupuUčenika));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblBrojUcenika = new Label();
            txtOznaka = new TextBox();
            cbKursevi = new ComboBox();
            cbDani = new ComboBox();
            cbSati = new ComboBox();
            numBrojUcenika = new NumericUpDown();
            btnKreiraj = new Button();
            btnIzmeni = new Button();
            btnHint = new Button();
            btnOmoguciIzmene = new Button();
            txtTermin = new TextBox();
            btnObrisi = new Button();
            dgvUcenici = new DataGridView();
            lblUcenici = new Label();
            btnDodajUcenika = new Button();
            slika = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numBrojUcenika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUcenici).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slika).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 61);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Oznaka grupe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 104);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 1;
            label2.Text = "Kurs";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 158);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Termin";
            // 
            // lblBrojUcenika
            // 
            lblBrojUcenika.AutoSize = true;
            lblBrojUcenika.Location = new Point(36, 202);
            lblBrojUcenika.Margin = new Padding(2, 0, 2, 0);
            lblBrojUcenika.Name = "lblBrojUcenika";
            lblBrojUcenika.Size = new Size(90, 20);
            lblBrojUcenika.TabIndex = 3;
            lblBrojUcenika.Text = "Broj učenika";
            lblBrojUcenika.Click += label4_Click;
            // 
            // txtOznaka
            // 
            txtOznaka.Enabled = false;
            txtOznaka.Location = new Point(143, 58);
            txtOznaka.Margin = new Padding(2);
            txtOznaka.Name = "txtOznaka";
            txtOznaka.Size = new Size(255, 27);
            txtOznaka.TabIndex = 4;
            txtOznaka.Text = "Oznaka se sama generiše nakon odabira termina i grupe";
            // 
            // cbKursevi
            // 
            cbKursevi.FormattingEnabled = true;
            cbKursevi.Location = new Point(143, 102);
            cbKursevi.Margin = new Padding(2);
            cbKursevi.Name = "cbKursevi";
            cbKursevi.Size = new Size(255, 28);
            cbKursevi.TabIndex = 5;
            cbKursevi.SelectedIndexChanged += cbKursevi_SelectedIndexChanged;
            // 
            // cbDani
            // 
            cbDani.FormattingEnabled = true;
            cbDani.Location = new Point(143, 152);
            cbDani.Margin = new Padding(2);
            cbDani.Name = "cbDani";
            cbDani.Size = new Size(126, 28);
            cbDani.TabIndex = 6;
            cbDani.SelectedIndexChanged += cbDani_SelectedIndexChanged;
            // 
            // cbSati
            // 
            cbSati.FormattingEnabled = true;
            cbSati.Location = new Point(271, 152);
            cbSati.Margin = new Padding(2);
            cbSati.Name = "cbSati";
            cbSati.Size = new Size(91, 28);
            cbSati.TabIndex = 7;
            cbSati.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // numBrojUcenika
            // 
            numBrojUcenika.Location = new Point(143, 200);
            numBrojUcenika.Margin = new Padding(2);
            numBrojUcenika.Name = "numBrojUcenika";
            numBrojUcenika.Size = new Size(148, 27);
            numBrojUcenika.TabIndex = 8;
            // 
            // btnKreiraj
            // 
            btnKreiraj.Location = new Point(45, 269);
            btnKreiraj.Margin = new Padding(2);
            btnKreiraj.Name = "btnKreiraj";
            btnKreiraj.Size = new Size(137, 76);
            btnKreiraj.TabIndex = 9;
            btnKreiraj.Text = "Kreiraj grupu učenika";
            btnKreiraj.UseVisualStyleBackColor = true;
            btnKreiraj.Click += btnKreiraj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(45, 269);
            btnIzmeni.Margin = new Padding(2);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(135, 76);
            btnIzmeni.TabIndex = 10;
            btnIzmeni.Text = "Izmeni grupu učenika";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Visible = false;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnHint
            // 
            btnHint.Location = new Point(365, 152);
            btnHint.Margin = new Padding(2);
            btnHint.Name = "btnHint";
            btnHint.Size = new Size(33, 25);
            btnHint.TabIndex = 11;
            btnHint.Text = "?";
            btnHint.UseVisualStyleBackColor = true;
            // 
            // btnOmoguciIzmene
            // 
            btnOmoguciIzmene.Location = new Point(40, 269);
            btnOmoguciIzmene.Name = "btnOmoguciIzmene";
            btnOmoguciIzmene.Size = new Size(142, 76);
            btnOmoguciIzmene.TabIndex = 12;
            btnOmoguciIzmene.Text = "Omogući izmene";
            btnOmoguciIzmene.UseVisualStyleBackColor = true;
            btnOmoguciIzmene.Visible = false;
            btnOmoguciIzmene.Click += btnOmoguciIzmene_Click;
            // 
            // txtTermin
            // 
            txtTermin.Location = new Point(143, 152);
            txtTermin.Name = "txtTermin";
            txtTermin.Size = new Size(219, 27);
            txtTermin.TabIndex = 13;
            txtTermin.Visible = false;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(198, 269);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(142, 76);
            btnObrisi.TabIndex = 14;
            btnObrisi.Text = "Obriši grupu";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // dgvUcenici
            // 
            dgvUcenici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUcenici.Location = new Point(444, 82);
            dgvUcenici.Margin = new Padding(2);
            dgvUcenici.Name = "dgvUcenici";
            dgvUcenici.RowHeadersWidth = 82;
            dgvUcenici.Size = new Size(329, 212);
            dgvUcenici.TabIndex = 15;
            // 
            // lblUcenici
            // 
            lblUcenici.AutoSize = true;
            lblUcenici.Location = new Point(444, 58);
            lblUcenici.Margin = new Padding(2, 0, 2, 0);
            lblUcenici.Name = "lblUcenici";
            lblUcenici.Size = new Size(57, 20);
            lblUcenici.TabIndex = 16;
            lblUcenici.Text = "Učenici";
            // 
            // btnDodajUcenika
            // 
            btnDodajUcenika.Location = new Point(535, 299);
            btnDodajUcenika.Margin = new Padding(2);
            btnDodajUcenika.Name = "btnDodajUcenika";
            btnDodajUcenika.Size = new Size(170, 46);
            btnDodajUcenika.TabIndex = 17;
            btnDodajUcenika.Text = "Dodaj učenika";
            btnDodajUcenika.UseVisualStyleBackColor = true;
            btnDodajUcenika.Click += btnDodajUcenika_Click;
            // 
            // slika
            // 
            slika.Image = (Image)resources.GetObject("slika.Image");
            slika.Location = new Point(403, 26);
            slika.Name = "slika";
            slika.Size = new Size(469, 319);
            slika.SizeMode = PictureBoxSizeMode.Zoom;
            slika.TabIndex = 18;
            slika.TabStop = false;
            // 
            // UCKreirajGrupuUčenika
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDodajUcenika);
            Controls.Add(lblUcenici);
            Controls.Add(dgvUcenici);
            Controls.Add(btnObrisi);
            Controls.Add(btnOmoguciIzmene);
            Controls.Add(btnHint);
            Controls.Add(btnIzmeni);
            Controls.Add(btnKreiraj);
            Controls.Add(numBrojUcenika);
            Controls.Add(cbSati);
            Controls.Add(cbDani);
            Controls.Add(cbKursevi);
            Controls.Add(txtOznaka);
            Controls.Add(lblBrojUcenika);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTermin);
            Controls.Add(slika);
            Margin = new Padding(2);
            Name = "UCKreirajGrupuUčenika";
            Size = new Size(800, 400);
            Load += UCKreirajGrupuUčenika_Load;
            ((System.ComponentModel.ISupportInitialize)numBrojUcenika).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUcenici).EndInit();
            ((System.ComponentModel.ISupportInitialize)slika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblBrojUcenika;
        private TextBox txtOznaka;
        private ComboBox cbKursevi;
        private ComboBox cbDani;
        private ComboBox cbSati;
        private NumericUpDown numBrojUcenika;
        private Button btnKreiraj;
        private Button btnIzmeni;
        private Button btnHint;
        private Button btnOmoguciIzmene;
        private TextBox txtTermin;
        private Button btnObrisi;
        private DataGridView dgvUcenici;
        private Label lblUcenici;
        private Button btnDodajUcenika;
        private PictureBox slika;
    }
}
