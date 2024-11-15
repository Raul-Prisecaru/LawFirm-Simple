namespace LawFirm__SimpleSolution;

class MainRun
{
    static void Main(string[] args)
    {
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
                break;
            
            case 2:
                Console.WriteLine("You have Chosen to Read Entry");
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