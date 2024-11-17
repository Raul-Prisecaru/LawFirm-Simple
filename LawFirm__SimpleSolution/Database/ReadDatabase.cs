using Microsoft.Data.Sqlite;

namespace LawFirm__SimpleSolution.Database;

public class ReadDatabase
{
    // Method for Inserting into Client Table
    public void ReadClientsTable()
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
                command.CommandText = @"SELECT * FROM clients";

                // Executing Query that is not expected to return results
                command.ExecuteNonQuery();

                Console.WriteLine("Inserted into the client table");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("There has been an error that occured: " + e);
        }

    }

    // Method for Inserting into Client Table
    public void ReadCasesTable()
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
                command.CommandText = @"SELECT * FROM cases";


                // Executing Query that is not expected to return results
                command.ExecuteNonQuery();

                Console.WriteLine("Inserted into the Case table");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("There has been an error that occured: " + e);
        }

    }

    public void ReadDocumentTable()
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
                command.CommandText = @"SELECT * FROM documents";

                // Executing Query that is not expected to return results
                command.ExecuteNonQuery();

                Console.WriteLine("Inserted into the Document table");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("There has been an error that occured: " + e);
        }

    }

    public void ReadDateTable()
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
                command.CommandText = @"SELECT * FROM important_dates";

                // Executing Query that is not expected to return results
                command.ExecuteNonQuery();

                Console.WriteLine("Inserted into the Dates table");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("There has been an error that occured: " + e);
        }

    }
}