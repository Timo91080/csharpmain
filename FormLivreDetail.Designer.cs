namespace Projet_cours_1
{
    partial class FormLivreDetail
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblGenre;
        private Label lblYear;
        private TextBox txtSummary;
        private PictureBox pbCover;
        private Label lblPurchaseLink;

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
            this.lblTitle = new Label();
            this.lblAuthor = new Label();
            this.lblGenre = new Label();
            this.lblYear = new Label();
            this.txtSummary = new TextBox();
            this.pbCover = new PictureBox();
            this.lblPurchaseLink = new Label();

            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();

            // 📖 Titre
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.Location = new Point(200, 20);
            this.lblTitle.Size = new Size(400, 40);

            // ✍️ Auteur
            this.lblAuthor.Location = new Point(200, 70);
            this.lblAuthor.Size = new Size(400, 20);

            // 🏷️ Genre
            this.lblGenre.Location = new Point(200, 100);
            this.lblGenre.Size = new Size(400, 20);

            // 📅 Année de publication
            this.lblYear.Location = new Point(200, 130);
            this.lblYear.Size = new Size(400, 20);

            // 📝 Résumé
            this.txtSummary.Location = new Point(200, 160);
            this.txtSummary.Size = new Size(400, 150);
            this.txtSummary.Multiline = true;
            this.txtSummary.ReadOnly = true;
            this.txtSummary.ScrollBars = ScrollBars.Vertical;

            // 🖼️ Image du livre
            this.pbCover.Location = new Point(20, 20);
            this.pbCover.Size = new Size(150, 220);
            this.pbCover.SizeMode = PictureBoxSizeMode.StretchImage;

            // 🔗 Lien d'achat
            this.lblPurchaseLink.Location = new Point(200, 320);
            this.lblPurchaseLink.Size = new Size(400, 30);
            this.lblPurchaseLink.Font = new Font("Segoe UI", 10F, FontStyle.Underline);

            // ⚙️ FormLivreDetail
            this.ClientSize = new Size(640, 380);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.pbCover);
            this.Controls.Add(this.lblPurchaseLink);
            this.Text = "Détails du Livre";

            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
