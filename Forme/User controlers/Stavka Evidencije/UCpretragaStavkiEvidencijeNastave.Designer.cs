namespace Forme.User_controlers
{
    partial class UCpretragaStavkiEvidencijeNastave
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
            cbEvidencija = new ComboBox();
            label1 = new Label();
            cbUcenik = new ComboBox();
            label2 = new Label();
            dgvStavke = new DataGridView();
            btnResetuj = new Button();
            btnPretrazi = new Button();
            btnPromeni = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).BeginInit();
            SuspendLayout();
            // 
            // cbEvidencija
            // 
            cbEvidencija.FormattingEnabled = true;
            cbEvidencija.Location = new Point(333, 63);
            cbEvidencija.Name = "cbEvidencija";
            cbEvidencija.Size = new Size(373, 40);
            cbEvidencija.TabIndex = 0;
            cbEvidencija.SelectedIndexChanged += cbEvidencija_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 66);
            label1.Name = "label1";
            label1.Size = new Size(212, 32);
            label1.TabIndex = 1;
            label1.Text = "Evidencija Nastave";
            // 
            // cbUcenik
            // 
            cbUcenik.FormattingEnabled = true;
            cbUcenik.Location = new Point(333, 135);
            cbUcenik.Name = "cbUcenik";
            cbUcenik.Size = new Size(373, 40);
            cbUcenik.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 135);
            label2.Name = "label2";
            label2.Size = new Size(86, 32);
            label2.TabIndex = 3;
            label2.Text = "Ucenik";
            // 
            // dgvStavke
            // 
            dgvStavke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStavke.Location = new Point(38, 238);
            dgvStavke.Name = "dgvStavke";
            dgvStavke.RowHeadersWidth = 82;
            dgvStavke.Size = new Size(1222, 303);
            dgvStavke.TabIndex = 4;
            // 
            // btnResetuj
            // 
            btnResetuj.Location = new Point(806, 52);
            btnResetuj.Name = "btnResetuj";
            btnResetuj.Size = new Size(263, 46);
            btnResetuj.TabIndex = 5;
            btnResetuj.Text = "Resetuj";
            btnResetuj.UseVisualStyleBackColor = true;
            btnResetuj.Click += btnResetuj_Click;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(806, 106);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(263, 91);
            btnPretrazi.TabIndex = 6;
            btnPretrazi.Text = "Pretrazi";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // btnPromeni
            // 
            btnPromeni.Location = new Point(806, 558);
            btnPromeni.Name = "btnPromeni";
            btnPromeni.Size = new Size(454, 56);
            btnPromeni.TabIndex = 7;
            btnPromeni.Text = "Promeni izabranu stavku evidencije";
            btnPromeni.UseVisualStyleBackColor = true;
            btnPromeni.Click += btnPromeni_Click;
            // 
            // UCpretragaStavkiEvidencijeNastave
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPromeni);
            Controls.Add(btnPretrazi);
            Controls.Add(btnResetuj);
            Controls.Add(dgvStavke);
            Controls.Add(label2);
            Controls.Add(cbUcenik);
            Controls.Add(label1);
            Controls.Add(cbEvidencija);
            Name = "UCpretragaStavkiEvidencijeNastave";
            Size = new Size(1300, 640);
            ((System.ComponentModel.ISupportInitialize)dgvStavke).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbEvidencija;
        private Label label1;
        private ComboBox cbUcenik;
        private Label label2;
        private DataGridView dgvStavke;
        private Button btnResetuj;
        private Button btnPretrazi;
        private Button btnPromeni;
    }
}
