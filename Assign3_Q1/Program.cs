using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assign3_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date birthDate = new Date(21,08,2001);
            Person person = new Person("Sneha", false, birthDate, "Kar");
            Console.WriteLine(person);
          //  person.Print();
            person.Accept();
            person.Print();
            Console.ReadKey();
        }

    }
    class Person
    {
        private string _name;
        private bool _gender;
        Date birthDate;
        private string _address;

        public Person(string name, bool gender, Date birth, string address)
        {
            _name = name;
            _gender = gender;
            _address = address;
            this.birthDate = birth;
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }


        public bool Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Gender: {(Gender ? "Male" : "Female")}, Address: {Address}"+", " + birthDate;
        }

        public void Accept()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine();
            Console.Write("Enter gender (true for male, false for female): ");
            Gender = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter birth date:");
            birthDate.Accept(); // Assuming Date class has an Accept method
            Console.Write("Enter address: ");
            Address = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Gender);
            birthDate.PrintAddress();
            Console.WriteLine(Address);
        }

    }
    
    class Date
    {
        private int _day;
        private int _Month;
        private int _year;

        public override string ToString()
        {
            return $"date: {Day}, Month: {Month}, Year: {Year}";
        }
        public Date(int day, int month, int year)
        {
            _day = day;
            _Month = month;
            _year = year;
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }


        public int Month
        {
            get { return _Month; }
            set { _Month = value; }
        }

        public int Day
        {
            get { return _day; }
            set { _day = value; }
        }

        public void Accept()
        {
            Console.Write("Enter day: ");
            Day = int.Parse(Console.ReadLine());
            Console.Write("Enter month: ");
            Month = int.Parse(Console.ReadLine());
            Console.Write("Enter year: ");
            Year = int.Parse(Console.ReadLine());
        }

        public void PrintAddress()
        {
            Console.WriteLine(Day);
            Console.WriteLine(Month);
            Console.WriteLine(Year);
        }

    }


}
