using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_ASSIGNMENTS_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //program 1
            Console.WriteLine("Enter employee details:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Salary: $");
            double salary = double.Parse(Console.ReadLine());

            // Create an Employee object
            Employee employee = new Employee(name, age, salary);

            // Display employee details
            
            employee.DisplayDetails();
            */

            /*
            //program 2

            Console.WriteLine("Enter account details:");

            Console.Write("Account Number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Account Holder Name: ");
            string accountHolderName = Console.ReadLine();

            Console.Write("Initial Balance: $");
            double initialBalance = double.Parse(Console.ReadLine());

            // Create a BankAccount object
            BankAccount account = new BankAccount(accountNumber, accountHolderName, initialBalance);

            while (true)
            {
                Console.WriteLine("\nChoose an action:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Display Account Details");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the deposit amount: $");
                        double depositAmount = double.Parse(Console.ReadLine());
                        account.Deposit(depositAmount);
                        break;
                    case 2:
                        Console.Write("Enter the withdrawal amount: $");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        account.Withdraw(withdrawAmount);
                        break;
                    case 3:
                        account.DisplayAccountDetails();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                      Console.ReadKey();

                }

            }*/

            /*
            //program 3
            int[] numbers = { 10, 20, 30, 40, 50 };

            double average = MathHelper.CalculateAverage(numbers);

            Console.WriteLine($"The average of the numbers is: {average:F2}");
            Console.ReadKey();
            */

            /*
            //program 4
            Logger.LogMessage("This is a log message.");
            Logger.LogMessage("Another log message.");
            Console.ReadKey();
            */


            /*
            //program 5 partial class 5 and 6(class name)
            Person person = new Person
            {
                FirstName = "John",
                LastName = "Doe"
            };

            person.PrintFullName(); // Calls the PrintFullName method

            // You can also access properties individually
            Console.WriteLine($"First Name: {person.FirstName}");
            Console.WriteLine($"Last Name: {person.LastName}");

            Console.ReadKey();

            */


            /*
            //program 6 of partial class 
            Employee1 employee = new Employee1
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Doe",
                BaseSalary = 50000,
                YearsOfWork = 7
            };

            employee.DisplayEmployeeDetails(); // Calls the DisplayEmployeeDetails method
            Console.ReadKey();

            */

            /*
            //program 7
            Circle circle = new Circle(5);
            Console.WriteLine($"Circle Area: {circle.CalculateArea():F2}");

            Rectangle rectangle = new Rectangle(4, 6);
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea():F2}");
            Console.ReadKey();

            */

            //program 8
            /*
             Dog dog = new Dog("Buddy", 3, "Golden Retriever");
            Cat cat = new Cat("Whiskers", 2, true);

            Console.WriteLine($"{dog.Name} is {dog.Age} years old.");
            dog.MakeSound();
            dog.Fetch();

            Console.WriteLine($"{cat.Name} is {cat.Age} years old.");
            cat.MakeSound();
            cat.Scratch();
            Console.ReadKey();
            */

            //Program 9
            /*
            
                Car car = new Car();
                car.StartEngine();
                car.Drive();
                car.StopEngine();

                // Uncommenting the code below will result in a compilation error
                //SportsCar sportsCar = new SportsCar();
                //sportsCar.StartEngine();
                //sportsCar.Drive();
                //sportsCar.StopEngine();
                //sportsCar.Race();
           
            */

            //Program 10
            /*
            SavingsAccount savingsAccount = new SavingsAccount(12345, 1000.0, 0.05);
            Console.WriteLine($"Account Number: {savingsAccount.AccountNumber}");
            Console.WriteLine($"Initial Balance: ${savingsAccount.Balance:F2}");
            Console.WriteLine($"Interest Rate: {savingsAccount.InterestRate:P}");

            // Calculate interest for 6 months
            savingsAccount.CalculateInterest(6);
            Console.ReadKey();
            */
        }
    }
}

