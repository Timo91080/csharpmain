namespace Projet_cours_1
{
    partial class FormProfil
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblUsername;
        private Label lblEmail;
        private Label lblRole;
        private FlowLayoutPanel flowLayoutPanelSavedBooks;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUsername = new Label();
            this.lblEmail = new Label();
            this.lblRole = new Label();
            this.flowLayoutPanelSavedBooks = new FlowLayoutPanel();

            // ✅ Label Nom d'utilisateur
            this.lblUsername.Location = new Point(20, 20);
            this.lblUsername.Size = new Size(300, 25);
            this.lblUsername.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // ✅ Label Email
            this.lblEmail.Location = new Point(20, 50);
            this.lblEmail.Size = new Size(300, 25);
            this.lblEmail.Font = new Font("Segoe UI", 10);

            // ✅ Label Rôle
            this.lblRole.Location = new Point(20, 80);
            this.lblRole.Size = new Size(300, 25);
            this.lblRole.Font = new Font("Segoe UI", 10);

            // ✅ FlowLayoutPanel pour les livres sauvegardés
            this.flowLayoutPanelSavedBooks.Location = new Point(20, 120);
            this.flowLayoutPanelSavedBooks.Size = new Size(600, 400);
            this.flowLayoutPanelSavedBooks.AutoScroll = true;
            this.flowLayoutPanelSavedBooks.BackColor = Color.WhiteSmoke;

            // ✅ FormProfil
            this.ClientSize = new Size(800, 600);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.flowLayoutPanelSavedBooks);
            this.Text = "Mon Profil";
        }
    }
}
