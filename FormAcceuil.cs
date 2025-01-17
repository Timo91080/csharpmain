using BiblioWorld.BLL;
using BiblioWorld.DAL;
using BiblioWorld.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Projet_cours_1
{
    public partial class FormAccueil : Form
    {
        private readonly BookService _bookService;
        private readonly SavedBookRepository _savedBookRepository;
        private readonly User _currentUser;

        // ✅ ComboBox pour filtrer
        private ComboBox cmbAuthorFilter;
        private ComboBox cmbGenreFilter;

        public FormAccueil(User user)
        {
            InitializeComponent();
            _currentUser = user;
            _bookService = new BookService();
            _savedBookRepository = new SavedBookRepository();

            InitializeProfileButton();
            InitializeLogoutButton();
         
            InitializeFilterControls();  // ✅ Ajouter les filtres

            if (_currentUser.Role == "Admin")
            {
                InitializeGestionButton();
            }

            LoadBooks();
            LoadFilters();  // ✅ Charger les données des filtres
        }

        // ✅ Bouton "Mon Profil"
        private void InitializeProfileButton()
        {
            Button btnProfile = new Button
            {
                Text = "👤 Mon Profil",
                Location = new Point(10, 10),
                Size = new Size(150, 30),
                BackColor = Color.LightBlue
            };

            btnProfile.Click += BtnProfile_Click;
            this.Controls.Add(btnProfile);
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            FormProfil formProfil = new FormProfil(_currentUser);
            formProfil.Show();
        }

        // ✅ Bouton "Gestion des Livres" pour l'Admin
        private void InitializeGestionButton()
        {
            Button btnGestionLivres = new Button
            {
                Text = "📚 Gestion des Livres",
                Location = new Point(180, 10),
                Size = new Size(170, 30),
                BackColor = Color.Orange
            };

            btnGestionLivres.Click += BtnGestionLivres_Click;
            this.Controls.Add(btnGestionLivres);
        }

        private void BtnGestionLivres_Click(object sender, EventArgs e)
        {
            FormGestionLivres gestionLivresForm = new FormGestionLivres(_currentUser, this);
            gestionLivresForm.Show();
        }

        // ✅ Charger les livres
        public void LoadBooks()
        {
            List<Book> books = _bookService.GetBooks();
            DisplayBooks(books);
        }

        // ✅ Affichage des livres
        private void DisplayBooks(List<Book> books)
        {
            flowLayoutPanelBooks.Controls.Clear();

            foreach (var book in books)
            {
                Panel card = new Panel
                {
                    Size = new Size(180, 350),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White,
                    Margin = new Padding(10)
                };

                PictureBox pbImage = new PictureBox
                {
                    Size = new Size(160, 100),
                    Location = new Point(10, 10),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Cursor = Cursors.Hand
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

                pbImage.Click += (s, e) =>
                {
                    FormLivreDetail detailForm = new FormLivreDetail(book);
                    detailForm.Show();
                };

                Label lblTitle = new Label
                {
                    Text = book.Title,
                    Location = new Point(10, 120),
                    Size = new Size(160, 20),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold)
                };

                Button btnSave = new Button
                {
                    Text = "📌 Sauvegarder",
                    Location = new Point(10, 150),
                    Size = new Size(160, 30),
                    Tag = book.BookID
                };

                btnSave.Click += (s, e) =>
                {
                    int bookId = (int)((Button)s).Tag;
                    _savedBookRepository.SaveBook(_currentUser.UserID, bookId);
                    MessageBox.Show($"📖 Livre '{book.Title}' sauvegardé !");
                };

                card.Controls.Add(pbImage);
                card.Controls.Add(lblTitle);
                card.Controls.Add(btnSave);
                flowLayoutPanelBooks.Controls.Add(card);
            }
        }

        // ✅ Bouton "Réinitialiser"
      


        // ✅ Bouton "Déconnexion"
        private void InitializeLogoutButton()
        {
            Button btnLogout = new Button
            {
                Text = "🚪 Déconnexion",
                Location = new Point(370, 10),
                Size = new Size(150, 30),
                BackColor = Color.Red,
                ForeColor = Color.White
            };

            btnLogout.Click += BtnLogout_Click;
            this.Controls.Add(btnLogout);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Voulez-vous vraiment vous déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                this.Hide();
                FormConnexion formConnexion = new FormConnexion();
                formConnexion.Show();
            }
        }

        // ✅ Initialisation des filtres
        private void InitializeFilterControls()
        {
            cmbAuthorFilter = new ComboBox
            {
                Location = new Point(10, 50),
                Size = new Size(150, 25)
            };
            cmbGenreFilter = new ComboBox
            {
                Location = new Point(180, 50),
                Size = new Size(150, 25)
            };

            cmbAuthorFilter.SelectedIndexChanged += (s, e) => ApplyFilters();
            cmbGenreFilter.SelectedIndexChanged += (s, e) => ApplyFilters();

            this.Controls.Add(cmbAuthorFilter);
            this.Controls.Add(cmbGenreFilter);

            LoadFilters();
        }

       private void LoadFilters()
{
            cmbAuthorFilter.Items.Clear();
            cmbGenreFilter.Items.Clear();

            cmbAuthorFilter.Items.Add("Tous");
            cmbGenreFilter.Items.Add("Tous");

    // ✅ Charger les auteurs depuis la base de données
    var authors = _bookService.GetAuthors();
    foreach (var author in authors)
    {
                cmbAuthorFilter.Items.Add(author);
    }

    // ✅ Charger les genres depuis la base de données
    var genres = _bookService.GetGenres();
    foreach (var genre in genres)
    {
                cmbGenreFilter.Items.Add(genre);
    }

            cmbAuthorFilter.SelectedIndex = 0;
            cmbGenreFilter.SelectedIndex = 0;
}


        private void ApplyFilters()
        {
            string selectedAuthor = cmbAuthorFilter.SelectedItem?.ToString();
            string selectedGenre = cmbGenreFilter.SelectedItem?.ToString();

            if (selectedAuthor == "Tous") selectedAuthor = null;
            if (selectedGenre == "Tous") selectedGenre = null;

            var filteredBooks = _bookService.FilterBooks(selectedAuthor, selectedGenre);
            DisplayBooks(filteredBooks);
        }



        private void buttonSearch_Click(object sender, EventArgs e)
{
    string query = textBoxSearch.Text.Trim();
    if (string.IsNullOrEmpty(query))
    {
        LoadBooks();
        return;
    }

    var results = _bookService.GetBooks().Where(b => b.Title.Contains(query)).ToList();
    DisplayBooks(results);
}


       

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            var selectedAuthor = cmbAuthorFilter.SelectedItem?.ToString();
            var selectedGenre = cmbGenreFilter.SelectedItem?.ToString();

            var filteredBooks = _bookService.FilterBooks(selectedAuthor, selectedGenre);
            DisplayBooks(filteredBooks);
        }
    }
}
