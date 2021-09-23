using System;

namespace Quadratic_Solver
{
    class Program
    {

        //methods

        private static double root2(int a, int b, int c)
        {
            return (-b - Math.Sqrt(discriminant(a, b, c))) / (2 * a);
        }
        public static double discriminant(int a, int b, int c)
        {
            return b * b - 4 * a * c;
        }

        public static void root1(int a, int b, int c)
        {
            double x1;
            x1 = (-b + Math.Sqrt(discriminant(a, b, c))) / (2 * a);

            Console.Write("\nThe value of x1 = " + x1);
        } 
        static void Main(string[] args)
        {
            // values for a b and c: inputs 
            // discriminant = b^2 - 4ac 
            // if disc < 0 = no roots
            // if disc == 0 there one repeating value of x = turning point
            // if disc > 0 there are two roots = two x - intercepts


            int a, b, c;

            double x2;
            string option;

            Console.WriteLine("\nWelcome to the Quadratic Equation Solver...\n\n");

            do {
                Console.Write("Please enter the value for a: ");
                while (!int.TryParse(Console.ReadLine(), out a) || a == 0)
                {
                    Console.Write("\nThe value of a has to be a number and not equal to 0: ");
                }

                Console.Write("Please enter the value for b: ");
                while (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.Write("\nThe value of b has to be a number: ");
                }

                Console.Write("Please enter the value for c: ");
                while (!int.TryParse(Console.ReadLine(), out c))
                {
                    Console.Write("\nThe value of c has to be a number: ");
                }                          

                if (discriminant(a, b, c) < 0)
                {
                    Console.Write("\nThis parabolo does not cut the x - axis therefore no solution for x ");
                }
                else if (discriminant(a, b, c) == 0)
                {
                   root1(a, b, c);                    
                }
                else
                {                    
                    x2 = root2(a, b, c);
                    Console.Write("\nThis parabolo has two real roots");
                    root1(a, b, c);
                    Console.Write("\nThe value of x2 = " + x2);
                    Console.WriteLine("\n");
                }

                Console.Write("\n\nTo continue press y/Y or any other key to exit: ");
                option = Console.ReadLine();

            } while (option == "y" || option == "Y");                       
        }
        
    }
   
}
