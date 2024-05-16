using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Assign2_Q1
{
    public struct Student
    {
        private string name;
        private int std;
        private bool gender;
        private int age;
        private int div;
        private double marks;


        public double Marks
        {
            get { return marks; }
            set { marks = value; }
        }


        public int Div
        {
            get { return div; }
            set { div = value; }
        }


        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }


        public int Std
        {
            get { return std; }
            set { std = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


       



        //public Student() 
        //{
        //    name = " ";
        //    gender = false;
        //    age = 0;
        //    std = 0;
        //    div = '\0';
        //    marks = 0.0;
        //}

        //public Student()
        //{

        //}

        public Student(string name, bool gender, int age, int std, int div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }

        public void AcceptDetails()
        {
            Console.WriteLine("Enter student details : ");

            Console.Write(("Name : "));
            name = Console.ReadLine();

            Console.Write("Gender : ");
            gender = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Age : ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Standard: ");
            std = Convert.ToInt32(Console.ReadLine());

            Console.Write("Division: ");
            div = Convert.ToChar(Console.ReadLine());

            Console.Write("Marks: ");
            marks = Convert.ToDouble(Console.ReadLine());
        }

        public void PrintDetails()
        {
            Console.WriteLine("\nStudent details:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Gender: " + (gender ? "Male" : "Female"));
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Standard: " + std);
            Console.WriteLine("Division: " + div);
            Console.WriteLine("Marks: " + marks);
        }

    };
    internal class Program
    {
        static void Main(string[] args)
        {
            // Student student1 = new Student();
            // student1.AcceptDetails();
            // student1.PrintDetails();

            Student student = new Student();
            student.AcceptDetails();
            student.PrintDetails();

            Student student2 = new Student("Sneha Maskar", true, 18, 12, 'A', 94.23);
            student2.PrintDetails();
            Console.ReadLine();
        }
    }
}
