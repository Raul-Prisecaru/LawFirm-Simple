using Microsoft.Data.Sqlite;

namespace LawFirm__SimpleSolution.Database;

public class CreateDatabase
{
    // Method for creating Client Table
    void CreateClientsTable()
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
    
    void CreateCasesTable()
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
                CREATE TABLE IF NOT EXISTS cases (
                    case_id INTEGER PRIMARY KEY,
                    case_number TEXT UNIQUE,
                    case_title TEXT NOT NULL,
                    case_description TEXT,
                    case_status TEXT,
                    date_filed DATE,
                    date_closed DATE,
                    client_id INTEGER
                    FOREIGN KEY (client_id) REFERENCES clients(client_id) ON DELETE SET NULL
                ) ";
                
                // Executing Query that is not expected to return results
                command.ExecuteNonQuery();
            
                Console.WriteLine("Created Cases Table");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("There has been an error that occured: " + e);
        }

    }
    
    void CreateLegalDocumentsTable()
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
                CREATE TABLE IF NOT EXISTS documents (
                    document_id INTEGER PRIMARY KEY,
                    case_id INTEGER,
                    document_name TEXT NOT NULL,
                    document_type TEXT,
                    document_path TEXT,
                    FOREIGN KEY (case_id) REFERENCES cases(case_id) ON DELETE CASCADE
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
    
    void CreateDatesTable()
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
                CREATE TABLE IF NOT EXISTS important_dates (
                    date_id INTEGER PRIMARY KEY,
                    case_id INTEGER,
                    event_date DATE,
                    event_description TEXT,
                    FOREIGN KEY (case_id) REFERENCES cases(case_id) ON DELETE CASCADE
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