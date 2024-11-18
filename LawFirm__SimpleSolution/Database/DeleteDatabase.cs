using Microsoft.Data.Sqlite;

namespace LawFirm__SimpleSolution.Database;

public class DeleteDatabase
{
    // Method for Deleting into Client Table
    public void DeleteClientsTable(Int32 clientid)
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
                command.CommandText = @"DELETE FROM clients WHERE client_id = @clientid";

                command.Parameters.AddWithValue("@clientid", clientid);

                // Executing Query that is not expected to return results
                command.ExecuteNonQuery();
            
                Console.WriteLine("client deleted from the client table");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("There has been an error that occured: " + e);
        }

    }

    // Method for Inserting into Client Table
    public void InsertCasesTable(Int32 caseID)
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
                command.CommandText = @"DELETE FROM cases WHERE case_id = @caseid";

                command.Parameters.AddWithValue("@caseid", caseID);


                // Executing Query that is not expected to return results
                command.ExecuteNonQuery();

                Console.WriteLine("Deleted case from the Case table");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("There has been an error that occured: " + e);
        }

    }

    public void InsertDocumentTable(Int32 documentid)
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
                command.CommandText = @"DELETE FROM documents WHERE document_id = @documentid";

                command.Parameters.AddWithValue("@documentid", documentid);

                // Executing Query that is not expected to return results
                command.ExecuteNonQuery();

                Console.WriteLine("Document deleted from the Document table");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("There has been an error that occured: " + e);
        }

    }

    public void InsertDateTable(Int32 dateid)
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
                command.CommandText = @"DELETE FROM important_dates WHERE date_id = @dateid";

                command.Parameters.AddWithValue("@dateid", dateid);

                // Executing Query that is not expected to return results
                command.ExecuteNonQuery();

                Console.WriteLine("Deleted date from the Dates table");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("There has been an error that occured: " + e);
        }

    }
}