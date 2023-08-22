using EmployeeManagementApp;

public class Program
{
    static readonly string textFileForEmployees = @"C:\Users\Manthan\source\repos\EmployeeManagementApp\EmployeeManagementApp\Input\ListOfEmployees.txt";

    static readonly string textFileForPLs = @"C:\Users\Manthan\source\repos\EmployeeManagementApp\EmployeeManagementApp\Input\PLInfo.txt";

    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome");

        CompanyManagement management = new CompanyManagement(textFileForEmployees, textFileForPLs);

        while (true)
        {
            Console.WriteLine("\n");
            Console.WriteLine("1. Read all Employees and print to screen");
            Console.WriteLine("2. Show staff proficient in a Programming Language");
            Console.WriteLine("3. Show Tester with salary greater than 2500000");
            Console.WriteLine("4. Show Employee wtih highest salary");
            Console.WriteLine("5. Show Leader of the Team with most Employees");
            Console.WriteLine("6. Sort Employees");
            Console.WriteLine("7. Write file");
            Console.WriteLine("8. Exit");
            Console.WriteLine("\n");

            int option = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            switch (option)
            {
                case 1: 
                    management.printEmpList();
                    break;
                case 2:
                    management.getDevelopersByProgrammingLanguages("C++")
                        .ForEach(p => Console.WriteLine(p.toString()));
                    break;
                case 3:
                    management.getTestersHaveSalaryGreaterThan(2500000)
                        .ForEach(p => Console.WriteLine(p.toString()));
                    break;
                case 4:
                    Console.WriteLine(management.getEmployeeWithHigestSalary().toString());
                    break;
                case 5:
                    Console.WriteLine(management.getLeaderWithMostEmployees().toString());
                    break;
                case 6:
                    management.sorted()
                        .ForEach(p => Console.WriteLine(p.toString()));
                    break;
                case 7:
                    break;
                case 8:
                    return;
                default:
                    Console.WriteLine("Please try again!");
                    break;
            }
        }

        
    }
    
}