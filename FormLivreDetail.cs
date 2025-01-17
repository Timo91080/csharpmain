using BiblioWorld.Models;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Projet_cours_1
{
    public partial class FormLivreDetail : Form
    {
        private readonly Book _book;

        public FormLivreDetail(Book book)
        {
            InitializeComponent();
            _book = book;
            LoadBookDetails();
        }

        // ✅ Chargement des détails du livre
        private void LoadBookDetails()
        {
            lblTitle.Text = _book.Title;
            lblAuthor.Text = $"Auteur : {_book.AuthorName}";
            lblGenre.Text = $"Genre : {_book.GenreName}";
            lblYear.Text = $"Année : {_book.PublishedYear}";
            txtSummary.Text = _book.Summary;

            // 🖼️ Charger l'image du livre
            try
            {
                using (var client = new WebClient())
                {
                    byte[] imgData = client.DownloadData(_book.image_book_url);
                    using (var ms = new MemoryStream(imgData))
                    {
                        pbCover.Image = Image.FromStream(ms);
                    }
                }
            }
            catch
            {
                pbCover.Image = null;
            }

            // 🔗 Lien d'achat
            if (!string.IsNullOrEmpty(_book.PurchaseLink))
            {
                lblPurchaseLink.Text = "📦 Acheter ce livre";
                lblPurchaseLink.ForeColor = Color.Blue;
                lblPurchaseLink.Cursor = Cursors.Hand;
                lblPurchaseLink.Click += (s, e) =>
                {
                    Process.Start(new ProcessStartInfo(_book.PurchaseLink) { UseShellExecute = true });
                };
            }
        }
    }
}
