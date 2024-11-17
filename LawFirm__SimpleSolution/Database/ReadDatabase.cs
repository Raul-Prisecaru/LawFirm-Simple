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
                using var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var caseid = reader.GetInt32(0);
                        var clientName = reader.GetString(1);
                        var clientAddress = reader.GetString(2);
                        var clientPhone = reader.GetString(3);
                        var clientEmail = reader.GetString(4);
                        Console.WriteLine($"{caseid}\t {clientName}\t {clientAddress}, {clientPhone}\t {clientEmail}");

                    }

                }
            }


        }
        catch (Exception e){
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
                using var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var caseid = reader.GetInt32(0);
                        var caseNumber = reader.GetString(1);
                        var caseTitle = reader.GetString(2);
                        var caseDescription = reader.GetString(3);
                        var caseStatus = reader.GetString(4);
                        var dateFiled = reader.GetString(5);
                        var dateClosed = reader.GetString(6);
                        var clientID = reader.GetInt32(7);
                        Console.WriteLine($"{caseid}\t {caseNumber}\t {caseTitle}, {caseDescription}\t {caseStatus}\t {dateFiled}\t {dateClosed}\t {clientID}");

                    }

                }

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
                using var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var documentid = reader.GetInt32(0);
                        var caseid = reader.GetInt32(1);
                        var documentName = reader.GetString(2);
                        var documentType = reader.GetString(3);
                        var documentPath = reader.GetString(4);
                        Console.WriteLine($"{documentid}\t {caseid}\t {documentName}, {documentType}\t {documentPath}");
                    }
                }

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
                using var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var dateid = reader.GetInt32(0);
                        var caseid = reader.GetInt32(1);
                        var eventDate = reader.GetString(2);
                        var eventDescription = reader.GetString(3);
                        Console.WriteLine($"{dateid}\t {caseid}\t {eventDate}, {eventDescription}");

                    }
                }
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("There has been an error that occured: " + e);
        }

    }
}