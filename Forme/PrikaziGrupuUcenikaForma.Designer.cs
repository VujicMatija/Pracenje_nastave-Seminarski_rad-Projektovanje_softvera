namespace Forme
{
    partial class PrikaziGrupuUcenikaForma
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel = new Panel();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Location = new Point(12, 12);
            panel.Name = "panel";
            panel.Size = new Size(578, 409);
            panel.TabIndex = 0;
            // 
            // PrikaziGrupuUcenikaForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 433);
            Controls.Add(panel);
            Name = "PrikaziGrupuUcenikaForma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrikaziGrupuUcenikaForma";
            Load += PrikaziGrupuUcenikaForma_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
    }
}