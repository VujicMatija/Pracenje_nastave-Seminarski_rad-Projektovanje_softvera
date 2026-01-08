namespace Forme.User_controlers
{
    partial class UCradSaStavkomEvidencijeNastave
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
            txtEvidencija = new TextBox();
            cbUcenik = new ComboBox();
            label2 = new Label();
            chPrisustvo = new CheckBox();
            chDomaci = new CheckBox();
            label3 = new Label();
            cbRedniBrojCasa = new ComboBox();
            label4 = new Label();
            dateDatum = new DateTimePicker();
            label5 = new Label();
            txtKomentar = new RichTextBox();
            btnDodaj = new Button();
            btnOmoguciIzmenu = new Button();
            btnPromeni = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 54);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 0;
            label1.Text = "Evidencija nastave";
            // 
            // txtEvidencija
            // 
            txtEvidencija.Location = new Point(143, 54);
            txtEvidencija.Margin = new Padding(2);
            txtEvidencija.Name = "txtEvidencija";
            txtEvidencija.Size = new Size(209, 27);
            txtEvidencija.TabIndex = 1;
            // 
            // cbUcenik
            // 
            cbUcenik.FormattingEnabled = true;
            cbUcenik.Location = new Point(143, 95);
            cbUcenik.Margin = new Padding(2);
            cbUcenik.Name = "cbUcenik";
            cbUcenik.Size = new Size(209, 28);
            cbUcenik.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 97);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 3;
            label2.Text = "Učenik";
            // 
            // chPrisustvo
            // 
            chPrisustvo.AutoSize = true;
            chPrisustvo.Location = new Point(143, 177);
            chPrisustvo.Margin = new Padding(2);
            chPrisustvo.Name = "chPrisustvo";
            chPrisustvo.RightToLeft = RightToLeft.No;
            chPrisustvo.Size = new Size(149, 24);
            chPrisustvo.TabIndex = 4;
            chPrisustvo.Text = "Prisustvo na času?";
            chPrisustvo.UseVisualStyleBackColor = true;
            // 
            // chDomaci
            // 
            chDomaci.AutoSize = true;
            chDomaci.Location = new Point(143, 212);
            chDomaci.Margin = new Padding(2);
            chDomaci.Name = "chDomaci";
            chDomaci.Size = new Size(140, 24);
            chDomaci.TabIndex = 5;
            chDomaci.Text = "Urađen domaći?";
            chDomaci.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 138);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 6;
            label3.Text = "Redni broj časa";
            // 
            // cbRedniBrojCasa
            // 
            cbRedniBrojCasa.FormattingEnabled = true;
            cbRedniBrojCasa.Location = new Point(143, 138);
            cbRedniBrojCasa.Margin = new Padding(2);
            cbRedniBrojCasa.Name = "cbRedniBrojCasa";
            cbRedniBrojCasa.Size = new Size(209, 28);
            cbRedniBrojCasa.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 256);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 8;
            label4.Text = "Datum";
            // 
            // dateDatum
            // 
            dateDatum.CustomFormat = "dd/MM/yyyy";
            dateDatum.Format = DateTimePickerFormat.Custom;
            dateDatum.Location = new Point(143, 256);
            dateDatum.Margin = new Padding(2);
            dateDatum.Name = "dateDatum";
            dateDatum.Size = new Size(209, 27);
            dateDatum.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(419, 46);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 10;
            label5.Text = "Komentar";
            // 
            // txtKomentar
            // 
            txtKomentar.Location = new Point(419, 74);
            txtKomentar.Margin = new Padding(2);
            txtKomentar.Name = "txtKomentar";
            txtKomentar.Size = new Size(329, 202);
            txtKomentar.TabIndex = 11;
            txtKomentar.Text = "";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(143, 315);
            btnDodaj.Margin = new Padding(2);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(118, 53);
            btnDodaj.TabIndex = 12;
            btnDodaj.Text = "Dodaj stavku";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnOmoguciIzmenu
            // 
            btnOmoguciIzmenu.Location = new Point(143, 316);
            btnOmoguciIzmenu.Margin = new Padding(2);
            btnOmoguciIzmenu.Name = "btnOmoguciIzmenu";
            btnOmoguciIzmenu.Size = new Size(118, 51);
            btnOmoguciIzmenu.TabIndex = 13;
            btnOmoguciIzmenu.Text = "Omoguci izmenu";
            btnOmoguciIzmenu.UseVisualStyleBackColor = true;
            btnOmoguciIzmenu.Visible = false;
            btnOmoguciIzmenu.Click += btnOmoguciIzmenu_Click;
            // 
            // btnPromeni
            // 
            btnPromeni.Location = new Point(143, 315);
            btnPromeni.Margin = new Padding(2);
            btnPromeni.Name = "btnPromeni";
            btnPromeni.Size = new Size(118, 51);
            btnPromeni.TabIndex = 14;
            btnPromeni.Text = "Promeni";
            btnPromeni.UseVisualStyleBackColor = true;
            btnPromeni.Visible = false;
            btnPromeni.Click += btnPromeni_Click;
            // 
            // UCradSaStavkomEvidencijeNastave
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPromeni);
            Controls.Add(btnOmoguciIzmenu);
            Controls.Add(btnDodaj);
            Controls.Add(txtKomentar);
            Controls.Add(label5);
            Controls.Add(dateDatum);
            Controls.Add(label4);
            Controls.Add(cbRedniBrojCasa);
            Controls.Add(label3);
            Controls.Add(chDomaci);
            Controls.Add(chPrisustvo);
            Controls.Add(label2);
            Controls.Add(cbUcenik);
            Controls.Add(txtEvidencija);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "UCradSaStavkomEvidencijeNastave";
            Size = new Size(810, 400);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEvidencija;
        private ComboBox cbUcenik;
        private Label label2;
        private CheckBox chPrisustvo;
        private CheckBox chDomaci;
        private Label label3;
        private ComboBox cbRedniBrojCasa;
        private Label label4;
        private DateTimePicker dateDatum;
        private Label label5;
        private RichTextBox txtKomentar;
        private Button btnDodaj;
        private Button btnOmoguciIzmenu;
        private Button btnPromeni;
    }
}
