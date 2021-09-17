using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Time();

            double x1, x2, x3, y1,
                condition;
            //X1
            Console.Write("Enter x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            //X2
            Console.Write("Enter x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            //X3
            Console.Write("Enter x3: ");
            x3 = Convert.ToDouble(Console.ReadLine());
            //Y1
            Console.Write("Enter y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            y1 = y1 + 7 / 3;
            //Task:
            condition = 6.3 * Math.Sin(1.3 * x1 - 3) - x2 + Math.Sqrt(x3 + 9/4) + Math.Pow(y1, 2/3);

            Console.WriteLine($"Condition = 6.3 * sin(1.3 * {x1} - 3) - {x2} + √({x3} + 9/4) + ({y1} + 7/3)^2/3 = {condition}");
        }

        static void Time()
        {
            Console.WriteLine($"Current time: {System.DateTime.Now}\n");
        }
    }
}