using System;

namespace UC_1
{
    public class Program
    {
      public static void Main(string[] args)
        {
            double x1, x2, y1, y2;

            Console.WriteLine("Enter The coordinate of x1: ");
            x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The coordinate of x2: ");
            x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The coordinate of y1: ");
            y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The coordinate of y2:");
            y2 = int.Parse(Console.ReadLine());


            double Length;

            Length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("Length of line : " + Length);
            Console.ReadLine();


        }
    }
}
