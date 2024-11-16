using Microsoft.Data.Sqlite;

namespace LawFirm__SimpleSolution.Database;

public class CreateDatabase
{
    // Method for creating Client Table
    void CreateClients()
    {
        // Error Handling
        try
        {
            // Defining Location of the Database
            var databaseLocation = "Data Source=LawFirmDatabase.db";
            // Creating an instance of the db and Close the db once done
            using (var connection = new SqliteConnection(databaseLocation))
            {
                // Connecting to the Database
                connection.Open();
                Console.WriteLine("Connected to the Database");
                
                // Instance of SQLite Command Object
                var command = connection.CreateCommand();
                
                // SQL Query to Create Table
                command.CommandText = @"
                CREATE TABLE IF NOT EXISTS clients (
                    client_id INTEGER PRIMARY KEY,
                    client_name TEXT NOT NULL,
                    client_address TEXT,
                    client_phone TEXT,
                    client_emai TEXT
                ) ";
                
                // Executing Query that is not expected to return results
                command.ExecuteNonQuery();
            
                Console.WriteLine("Created Client Table");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("There has been an error that occured: " + e);
        }

    }
}