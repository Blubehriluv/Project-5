using System;
using Payroll.Classes;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            int sysPeople = 0;
            int sysEmployee = 0;

            ProgramStart();

            void ProgramStart()
            {
                Console.WriteLine("Welcome to the Payroll Simulator");
                Console.WriteLine("A paid worker is a happy worker!");
                Console.WriteLine("");
                Console.WriteLine("There are currently {0} people and {1} employees in the system.", sysPeople, sysEmployee);
                Console.WriteLine("");
                MenuSelect();
            }

            void MenuSelect()
            {
                Console.WriteLine("Please select an item by typing the corresponding number.");
                Console.WriteLine(" 1  Hire an employee");
                Console.WriteLine(" 2  Add a person to the system");
                Console.WriteLine(" 3  Edit current employee information");
                Console.WriteLine(" 4  Pay all employees");

                MenuChoice();
            }

            void MenuChoice()
            {
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Option 1 selected.");
                        AddPerson();
                        break;
                    case "2":
                        Console.WriteLine("Option 2 selected.");
                        EmpHire();
                        break;
                    case "3":
                        Console.WriteLine("Option 3 selected.");
                        EditInfo();
                        break;
                    case "4":
                        Console.WriteLine("Option 4 selected.");
                        PayDay();
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }

            void AddPerson()
            {
                Console.WriteLine("");
                Console.WriteLine("Adding a person to the system.");
                Console.WriteLine("Please enter the person's first name.");
                Console.ReadLine();
                Console.WriteLine("Please enter the person's last name.");
                Console.ReadLine();
                Console.WriteLine("Please enter the person's phone number.");
            }

            void EmpHire()
            {

            }
            
            void EditInfo()
            {

            }

            void PayDay()
            {

            }
        }
    }
}
