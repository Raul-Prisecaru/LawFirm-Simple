using LawFirm__SimpleSolution.Database;

namespace LawFirm__SimpleSolution;

class MainRun
{
    static void Main(string[] args)
    {
        CreateDatabase createDatabase = new CreateDatabase();
        InsertDatabase insertData = new InsertDatabase();
        ReadDatabase readDatabase = new ReadDatabase();
        createDatabase.createTables();
        
        Console.WriteLine("Welcome to Law's Firm Management System");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("[1] - Create Entry");
        Console.WriteLine("[2] - Read Entry");
        Console.WriteLine("[3] - Update Entry");
        Console.WriteLine("[4] - Delete Entry");

        int user_option = Convert.ToInt32(Console.ReadLine());
        createDatabase.createTables();
        switch (user_option)
        {
            case 1:
                Console.WriteLine("You have Chosen to Create Entry");
                Console.WriteLine("Which data do you want to Create?");
                Console.WriteLine("[1] - Clients");
                Console.WriteLine("[2] - Cases");
                Console.WriteLine("[3] - Documents");
                Console.WriteLine("[4] - Dates");
                int userOptionCreate = Convert.ToInt32(Console.ReadLine());
                switch (userOptionCreate)
                {
                    case 1:
                        Console.Write("Client Name: ");
                        String clientNameInput = Console.ReadLine();

                        Console.Write("Client Address: ");
                        String clientAddressInput = Console.ReadLine();

                        Console.Write("Client Phone Number: ");
                        String clientPhoneInput = Console.ReadLine();

                        Console.Write("Client Email: ");
                        String clientEmailInput = Console.ReadLine();


                        insertData.InsertClientsTable(clientNameInput, clientAddressInput, clientPhoneInput, clientEmailInput);
                        break;

                    case 2:
                        Console.Write("Case Number: ");
                        String caseNumberInput = Console.ReadLine();

                        Console.Write("Case Title: ");
                        String caseTitleInput = Console.ReadLine();

                        Console.Write("Case Description: ");
                        String caseDescriptionInput = Console.ReadLine();

                        Console.Write("Case Status: ");
                        String caseStatusInput = Console.ReadLine();

                        Console.Write("Date Filed: ");
                        String caseDateFiledInput = Console.ReadLine();
                        DateTime convertDateFiledInput = DateTime.Parse(caseDateFiledInput);

                        Console.Write("Date Closed: ");
                        String caseDateClosedInput = Console.ReadLine();

                        Console.Write("Client ID: ");
                        String caseClientIDInput = Console.ReadLine();

                        insertData.InsertCasesTable(caseNumberInput, caseTitleInput, caseDescriptionInput, caseStatusInput, caseDateFiledInput, caseDateClosedInput, caseClientIDInput);
                        break;

                    case 3:
                        Console.Write("Case ID: ");
                        Int32 documentCaseIDInput = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Document Name: ");
                        String documentNameInput = Console.ReadLine();

                        Console.Write("Document Type: ");
                        String documentTypeInput = Console.ReadLine();

                        Console.Write("Document Path: ");
                        String documentPathInput = Console.ReadLine();

                        insertData.InsertDocumentTable(documentCaseIDInput, documentNameInput, documentTypeInput, documentPathInput);
                        break;

                    case 4:
                        Console.Write("Case ID: ");
                        Int32 dateCaseIDInput = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Event Date: ");
                        String dateEventDateInput = Console.ReadLine();

                        Console.Write("Event Description: ");
                        String dateEventDescriptionInput = Console.ReadLine();


                        insertData.InsertDateTable(dateCaseIDInput, dateEventDateInput, dateEventDescriptionInput);
                        break;
                }
                break;
            case 2:
                Console.WriteLine("You have Chosen to Read Entry");
                Console.WriteLine("Which data do you want to Read?");
                Console.WriteLine("[1] - Clients");
                Console.WriteLine("[2] - Cases");
                Console.WriteLine("[3] - Documents");
                Console.WriteLine("[4] - Dates");

                int userOptionRead = Convert.ToInt32(Console.ReadLine());
                switch (userOptionRead)
                {
                    case 1:
                        readDatabase.ReadClientsTable();
                        break;

                    case 2:
                        readDatabase.ReadCasesTable();
                        break;

                    case 3:
                        readDatabase.ReadDocumentTable();
                        break;

                    case 4:
                        readDatabase.ReadDateTable();
                        break;
                }
                break;
            
            case 3:
                Console.WriteLine("You have chosen to Update Entry");
                break;
            
            case 4:
                Console.WriteLine("You have chosen to Delete Entry");
                break;
        }
        
        
    }
}