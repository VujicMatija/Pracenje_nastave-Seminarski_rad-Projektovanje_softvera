namespace Forme.User_controlers
{
    partial class UCkreirajLicencu
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
            cbSertifikati = new ComboBox();
            dateDobijanje = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnDodajLicencu = new Button();
            txtUcitelj = new TextBox();
            btnOmoguciIzmenu = new Button();
            btnIzmeni = new Button();
            SuspendLayout();
            // 
            // cbSertifikati
            // 
            cbSertifikati.FormattingEnabled = true;
            cbSertifikati.Location = new Point(136, 66);
            cbSertifikati.Margin = new Padding(3, 2, 3, 2);
            cbSertifikati.Name = "cbSertifikati";
            cbSertifikati.Size = new Size(133, 23);
            cbSertifikati.TabIndex = 1;
            // 
            // dateDobijanje
            // 
            dateDobijanje.CustomFormat = "dd/MM/yyyy";
            dateDobijanje.Format = DateTimePickerFormat.Custom;
            dateDobijanje.Location = new Point(136, 103);
            dateDobijanje.Margin = new Padding(3, 2, 3, 2);
            dateDobijanje.MaxDate = new DateTime(2026, 1, 10, 0, 0, 0, 0);
            dateDobijanje.Name = "dateDobijanje";
            dateDobijanje.Size = new Size(133, 23);
            dateDobijanje.TabIndex = 2;
            dateDobijanje.Value = new DateTime(2026, 1, 10, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 30);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Učitelj";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 68);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 4;
            label2.Text = "Sertifikat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 106);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 5;
            label3.Text = "Datum dobijanja";
            // 
            // btnDodajLicencu
            // 
            btnDodajLicencu.Location = new Point(98, 141);
            btnDodajLicencu.Margin = new Padding(3, 2, 3, 2);
            btnDodajLicencu.Name = "btnDodajLicencu";
            btnDodajLicencu.Size = new Size(110, 49);
            btnDodajLicencu.TabIndex = 6;
            btnDodajLicencu.Text = "Dodaj licencu";
            btnDodajLicencu.UseVisualStyleBackColor = true;
            btnDodajLicencu.Click += btnDodajLicencu_Click;
            // 
            // txtUcitelj
            // 
            txtUcitelj.Enabled = false;
            txtUcitelj.Location = new Point(136, 28);
            txtUcitelj.Margin = new Padding(3, 2, 3, 2);
            txtUcitelj.Name = "txtUcitelj";
            txtUcitelj.Size = new Size(133, 23);
            txtUcitelj.TabIndex = 7;
            // 
            // btnOmoguciIzmenu
            // 
            btnOmoguciIzmenu.Location = new Point(98, 141);
            btnOmoguciIzmenu.Margin = new Padding(2);
            btnOmoguciIzmenu.Name = "btnOmoguciIzmenu";
            btnOmoguciIzmenu.Size = new Size(110, 49);
            btnOmoguciIzmenu.TabIndex = 8;
            btnOmoguciIzmenu.Text = "Omoguci izmenu";
            btnOmoguciIzmenu.UseVisualStyleBackColor = true;
            btnOmoguciIzmenu.Visible = false;
            btnOmoguciIzmenu.Click += btnOmoguciIzmenu_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(98, 141);
            btnIzmeni.Margin = new Padding(2);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(110, 49);
            btnIzmeni.TabIndex = 9;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Visible = false;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // UCkreirajLicencu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnIzmeni);
            Controls.Add(btnOmoguciIzmenu);
            Controls.Add(txtUcitelj);
            Controls.Add(btnDodajLicencu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateDobijanje);
            Controls.Add(cbSertifikati);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCkreirajLicencu";
            Size = new Size(300, 225);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox cbSertifikati;
        private DateTimePicker dateDobijanje;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnDodajLicencu;
        private TextBox txtUcitelj;
        private Button btnOmoguciIzmenu;
        private Button btnIzmeni;
    }
}
