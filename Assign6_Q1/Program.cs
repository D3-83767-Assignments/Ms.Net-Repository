namespace Assign6_Q1
{

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }

        public Employee(int id, string name, string designation)
        {
            Id = id;
            Name = name;
            Designation = designation;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Designation: {Designation}";
        }
    }

    public class Company
    {
        private string name;
        private string address;
        private LinkedList<Employee> empList;
        private double salaryExpense;

        public Company()
        {
            name = "";
            address = "";
            empList = new LinkedList<Employee>();
            salaryExpense = 0.0;
        }

        public Company(string name, string address)
        {
            this.name = name;
            this.address = address;
            empList = new LinkedList<Employee>();
            salaryExpense = 0.0;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public LinkedList<Employee> EmpList
        {
            get { return empList; }
        }

        public double SalaryExpense
        {
            get { return salaryExpense; }
        }

        public void Accept()
        {
            Console.WriteLine("Enter company name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter company address:");
            address = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine($"Company Name: {name}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Salary Expense: {salaryExpense}");
        }

        public double CalculateSalaryExpense()
        {
            double totalExpense = 0.0;
            foreach (Employee emp in empList)
            {
                // Assuming all employees have a fixed monthly salary
                totalExpense += 1000; // Example fixed salary value, replace with actual calculation based on employee salary
            }
            salaryExpense = totalExpense;
            return totalExpense;
        }

        public void AddEmployee(Employee e)
        {
            
            empList.AddLast(e);
        }

        public bool RemoveEmployee(int id)
        {
            LinkedListNode<Employee> node = FindEmployee(id);
            if (node != null)
            {
                empList.Remove(node);
                return true;
            }
            return false;
        }

        public LinkedListNode<Employee> FindEmployee(int id)
        {
            foreach (Employee emp in empList)
            {
                if (emp.Id == id)
                {
                    return empList.Find(emp);
                }
            }
            return null;
        }

        public override string ToString()
        {
            return $"Company Name: {name}, Address: {address}, Salary Expense: {salaryExpense}";
        }

        public void PrintEmployees()
        {
            Console.WriteLine("Employee List:");
            foreach (Employee emp in empList)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.Accept();

            Console.WriteLine("\nEnter employee details:");
            Employee emp1 = new Employee(1, "Sneha", "Manager");
            Employee emp2 = new Employee(2, "Prajkta", "Developer");
            company.AddEmployee(emp1);
            company.AddEmployee(emp2);

            Console.WriteLine("\nCompany Information:");
            company.Print();
            Console.WriteLine("\nCompany Information (ToString):");
            Console.WriteLine(company.ToString());

            Console.WriteLine("\nEmployee Information:");
            company.PrintEmployees();

            Console.WriteLine("\nRemoving employee with ID 1...");
            company.RemoveEmployee(1);
            Console.WriteLine("\nEmployee Information after removal:");
            company.PrintEmployees();

            Console.WriteLine("\nTotal Salary Expense: $" + company.CalculateSalaryExpense());
            Console.ReadLine();
        
        }
    }
}
