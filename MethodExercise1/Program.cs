using System;

namespace MethodExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1: Exercise 1\n2: Exercise 2\n3: Exit");
                Console.Write("\nChoose one of the options (pick a number):");
                var number =Console.ReadLine();
                switch (number)
                {
                    case "1":
                        Story();
                        break;

                    case "2":

                        Console.WriteLine("\nMethods for Addition, Multiplication,Subtraction & Division \n-------------------------------------");
                 
                        int sum = Sum(10, 20);
                        Console.WriteLine($"\nSum of 10 and 20 is {sum} ");
                        
                        int multiply = Multiply(10, 20);
                        Console.WriteLine($"\nMultiplication of 10 and 20 is {multiply}");

                        int subtract = Subtract(20, 10);
                        Console.WriteLine($"\nDifference of 10 and 20 is {subtract} ");

                        int divide = Divide(20,10);
                        Console.WriteLine($"\nDivision of 20 and 10 is {divide}");

                        break;

                    case "3":
                        Console.WriteLine("\nYou have exited the program!!");
                        return;
                            
                    default:

                        Console.WriteLine("\nNot in the list!! please select from the list!!");
                        break;

                }
                AddSpaces(2);
            }
           
        }
        public static void Story()
        {
            Console.Write("\nWhat is your name? ");
            var name = Console.ReadLine();
            Console.Write("What is your favorite color? ");
            var color = Console.ReadLine();
            Console.Write("What is your favorite animal? ");
            var animal = Console.ReadLine();
            Console.Write("What is your favorite brand? ");
            var brand = Console.ReadLine();

            AddSpaces(2);

            Console.WriteLine($"Hi, I am {name}. My favorite color is {color}. I like {animal}. {brand} is my favorite brand!!");
        }
        public static void AddSpaces(int x)
        {
            while (x != 0)
            {
                Console.WriteLine();
                x--;
            }
        }
        public static int Sum(int x, int y)
        {
                int sum = x + y;
                return sum;
        }
        public static int Subtract(int x, int y)
        {
            int difference= x - y;
            return difference;
        }

        public static int Divide(int x, int y)
        {
            int divide = x/ y;
            return divide;
        }

        public static int Multiply(int x,int y)
        {
            int multiply = x * y;
            return multiply;
        }

        
    }
}
