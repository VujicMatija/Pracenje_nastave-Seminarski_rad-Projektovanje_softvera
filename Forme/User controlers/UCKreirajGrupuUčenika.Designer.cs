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
            ((System.ComponentModel.ISupportInitialize)numBrojUcenika).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 137);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 0;
            label1.Text = "Oznaka grupe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 198);
            label2.Name = "label2";
            label2.Size = new Size(60, 32);
            label2.TabIndex = 1;
            label2.Text = "Kurs";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 262);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 2;
            label3.Text = "Termin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 313);
            label4.Name = "label4";
            label4.Size = new Size(145, 32);
            label4.TabIndex = 3;
            label4.Text = "Broj učenika";
            label4.Click += label4_Click;
            // 
            // txtOznaka
            // 
            txtOznaka.Enabled = false;
            txtOznaka.Location = new Point(336, 134);
            txtOznaka.Name = "txtOznaka";
            txtOznaka.Size = new Size(412, 39);
            txtOznaka.TabIndex = 4;
            txtOznaka.Text = "Oznaka se sama generiše nakon odabira termina i grupe";
            // 
            // cbKursevi
            // 
            cbKursevi.FormattingEnabled = true;
            cbKursevi.Location = new Point(336, 195);
            cbKursevi.Name = "cbKursevi";
            cbKursevi.Size = new Size(412, 40);
            cbKursevi.TabIndex = 5;
            cbKursevi.SelectedIndexChanged += cbKursevi_SelectedIndexChanged;
            // 
            // cbDani
            // 
            cbDani.FormattingEnabled = true;
            cbDani.Location = new Point(336, 254);
            cbDani.Name = "cbDani";
            cbDani.Size = new Size(168, 40);
            cbDani.TabIndex = 6;
            cbDani.SelectedIndexChanged += cbDani_SelectedIndexChanged;
            // 
            // cbSati
            // 
            cbSati.FormattingEnabled = true;
            cbSati.Location = new Point(521, 254);
            cbSati.Name = "cbSati";
            cbSati.Size = new Size(168, 40);
            cbSati.TabIndex = 7;
            cbSati.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // numBrojUcenika
            // 
            numBrojUcenika.Location = new Point(336, 311);
            numBrojUcenika.Name = "numBrojUcenika";
            numBrojUcenika.Size = new Size(240, 39);
            numBrojUcenika.TabIndex = 8;
            // 
            // btnKreiraj
            // 
            btnKreiraj.Location = new Point(336, 384);
            btnKreiraj.Name = "btnKreiraj";
            btnKreiraj.Size = new Size(263, 107);
            btnKreiraj.TabIndex = 9;
            btnKreiraj.Text = "Kreiraj grupu učenika";
            btnKreiraj.UseVisualStyleBackColor = true;
            btnKreiraj.Click += btnKreiraj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(336, 509);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(263, 100);
            btnIzmeni.TabIndex = 10;
            btnIzmeni.Text = "izmeni grupu učenika";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Visible = false;
            // 
            // btnHint
            // 
            btnHint.Location = new Point(695, 253);
            btnHint.Name = "btnHint";
            btnHint.Size = new Size(53, 40);
            btnHint.TabIndex = 11;
            btnHint.Text = "?";
            btnHint.UseVisualStyleBackColor = true;
            // 
            // UCKreirajGrupuUčenika
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "UCKreirajGrupuUčenika";
            Size = new Size(909, 636);
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
    }
}
