namespace Forme.User_controlers
{
    partial class UCPrikazEvidencijeNastave
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
            cbUcitelj = new ComboBox();
            cbGrupa = new ComboBox();
            dgvUcenici = new DataGridView();
            label3 = new Label();
            dgvStavke = new DataGridView();
            label4 = new Label();
            chAktivna = new CheckBox();
            datePocetak = new DateTimePicker();
            label5 = new Label();
            btnPromeni = new Button();
            btnDodajStavku = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUcenici).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 61);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Učitelj";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 102);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "Grupa učenika";
            // 
            // cbUcitelj
            // 
            cbUcitelj.FormattingEnabled = true;
            cbUcitelj.Location = new Point(165, 59);
            cbUcitelj.Margin = new Padding(2);
            cbUcitelj.Name = "cbUcitelj";
            cbUcitelj.Size = new Size(163, 28);
            cbUcitelj.TabIndex = 2;
            // 
            // cbGrupa
            // 
            cbGrupa.FormattingEnabled = true;
            cbGrupa.Location = new Point(165, 102);
            cbGrupa.Margin = new Padding(2);
            cbGrupa.Name = "cbGrupa";
            cbGrupa.Size = new Size(163, 28);
            cbGrupa.TabIndex = 3;
            // 
            // dgvUcenici
            // 
            dgvUcenici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUcenici.Location = new Point(365, 59);
            dgvUcenici.Margin = new Padding(2);
            dgvUcenici.Name = "dgvUcenici";
            dgvUcenici.RowHeadersWidth = 82;
            dgvUcenici.Size = new Size(392, 156);
            dgvUcenici.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(365, 31);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 5;
            label3.Text = "Učenici";
            // 
            // dgvStavke
            // 
            dgvStavke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStavke.Location = new Point(34, 244);
            dgvStavke.Margin = new Padding(2);
            dgvStavke.Name = "dgvStavke";
            dgvStavke.RowHeadersWidth = 82;
            dgvStavke.Size = new Size(574, 134);
            dgvStavke.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 218);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(177, 20);
            label4.TabIndex = 7;
            label4.Text = "Stavke evidencije nastave";
            label4.Click += label4_Click;
            // 
            // chAktivna
            // 
            chAktivna.AutoSize = true;
            chAktivna.Location = new Point(165, 183);
            chAktivna.Margin = new Padding(2);
            chAktivna.Name = "chAktivna";
            chAktivna.Size = new Size(80, 24);
            chAktivna.TabIndex = 8;
            chAktivna.Text = "Aktivna";
            chAktivna.UseVisualStyleBackColor = true;
            // 
            // datePocetak
            // 
            datePocetak.CustomFormat = "dd/MM/yyyy";
            datePocetak.Format = DateTimePickerFormat.Custom;
            datePocetak.Location = new Point(165, 151);
            datePocetak.Margin = new Padding(2);
            datePocetak.Name = "datePocetak";
            datePocetak.Size = new Size(163, 27);
            datePocetak.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 154);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 10;
            label5.Text = "Datum početka";
            // 
            // btnPromeni
            // 
            btnPromeni.Location = new Point(625, 254);
            btnPromeni.Margin = new Padding(2);
            btnPromeni.Name = "btnPromeni";
            btnPromeni.Size = new Size(132, 49);
            btnPromeni.TabIndex = 11;
            btnPromeni.Text = "Sacuvaj izmene";
            btnPromeni.UseVisualStyleBackColor = true;
            btnPromeni.Click += btnPromeni_Click;
            // 
            // btnDodajStavku
            // 
            btnDodajStavku.Location = new Point(625, 317);
            btnDodajStavku.Margin = new Padding(2);
            btnDodajStavku.Name = "btnDodajStavku";
            btnDodajStavku.Size = new Size(132, 49);
            btnDodajStavku.TabIndex = 12;
            btnDodajStavku.Text = "Dodaj stavku evidencije nastave";
            btnDodajStavku.UseVisualStyleBackColor = true;
            btnDodajStavku.Click += btnDodajStavku_Click;
            // 
            // UCPrikazEvidencijeNastave
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDodajStavku);
            Controls.Add(btnPromeni);
            Controls.Add(label5);
            Controls.Add(datePocetak);
            Controls.Add(chAktivna);
            Controls.Add(label4);
            Controls.Add(dgvStavke);
            Controls.Add(label3);
            Controls.Add(dgvUcenici);
            Controls.Add(cbGrupa);
            Controls.Add(cbUcitelj);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "UCPrikazEvidencijeNastave";
            Size = new Size(800, 400);
            ((System.ComponentModel.ISupportInitialize)dgvUcenici).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbUcitelj;
        private ComboBox cbGrupa;
        private DataGridView dgvUcenici;
        private Label label3;
        private DataGridView dgvStavke;
        private Label label4;
        private CheckBox chAktivna;
        private DateTimePicker datePocetak;
        private Label label5;
        private Button btnPromeni;
        private Button btnDodajStavku;
    }
}
