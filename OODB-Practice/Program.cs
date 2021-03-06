using System;

namespace OODB_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            ShowMainMenu();
        }

        static void ShowExitOptions()
        {
            Console.WriteLine("Press 0 to exit");
            Console.WriteLine("Press 1 to return to Main Menu");

            int selectedOption = Convert.ToInt32(Console.ReadLine());

            switch (selectedOption)
            {
                case 0: Environment.Exit(0); break;
                case 1: ShowMainMenu(); break;
                default: Console.WriteLine("Select in range value!"); break;
            }

        }

        static void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1: Lab Problems");
            Console.WriteLine("2: Lab Activites");
            Console.Write("Select category: ");

            int selectedOption = Convert.ToInt32(Console.ReadLine());

            switch (selectedOption)
            {
                case 1: ShowLabs(); break;
                default: Console.WriteLine("Select in range value!"); break;
            }
        }

        static void ShowLabs()
        {
            Console.Clear();
            Console.WriteLine("1: Lab 00");
            Console.WriteLine("2: Lab 01");
            Console.WriteLine("3: Lab 02");
            Console.WriteLine("4: Lab 03");

            Console.Write("Select lab: ");
            int selectedOption = Convert.ToInt32(Console.ReadLine());

            switch (selectedOption)
            {
                case 1: { ShowLab00Options(); break; }
                default: Console.WriteLine("Select in range value!"); break;
            }

        }

        static int GetUserOption()
        {
            Console.Write("Select an option: ");
            int selectedOption = Convert.ToInt32(Console.ReadLine());

            return selectedOption;
        }

        static void ShowOptions(int labNumber, int problemsNumber)
        {
            Console.Clear();
            for (int i = 0; i < problemsNumber; i++)
            {
                Console.WriteLine("Option " + (i+1) + ": Lab " + labNumber + " Problem " + (i + 1));
            }
        }

        static void ShowLab00Options()
        {
            ShowOptions(0, 8);
            int option = GetUserOption();

            switch (option)
            {
                case 1: { Console.Clear(); Lab00Problem01(); break; }
                case 2: { Console.Clear(); Lab00Problem02(); break; }
                case 3: { Console.Clear(); Lab00Problem03(); break; }
                case 4: { Console.Clear(); Lab00Problem04(); break; }
                case 5: { Console.Clear(); Lab00Problem05(); break; }
                case 6: { Console.Clear(); Lab00Problem06(); break; }
                case 7: { Console.Clear(); Lab00Problem07(); break; }
                case 8: { Console.Clear(); Lab00Problem08(); break; }
                default: Console.WriteLine("Please enter in range value"); break;
            }
        }

        static void Lab00Problem01()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Welcome to KFU, " + userName);
            ShowExitOptions();

        }

        static void Lab00Problem02()
        {
            Console.Write("Enter the first number: ");
            int fNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int sNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum: " + (fNumber + sNumber));
            Console.WriteLine("Product: " + (fNumber * sNumber));

        }

        static void Lab00Problem03()
        {
            Console.Write("Enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0) Console.WriteLine("Even");
            else Console.WriteLine("Odd");
        }

        static void Lab00Problem04()
        {
            Console.Write("Enter the day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thrusday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Enter a value within range!");
                    break;
            }

        }

        static void Lab00Problem05()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + "*" + i + "=" + (i * num));
            }
        }

        static void Lab00Problem06()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int counter = 1;
            while (counter <= 10)
            {
                Console.WriteLine(num + "*" + counter + "=" + (counter * num));
                counter++;
            }
        }
        static void Lab00Problem07()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = RecursiveFact(num);

            Console.WriteLine("The factorial of {0} is: {1}", num, fact);


        }

        static void Lab00Problem08()
        {
            Console.WriteLine("Enter a serise of numbers (enter 0 to stop): ");
            int num = 1;
            int sum = 0;
            while (num != 0)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0) sum += num;
            }

            Console.WriteLine("The summation of even numbers is: " + sum);
        }

        static int RecursiveFact(int n)
        {
            if (n == 0 || n == 1) return 1;
            else return n * RecursiveFact(n - 1);
        }


    }
}
