namespace Assignment4_Q1
{
    public enum DepartmentType
    {
        IT,
        Finance,
        HR,
        Marketing,
        Operations
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Person() { }

        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        public virtual void Accept()
        {
            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Age:");
            Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Address:");
            Address = Console.ReadLine();
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Address: {Address}");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Address: {Address}";
        }
    }

    public class Employee : Person
    {
        private static int count = 0;

        public int Id { get; private set; }
        public double Salary { get; set; }
        public string Designation { get; set; }
        public DepartmentType Dept { get; set; }

        public Employee()
        {
            Id = GenerateId();
        }

        public Employee(double salary, string designation, DepartmentType dept)
        {
            Id = GenerateId();
            Salary = salary;
            Designation = designation;
            Dept = dept;
        }

        private int GenerateId()
        {
            return ++count;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter Salary:");
            Salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Designation:");
            Designation = Console.ReadLine();

            Console.WriteLine("Enter Department (IT, Finance, HR, Marketing, Operations):");
            Dept = (DepartmentType)Enum.Parse(typeof(DepartmentType), Console.ReadLine(), true);
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Designation: {Designation}");
            Console.WriteLine($"Department: {Dept}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, ID: {Id}, Salary: {Salary}, Designation: {Designation}, Department: {Dept}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Accept();
            emp.Print();
        }

    }

    


}