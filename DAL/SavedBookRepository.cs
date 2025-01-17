using BiblioWorld.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace BiblioWorld.DAL
{
    public class SavedBookRepository
    {
        private readonly Database _database = new Database();

        // ✅ Méthode pour sauvegarder un livre
        public void SaveBook(int userId, int bookId)
        {
            using (MySqlConnection conn = _database.GetConnection())
            {
                conn.Open();

                // Vérifie si le livre est déjà sauvegardé
                string checkQuery = "SELECT COUNT(*) FROM saved_books WHERE UserID = @userId AND BookID = @bookId";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@userId", userId);
                    checkCmd.Parameters.AddWithValue("@bookId", bookId);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count == 0)
                    {
                        // Si le livre n'est pas encore sauvegardé, on l'ajoute
                        string insertQuery = "INSERT INTO saved_books (UserID, BookID, SavedAt) VALUES (@userId, @bookId, NOW())";
                        using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@userId", userId);
                            insertCmd.Parameters.AddWithValue("@bookId", bookId);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        // ✅ Méthode pour récupérer les livres sauvegardés
        public List<Book> GetSavedBooks(int userId)
        {
            List<Book> savedBooks = new List<Book>();

            using (MySqlConnection conn = _database.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT b.*
                    FROM saved_books sb
                    JOIN books b ON sb.BookID = b.BookID
                    WHERE sb.UserID = @userId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            savedBooks.Add(new Book
                            {
                                BookID = reader.GetInt32("BookID"),
                                Title = reader.GetString("Title"),
                                AuthorName = reader.GetString("AuthorName"),
                                GenreName = reader.GetString("GenreName"),
                                PublishedYear = reader.GetInt32("PublishedYear"),
                                Summary = reader.GetString("Summary"),
                                image_book_url = reader.GetString("image_book_url"),
                                PurchaseLink = reader.IsDBNull(reader.GetOrdinal("PurchaseLink")) ? null : reader.GetString("PurchaseLink")
                            });
                        }
                    }
                }
            }

            return savedBooks;
        }
    }
}
