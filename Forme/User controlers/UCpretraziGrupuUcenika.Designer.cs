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
            cbKursevi = new ComboBox();
            dgvGrupeUcenika = new DataGridView();
            label1 = new Label();
            btnPretrazi = new Button();
            btnPrikaziGrupu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGrupeUcenika).BeginInit();
            SuspendLayout();
            // 
            // cbKursevi
            // 
            cbKursevi.FlatStyle = FlatStyle.Popup;
            cbKursevi.FormattingEnabled = true;
            cbKursevi.Location = new Point(72, 41);
            cbKursevi.Margin = new Padding(2, 2, 2, 2);
            cbKursevi.Name = "cbKursevi";
            cbKursevi.Size = new Size(328, 28);
            cbKursevi.TabIndex = 0;
            // 
            // dgvGrupeUcenika
            // 
            dgvGrupeUcenika.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupeUcenika.Location = new Point(25, 109);
            dgvGrupeUcenika.Margin = new Padding(2, 2, 2, 2);
            dgvGrupeUcenika.Name = "dgvGrupeUcenika";
            dgvGrupeUcenika.RowHeadersWidth = 82;
            dgvGrupeUcenika.Size = new Size(506, 160);
            dgvGrupeUcenika.TabIndex = 1;
            dgvGrupeUcenika.CellContentClick += dgvGrupeUcenika_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 43);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 2;
            label1.Text = "Kurs";
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(419, 26);
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
            btnPrikaziGrupu.Location = new Point(345, 274);
            btnPrikaziGrupu.Name = "btnPrikaziGrupu";
            btnPrikaziGrupu.Size = new Size(186, 29);
            btnPrikaziGrupu.TabIndex = 4;
            btnPrikaziGrupu.Text = "Prikazi odabranu grupu";
            btnPrikaziGrupu.UseVisualStyleBackColor = true;
            btnPrikaziGrupu.Click += btnPrikaziGrupu_Click;
            // 
            // UCpretraziGrupuUcenika
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPrikaziGrupu);
            Controls.Add(btnPretrazi);
            Controls.Add(label1);
            Controls.Add(dgvGrupeUcenika);
            Controls.Add(cbKursevi);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UCpretraziGrupuUcenika";
            Size = new Size(552, 323);
            Load += UCpretraziGrupuUcenika_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGrupeUcenika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbKursevi;
        private DataGridView dgvGrupeUcenika;
        private Label label1;
        private Button btnPretrazi;
        private Button btnPrikaziGrupu;
    }
}
