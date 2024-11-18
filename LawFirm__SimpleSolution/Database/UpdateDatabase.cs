using Microsoft.Data.Sqlite;

namespace LawFirm__SimpleSolution.Database;

public class UpdateDatabase
{
    // Method for Inserting into Client Table
    public void UpdateClientsTable(Int32 clientID, String clientName, String clientAddress, String clientPhone, String clientEmail)
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
                    UPDATE clients SET client_name = @client_name,
                                       client_address = @client_address,
                                       client_phone = @client_phone, 
                                       client_email = @client_email
                                       
                    WHERE client_id = @clientID";

                command.Parameters.AddWithValue("@clientID", clientID);
                command.Parameters.AddWithValue("@client_name", clientName);
                command.Parameters.AddWithValue("@client_address", clientAddress);
                command.Parameters.AddWithValue("@client_phone", clientPhone);
                command.Parameters.AddWithValue("@client_email", clientEmail);
                command.Parameters.AddWithValue("@client_email", clientEmail);

                // Executing Query that is not expected to return results
                command.ExecuteNonQuery();
            
                Console.WriteLine("Updated client from the client table");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("There has been an error that occured: " + e);
        }

    }

    // Method for Inserting into Client Table
    public void UpdateCasesTable(Int32 caseID, String caseNumber, String caseTitle, String caseDescription, String caseStatus, String dateFiled, String dateClosed, String clientID)
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
                    UPDATE cases SET case_number = @caseNumber, 
                                     case_title = @caseTitle,
                                     case_description = @caseDescription,
                                     case_status = @caseStatus,
                                     date_filed = @dateFiled,
                                     date_closed = @dateClosed,
                                     client_id = @clientID
                    WHERE case_id = @caseID";

                command.Parameters.AddWithValue("@caseID", caseID);
                command.Parameters.AddWithValue("@case_number", caseNumber);
                command.Parameters.AddWithValue("@case_title", caseTitle);
                command.Parameters.AddWithValue("@case_description", caseDescription);
                command.Parameters.AddWithValue("@case_status", caseStatus);
                command.Parameters.AddWithValue("@date_filed", dateFiled);
                command.Parameters.AddWithValue("@date_closed", dateClosed);
                command.Parameters.AddWithValue("@client_id", clientID);

                // Executing Query that is not expected to return results
                command.ExecuteNonQuery();

                Console.WriteLine("Updated case from the Case table");
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
                    UPDATE documents SET case_id = @caseid,
                                         document_name = @documentName,
                                         document_type = @documentType,
                                         document_path = @documentPath";

                command.Parameters.AddWithValue("@case_id", caseid);
                command.Parameters.AddWithValue("@document_name", documentName);
                command.Parameters.AddWithValue("@document_type", documentType);
                command.Parameters.AddWithValue("document_path", documentPath);

                // Executing Query that is not expected to return results
                command.ExecuteNonQuery();

                Console.WriteLine("Updated Document from the Document table");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("There has been an error that occured: " + e);
        }

    }

    public void UpdateDateTable(Int32 dateid, Int32 caseid, String eventDate, String eventDescription)
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
                    UPDATE important_dates SET case_id = @caseid,
                                               event_date = @eventDate,
                                               event_description = @eventDescription
                    WHERE date_id = @dateid";

                command.Parameters.AddWithValue("@date_id", dateid);
                command.Parameters.AddWithValue("@case_id", caseid);
                command.Parameters.AddWithValue("@event_date", eventDate);
                command.Parameters.AddWithValue("@event_description", eventDescription);

                // Executing Query that is not expected to return results
                command.ExecuteNonQuery();

                Console.WriteLine("Updated Date information from the Dates table");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("There has been an error that occured: " + e);
        }

    }
}