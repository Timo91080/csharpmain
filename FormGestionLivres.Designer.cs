namespace Projet_cours_1
{
    partial class FormGestionLivres
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewBooks;
        private TextBox txtTitle, txtAuthorName, txtGenreName, txtYear, txtSummary, txtPurchaseLink, txtImageUrl;
        private Button btnAddBook, btnDeleteBook;
        private PictureBox pictureBoxCover;
        private Button btnRefresh;

        private void InitializeComponent()
        {
            this.txtTitle = new TextBox();
            this.txtAuthorName = new TextBox();
            this.txtGenreName = new TextBox();
            this.txtYear = new TextBox();
            this.txtSummary = new TextBox();
            this.txtPurchaseLink = new TextBox();
            this.txtImageUrl = new TextBox();
            this.pictureBoxCover = new PictureBox();
            this.dataGridViewBooks = new DataGridView();
            this.btnAddBook = new Button();
            this.btnDeleteBook = new Button();

            // 📚 DataGridView
            this.dataGridViewBooks.Location = new Point(20, 340);
            this.dataGridViewBooks.Size = new Size(600, 200);

            // 📖 Titre
            this.txtTitle.Location = new Point(20, 20);
            this.txtTitle.PlaceholderText = "Titre";

            // ✍️ Nom de l'Auteur
            this.txtAuthorName = new TextBox();
            this.txtAuthorName.Location = new Point(20, 60);
            this.txtAuthorName.PlaceholderText = "Nom de l'Auteur";

            // 🏷️ Nom du Genre
            this.txtGenreName = new TextBox();
            this.txtGenreName.Location = new Point(20, 100);
            this.txtGenreName.PlaceholderText = "Nom du Genre";


            // 📅 Année
            this.txtYear.Location = new Point(20, 140);
            this.txtYear.PlaceholderText = "Année de publication";

            // 📝 Résumé
            this.txtSummary.Location = new Point(20, 180);
            this.txtSummary.PlaceholderText = "Résumé";

            // 🔗 Lien d'achat
            this.txtPurchaseLink.Location = new Point(20, 220);
            this.txtPurchaseLink.PlaceholderText = "Lien d'achat";

            // 🌐 URL de l'image
            this.txtImageUrl.Location = new Point(20, 260);
            this.txtImageUrl.PlaceholderText = "URL de l'image de couverture";

            // 📷 Image de couverture (prévisualisation)
            this.pictureBoxCover.Location = new Point(300, 20);
            this.pictureBoxCover.Size = new Size(100, 150);
            this.pictureBoxCover.SizeMode = PictureBoxSizeMode.StretchImage;

            // ➕ Ajouter un livre
            this.btnAddBook.Text = "Ajouter";
            this.btnAddBook.Location = new Point(20, 300);
            this.btnAddBook.Click += new EventHandler(this.btnAddBook_Click);

            // ❌ Supprimer un livre
            this.btnDeleteBook.Text = "Supprimer";
            this.btnDeleteBook.Location = new Point(120, 300);
            this.btnDeleteBook.Click += new EventHandler(this.btnDeleteBook_Click);

            // 🔄 Bouton Actualiser
            this.btnRefresh = new Button();
            this.btnRefresh.Text = "Actualiser";
            this.btnRefresh.Location = new Point(220, 300);
            this.btnRefresh.Size = new Size(100, 30);
            this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);


            // ✅ Ajouter les composants au formulaire
            this.Controls.Add(txtTitle);
            this.Controls.Add(txtAuthorName);
            this.Controls.Add(txtGenreName);
            this.Controls.Add(txtYear);
            this.Controls.Add(txtSummary);
            this.Controls.Add(txtPurchaseLink);
            this.Controls.Add(txtImageUrl);
            this.Controls.Add(pictureBoxCover);
            this.Controls.Add(btnAddBook);
            this.Controls.Add(btnDeleteBook);
            this.Controls.Add(dataGridViewBooks);
            this.Controls.Add(btnRefresh);
            // 🖼️ Formulaire
            this.Text = "Gestion des Livres";
            this.ClientSize = new Size(700, 600);
        }
    }
}
