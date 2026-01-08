namespace Forme.User_controlers
{
    partial class UCdodajUcenikGrupa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCdodajUcenikGrupa));
            dgvTrenutni = new DataGridView();
            txtImePrezime = new TextBox();
            label1 = new Label();
            btnPretrazi = new Button();
            dgvRaspolozivi = new DataGridView();
            button1 = new Button();
            lblGrupa = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTrenutni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRaspolozivi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvTrenutni
            // 
            dgvTrenutni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrenutni.Location = new Point(312, 110);
            dgvTrenutni.Margin = new Padding(2, 2, 2, 2);
            dgvTrenutni.Name = "dgvTrenutni";
            dgvTrenutni.RowHeadersWidth = 82;
            dgvTrenutni.Size = new Size(279, 277);
            dgvTrenutni.TabIndex = 0;
            // 
            // txtImePrezime
            // 
            txtImePrezime.Location = new Point(19, 110);
            txtImePrezime.Margin = new Padding(2, 2, 2, 2);
            txtImePrezime.Name = "txtImePrezime";
            txtImePrezime.Size = new Size(169, 27);
            txtImePrezime.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 76);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 2;
            label1.Text = "Pretraga učenika po imenu";
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(201, 108);
            btnPretrazi.Margin = new Padding(2, 2, 2, 2);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(92, 29);
            btnPretrazi.TabIndex = 3;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += button1_Click;
            // 
            // dgvRaspolozivi
            // 
            dgvRaspolozivi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRaspolozivi.Location = new Point(19, 153);
            dgvRaspolozivi.Margin = new Padding(2, 2, 2, 2);
            dgvRaspolozivi.Name = "dgvRaspolozivi";
            dgvRaspolozivi.RowHeadersWidth = 82;
            dgvRaspolozivi.Size = new Size(274, 234);
            dgvRaspolozivi.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(19, 402);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(185, 29);
            button1.TabIndex = 5;
            button1.Text = "Dodaj učenika u grupi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // lblGrupa
            // 
            lblGrupa.AutoSize = true;
            lblGrupa.Location = new Point(312, 76);
            lblGrupa.Margin = new Padding(2, 0, 2, 0);
            lblGrupa.Name = "lblGrupa";
            lblGrupa.Size = new Size(104, 20);
            lblGrupa.TabIndex = 6;
            lblGrupa.Text = "Učenici grupe ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(596, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // UCdodajUcenikGrupa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(lblGrupa);
            Controls.Add(button1);
            Controls.Add(dgvRaspolozivi);
            Controls.Add(btnPretrazi);
            Controls.Add(label1);
            Controls.Add(txtImePrezime);
            Controls.Add(dgvTrenutni);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UCdodajUcenikGrupa";
            Size = new Size(810, 485);
            Load += UCdodajUcenikGrupa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTrenutni).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRaspolozivi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTrenutni;
        private TextBox txtImePrezime;
        private Label label1;
        private Button btnPretrazi;
        private DataGridView dgvRaspolozivi;
        private Button button1;
        private Label lblGrupa;
        private PictureBox pictureBox1;
    }
}
