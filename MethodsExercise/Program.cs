using System;

namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter your name below:");
            var name = Console.ReadLine();

            Console.WriteLine($"Hi {name}! What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an ugly color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{animal} is also ugly! Final question, what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine("Would you like to hear a story?");
            Console.ReadLine();
            Console.WriteLine("Well too bad, I'm going to tell you anyway");
            Console.WriteLine($"Once upon a time, there was a person named {name} " +
                $"who's favorite color was {color}. They had a " +
                $"{animal} for a pet and for some strange reason the " +
                $"{animal} enjoyed listening to {band}");

            Console.WriteLine("Type in a number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Type in a number to add to the first number");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("Type in a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Type in a number to multipy to the first number");
            num2 = int.Parse(Console.ReadLine());

            int product = multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");

            Console.WriteLine("------------------------------------------------------------------");

        }

        public static int Sum(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;
        }

        public static int multiply(int x, int y)
        {
            return x * y;
        }
    }
}
