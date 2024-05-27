using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        protected string designation;

        public Employee()
        {
            designation = "Wage";
        }

        public string Designation
        {
            get { return designation; }
        }
    }


    public class WageEmp : Employee
    {
        private int hours;
        private int rate;

        public WageEmp()
        {
            hours = 0;
            rate = 0;
        }

        public WageEmp(int hours, int rate)
        {
            this.hours = hours;
            this.rate = rate;
        }

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public int Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public void Accept()
        {
            Console.WriteLine("Enter hours worked:");
            hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter hourly rate:");
            rate = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("Hours: " + hours);
            Console.WriteLine("Rate: " + rate);
        }

        public override string ToString()
        {
            return "Hours: " + hours + ", Rate: " + rate;
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            WageEmp employee = new WageEmp();
            employee.Accept();

            Console.WriteLine("\nEmployee Information:");
            employee.Print();

            Console.WriteLine("\nEmployee Information (ToString):");
            Console.WriteLine(employee.ToString());
        }
    }


}
