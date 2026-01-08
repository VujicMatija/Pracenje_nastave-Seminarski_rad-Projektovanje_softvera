namespace Forme.User_controlers
{
    partial class UCpretraziUcenika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCpretraziUcenika));
            txtImePrezime = new TextBox();
            label1 = new Label();
            btnPretraga = new Button();
            dgvUcenici = new DataGridView();
            butnPrikaz = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvUcenici).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtImePrezime
            // 
            txtImePrezime.Location = new Point(180, 68);
            txtImePrezime.Name = "txtImePrezime";
            txtImePrezime.Size = new Size(240, 27);
            txtImePrezime.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 71);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 1;
            label1.Text = "Ime i prezime učenika";
            // 
            // btnPretraga
            // 
            btnPretraga.Location = new Point(445, 61);
            btnPretraga.Name = "btnPretraga";
            btnPretraga.Size = new Size(108, 40);
            btnPretraga.TabIndex = 2;
            btnPretraga.Text = "Pretraži";
            btnPretraga.UseVisualStyleBackColor = true;
            btnPretraga.Click += btnPretraga_Click;
            // 
            // dgvUcenici
            // 
            dgvUcenici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUcenici.Location = new Point(20, 118);
            dgvUcenici.Name = "dgvUcenici";
            dgvUcenici.RowHeadersWidth = 51;
            dgvUcenici.Size = new Size(533, 188);
            dgvUcenici.TabIndex = 3;
            // 
            // butnPrikaz
            // 
            butnPrikaz.Location = new Point(357, 311);
            butnPrikaz.Name = "butnPrikaz";
            butnPrikaz.Size = new Size(196, 41);
            butnPrikaz.TabIndex = 4;
            butnPrikaz.Text = "Prikazi odabranog ucenika";
            butnPrikaz.UseVisualStyleBackColor = true;
            butnPrikaz.Click += butnPrikaz_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(559, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // UCpretraziUcenika
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(butnPrikaz);
            Controls.Add(dgvUcenici);
            Controls.Add(btnPretraga);
            Controls.Add(label1);
            Controls.Add(txtImePrezime);
            Name = "UCpretraziUcenika";
            Size = new Size(800, 400);
            ((System.ComponentModel.ISupportInitialize)dgvUcenici).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtImePrezime;
        private Label label1;
        private Button btnPretraga;
        private DataGridView dgvUcenici;
        private Button butnPrikaz;
        private PictureBox pictureBox1;
    }
}
