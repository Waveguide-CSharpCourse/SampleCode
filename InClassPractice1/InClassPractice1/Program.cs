using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length: ");
            string length = Console.ReadLine();
            Console.WriteLine("Enter the width: ");
            string width = Console.ReadLine();
            int length_int = int.Parse(length);
            int width_int = int.Parse(width);
            Program myProgramInstance = new Program();

            myProgramInstance.computePerimeter(length_int, width_int);
            int area = computeArea(length_int, width_int);
            Console.WriteLine("Area = {0}", area);
            Console.ReadLine();
            
        }

        static int computeArea(int length, int width)
        {
            int area = length * width;
            return area;
        }

        int computePerimeter(int length, int width)
        {
            int perimeter = length * 2 + width * 2;
            return perimeter;
        }
    }
}
