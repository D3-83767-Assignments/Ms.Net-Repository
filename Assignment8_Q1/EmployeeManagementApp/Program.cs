using System;
using EmployeeLib;

namespace EmployeeManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nEmployee Management System");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Remove Employee");
                Console.WriteLine("3. Find Employee by ID");
                Console.WriteLine("4. Display Company Info");
                Console.WriteLine("5. Display All Employees");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddEmployee(company);
                            break;
                        case 2:
                            RemoveEmployee(company);
                            break;
                        case 3:
                            FindEmployeeByID(company);
                            break;
                        case 4:
                            DisplayCompanyInfo(company);
                            break;
                        case 5:
                            DisplayAllEmployees(company);
                            break;
                        case 6:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        static void AddEmployee(Company company)
        {
            Console.WriteLine("\nEnter employee details:");
            Console.Write("Enter employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();
            Console.Write("Enter employee designation: ");
            string designation = Console.ReadLine();

            Employee employee = new Employee(id, name, designation);
            company.AddEmployee(employee);
            Console.WriteLine("Employee added successfully.");
        }

        static void RemoveEmployee(Company company)
        {
            Console.Write("\nEnter employee ID to remove: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (company.RemoveEmployee(id))
                Console.WriteLine("Employee removed successfully.");
            else
                Console.WriteLine("Employee with the provided ID not found.");
        }

        static void FindEmployeeByID(Company company)
        {
            Console.Write("\nEnter employee ID to find: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var employee = company.FindEmployee(id);
            if (employee != null)
                Console.WriteLine("Employee found:\n" + employee.Value.ToString());
            else
                Console.WriteLine("Employee with the provided ID not found.");
        }

        static void DisplayCompanyInfo(Company company)
        {
            Console.WriteLine("\nCompany Information:");
            company.Print();
        }

        static void DisplayAllEmployees(Company company)
        {
            Console.WriteLine("\nEmployee Information:");
            company.PrintEmployees();
        }
    }
}
