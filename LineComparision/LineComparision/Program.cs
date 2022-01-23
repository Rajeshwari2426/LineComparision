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
         int S_One, S_Two;
         int R_One , R_Two;


         Console.WriteLine("Enter x, y co ordinates of the line 1 :");
         Console.WriteLine("Enter value X_One");
         X_One = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter vale X_Two");
         X_Two = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter vale Y_One");
         Y_One = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter vale Y_Two");
         Y_Two = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Enter x, y co ordinates of the line 2 :");
         Console.WriteLine("Enter value of S_One");
         S_One = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter value of S_Two");
         S_Two = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter vale R_One");
         R_One = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter vale R_Two");
         R_Two = Convert.ToInt32(Console.ReadLine());

         double Length_XY = Math.Sqrt(Math.Pow((X_One - X_Two), 2) + Math.Pow((Y_Two - Y_One), 2));
         Console.WriteLine("Length of Line 1 is:: " + Length_XY);
           
         double Length_SR = Math.Sqrt(Math.Pow((S_Two - S_One), 2) + Math.Pow((R_Two - R_One), 2));
         Console.WriteLine("Length of Line 2 is: " + Length_SR);
            
         bool equal_result = Length_XY.Equals(Length_SR);
                     
         if (equal_result == false)
                Console.WriteLine(" Length of XY and Length of SR are NOT Equal");
         else
                Console.WriteLine("Length of XY and Length of SR are Equal");
         Console.ReadKey();

        Console.ReadLine();        
        }
    }
}
