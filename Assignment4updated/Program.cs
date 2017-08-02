/*CENTENNIAL COLLEGE - COMP 123
 * The Author's name: Priscylla Flisch
 * Author’s student number: 300931589 
 * Date last Modified: 07/13/2017 
 * Program description: Planets and its diameter and mass
 * Revision History: Debugging and testing the program
 * github link https://github.com/pflisch/Assignment4updated
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4updated
{
    class Program
    {
        static void Main(string[] args)
        {
            //The Main method of your driver class (Program), implements the GiantPlanet class by
            //creating a new giantPlanet object
            //public ToString() method

            GiantPlanet thisGiantPlanet = new GiantPlanet("Galactus", 70.0, 140.0, "Ice");
            Console.WriteLine(thisGiantPlanet.ToString());

            //The Main method of your driver class (Program), will also implement the
            //TerrestrialPlanet class by creating a new terrestrialPlanet object
            //public ToString() method

            TerrestrialPlanet thisTerrestrialPlanet = new TerrestrialPlanet("Pluto", 7000000.0, 1400000.0, true);
            Console.WriteLine(thisTerrestrialPlanet.ToString());

            //Implement another Method of your driver class (Program), WaitForAnyKey, that reads
            //the console for any key press before the console is closed
            WaitForAnyKey();
        }

        private static void WaitForAnyKey()
        {
            Console.Write("\n");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("| Please press any key to exit the console. |");
            Console.WriteLine("---------------------------------------------");
            Console.ReadKey();
        }
    }
}