using System;
using System.Windows.Forms;

namespace Projet_cours_1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ✅ Lancer l'application avec le formulaire de connexion
            Application.Run(new FormConnexion());
        }
    }
}
