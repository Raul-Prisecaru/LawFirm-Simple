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
    }
}