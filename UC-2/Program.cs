using System;

namespace UC_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double x1, x2, y1, y2;
            double g1, g2, h1, h2;

            Console.WriteLine("Enter The Line cooridinate of x1:");
            x1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter The Line coordinate of x2:");
            x2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter The Line coordinate of y1:");
            y1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter The Line coordinate of y2:");
            y2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter The Line Coordinate of g1:");
            g1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter The Line coordinate of g2:");
            g2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter The Line coordinate of h1:");
            h1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter The Line Coordinate of h2:");
            h2 = int.Parse(Console.ReadLine());



            double Length1, Length2;


            Length1 = Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y2)));
            Length2 = Math.Sqrt(((g2 - g1) * (g2 - g1) + (h2 - h1) * (h2 - h2)));

            Console.WriteLine("Length of The Line1: " + Length1);
            Console.WriteLine("Length of The Line2: " + Length2);


            if (Length1 == Length2)
            {
                Console.WriteLine("Two line are equal");
            }
            else
            {
                Console.WriteLine("Two line is not equal");
            }



        }
    }
}
    

