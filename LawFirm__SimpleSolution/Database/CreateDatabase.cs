using Microsoft.Data.Sqlite;

namespace LawFirm__SimpleSolution.Database;

public class CreateDatabase
{
    void CreateClients()
    {
        try
        {
            var databaseLocation = "Data Source=LawFirmDatabase.db";
            using (var connection = new SqliteConnection(databaseLocation))
            {
                connection.Open();
                Console.WriteLine("Connected to the Database");

                var createCommand = connection.CreateCommand();

                createCommand.CommandText = @"
                CREATE TABLE IF NOT EXISTS clients (
                    client_id INTEGER PRIMARY KEY,
                    client_name TEXT NOT NULL,
                    client_address TEXT,
                    client_phone TEXT,
                    client_emai TEXT
                ) ";
                createCommand.ExecuteNonQuery();
            
                Console.WriteLine("Created Client Table");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

    }
}