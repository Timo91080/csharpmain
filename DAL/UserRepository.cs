using BiblioWorld.Models;
using MySql.Data.MySqlClient;

namespace BiblioWorld.DAL
{
    public class UserRepository
    {
        private readonly string _connectionString = "Server=localhost;Database=biblioworld;User ID=root;Password=;";

        public User AuthenticateUser(string username, string password)
        {
            User user = null;

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE Username = @username AND Password = @password";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User
                            {
                                UserID = reader.GetInt32("UserID"),
                                Username = reader.GetString("Username"),
                                Password = reader.GetString("Password"),
                                Role = reader.GetString("Role")
                            };
                        }
                    }
                }
            }
            return user;
        }
    }
}
