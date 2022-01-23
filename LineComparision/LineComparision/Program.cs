using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Welcome to Line Comparison Computation Program on Master Branch");
            
         int X_One,X_Two;
         int Y_One, Y_Two;
         
         Console.WriteLine("Enter x, y co ordinates of the line 1 :");
         Console.WriteLine("Enter value X_One");
         X_One = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter vale X_Two");
         X_Two = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter vale Y_One");
         Y_One = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter vale Y_Two");
         Y_Two = Convert.ToInt32(Console.ReadLine());

         double Length_XY = Math.Sqrt(Math.Pow((X_One - X_Two), 2) + Math.Pow((Y_Two - Y_One), 2));
         Console.WriteLine("Length of Line 1 is:: " + Length_XY);

         Console.ReadLine();        
        }
    }
}
