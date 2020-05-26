/******************************************************
* Programmer: Lance Zotigh (lzotigh@cnm.edu)
* Program: IdealGasCal
* Date: 2/24/2020
* Purpose: To claculate the pressure exertied by a given gas
* project.
*******************************************************/

using System;
using System.Reflection.Metadata.Ecma335;

namespace ZotighIdealGasCal
{
    class Program
    {
        //declair constants
        private const double GAS_CONSTANT = 8.3145;
        private const double PASCALS_TO_PSI = 0.000145037738;
        private const double DEGREE_KELVIN_AT_ZERO_CELSIUS = 273.15;

        static void Main(string[] args)
        {
            //declair the arrays. their aere two of them doubles
            //declair int for count

            DisplayHeader();
            //Call ReadMolecularWeights(...)
            //Call DisplayGasNames()
            
            //open a do while loop for repeat calculations
            //call GetMolecularWeightFromName, returns 
            //check to see 'if' molecular weight is == 0 else return 0
            //else = the gasName was found 
            //private static double GetDoubleFromUser(string prompt) // three times ie the questions please enter etc...
            //ask for the volume of the gas, the mass of the gas in grams 
            //and tempature of the gas in celsious
            //call Presssure to get the pressure
            //DisplayPressure, passing in the pressure
            //ask the user if they want to go again dawg? maybe do another function
            //finish the while

            //Exit message

        }

        public static void DisplayHeader()
        {
            Console.WriteLine("Lance Zotigh");
            Console.WriteLine("\nIdeal Gas Calc");
            Console.WriteLine("\nObjective: To calculate the pressure of a given gas.");
        }

        static void ReadMolecularWeights(ref string[] gasNames, ref double[] molecularWeights, out int count)
        {
            //Create a StreamReader object passing it the name of the file to be read the csv
            //Use the splitStream or split function to split the data on a comma.
            //Read one line at a time (use split method) based on dilimmiter i.e Split(',') returns an array this needs to be split into two. throw away first line
            //Reading string and a double, so use an array of strings and converet the second element into a double
            string line = "asdf";
            string[] elements = line.Split(',');
        }

        private static double GetDoubleFromUser(string prompt)
        {
            //display the string prompt
            //what the user enters
            return 1.0;
        }

        private static void DisplayGasNames(string[] gasNames, int countGases)
        {
            //Dislplay names of the gases read with a while loop while the line we are reading is not null.
        }

        private static double GetMolecularWeightFromName(string gasName, string[] gasNames, double[] molecularWeights, int countGases)
        {
            //Search for GasName in gasNames array
            // go to the same index in the molecular weight array
            //if no weight found return 0
            double molWt = 1.0; // or just return molecular weights
            return molWt;
        }

        static double Pressure(double mass, double vol, double temp, double molecularWeight)
        {
            //calculate the parameters 
            //first call NumberofMoles to calculate the number of moles
            return 1.0;
        }

        static double NumberOfMoles(double mass, double molecularWeight)
        {
            //Given mass and molecular weight, return the number of moles
            return 1.0;
        }

        static double CelciusToKelvin(double celcius)
        {
            //return degrees Kelvin
            return 1.0;
        }

        private static void DisplayPresure(double pressure)
        {
            //Display the pressure in Pascals and to PSI to the console. use a conversion
            //Given the pressure in pascals
            //Call the function PatoPSI to do the conversion
        }

        static double PaToPSI(double pascals)
        {
            //return the converted value 
            return 1.0;
        }

    }
}
