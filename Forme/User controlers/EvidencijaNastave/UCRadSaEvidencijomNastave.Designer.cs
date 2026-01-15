namespace Forme.User_controlers
{
    partial class UCRadSaEvidencijomNastave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRadSaEvidencijomNastave));
            pictureBox1 = new PictureBox();
            chAktivna = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            datePocetakRada = new DateTimePicker();
            cbGrupa = new ComboBox();
            cbUcitelj = new ComboBox();
            btnKreiraj = new Button();
            dgvStavke = new DataGridView();
            label4 = new Label();
            cbUcenici = new ComboBox();
            label5 = new Label();
            cbRBCasa = new ComboBox();
            chPrisustvo = new CheckBox();
            chDomaci = new CheckBox();
            label6 = new Label();
            dateDatumStavke = new DateTimePicker();
            btnDodajStavku = new Button();
            txtKomentar = new RichTextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(583, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // chAktivna
            // 
            chAktivna.AutoSize = true;
            chAktivna.Checked = true;
            chAktivna.CheckState = CheckState.Checked;
            chAktivna.Location = new Point(221, 240);
            chAktivna.Name = "chAktivna";
            chAktivna.Size = new Size(198, 24);
            chAktivna.TabIndex = 24;
            chAktivna.Text = "Grupa je trenutno aktivna";
            chAktivna.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 193);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 23;
            label3.Text = "Početak rada: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 149);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 22;
            label2.Text = "Odaberite grupu: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 105);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 21;
            label1.Text = "Odaberite učitelja:";
            // 
            // datePocetakRada
            // 
            datePocetakRada.Format = DateTimePickerFormat.Short;
            datePocetakRada.Location = new Point(221, 193);
            datePocetakRada.MaxDate = new DateTime(2026, 1, 14, 0, 0, 0, 0);
            datePocetakRada.Name = "datePocetakRada";
            datePocetakRada.Size = new Size(245, 27);
            datePocetakRada.TabIndex = 20;
            datePocetakRada.Value = new DateTime(2026, 1, 9, 0, 0, 0, 0);
            // 
            // cbGrupa
            // 
            cbGrupa.FormattingEnabled = true;
            cbGrupa.Location = new Point(221, 149);
            cbGrupa.Name = "cbGrupa";
            cbGrupa.Size = new Size(245, 28);
            cbGrupa.TabIndex = 19;
            cbGrupa.DropDown += cbGrupa_DropDown;
            cbGrupa.SelectedIndexChanged += cbGrupa_SelectedIndexChanged;
            cbGrupa.SelectionChangeCommitted += cbGrupa_SelectionChangeCommitted;
            // 
            // cbUcitelj
            // 
            cbUcitelj.FormattingEnabled = true;
            cbUcitelj.Location = new Point(221, 102);
            cbUcitelj.Name = "cbUcitelj";
            cbUcitelj.Size = new Size(245, 28);
            cbUcitelj.TabIndex = 18;
            // 
            // btnKreiraj
            // 
            btnKreiraj.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnKreiraj.Location = new Point(285, 791);
            btnKreiraj.Name = "btnKreiraj";
            btnKreiraj.Size = new Size(390, 58);
            btnKreiraj.TabIndex = 27;
            btnKreiraj.Text = "Kreiraj evidenciju nastave";
            btnKreiraj.UseVisualStyleBackColor = true;
            btnKreiraj.Click += btnKreiraj_Click;
            // 
            // dgvStavke
            // 
            dgvStavke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStavke.Location = new Point(348, 335);
            dgvStavke.Name = "dgvStavke";
            dgvStavke.RowHeadersWidth = 51;
            dgvStavke.Size = new Size(634, 421);
            dgvStavke.TabIndex = 28;
            dgvStavke.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 338);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 29;
            label4.Text = "Učenik:";
            // 
            // cbUcenici
            // 
            cbUcenici.FormattingEnabled = true;
            cbUcenici.Location = new Point(149, 335);
            cbUcenici.Name = "cbUcenici";
            cbUcenici.Size = new Size(183, 28);
            cbUcenici.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 380);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 31;
            label5.Text = "Redni broj časa:";
            // 
            // cbRBCasa
            // 
            cbRBCasa.FormattingEnabled = true;
            cbRBCasa.Location = new Point(149, 377);
            cbRBCasa.Name = "cbRBCasa";
            cbRBCasa.Size = new Size(183, 28);
            cbRBCasa.TabIndex = 32;
            // 
            // chPrisustvo
            // 
            chPrisustvo.AutoSize = true;
            chPrisustvo.Location = new Point(149, 420);
            chPrisustvo.Name = "chPrisustvo";
            chPrisustvo.Size = new Size(149, 24);
            chPrisustvo.TabIndex = 33;
            chPrisustvo.Text = "Prisustvo na času?";
            chPrisustvo.UseVisualStyleBackColor = true;
            // 
            // chDomaci
            // 
            chDomaci.AutoSize = true;
            chDomaci.Location = new Point(149, 453);
            chDomaci.Name = "chDomaci";
            chDomaci.Size = new Size(140, 24);
            chDomaci.TabIndex = 34;
            chDomaci.Text = "Urađen domaći?";
            chDomaci.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(85, 494);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 35;
            label6.Text = "Datum:";
            // 
            // dateDatumStavke
            // 
            dateDatumStavke.CustomFormat = "dd/MM/yyyy";
            dateDatumStavke.Format = DateTimePickerFormat.Custom;
            dateDatumStavke.Location = new Point(149, 494);
            dateDatumStavke.MaxDate = new DateTime(2026, 1, 14, 0, 0, 0, 0);
            dateDatumStavke.Name = "dateDatumStavke";
            dateDatumStavke.Size = new Size(183, 27);
            dateDatumStavke.TabIndex = 36;
            dateDatumStavke.Value = new DateTime(2026, 1, 14, 0, 0, 0, 0);
            // 
            // btnDodajStavku
            // 
            btnDodajStavku.Location = new Point(149, 715);
            btnDodajStavku.Name = "btnDodajStavku";
            btnDodajStavku.Size = new Size(183, 41);
            btnDodajStavku.TabIndex = 37;
            btnDodajStavku.Text = "Dodaj stavku evidencije";
            btnDodajStavku.UseVisualStyleBackColor = true;
            btnDodajStavku.Click += btnDodajStavku_Click;
            // 
            // txtKomentar
            // 
            txtKomentar.Location = new Point(44, 589);
            txtKomentar.Name = "txtKomentar";
            txtKomentar.Size = new Size(288, 120);
            txtKomentar.TabIndex = 38;
            txtKomentar.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 556);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 39;
            label7.Text = "Komentar";
            // 
            // UCRadSaEvidencijomNastave
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(txtKomentar);
            Controls.Add(btnDodajStavku);
            Controls.Add(dateDatumStavke);
            Controls.Add(label6);
            Controls.Add(chDomaci);
            Controls.Add(chPrisustvo);
            Controls.Add(cbRBCasa);
            Controls.Add(label5);
            Controls.Add(cbUcenici);
            Controls.Add(label4);
            Controls.Add(dgvStavke);
            Controls.Add(btnKreiraj);
            Controls.Add(pictureBox1);
            Controls.Add(chAktivna);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(datePocetakRada);
            Controls.Add(cbGrupa);
            Controls.Add(cbUcitelj);
            Name = "UCRadSaEvidencijomNastave";
            Size = new Size(1000, 880);
            Load += UCRadSaEvidencijomNastave_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private CheckBox chAktivna;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker datePocetakRada;
        private ComboBox cbGrupa;
        private ComboBox cbUcitelj;
        private Button btnKreiraj;
        private DataGridView dgvStavke;
        private Label label4;
        private ComboBox cbUcenici;
        private Label label5;
        private ComboBox cbRBCasa;
        private CheckBox chPrisustvo;
        private CheckBox chDomaci;
        private Label label6;
        private DateTimePicker dateDatumStavke;
        private Button btnDodajStavku;
        private RichTextBox txtKomentar;
        private Label label7;
    }
}
