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
            txtIme = new TextBox();
            cbSertifikati = new ComboBox();
            dgvUcitelji = new DataGridView();
            btnPretrazi = new Button();
            btnResetuj = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtPrezime = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUcitelji).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 60);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Sertifikati";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 10);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "Ime";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(70, 27);
            txtIme.Margin = new Padding(3, 2, 3, 2);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(133, 23);
            txtIme.TabIndex = 2;
            // 
            // cbSertifikati
            // 
            cbSertifikati.FormattingEnabled = true;
            cbSertifikati.Location = new Point(150, 58);
            cbSertifikati.Margin = new Padding(3, 2, 3, 2);
            cbSertifikati.Name = "cbSertifikati";
            cbSertifikati.Size = new Size(201, 23);
            cbSertifikati.TabIndex = 3;
            // 
            // dgvUcitelji
            // 
            dgvUcitelji.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUcitelji.Location = new Point(46, 120);
            dgvUcitelji.Margin = new Padding(3, 2, 3, 2);
            dgvUcitelji.Name = "dgvUcitelji";
            dgvUcitelji.RowHeadersWidth = 51;
            dgvUcitelji.Size = new Size(304, 136);
            dgvUcitelji.TabIndex = 4;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(239, 90);
            btnPretrazi.Margin = new Padding(3, 2, 3, 2);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(110, 22);
            btnPretrazi.TabIndex = 5;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += button1_Click;
            // 
            // btnResetuj
            // 
            btnResetuj.Location = new Point(46, 90);
            btnResetuj.Margin = new Padding(3, 2, 3, 2);
            btnResetuj.Name = "btnResetuj";
            btnResetuj.Size = new Size(101, 22);
            btnResetuj.TabIndex = 6;
            btnResetuj.Text = "Resetuj";
            btnResetuj.UseVisualStyleBackColor = true;
            btnResetuj.Click += btnResetuj_Click;
            // 
            // button1
            // 
            button1.Location = new Point(176, 268);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(173, 22);
            button1.TabIndex = 7;
            button1.Text = "Prikaži izabranog učitelja";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(416, 56);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 9);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 9;
            label3.Text = "Prezime";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(218, 27);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(133, 23);
            txtPrezime.TabIndex = 10;
            // 
            // UCpretraziUcitelja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtPrezime);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(btnResetuj);
            Controls.Add(btnPretrazi);
            Controls.Add(dgvUcitelji);
            Controls.Add(cbSertifikati);
            Controls.Add(txtIme);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCpretraziUcitelja";
            Size = new Size(700, 300);
            Load += UCpretraziUcitelja_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUcitelji).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtIme;
        private ComboBox cbSertifikati;
        private DataGridView dgvUcitelji;
        private Button btnPretrazi;
        private Button btnResetuj;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtPrezime;
    }
}
