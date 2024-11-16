using Microsoft.Data.Sqlite;

namespace LawFirm__SimpleSolution.Database;

public class CreateDatabase
{
    void Database()
    {
        var databaseLocation = "Data Source=test.db";
        using (var connection = new SqliteConnection(databaseLocation))
        {
            connection.Open();
            Console.WriteLine("Connected to the Database");
        }
    }
}