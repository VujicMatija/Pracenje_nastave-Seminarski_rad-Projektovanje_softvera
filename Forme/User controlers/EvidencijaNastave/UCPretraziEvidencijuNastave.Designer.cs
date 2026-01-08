namespace Forme.User_controlers
{
    partial class UCPretraziEvidencijuNastave
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
            cbUcitelj = new ComboBox();
            cbUcenik = new ComboBox();
            cbGrupa = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvEvidencije = new DataGridView();
            btnPretraziEvidencije = new Button();
            btnPrikazi = new Button();
            btnIzmeni = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEvidencije).BeginInit();
            SuspendLayout();
            // 
            // cbUcitelj
            // 
            cbUcitelj.FormattingEnabled = true;
            cbUcitelj.Location = new Point(124, 63);
            cbUcitelj.Name = "cbUcitelj";
            cbUcitelj.Size = new Size(169, 28);
            cbUcitelj.TabIndex = 0;
            // 
            // cbUcenik
            // 
            cbUcenik.FormattingEnabled = true;
            cbUcenik.Location = new Point(322, 63);
            cbUcenik.Name = "cbUcenik";
            cbUcenik.Size = new Size(169, 28);
            cbUcenik.TabIndex = 1;
            // 
            // cbGrupa
            // 
            cbGrupa.FormattingEnabled = true;
            cbGrupa.Location = new Point(523, 63);
            cbGrupa.Name = "cbGrupa";
            cbGrupa.Size = new Size(169, 28);
            cbGrupa.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 31);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 3;
            label1.Text = "Učitelj";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 31);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 4;
            label2.Text = "Učenik";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(523, 31);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 5;
            label3.Text = "Grupa učenika";
            // 
            // dgvEvidencije
            // 
            dgvEvidencije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvidencije.Location = new Point(87, 158);
            dgvEvidencije.Name = "dgvEvidencije";
            dgvEvidencije.RowHeadersWidth = 51;
            dgvEvidencije.Size = new Size(630, 158);
            dgvEvidencije.TabIndex = 6;
            // 
            // btnPretraziEvidencije
            // 
            btnPretraziEvidencije.Location = new Point(540, 104);
            btnPretraziEvidencije.Name = "btnPretraziEvidencije";
            btnPretraziEvidencije.Size = new Size(151, 37);
            btnPretraziEvidencije.TabIndex = 7;
            btnPretraziEvidencije.Text = "Pretrazi";
            btnPretraziEvidencije.UseVisualStyleBackColor = true;
            btnPretraziEvidencije.Click += btnPretraziEvidencije_Click;
            // 
            // btnPrikazi
            // 
            btnPrikazi.Location = new Point(441, 334);
            btnPrikazi.Margin = new Padding(2);
            btnPrikazi.Name = "btnPrikazi";
            btnPrikazi.Size = new Size(195, 46);
            btnPrikazi.TabIndex = 8;
            btnPrikazi.Text = "Prikazi izabranu evidenciju";
            btnPrikazi.UseVisualStyleBackColor = true;
            btnPrikazi.Click += btnPrikazi_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(210, 334);
            btnIzmeni.Margin = new Padding(2);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(200, 46);
            btnIzmeni.TabIndex = 9;
            btnIzmeni.Text = "Izmeni izabranu evidenciju";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // UCPretraziEvidencijuNastave
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnIzmeni);
            Controls.Add(btnPrikazi);
            Controls.Add(btnPretraziEvidencije);
            Controls.Add(dgvEvidencije);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbGrupa);
            Controls.Add(cbUcenik);
            Controls.Add(cbUcitelj);
            Name = "UCPretraziEvidencijuNastave";
            Size = new Size(800, 400);
            Load += UCPretraziEvidencijuNastave_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEvidencije).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbUcitelj;
        private ComboBox cbUcenik;
        private ComboBox cbGrupa;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvEvidencije;
        private Button btnPretraziEvidencije;
        private Button btnPrikazi;
        private Button btnIzmeni;
    }
}
