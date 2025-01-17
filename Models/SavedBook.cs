namespace BiblioWorld.Models
{
    public class SavedBook
    {
        public int SaveID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public string ImageUrl { get; set; }  // ✅ Ajout de l'image
        public DateTime SavedAt { get; set; }
    }
}
