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

        switch (user_option)
        {
            case 1:
                Console.WriteLine("You have Chosen to Create Entry");
                createDatabase.createTables();
                insertData.InsertClientsTable("Test", "test", "test", "test");
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
                readDatabase.ReadClientsTable();
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