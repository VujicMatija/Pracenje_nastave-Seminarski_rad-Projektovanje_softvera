namespace Forme.User_controlers
{
    partial class UCPrikazUcitelja
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
            txtIme = new TextBox();
            txtPrezime = new TextBox();
            txtEmail = new TextBox();
            txtTelefon = new TextBox();
            dgvLicence = new DataGridView();
            dgvGrupe = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            btnIzmeni = new Button();
            dateDatumPocetka = new DateTimePicker();
            btnDodajLicencu = new Button();
            btnObrisi = new Button();
            btnOmoguciIzmenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLicence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGrupe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 74);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "Ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 126);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Prezime:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 178);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 231);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 3;
            label4.Text = "Telefon:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 282);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 4;
            label5.Text = "Početak rada:";
            // 
            // txtIme
            // 
            txtIme.Enabled = false;
            txtIme.Location = new Point(174, 72);
            txtIme.Margin = new Padding(2, 2, 2, 2);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(184, 27);
            txtIme.TabIndex = 5;
            // 
            // txtPrezime
            // 
            txtPrezime.Enabled = false;
            txtPrezime.Location = new Point(174, 126);
            txtPrezime.Margin = new Padding(2, 2, 2, 2);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(184, 27);
            txtPrezime.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(174, 178);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(184, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtTelefon
            // 
            txtTelefon.Enabled = false;
            txtTelefon.Location = new Point(174, 231);
            txtTelefon.Margin = new Padding(2, 2, 2, 2);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(184, 27);
            txtTelefon.TabIndex = 8;
            // 
            // dgvLicence
            // 
            dgvLicence.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLicence.Location = new Point(418, 103);
            dgvLicence.Margin = new Padding(2, 2, 2, 2);
            dgvLicence.Name = "dgvLicence";
            dgvLicence.RowHeadersWidth = 82;
            dgvLicence.Size = new Size(146, 204);
            dgvLicence.TabIndex = 10;
            // 
            // dgvGrupe
            // 
            dgvGrupe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupe.Location = new Point(590, 103);
            dgvGrupe.Margin = new Padding(2, 2, 2, 2);
            dgvGrupe.Name = "dgvGrupe";
            dgvGrupe.RowHeadersWidth = 82;
            dgvGrupe.Size = new Size(146, 204);
            dgvGrupe.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(418, 69);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 12;
            label6.Text = "Licence učitelja";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(590, 69);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 13;
            label7.Text = "Grupe učenika";
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(215, 325);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(142, 29);
            btnIzmeni.TabIndex = 15;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // dateDatumPocetka
            // 
            dateDatumPocetka.CustomFormat = "dd/MM/yyyy";
            dateDatumPocetka.Enabled = false;
            dateDatumPocetka.Format = DateTimePickerFormat.Custom;
            dateDatumPocetka.Location = new Point(174, 282);
            dateDatumPocetka.Name = "dateDatumPocetka";
            dateDatumPocetka.Size = new Size(184, 27);
            dateDatumPocetka.TabIndex = 16;
            // 
            // btnDodajLicencu
            // 
            btnDodajLicencu.Location = new Point(423, 325);
            btnDodajLicencu.Name = "btnDodajLicencu";
            btnDodajLicencu.Size = new Size(135, 29);
            btnDodajLicencu.TabIndex = 17;
            btnDodajLicencu.Text = "Dodaj licencu";
            btnDodajLicencu.UseVisualStyleBackColor = true;
            btnDodajLicencu.Click += btnDodajLicencu_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(39, 325);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(142, 29);
            btnObrisi.TabIndex = 18;
            btnObrisi.Text = "Obriši učitelja";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnOmoguciIzmenu
            // 
            btnOmoguciIzmenu.Location = new Point(215, 325);
            btnOmoguciIzmenu.Name = "btnOmoguciIzmenu";
            btnOmoguciIzmenu.Size = new Size(142, 29);
            btnOmoguciIzmenu.TabIndex = 14;
            btnOmoguciIzmenu.Text = "Omogući izmenu";
            btnOmoguciIzmenu.UseVisualStyleBackColor = true;
            btnOmoguciIzmenu.Click += btnOmoguciIzmenu_Click;
            // 
            // UCPrikazUcitelja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(btnObrisi);
            Controls.Add(btnDodajLicencu);
            Controls.Add(dateDatumPocetka);
            Controls.Add(btnOmoguciIzmenu);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dgvGrupe);
            Controls.Add(dgvLicence);
            Controls.Add(txtTelefon);
            Controls.Add(txtEmail);
            Controls.Add(txtPrezime);
            Controls.Add(txtIme);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIzmeni);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UCPrikazUcitelja";
            Size = new Size(800, 400);
            ((System.ComponentModel.ISupportInitialize)dgvLicence).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGrupe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIme;
        private TextBox txtPrezime;
        private TextBox txtEmail;
        private TextBox txtTelefon;
        private DataGridView dgvLicence;
        private DataGridView dgvGrupe;
        private Label label6;
        private Label label7;
        private Button btnIzmeni;
        private DateTimePicker dateDatumPocetka;
        private Button btnDodajLicencu;
        private Button btnObrisi;
        private Button btnOmoguciIzmenu;
    }
}
