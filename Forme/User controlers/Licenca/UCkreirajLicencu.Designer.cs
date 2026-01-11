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
            cbSertifikati.Location = new Point(156, 88);
            cbSertifikati.Name = "cbSertifikati";
            cbSertifikati.Size = new Size(151, 28);
            cbSertifikati.TabIndex = 1;
            // 
            // dateDobijanje
            // 
            dateDobijanje.CustomFormat = "dd/MM/yyyy";
            dateDobijanje.Format = DateTimePickerFormat.Custom;
            dateDobijanje.Location = new Point(156, 137);
            dateDobijanje.MaxDate = new DateTime(2026, 1, 10, 0, 0, 0, 0);
            dateDobijanje.Name = "dateDobijanje";
            dateDobijanje.Size = new Size(151, 27);
            dateDobijanje.TabIndex = 2;
            dateDobijanje.Value = new DateTime(2026, 1, 10, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 40);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 3;
            label1.Text = "Učitelj";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 91);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 4;
            label2.Text = "Sertifikat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 142);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 5;
            label3.Text = "Datum dobijanja";
            // 
            // btnDodajLicencu
            // 
            btnDodajLicencu.Location = new Point(112, 188);
            btnDodajLicencu.Name = "btnDodajLicencu";
            btnDodajLicencu.Size = new Size(126, 65);
            btnDodajLicencu.TabIndex = 6;
            btnDodajLicencu.Text = "Dodaj licencu";
            btnDodajLicencu.UseVisualStyleBackColor = true;
            btnDodajLicencu.Click += btnDodajLicencu_Click;
            // 
            // txtUcitelj
            // 
            txtUcitelj.Enabled = false;
            txtUcitelj.Location = new Point(156, 37);
            txtUcitelj.Name = "txtUcitelj";
            txtUcitelj.Size = new Size(151, 27);
            txtUcitelj.TabIndex = 7;
            // 
            // btnOmoguciIzmenu
            // 
            btnOmoguciIzmenu.Location = new Point(112, 188);
            btnOmoguciIzmenu.Margin = new Padding(2, 2, 2, 2);
            btnOmoguciIzmenu.Name = "btnOmoguciIzmenu";
            btnOmoguciIzmenu.Size = new Size(126, 65);
            btnOmoguciIzmenu.TabIndex = 8;
            btnOmoguciIzmenu.Text = "Omoguci izmenu";
            btnOmoguciIzmenu.UseVisualStyleBackColor = true;
            btnOmoguciIzmenu.Visible = false;
            btnOmoguciIzmenu.Click += btnOmoguciIzmenu_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(112, 188);
            btnIzmeni.Margin = new Padding(2, 2, 2, 2);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(126, 65);
            btnIzmeni.TabIndex = 9;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Visible = false;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // UCkreirajLicencu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Name = "UCkreirajLicencu";
            Size = new Size(348, 300);
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
