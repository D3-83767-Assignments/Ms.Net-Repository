using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Q3
{
    class Date
    {
        private int _day;
        private int _month;
        private int _year;

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
            
           
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }


        public int Month
        {
            get { return _month; }
            set { _month = value; }
        }


        public int Day
        {
            get { return _day; }
            set { _day = value; }
        }

        public  void AcceptDate(Date date, int day, int month, int year)
        {
            date.Day = day;
            date.Month = month;
            date.Year = year;
        }
        void PrintDate()
        {
            System.Console.WriteLine($"{_day}/{_month}/{_year}");
        }

        public bool IsValid()
        {
            if(Year < 0 || Month < 1 || Day < 1 || Day > DateTime.DaysInMonth(Year, Month))
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return $"{_day}/{_month}/{_year}";
        }
        public static int CalculateYearDifference(Date date1, Date date2)
        {
            return Math.Abs(date1.Year - date2.Year);
        }

        public static int  operator -(Date date1, Date date2) {
            return CalculateYearDifference(date1, date2);   
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date(1, 1, 2020);
            Date date2 = new Date(1, 1, 2024);
           date1.AcceptDate(date1, 21,8,2001);
            Console.WriteLine($"Date 1: {date1}");
            
            Console.WriteLine($"Date 2: {date2}");

            Console.WriteLine($"Difference in years (method): {Date.CalculateYearDifference(date1, date2)}");
            Console.WriteLine($"Difference in years (operator overloading): {date1 - date2}");

            Console.ReadKey();
        }
    }
}
