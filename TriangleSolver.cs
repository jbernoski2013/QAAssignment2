using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Julia Bernoski
 * Revision on Feb 22nd, due Feb 23rd
 * Static class that contains an analyze method.
 * Analyze method used to check if inputs form a triangle
 * As well as test to see what kind of triangle that input forms
 */
namespace PROG2070A2
{
    public class TriangleSolver
    {
       //analyze method 
       //checks if user input forms a triangle
       // also checks what kind of tirangle the user input forms
        public static string analyze(decimal dem1, decimal dem2, decimal dem3)
        {
            //first checks if user input forms a triangle
            if (dem1 + dem2 > dem3 && dem1 + dem3 > dem2 && dem2 + dem3 > dem1 && dem1 > 0 && dem2 > 0 && dem3 > 0)
            {
                Console.WriteLine("Forms a Triangle");

                // if it does form a triangle
                //goes in and figures out what kind of triangle it form
                if (dem1 == dem2 && dem2 == dem3 && dem1 > 0 && dem1 > 0 && dem2 > 0 && dem3 > 0)
                {
                    Console.WriteLine("Triangle is an equilateral");
                }
                else if (dem1 == dem2 || dem1 == dem3 || dem2 == dem3 && dem1 > 0 && dem2 > 0 && dem3 > 0)
                {
                    Console.WriteLine("Traingle is an isosceles");
                }
                else if (dem1 != dem2 && dem2 != dem3 && dem3 != dem1 && dem1 > 0 && dem2 > 0 && dem3 > 0)
                {
                    Console.WriteLine("Triangle is Scalene");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            //input doesn't form a triangle
            //doesn't display what kind of triangle
            else
            {
                Console.WriteLine("Does Not form a triangle");
            }

            return ("Good Luck");
           
        }

        int[] testArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        public void string ArrayTest()
        {
            string  asd = testArray.ToString();
            return asd;
        }
  
    }
}
