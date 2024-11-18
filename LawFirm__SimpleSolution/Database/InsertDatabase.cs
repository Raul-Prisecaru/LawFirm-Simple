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
                    INSERT INTO clients (client_name, client_address, client_phone, client_email) VALUES (@client_name, @client_address, @client_phone, @client_email)";

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

    // Method for Inserting into Client Table
    public void InsertCasesTable(String caseNumber, String caseTitle, String caseDescription, String caseStatus, String dateFiled, String dateClosed, String clientID)
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
                    INSERT INTO cases (case_number, case_title, case_description, case_status, date_filed, date_closed, client_id) VALUES (@caseNumber, @caseTitle, @caseDescription, @caseStatus, @dateFiled, @dateClosed, @clientID)";

                command.Parameters.AddWithValue("@case_number", caseNumber);
                command.Parameters.AddWithValue("@case_title", caseTitle);
                command.Parameters.AddWithValue("@case_description", caseDescription);
                command.Parameters.AddWithValue("@case_status", caseStatus);
                command.Parameters.AddWithValue("@date_filed", dateFiled);
                command.Parameters.AddWithValue("@date_closed", dateClosed);
                command.Parameters.AddWithValue("@client_id", clientID);

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

    public void InsertDocumentTable(Int32 caseid, String documentName, String documentType, String documentPath)
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
                    INSERT INTO documents (case_id, document_name, document_type, document_path) VALUES (@caseid, @documentName, @documentType, @documentPath)";

                command.Parameters.AddWithValue("@case_id", caseid);
                command.Parameters.AddWithValue("@document_name", documentName);
                command.Parameters.AddWithValue("@document_type", documentType);
                command.Parameters.AddWithValue("document_path", documentPath);

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

    public void InsertDateTable(Int32 caseid, String eventDate, String eventDescription)
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
                    INSERT INTO important_dates (case_id, event_date, event_description) VALUES (@caseid, @eventDate, @eventDescription)";

                command.Parameters.AddWithValue("@case_id", caseid);
                command.Parameters.AddWithValue("@event_date", eventDate);
                command.Parameters.AddWithValue("@event_description", eventDescription);

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