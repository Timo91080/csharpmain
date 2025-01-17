using MySql.Data.MySqlClient;

namespace BiblioWorld.DAL
{
    public class Database
    {
        private readonly string connectionString = "Server=localhost;Database=biblioworld;User ID=root;Password=;Port=3306;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}