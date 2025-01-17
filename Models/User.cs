namespace BiblioWorld.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }  // Admin ou Lecteur
        public string Email { get; set; } // ✅ Champ Email ajouté
    }
}
