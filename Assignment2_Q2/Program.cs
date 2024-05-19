namespace Assignment2_Q2
{
    internal class Program
    {
        static Student[] students;

        static void Main(string[] args)
        {
            CreateArray();
            AcceptInfo();
            Console.WriteLine("Original Array:");
            PrintInfo(students);

            Student[] reversedArray = ReverseArray(students);
            Console.WriteLine("\nReversed Array:");
            PrintInfo(reversedArray);
        }
        static void CreateArray()
        {
            Console.Write("Enter the number of students: ");
            int numStudents = Convert.ToInt32(Console.ReadLine());
            students = new Student[numStudents];
        }

        static void AcceptInfo()
        {
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();

                Console.WriteLine($"\nEnter information for student {i + 1}:");
                Console.Write("Name: ");
                students[i].Name = Console.ReadLine();

                Console.Write("Age: ");
                students[i].Age = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void PrintInfo(Student[] arr)
        {
            foreach (var student in arr)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }
        }

        static Student[] ReverseArray(Student[] arr)
        {
            Student[] reversedArray = new Student[arr.Length];
            int j = arr.Length - 1;
            for (int i = 0; i < arr.Length; i++)
            {
                reversedArray[i] = arr[j];
                j--;

            }
            return reversedArray;
        }

    }
}
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

