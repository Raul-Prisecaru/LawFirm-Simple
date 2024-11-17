using Microsoft.Data.Sqlite;

namespace LawFirm__SimpleSolution.Database;

public class InsertDatabase
{
    // Method for Inserting into Client Table
    public void InsertClientsTable(String clientName, String clientAddress, String clientPhone, String clientEmail)
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
                    INSERT INTO clients (client_name, client_address, client_phone, client_emai) VALUES (@client_name, @client_address, @client_phone, @client_email)";

                command.Parameters.AddWithValue("@client_name", clientName);
                command.Parameters.AddWithValue("@client_address", clientAddress);
                command.Parameters.AddWithValue("@client_phone", clientPhone);
                command.Parameters.AddWithValue("@client_email", clientEmail);

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
    
    // public void CreateCasesTable()
    // {
    //     // Error Handling
    //     try
    //     {
    //         // Defining Location of the Database
    //         var databaseLocation = "Data Source=LawFirmDatabase.db";
    //         // Creating an instance of the db and Close the db once done
    //         using (var connection = new SqliteConnection(databaseLocation))
    //         {
    //             // Connecting to the Database
    //             connection.Open();
    //             Console.WriteLine("Connected to the Database");
    //
    //             // Instance of SQLite Command Object
    //             var command = connection.CreateCommand();
    //
    //             // SQL Query to Create Table
    //             command.CommandText = @"
    //             CREATE TABLE IF NOT EXISTS cases (
    //                 case_id INTEGER PRIMARY KEY,
    //                 case_number TEXT UNIQUE,
    //                 case_title TEXT NOT NULL,
    //                 case_description TEXT,
    //                 case_status TEXT,
    //                 date_filed DATE,
    //                 date_closed DATE,
    //                 client_id INTEGER,
    //                 FOREIGN KEY (client_id) REFERENCES clients(client_id) ON DELETE SET NULL
    //             ) ";
    //
    //             // Executing Query that is not expected to return results
    //             command.ExecuteNonQuery();
    //
    //             Console.WriteLine("Created Cases Table");
    //         }
    //
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine("There has been an error that occured: " + e);
    //     }
    //
    // }
    //
    // public void CreateLegalDocumentsTable()
    // {
    //     // Error Handling
    //     try
    //     {
    //         // Defining Location of the Database
    //         var databaseLocation = "Data Source=LawFirmDatabase.db";
    //         // Creating an instance of the db and Close the db once done
    //         using (var connection = new SqliteConnection(databaseLocation))
    //         {
    //             // Connecting to the Database
    //             connection.Open();
    //             Console.WriteLine("Connected to the Database");
    //
    //             // Instance of SQLite Command Object
    //             var command = connection.CreateCommand();
    //
    //             // SQL Query to Create Table
    //             command.CommandText = @"
    //             CREATE TABLE IF NOT EXISTS documents (
    //                 document_id INTEGER PRIMARY KEY,
    //                 case_id INTEGER,
    //                 document_name TEXT NOT NULL,
    //                 document_type TEXT,
    //                 document_path TEXT,
    //                 FOREIGN KEY (case_id) REFERENCES cases(case_id) ON DELETE CASCADE
    //             ) ";
    //
    //             // Executing Query that is not expected to return results
    //             command.ExecuteNonQuery();
    //
    //             Console.WriteLine("Created Client Table");
    //         }
    //
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine("There has been an error that occured: " + e);
    //     }
    //
    // }
    //
    // public void CreateDatesTable()
    // {
    //     // Error Handling
    //     try
    //     {
    //         // Defining Location of the Database
    //         var databaseLocation = "Data Source=LawFirmDatabase.db";
    //         // Creating an instance of the db and Close the db once done
    //         using (var connection = new SqliteConnection(databaseLocation))
    //         {
    //             // Connecting to the Database
    //             connection.Open();
    //             Console.WriteLine("Connected to the Database");
    //
    //             // Instance of SQLite Command Object
    //             var command = connection.CreateCommand();
    //
    //             // SQL Query to Create Table
    //             command.CommandText = @"
    //             CREATE TABLE IF NOT EXISTS important_dates (
    //                 date_id INTEGER PRIMARY KEY,
    //                 case_id INTEGER,
    //                 event_date DATE,
    //                 event_description TEXT,
    //                 FOREIGN KEY (case_id) REFERENCES cases(case_id) ON DELETE CASCADE
    //             ) ";
    //
    //             // Executing Query that is not expected to return results
    //             command.ExecuteNonQuery();
    //
    //             Console.WriteLine("Created Client Table");
    //         }
    //
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine("There has been an error that occured: " + e);
    //     }
    //
    // }
}