using BiblioWorld.DAL;
using BiblioWorld.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Projet_cours_1
{
    public partial class FormProfil : Form
    {
        private readonly User _currentUser;
        private readonly SavedBookRepository _savedBookRepository;

        public FormProfil(User user)
        {
            InitializeComponent();
            _currentUser = user;
            _savedBookRepository = new SavedBookRepository();

            LoadUserProfile();
            LoadSavedBooks();
        }

        // ✅ Charger les informations du profil
        private void LoadUserProfile()
        {
            lblUsername.Text = $"👤 Nom d'utilisateur : {_currentUser.Username}";
            lblEmail.Text = $"📧 Email : {_currentUser.Email}";
            lblRole.Text = $"🔒 Rôle : {_currentUser.Role}";
        }

        // ✅ Charger les livres sauvegardés
        private void LoadSavedBooks()
        {
            List<Book> savedBooks = _savedBookRepository.GetSavedBooks(_currentUser.UserID);
            flowLayoutPanelSavedBooks.Controls.Clear();

            if (savedBooks.Count == 0)
            {
                Label lblEmpty = new Label
                {
                    Text = "📭 Aucun livre sauvegardé.",
                    Font = new Font("Segoe UI", 10, FontStyle.Italic),
                    AutoSize = true
                };
                flowLayoutPanelSavedBooks.Controls.Add(lblEmpty);
                return;
            }

            foreach (var book in savedBooks)
            {
                Panel card = new Panel
                {
                    Size = new Size(180, 300),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White,
                    Margin = new Padding(10)
                };

                // 🖼️ Image du livre
                PictureBox pbImage = new PictureBox
                {
                    Size = new Size(160, 100),
                    Location = new Point(10, 10),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                try
                {
                    using (var client = new WebClient())
                    {
                        byte[] imgData = client.DownloadData(book.image_book_url);
                        using (var ms = new MemoryStream(imgData))
                        {
                            pbImage.Image = Image.FromStream(ms);
                        }
                    }
                }
                catch
                {
                    pbImage.Image = null;
                }

                // 📖 Titre du livre
                Label lblTitle = new Label
                {
                    Text = book.Title,
                    Location = new Point(10, 120),
                    Size = new Size(160, 40),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold)
                };

                card.Controls.Add(pbImage);
                card.Controls.Add(lblTitle);
                flowLayoutPanelSavedBooks.Controls.Add(card);
            }
        }
    }
}
