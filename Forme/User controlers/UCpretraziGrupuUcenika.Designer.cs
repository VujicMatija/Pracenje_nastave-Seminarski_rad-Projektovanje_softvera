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
            ((System.ComponentModel.ISupportInitialize)dgvGrupeUcenika).BeginInit();
            SuspendLayout();
            // 
            // cbKursevi
            // 
            cbKursevi.FlatStyle = FlatStyle.Popup;
            cbKursevi.FormattingEnabled = true;
            cbKursevi.Location = new Point(117, 66);
            cbKursevi.Name = "cbKursevi";
            cbKursevi.Size = new Size(530, 40);
            cbKursevi.TabIndex = 0;
            // 
            // dgvGrupeUcenika
            // 
            dgvGrupeUcenika.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupeUcenika.Location = new Point(40, 174);
            dgvGrupeUcenika.Name = "dgvGrupeUcenika";
            dgvGrupeUcenika.RowHeadersWidth = 82;
            dgvGrupeUcenika.Size = new Size(823, 256);
            dgvGrupeUcenika.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 69);
            label1.Name = "label1";
            label1.Size = new Size(60, 32);
            label1.TabIndex = 2;
            label1.Text = "Kurs";
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(681, 41);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(173, 89);
            btnPretrazi.TabIndex = 3;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // UCpretraziGrupuUcenika
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPretrazi);
            Controls.Add(label1);
            Controls.Add(dgvGrupeUcenika);
            Controls.Add(cbKursevi);
            Name = "UCpretraziGrupuUcenika";
            Size = new Size(897, 517);
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
    }
}
