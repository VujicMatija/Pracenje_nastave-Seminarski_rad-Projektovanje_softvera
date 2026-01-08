namespace Forme.User_controlers
{
    partial class UCradSaKursom
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
            label5 = new Label();
            txtNaziv = new TextBox();
            cbTezina = new ComboBox();
            cbUzrast = new ComboBox();
            numTrajanje = new NumericUpDown();
            label6 = new Label();
            txtOznaka = new TextBox();
            btnKreiraj = new Button();
            dgvPodaci = new DataGridView();
            btnPretrazi = new Button();
            btnPrikazi = new Button();
            btnOmoguciIzmene = new Button();
            btnIzmeni = new Button();
            ((System.ComponentModel.ISupportInitialize)numTrajanje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 68);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Naziv kursa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 120);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "Tezina kurs";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 169);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "Uzrast kursa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 216);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 3;
            label4.Text = "Trajanje kursa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 261);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 4;
            label5.Text = "Oznaka kursa";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(193, 68);
            txtNaziv.Margin = new Padding(2, 2, 2, 2);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(192, 27);
            txtNaziv.TabIndex = 5;
            // 
            // cbTezina
            // 
            cbTezina.FormattingEnabled = true;
            cbTezina.Location = new Point(193, 120);
            cbTezina.Margin = new Padding(2, 2, 2, 2);
            cbTezina.Name = "cbTezina";
            cbTezina.Size = new Size(189, 28);
            cbTezina.TabIndex = 6;
            // 
            // cbUzrast
            // 
            cbUzrast.FormattingEnabled = true;
            cbUzrast.Location = new Point(193, 169);
            cbUzrast.Margin = new Padding(2, 2, 2, 2);
            cbUzrast.Name = "cbUzrast";
            cbUzrast.Size = new Size(189, 28);
            cbUzrast.TabIndex = 7;
            // 
            // numTrajanje
            // 
            numTrajanje.Location = new Point(193, 216);
            numTrajanje.Margin = new Padding(2, 2, 2, 2);
            numTrajanje.Name = "numTrajanje";
            numTrajanje.Size = new Size(102, 27);
            numTrajanje.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(304, 218);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 9;
            label6.Text = "termina";
            // 
            // txtOznaka
            // 
            txtOznaka.Location = new Point(193, 259);
            txtOznaka.Margin = new Padding(2, 2, 2, 2);
            txtOznaka.Name = "txtOznaka";
            txtOznaka.Size = new Size(189, 27);
            txtOznaka.TabIndex = 10;
            // 
            // btnKreiraj
            // 
            btnKreiraj.Location = new Point(186, 300);
            btnKreiraj.Margin = new Padding(2, 2, 2, 2);
            btnKreiraj.Name = "btnKreiraj";
            btnKreiraj.Size = new Size(123, 56);
            btnKreiraj.TabIndex = 11;
            btnKreiraj.Text = "Kreiraj kurs";
            btnKreiraj.UseVisualStyleBackColor = true;
            btnKreiraj.Click += btnKreiraj_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Location = new Point(420, 120);
            dgvPodaci.Margin = new Padding(2, 2, 2, 2);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.RowHeadersWidth = 82;
            dgvPodaci.Size = new Size(306, 164);
            dgvPodaci.TabIndex = 12;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(420, 61);
            btnPretrazi.Margin = new Padding(2, 2, 2, 2);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(191, 33);
            btnPretrazi.TabIndex = 13;
            btnPretrazi.Text = "Pretraži kurs po nazivu ";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // btnPrikazi
            // 
            btnPrikazi.Location = new Point(420, 300);
            btnPrikazi.Margin = new Padding(2, 2, 2, 2);
            btnPrikazi.Name = "btnPrikazi";
            btnPrikazi.Size = new Size(162, 56);
            btnPrikazi.TabIndex = 14;
            btnPrikazi.Text = "Prikazi izabrani kurs";
            btnPrikazi.UseVisualStyleBackColor = true;
            btnPrikazi.Click += button1_Click;
            // 
            // btnOmoguciIzmene
            // 
            btnOmoguciIzmene.Location = new Point(186, 300);
            btnOmoguciIzmene.Margin = new Padding(2, 2, 2, 2);
            btnOmoguciIzmene.Name = "btnOmoguciIzmene";
            btnOmoguciIzmene.Size = new Size(123, 56);
            btnOmoguciIzmene.TabIndex = 15;
            btnOmoguciIzmene.Text = "Omoguci izmene";
            btnOmoguciIzmene.UseVisualStyleBackColor = true;
            btnOmoguciIzmene.Visible = false;
            btnOmoguciIzmene.Click += btnOmoguciIzmene_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(186, 300);
            btnIzmeni.Margin = new Padding(2, 2, 2, 2);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(123, 56);
            btnIzmeni.TabIndex = 16;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Visible = false;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // UCradSaKursom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnIzmeni);
            Controls.Add(btnOmoguciIzmene);
            Controls.Add(btnPrikazi);
            Controls.Add(btnPretrazi);
            Controls.Add(dgvPodaci);
            Controls.Add(btnKreiraj);
            Controls.Add(txtOznaka);
            Controls.Add(label6);
            Controls.Add(numTrajanje);
            Controls.Add(cbUzrast);
            Controls.Add(cbTezina);
            Controls.Add(txtNaziv);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UCradSaKursom";
            Size = new Size(800, 400);
            Load += UCradSaKursom_Load;
            ((System.ComponentModel.ISupportInitialize)numTrajanje).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNaziv;
        private ComboBox cbTezina;
        private ComboBox cbUzrast;
        private NumericUpDown numTrajanje;
        private Label label6;
        private TextBox txtOznaka;
        private Button btnKreiraj;
        private DataGridView dgvPodaci;
        private Button btnPretrazi;
        private Button btnPrikazi;
        private Button btnOmoguciIzmene;
        private Button btnIzmeni;
    }
}
