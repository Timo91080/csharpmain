using BiblioWorld.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace BiblioWorld.DAL
{
    public class BookRepository
    {
        private readonly string _connectionString = "Server=localhost;Database=BiblioWorld;Uid=root;Pwd=;";

        public List<Book> GetAllBooks()
        {
            var books = new List<Book>();

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Books";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    books.Add(new Book
                    {
                        BookID = reader.GetInt32("BookID"),
                        Title = reader.GetString("Title"),
                        AuthorName = reader.GetString("AuthorName"),
                        GenreName = reader.GetString("GenreName"),
                        PublishedYear = reader.GetInt32("PublishedYear"),
                        Summary = reader.GetString("Summary"),
                        image_book_url = reader.GetString("image_book_url"),
                        PurchaseLink = reader.GetString("PurchaseLink")
                    });
                }
            }

            return books;
        }


        // ✅ Récupérer les auteurs uniques
        public List<string> GetAuthors()
        {
            List<string> authors = new List<string>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                string query = "SELECT DISTINCT AuthorName FROM Books WHERE AuthorName IS NOT NULL AND AuthorName <> ''";
                using (var command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            authors.Add(reader.GetString("AuthorName"));
                        }
                    }
                }
            }
            return authors;
        }

        // ✅ Récupérer les genres uniques
        public List<string> GetGenres()
        {
            List<string> genres = new List<string>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                string query = "SELECT DISTINCT GenreName FROM Books WHERE GenreName IS NOT NULL AND GenreName <> ''";
                using (var command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            genres.Add(reader.GetString("GenreName"));
                        }
                    }
                }
            }
            return genres;
        }
        // ✅ Filtrer les livres par Auteur et Genre
        public List<Book> FilterBooks(string authorName, string genreName)
        {
            List<Book> books = new List<Book>();
            string query = "SELECT * FROM Books WHERE 1=1";

            if (!string.IsNullOrEmpty(authorName))
                query += " AND AuthorName = @AuthorName";

            if (!string.IsNullOrEmpty(genreName))
                query += " AND GenreName = @GenreName";

            using (var connection = new MySqlConnection(_connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(authorName))
                        command.Parameters.AddWithValue("@AuthorName", authorName);

                    if (!string.IsNullOrEmpty(genreName))
                        command.Parameters.AddWithValue("@GenreName", genreName);

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book
                            {
                                BookID = reader.GetInt32("BookID"),
                                Title = reader.GetString("Title"),
                                PublishedYear = reader.GetInt32("PublishedYear"),
                                Summary = reader.GetString("Summary"),
                                image_book_url = reader.GetString("image_book_url"),
                                PurchaseLink = reader.GetString("PurchaseLink"),
                                AuthorName = reader.GetString("AuthorName"),
                                GenreName = reader.GetString("GenreName")
                            });
                        }
                    }
                }
            }
            return books;
        }


public void AddBook(Book book)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO Books (Title, AuthorName, GenreName, PublishedYear, Summary, image_book_url, PurchaseLink) 
                                 VALUES (@Title, @AuthorName, @GenreName, @PublishedYear, @Summary, @imageUrl, @PurchaseLink)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@AuthorName", book.AuthorName);
                cmd.Parameters.AddWithValue("@GenreName", book.GenreName);
                cmd.Parameters.AddWithValue("@PublishedYear", book.PublishedYear);
                cmd.Parameters.AddWithValue("@Summary", book.Summary);
                cmd.Parameters.AddWithValue("@imageUrl", book.image_book_url);
                cmd.Parameters.AddWithValue("@PurchaseLink", book.PurchaseLink);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteBook(int bookId)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Books WHERE BookID = @BookID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@BookID", bookId);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
