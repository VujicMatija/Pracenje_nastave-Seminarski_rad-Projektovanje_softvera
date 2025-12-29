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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtOznaka = new TextBox();
            cbKursevi = new ComboBox();
            cbDani = new ComboBox();
            cbSati = new ComboBox();
            numBrojUcenika = new NumericUpDown();
            btnKreiraj = new Button();
            btnIzmeni = new Button();
            btnHint = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnOmoguciIzmene = new Button();
            txtTermin = new TextBox();
            btnObrisi = new Button();
            ((System.ComponentModel.ISupportInitialize)numBrojUcenika).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 86);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Oznaka grupe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 124);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 1;
            label2.Text = "Kurs";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 164);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Termin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 196);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 3;
            label4.Text = "Broj učenika";
            label4.Click += label4_Click;
            // 
            // txtOznaka
            // 
            txtOznaka.Enabled = false;
            txtOznaka.Location = new Point(207, 84);
            txtOznaka.Margin = new Padding(2);
            txtOznaka.Name = "txtOznaka";
            txtOznaka.Size = new Size(255, 27);
            txtOznaka.TabIndex = 4;
            txtOznaka.Text = "Oznaka se sama generiše nakon odabira termina i grupe";
            // 
            // cbKursevi
            // 
            cbKursevi.FormattingEnabled = true;
            cbKursevi.Location = new Point(207, 122);
            cbKursevi.Margin = new Padding(2);
            cbKursevi.Name = "cbKursevi";
            cbKursevi.Size = new Size(255, 28);
            cbKursevi.TabIndex = 5;
            cbKursevi.SelectedIndexChanged += cbKursevi_SelectedIndexChanged;
            // 
            // cbDani
            // 
            cbDani.FormattingEnabled = true;
            cbDani.Location = new Point(207, 159);
            cbDani.Margin = new Padding(2);
            cbDani.Name = "cbDani";
            cbDani.Size = new Size(105, 28);
            cbDani.TabIndex = 6;
            cbDani.SelectedIndexChanged += cbDani_SelectedIndexChanged;
            // 
            // cbSati
            // 
            cbSati.FormattingEnabled = true;
            cbSati.Location = new Point(321, 159);
            cbSati.Margin = new Padding(2);
            cbSati.Name = "cbSati";
            cbSati.Size = new Size(105, 28);
            cbSati.TabIndex = 7;
            cbSati.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // numBrojUcenika
            // 
            numBrojUcenika.Location = new Point(207, 194);
            numBrojUcenika.Margin = new Padding(2);
            numBrojUcenika.Name = "numBrojUcenika";
            numBrojUcenika.Size = new Size(148, 27);
            numBrojUcenika.TabIndex = 8;
            // 
            // btnKreiraj
            // 
            btnKreiraj.Location = new Point(99, 236);
            btnKreiraj.Margin = new Padding(2);
            btnKreiraj.Name = "btnKreiraj";
            btnKreiraj.Size = new Size(133, 67);
            btnKreiraj.TabIndex = 9;
            btnKreiraj.Text = "Kreiraj grupu učenika";
            btnKreiraj.UseVisualStyleBackColor = true;
            btnKreiraj.Click += btnKreiraj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(236, 236);
            btnIzmeni.Margin = new Padding(2);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(132, 67);
            btnIzmeni.TabIndex = 10;
            btnIzmeni.Text = "Izmeni grupu učenika";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Visible = false;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnHint
            // 
            btnHint.Location = new Point(428, 158);
            btnHint.Margin = new Padding(2);
            btnHint.Name = "btnHint";
            btnHint.Size = new Size(33, 25);
            btnHint.TabIndex = 11;
            btnHint.Text = "?";
            btnHint.UseVisualStyleBackColor = true;
            // 
            // btnOmoguciIzmene
            // 
            btnOmoguciIzmene.Location = new Point(373, 236);
            btnOmoguciIzmene.Name = "btnOmoguciIzmene";
            btnOmoguciIzmene.Size = new Size(94, 67);
            btnOmoguciIzmene.TabIndex = 12;
            btnOmoguciIzmene.Text = "Omogući izmene";
            btnOmoguciIzmene.UseVisualStyleBackColor = true;
            btnOmoguciIzmene.Visible = false;
            btnOmoguciIzmene.Click += btnOmoguciIzmene_Click;
            // 
            // txtTermin
            // 
            txtTermin.Location = new Point(207, 159);
            txtTermin.Name = "txtTermin";
            txtTermin.Size = new Size(219, 27);
            txtTermin.TabIndex = 13;
            txtTermin.Visible = false;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(373, 309);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(94, 62);
            btnObrisi.TabIndex = 14;
            btnObrisi.Text = "Obriši grupu";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // UCKreirajGrupuUčenika
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTermin);
            Margin = new Padding(2);
            Name = "UCKreirajGrupuUčenika";
            Size = new Size(559, 398);
            ((System.ComponentModel.ISupportInitialize)numBrojUcenika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtOznaka;
        private ComboBox cbKursevi;
        private ComboBox cbDani;
        private ComboBox cbSati;
        private NumericUpDown numBrojUcenika;
        private Button btnKreiraj;
        private Button btnIzmeni;
        private Button btnHint;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnOmoguciIzmene;
        private TextBox txtTermin;
        private Button btnObrisi;
    }
}
