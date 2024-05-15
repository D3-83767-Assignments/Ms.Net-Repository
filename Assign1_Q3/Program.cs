using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ques02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            while(true) 
            {

                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Substract");
                Console.WriteLine("3.Multiply");
                Console.WriteLine("4.Division");

                Console.WriteLine("Enter your choice :");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0) // Check if choice is 0
                {
                    break; // Exit the loop if choice is 0
                }
                Console.WriteLine("Enter num1 : ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter num2 : ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                   // case 0:
                    //    break;
                    case 1:
                        int add = num1 + num2;
                        Console.WriteLine(num1 + "+" + num2 + "=" + add);
                        break;
                    case 2:
                        int sub = num1 - num2;
                        Console.WriteLine(num1 + "-" + num2 + "=" + sub);
                        break;
                    case 3:
                        int mul = num1 * num2;
                        Console.WriteLine(num1 + "*" + num2 + "=" + mul);
                        break;
                    case 4:
                        int div = num1 / num2;
                        Console.WriteLine(num1 + "/" + num2 + "=" + div);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose correct option");
                        break;

                };
                
            } 
            Console.ReadKey();
        }
    }
}