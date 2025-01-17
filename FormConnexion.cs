using BiblioWorld.DAL;
using BiblioWorld.Models;
using System;
using System.Windows.Forms;

namespace Projet_cours_1
{
    public partial class FormConnexion : Form
    {
        private readonly UserRepository _userRepository;

        public FormConnexion()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        // ✅ Méthode de connexion
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez entrer un nom d'utilisateur et un mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user = _userRepository.AuthenticateUser(username, password);

            if (user != null)
            {
                MessageBox.Show($"✅ Connexion réussie ! Bienvenue {user.Username}.");
                FormAccueil formAccueil = new FormAccueil(user);
                formAccueil.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("❌ Nom d'utilisateur ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
