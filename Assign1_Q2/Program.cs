namespace CalculatorCmd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (args.Length != 3)
            {
                Console.WriteLine("enter args in format <number1> <operator> <number2>");
                return;
            }

            float num1, num2, result;
            char op = char.Parse(args[1]);

            if (!float.TryParse(args[0], out num1) || !float.TryParse(args[2], out num2))
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
                return;
            }

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case '/':
                    // Checking for division by zero
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Error! Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
