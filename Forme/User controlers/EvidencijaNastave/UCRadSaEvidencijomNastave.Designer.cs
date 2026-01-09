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
            cbUcitelj = new ComboBox();
            cbGrupa = new ComboBox();
            datePocetakRada = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            chAktivna = new CheckBox();
            btnKreiraj = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbUcitelj
            // 
            cbUcitelj.FormattingEnabled = true;
            cbUcitelj.Location = new Point(195, 73);
            cbUcitelj.Name = "cbUcitelj";
            cbUcitelj.Size = new Size(245, 28);
            cbUcitelj.TabIndex = 0;
            // 
            // cbGrupa
            // 
            cbGrupa.FormattingEnabled = true;
            cbGrupa.Location = new Point(195, 120);
            cbGrupa.Name = "cbGrupa";
            cbGrupa.Size = new Size(245, 28);
            cbGrupa.TabIndex = 1;
            // 
            // datePocetakRada
            // 
            datePocetakRada.Format = DateTimePickerFormat.Short;
            datePocetakRada.Location = new Point(195, 164);
            datePocetakRada.MaxDate = new DateTime(2026, 1, 9, 0, 0, 0, 0);
            datePocetakRada.Name = "datePocetakRada";
            datePocetakRada.Size = new Size(245, 27);
            datePocetakRada.TabIndex = 2;
            datePocetakRada.Value = new DateTime(2026, 1, 9, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 76);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 3;
            label1.Text = "Odaberite učitelja:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 120);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 4;
            label2.Text = "Odaberite grupu: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 164);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 5;
            label3.Text = "Početak rada: ";
            // 
            // chAktivna
            // 
            chAktivna.AutoSize = true;
            chAktivna.Checked = true;
            chAktivna.CheckState = CheckState.Checked;
            chAktivna.Location = new Point(195, 211);
            chAktivna.Name = "chAktivna";
            chAktivna.Size = new Size(198, 24);
            chAktivna.TabIndex = 6;
            chAktivna.Text = "Grupa je trenutno aktivna";
            chAktivna.UseVisualStyleBackColor = true;
            // 
            // btnKreiraj
            // 
            btnKreiraj.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKreiraj.Location = new Point(143, 271);
            btnKreiraj.Name = "btnKreiraj";
            btnKreiraj.Size = new Size(187, 71);
            btnKreiraj.TabIndex = 7;
            btnKreiraj.Text = "Kreiraj evidenciju nastave";
            btnKreiraj.UseVisualStyleBackColor = true;
            btnKreiraj.Click += btnKreiraj_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(495, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // UCRadSaEvidencijomNastave
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(btnKreiraj);
            Controls.Add(chAktivna);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(datePocetakRada);
            Controls.Add(cbGrupa);
            Controls.Add(cbUcitelj);
            Name = "UCRadSaEvidencijomNastave";
            Size = new Size(800, 400);
            Load += UCRadSaEvidencijomNastave_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbUcitelj;
        private ComboBox cbGrupa;
        private DateTimePicker datePocetakRada;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox chAktivna;
        private Button btnKreiraj;
        private PictureBox pictureBox1;
    }
}
