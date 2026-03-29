namespace TestWins.Model;

// dotnet add package MySql.Data
using MySql.Data.MySqlClient;

public class ConnectionSql
{
    private readonly string _connectionString = "server=localhost;database=student;uid=root;pwd=root";
    private MySqlConnection _conn;

    public MySqlConnection connectSql()
    {
        Console.WriteLine("Connecting to DB");

        _conn = new MySqlConnection(_connectionString);

        try
        {
            _conn.Open();
            Console.WriteLine("Database connection successful");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Database connection failed: " + ex.Message);
        }

        return _conn;
    }

    public void closeSql()
    {
        if (_conn != null && _conn.State == System.Data.ConnectionState.Open)
        {
            _conn.Close();
            Console.WriteLine("Database connection closed");
        }
    }
}
