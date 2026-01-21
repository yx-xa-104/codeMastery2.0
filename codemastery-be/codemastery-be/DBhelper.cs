using Npgsql; 
using System;

public void ConnectToPostgres()
{
    string connString = "Host=localhost;Database=codeMastery_db;Username=Postgres;Password=1234;";
    using (var conn = new NpgsqlConnection(connString))
    {
        try
        {
            conn.Open();
            Console.WriteLine("Kết nối thành công!");

            using (var cmd = new NpgsqlCommand("SELECT version();", conn))
            {
                var version = cmd.ExecuteScalar();
                Console.WriteLine($"Phiên bản PostgreSQL: {version}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi kết nối: {ex.Message}");
        }
    }
}
