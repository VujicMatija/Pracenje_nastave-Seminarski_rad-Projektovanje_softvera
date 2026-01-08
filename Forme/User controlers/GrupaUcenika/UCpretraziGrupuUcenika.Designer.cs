namespace Forme.User_controlers
{
    partial class UCpretraziGrupuUcenika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCpretraziGrupuUcenika));
            cbKursevi = new ComboBox();
            dgvGrupeUcenika = new DataGridView();
            label1 = new Label();
            btnPretrazi = new Button();
            btnPrikaziGrupu = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvGrupeUcenika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbKursevi
            // 
            cbKursevi.FlatStyle = FlatStyle.Popup;
            cbKursevi.FormattingEnabled = true;
            cbKursevi.Location = new Point(130, 62);
            cbKursevi.Margin = new Padding(2, 2, 2, 2);
            cbKursevi.Name = "cbKursevi";
            cbKursevi.Size = new Size(328, 28);
            cbKursevi.TabIndex = 0;
            // 
            // dgvGrupeUcenika
            // 
            dgvGrupeUcenika.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupeUcenika.Location = new Point(23, 126);
            dgvGrupeUcenika.Margin = new Padding(2, 2, 2, 2);
            dgvGrupeUcenika.Name = "dgvGrupeUcenika";
            dgvGrupeUcenika.RowHeadersWidth = 82;
            dgvGrupeUcenika.Size = new Size(560, 160);
            dgvGrupeUcenika.TabIndex = 1;
            dgvGrupeUcenika.CellContentClick += dgvGrupeUcenika_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 64);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 2;
            label1.Text = "Kurs";
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(477, 48);
            btnPretrazi.Margin = new Padding(2, 2, 2, 2);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(106, 56);
            btnPretrazi.TabIndex = 3;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // btnPrikaziGrupu
            // 
            btnPrikaziGrupu.Location = new Point(388, 311);
            btnPrikaziGrupu.Name = "btnPrikaziGrupu";
            btnPrikaziGrupu.Size = new Size(194, 54);
            btnPrikaziGrupu.TabIndex = 4;
            btnPrikaziGrupu.Text = "Prikazi odabranu grupu";
            btnPrikaziGrupu.UseVisualStyleBackColor = true;
            btnPrikaziGrupu.Click += btnPrikaziGrupu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(598, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // UCpretraziGrupuUcenika
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(btnPrikaziGrupu);
            Controls.Add(btnPretrazi);
            Controls.Add(label1);
            Controls.Add(dgvGrupeUcenika);
            Controls.Add(cbKursevi);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UCpretraziGrupuUcenika";
            Size = new Size(800, 400);
            Load += UCpretraziGrupuUcenika_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGrupeUcenika).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbKursevi;
        private DataGridView dgvGrupeUcenika;
        private Label label1;
        private Button btnPretrazi;
        private Button btnPrikaziGrupu;
        private PictureBox pictureBox1;
    }
}
