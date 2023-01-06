// See https://aka.ms/new-console-template for more information
//
namespace EmployeeWageComputation
{
public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("WelCome To Employee Wage Computaion Program");
            int IS_FULL_TIME = 1;

            Random random = new Random();
            int EMP_Check = random.Next(0, 2);

            if (EMP_Check == 1)
            {
                Console.WriteLine("Employee is Present");
            }
            else
                Console.WriteLine("Employee is Absent.");
        }
    }
}
