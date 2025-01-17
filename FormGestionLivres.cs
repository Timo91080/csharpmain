using BiblioWorld.BLL;
using BiblioWorld.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projet_cours_1
{
    public partial class FormGestionLivres : Form
    {
        private readonly BookService _bookService;
        private readonly FormAccueil _formAccueil;  // ✅ Référence vers FormAccueil

        public FormGestionLivres(User user, FormAccueil formAccueil)
        {
            InitializeComponent();
            _bookService = new BookService();
            _formAccueil = formAccueil;  // ✅ Initialisation de la référence

            if (user.Role != "Admin")
            {
                MessageBox.Show("Accès réservé aux administrateurs.");
                this.Close();
            }

            LoadBooks();
        }

        // ✅ Charger les livres dans DataGridView
        private void LoadBooks()
        {
            dataGridViewBooks.DataSource = _bookService.GetBooks();
            dataGridViewBooks.Columns["BookID"].Visible = false;
        }

        // ✅ Ajouter un livre
        // ✅ Ajouter un livre avec le nom de l'auteur et du genre
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthorName.Text) ||
                string.IsNullOrWhiteSpace(txtGenreName.Text) ||
                string.IsNullOrWhiteSpace(txtYear.Text) ||
                string.IsNullOrWhiteSpace(txtImageUrl.Text))
            {
                MessageBox.Show("⚠️ Tous les champs doivent être remplis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtYear.Text, out int publishedYear))
            {
                MessageBox.Show("⚠️ L'année de publication doit être un nombre valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Book newBook = new Book
            {
                Title = txtTitle.Text,
                AuthorName = txtAuthorName.Text,
                GenreName = txtGenreName.Text,
                PublishedYear = publishedYear,
                Summary = txtSummary.Text,
                image_book_url = txtImageUrl.Text,
                PurchaseLink = txtPurchaseLink.Text
            };

            _bookService.AddBook(newBook);
            MessageBox.Show("📚 Livre ajouté avec succès !");
            LoadBooks();
            ClearFields();
        }

        // ✅ Supprimer un livre
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                int bookId = Convert.ToInt32(dataGridViewBooks.SelectedRows[0].Cells["BookID"].Value);
                var confirmation = MessageBox.Show("Voulez-vous supprimer ce livre ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    _bookService.DeleteBook(bookId);
                    MessageBox.Show("❌ Livre supprimé !");
                    LoadBooks();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un livre à supprimer.");
            }
        }

        // ✅ Bouton Actualiser
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBooks();
            _formAccueil.LoadBooks();  // ✅ Actualise les livres dans FormAccueil
            MessageBox.Show("🔄 La liste des livres a été actualisée !");
        }

        // ✅ Réinitialiser les champs
        private void ClearFields()
        {
            txtTitle.Clear();
            txtAuthorName.Clear();
            txtGenreName.Clear();
            txtYear.Clear();
            txtSummary.Clear();
            txtPurchaseLink.Clear();
            txtImageUrl.Clear();
            pictureBoxCover.Image = null;
        }
    }
}
