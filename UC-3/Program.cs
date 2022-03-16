using System;

namespace UC_3
{
    public class Program
    {
        public static void Main(string[] args)
        {

            double x1, x2, y1, y2;
            double g1, g2, h1, h2;

            Console.Write("Enter the co-ordinate of x1  : ");
            x1 = double.Parse(Console.ReadLine());


            Console.Write("Enter the co-ordinate of x2  : ");
            x2 = double.Parse(Console.ReadLine());


            Console.Write("Enter the co-ordinate of y1  : ");
            y1 = double.Parse(Console.ReadLine());


            Console.Write("Enter the co-ordinates of y2 : ");
            y2 = double.Parse(Console.ReadLine());


            Console.Write("Enter the co-ordinates of g1 : ");
            g1 = double.Parse(Console.ReadLine());


            Console.Write("Enter the co-ordinates of g2 : ");
            g2 = double.Parse(Console.ReadLine());


            Console.Write("Enter the co-ordinates of h1 : ");
            h1 = double.Parse(Console.ReadLine());


            Console.Write("Enter the co-ordinate of h2  : ");
            h2 = double.Parse(Console.ReadLine());



            double Length1, Length2;


            Length1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Length2 = Math.Sqrt((g2 - g1) * (g2 - g1) + (h2 - h1) * (h2 - h1));


            Console.WriteLine("Length of  a Line 1  :" + Length1);
            Console.WriteLine("Length of a Line  2  :" + Length2);


            //Comparing the length of line 1 and two if they are equal or not 

            if (Length1 == Length2)
            {
                Console.WriteLine("Two lines are equal ");

            }
            else if (Length1 >= Length2)
            {
                Console.WriteLine("Length of line 1 is greater than length of line 2 ");
            }
            else
            {
                Console.WriteLine("Length of line 2 is greater than Length of line 1 ");
            }
            Console.ReadLine();
        }
    }
    
}
