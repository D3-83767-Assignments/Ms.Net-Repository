namespace EmployeeLib
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

        public Company()
        {
            name = "";
            address = "";
            empList = new LinkedList<Employee>();
        }

        public Company(string name, string address)
        {
            this.name = name;
            this.address = address;
            empList = new LinkedList<Employee>();
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

        public void Print()
        {
            Console.WriteLine($"Company Name: {name}");
            Console.WriteLine($"Address: {address}");
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
}
