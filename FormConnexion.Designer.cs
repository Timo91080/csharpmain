namespace Projet_cours_1
{
    partial class FormConnexion
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblUsername;
        private Label lblPassword;

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
            this.txtUsername = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.lblUsername = new Label();
            this.lblPassword = new Label();

            // 🔤 Label Nom d'utilisateur
            this.lblUsername.Text = "Nom d'utilisateur :";
            this.lblUsername.Location = new System.Drawing.Point(30, 30);
            this.lblUsername.Size = new System.Drawing.Size(120, 20);

            // 📝 TextBox Nom d'utilisateur
            this.txtUsername.Location = new System.Drawing.Point(160, 30);
            this.txtUsername.Size = new System.Drawing.Size(200, 23);

            // 🔒 Label Mot de passe
            this.lblPassword.Text = "Mot de passe :";
            this.lblPassword.Location = new System.Drawing.Point(30, 70);
            this.lblPassword.Size = new System.Drawing.Size(120, 20);

            // 📝 TextBox Mot de passe
            this.txtPassword.Location = new System.Drawing.Point(160, 70);
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.PasswordChar = '*';

            // 🔑 Bouton Connexion
            this.btnLogin.Text = "Se connecter";
            this.btnLogin.Location = new System.Drawing.Point(160, 110);
            this.btnLogin.Size = new System.Drawing.Size(100, 30);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // ✅ Configuration du Formulaire
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Text = "Connexion - BiblioWorld";
        }
    }
}
