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
            btnOmoguciIzmenu = new Button();
            btnIzmeni = new Button();
            dateDatumPocetka = new DateTimePicker();
            btnDodajLicencu = new Button();
            btnObrisi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLicence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGrupe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 118);
            label1.Name = "label1";
            label1.Size = new Size(59, 32);
            label1.TabIndex = 0;
            label1.Text = "Ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 202);
            label2.Name = "label2";
            label2.Size = new Size(104, 32);
            label2.TabIndex = 1;
            label2.Text = "Prezime:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 285);
            label3.Name = "label3";
            label3.Size = new Size(76, 32);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 370);
            label4.Name = "label4";
            label4.Size = new Size(98, 32);
            label4.TabIndex = 3;
            label4.Text = "Telefon:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 451);
            label5.Name = "label5";
            label5.Size = new Size(154, 32);
            label5.TabIndex = 4;
            label5.Text = "Početak rada:";
            // 
            // txtIme
            // 
            txtIme.Enabled = false;
            txtIme.Location = new Point(283, 115);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(296, 39);
            txtIme.TabIndex = 5;
            // 
            // txtPrezime
            // 
            txtPrezime.Enabled = false;
            txtPrezime.Location = new Point(283, 202);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(296, 39);
            txtPrezime.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(283, 285);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(296, 39);
            txtEmail.TabIndex = 7;
            // 
            // txtTelefon
            // 
            txtTelefon.Enabled = false;
            txtTelefon.Location = new Point(283, 370);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(296, 39);
            txtTelefon.TabIndex = 8;
            // 
            // dgvLicence
            // 
            dgvLicence.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLicence.Location = new Point(679, 165);
            dgvLicence.Name = "dgvLicence";
            dgvLicence.RowHeadersWidth = 82;
            dgvLicence.Size = new Size(238, 326);
            dgvLicence.TabIndex = 10;
            // 
            // dgvGrupe
            // 
            dgvGrupe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupe.Location = new Point(959, 165);
            dgvGrupe.Name = "dgvGrupe";
            dgvGrupe.RowHeadersWidth = 82;
            dgvGrupe.Size = new Size(237, 326);
            dgvGrupe.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(679, 110);
            label6.Name = "label6";
            label6.Size = new Size(176, 32);
            label6.TabIndex = 12;
            label6.Text = "Licence učitelja";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(959, 110);
            label7.Name = "label7";
            label7.Size = new Size(168, 32);
            label7.TabIndex = 13;
            label7.Text = "Grupe učenika";
            // 
            // btnOmoguciIzmenu
            // 
            btnOmoguciIzmenu.Location = new Point(349, 520);
            btnOmoguciIzmenu.Margin = new Padding(5, 5, 5, 5);
            btnOmoguciIzmenu.Name = "btnOmoguciIzmenu";
            btnOmoguciIzmenu.Size = new Size(230, 46);
            btnOmoguciIzmenu.TabIndex = 14;
            btnOmoguciIzmenu.Text = "Omogući izmenu";
            btnOmoguciIzmenu.UseVisualStyleBackColor = true;
            btnOmoguciIzmenu.Click += btnOmoguciIzmenu_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(349, 520);
            btnIzmeni.Margin = new Padding(5, 5, 5, 5);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(230, 46);
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
            dateDatumPocetka.Location = new Point(283, 451);
            dateDatumPocetka.Margin = new Padding(5, 5, 5, 5);
            dateDatumPocetka.Name = "dateDatumPocetka";
            dateDatumPocetka.Size = new Size(296, 39);
            dateDatumPocetka.TabIndex = 16;
            // 
            // btnDodajLicencu
            // 
            btnDodajLicencu.Location = new Point(687, 520);
            btnDodajLicencu.Margin = new Padding(5, 5, 5, 5);
            btnDodajLicencu.Name = "btnDodajLicencu";
            btnDodajLicencu.Size = new Size(220, 46);
            btnDodajLicencu.TabIndex = 17;
            btnDodajLicencu.Text = "Dodaj licencu";
            btnDodajLicencu.UseVisualStyleBackColor = true;
            btnDodajLicencu.Click += btnDodajLicencu_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(63, 520);
            btnObrisi.Margin = new Padding(5, 5, 5, 5);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(230, 46);
            btnObrisi.TabIndex = 18;
            btnObrisi.Text = "Obriši učitelja";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // UCPrikazUcitelja
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
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
            Name = "UCPrikazUcitelja";
            Size = new Size(1300, 640);
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
        private Button btnOmoguciIzmenu;
        private Button btnIzmeni;
        private DateTimePicker dateDatumPocetka;
        private Button btnDodajLicencu;
        private Button btnObrisi;
    }
}
