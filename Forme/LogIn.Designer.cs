namespace Forme
{
    partial class LogIn
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
            label1 = new Label();
            label2 = new Label();
            txtKorisnickoIme = new TextBox();
            txtLozinka = new TextBox();
            btnPrijava = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 60);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 102);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Lozinka: ";
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.Location = new Point(214, 57);
            txtKorisnickoIme.Name = "txtKorisnickoIme";
            txtKorisnickoIme.Size = new Size(168, 27);
            txtKorisnickoIme.TabIndex = 2;
            txtKorisnickoIme.Text = "vujicmatija";
            // 
            // txtLozinka
            // 
            txtLozinka.Location = new Point(214, 102);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.PasswordChar = '*';
            txtLozinka.Size = new Size(168, 27);
            txtLozinka.TabIndex = 3;
            txtLozinka.Text = "vm123";
            // 
            // btnPrijava
            // 
            btnPrijava.Location = new Point(136, 152);
            btnPrijava.Name = "btnPrijava";
            btnPrijava.Size = new Size(125, 54);
            btnPrijava.TabIndex = 4;
            btnPrijava.Text = "Prijavi se";
            btnPrijava.UseVisualStyleBackColor = true;
            btnPrijava.Click += btnPrijava_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 272);
            Controls.Add(btnPrijava);
            Controls.Add(txtLozinka);
            Controls.Add(txtKorisnickoIme);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Default;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKorisnickoIme;
        private TextBox txtLozinka;
        private Button btnPrijava;
    }
}