using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;

namespace MethodsExercise
{
    public class Program
    {
        public static void Madlip()
        {
            Console.WriteLine("What is your first name?"); //Output
            var firstName = Console.ReadLine(); // Input

            Console.WriteLine("What is your favorite color?"); //output
            var favoriteColor = Console.ReadLine(); //Input

            Console.WriteLine("What is your favorite animal?"); //output
            var favoriteAnimal = Console.ReadLine(); // Input

            Console.WriteLine("What is your favorite type of food?"); // output
            var favoriteFood = Console.ReadLine(); // Input

            Console.WriteLine($"My name is {firstName} and my favroite food is {favoriteFood}, even though it has been linked to the extinction of the common {favoriteColor} {favoriteAnimal}.");

            //end of Exercise 1
        }
        static void Main(string[] args)
        {
            Madlip();

            Console.WriteLine(Add(74, 39));

            var result = (5, 1);
            Console.WriteLine($"The answer is: {result}");

            Multiply();
        }
        public static int Add(int num1, int num2)
        {
            var answer = num1 + num2;

            return answer;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        
        public static void Multiply()
        {
            Console.WriteLine("What is the 1st number you want to multiply?");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the 2nd number?");
            var num2 = int.Parse(Console.ReadLine());

            var answer = num1 * num2;

            Console.WriteLine($"The multiplication answer is: {answer}");
        }
        public static double Divide(double num1, int num2)
        { 
            return num1 / num2; 
        }
        }













    }

