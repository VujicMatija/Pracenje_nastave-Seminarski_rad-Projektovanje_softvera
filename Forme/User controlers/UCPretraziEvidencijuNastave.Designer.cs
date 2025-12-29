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
            cbUcitelj.Location = new Point(62, 104);
            cbUcitelj.Margin = new Padding(5);
            cbUcitelj.Name = "cbUcitelj";
            cbUcitelj.Size = new Size(243, 40);
            cbUcitelj.TabIndex = 0;
            // 
            // cbUcenik
            // 
            cbUcenik.FormattingEnabled = true;
            cbUcenik.Location = new Point(384, 104);
            cbUcenik.Margin = new Padding(5);
            cbUcenik.Name = "cbUcenik";
            cbUcenik.Size = new Size(243, 40);
            cbUcenik.TabIndex = 1;
            // 
            // cbGrupa
            // 
            cbGrupa.FormattingEnabled = true;
            cbGrupa.Location = new Point(710, 104);
            cbGrupa.Margin = new Padding(5);
            cbGrupa.Name = "cbGrupa";
            cbGrupa.Size = new Size(243, 40);
            cbGrupa.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 53);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 3;
            label1.Text = "Učitelj";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(384, 53);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 32);
            label2.TabIndex = 4;
            label2.Text = "Učenik";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(710, 53);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(167, 32);
            label3.TabIndex = 5;
            label3.Text = "Grupa učenika";
            // 
            // dgvEvidencije
            // 
            dgvEvidencije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvidencije.Location = new Point(62, 258);
            dgvEvidencije.Margin = new Padding(5);
            dgvEvidencije.Name = "dgvEvidencije";
            dgvEvidencije.RowHeadersWidth = 51;
            dgvEvidencije.Size = new Size(894, 253);
            dgvEvidencije.TabIndex = 6;
            // 
            // btnPretraziEvidencije
            // 
            btnPretraziEvidencije.Location = new Point(710, 174);
            btnPretraziEvidencije.Margin = new Padding(5);
            btnPretraziEvidencije.Name = "btnPretraziEvidencije";
            btnPretraziEvidencije.Size = new Size(245, 59);
            btnPretraziEvidencije.TabIndex = 7;
            btnPretraziEvidencije.Text = "Pretrazi";
            btnPretraziEvidencije.UseVisualStyleBackColor = true;
            btnPretraziEvidencije.Click += btnPretraziEvidencije_Click;
            // 
            // btnPrikazi
            // 
            btnPrikazi.Location = new Point(735, 535);
            btnPrikazi.Name = "btnPrikazi";
            btnPrikazi.Size = new Size(218, 74);
            btnPrikazi.TabIndex = 8;
            btnPrikazi.Text = "Prikazi izabranu evidenciju";
            btnPrikazi.UseVisualStyleBackColor = true;
            btnPrikazi.Click += btnPrikazi_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(498, 535);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(218, 74);
            btnIzmeni.TabIndex = 9;
            btnIzmeni.Text = "Izmeni izabranu evidenciju";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // UCPretraziEvidencijuNastave
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
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
            Margin = new Padding(5);
            Name = "UCPretraziEvidencijuNastave";
            Size = new Size(1063, 678);
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
