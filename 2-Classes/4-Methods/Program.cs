using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var num = int.Parse("abc");

            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed.");
            }

            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed.");


        }

        static void UsePoints()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));

        }
        static void UsePoint()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0},{1}", point.X, point.Y);


                point.Move(500, 200);
                Console.WriteLine("Point is at ({0},{1}", point.X, point.Y);


            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured,");

            }
        }
    }
}

