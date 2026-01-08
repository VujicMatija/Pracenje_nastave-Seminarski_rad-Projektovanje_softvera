namespace Forme.User_controlers
{
    partial class UCpretraziUcitelja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCpretraziUcitelja));
            label1 = new Label();
            label2 = new Label();
            txtImePrezime = new TextBox();
            cbSertifikati = new ComboBox();
            dgvUcitelji = new DataGridView();
            btnPretrazi = new Button();
            btnResetuj = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvUcitelji).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 70);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Sertifikati";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 32);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Ime i prezime";
            // 
            // txtImePrezime
            // 
            txtImePrezime.Location = new Point(171, 29);
            txtImePrezime.Name = "txtImePrezime";
            txtImePrezime.Size = new Size(229, 27);
            txtImePrezime.TabIndex = 2;
            // 
            // cbSertifikati
            // 
            cbSertifikati.FormattingEnabled = true;
            cbSertifikati.Location = new Point(171, 67);
            cbSertifikati.Name = "cbSertifikati";
            cbSertifikati.Size = new Size(229, 28);
            cbSertifikati.TabIndex = 3;
            // 
            // dgvUcitelji
            // 
            dgvUcitelji.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUcitelji.Location = new Point(52, 153);
            dgvUcitelji.Name = "dgvUcitelji";
            dgvUcitelji.RowHeadersWidth = 51;
            dgvUcitelji.Size = new Size(347, 188);
            dgvUcitelji.TabIndex = 4;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(273, 109);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(126, 29);
            btnPretrazi.TabIndex = 5;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += button1_Click;
            // 
            // btnResetuj
            // 
            btnResetuj.Location = new Point(52, 109);
            btnResetuj.Name = "btnResetuj";
            btnResetuj.Size = new Size(115, 29);
            btnResetuj.TabIndex = 6;
            btnResetuj.Text = "Resetuj";
            btnResetuj.UseVisualStyleBackColor = true;
            btnResetuj.Click += btnResetuj_Click;
            // 
            // button1
            // 
            button1.Location = new Point(201, 357);
            button1.Name = "button1";
            button1.Size = new Size(198, 29);
            button1.TabIndex = 7;
            button1.Text = "Prikaži izabranog učitelja";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(475, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // UCpretraziUcitelja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(btnResetuj);
            Controls.Add(btnPretrazi);
            Controls.Add(dgvUcitelji);
            Controls.Add(cbSertifikati);
            Controls.Add(txtImePrezime);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCpretraziUcitelja";
            Size = new Size(800, 400);
            Load += UCpretraziUcitelja_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUcitelji).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtImePrezime;
        private ComboBox cbSertifikati;
        private DataGridView dgvUcitelji;
        private Button btnPretrazi;
        private Button btnResetuj;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
