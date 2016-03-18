using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a fortune telling program!");

            bool playAgainBool = true;
            do
            {
                FortuneTellingProgram();
                Console.WriteLine("Would you like to get another fortune? yes or no");
                string userResponse = Console.ReadLine();
                if (!(userResponse.ToUpper() == "YES" || userResponse.ToUpper() == "Y"))
                {
                    playAgainBool = false;
                }
            }
            while (playAgainBool);

            Console.WriteLine("Goodbye!");

        }

        static void FortuneTellingProgram()
        {
            // PART ONE: ASKING USER FOR INPUT

            Console.WriteLine("Please enter your first name.");                                                                /* Console.WriteLine("Please enter your last name.  "); */
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name.");
            string lastName = Console.ReadLine();

     
            Console.WriteLine("How old are you.");
            int age = int.Parse(Console.ReadLine());

            while (age < 1 || age > 110)
            {
                Console.WriteLine("Come on, you can't be that age. How old are you?");
                age = int.Parse(Console.ReadLine());
            }

            string birthMonth = "";
            string[] monthsOfTheYear = { "JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER" };
                        
            bool monthFound = false;

            do
            {
                Console.WriteLine("What month were you born?");
                birthMonth = Console.ReadLine().ToUpper();
                foreach(string month in monthsOfTheYear)
                {
                    if(month == birthMonth)
                    {
                        monthFound = true;
                        break;

                    }
                }
                if (monthFound == false)
                {
                    Console.Write("Input not recognized. Please type full month name. ");
                }
            }
            while (monthFound == false);

            Console.WriteLine("What's your favorite ROYGBIV color? (If you do not know what ROYGBIV is, type \"Help\")");
            string favColor = (Console.ReadLine());
            if (favColor.ToUpper() == "HELP")
            {
                Console.WriteLine("ROYGBIV colors are red, orange, yellow, green, blue,, indigo, violet.");
                Console.WriteLine("What's your favorite ROYGBIV color?");
                favColor = (Console.ReadLine());
            }

            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());

            // PART TWO: MANIPULATING INPUT

            int yearsToRetirement;
            if (age % 2 == 0)
            {
                yearsToRetirement = 10;
            }
            else
            {
                yearsToRetirement = 20;
            }

            string whereYouLive = "";
            switch (siblings)
            {
                case 0:
                    whereYouLive = "Florida";
                    break;
                case 1:
                    whereYouLive = "Malibu";
                    break;
                case 2:
                    whereYouLive = "Italy";
                    break;
                case 3:
                    whereYouLive = "Portugal";
                    break;
                default:
                    whereYouLive = "South Africa";
                    break;
            }
            string vehicle = "";

            switch (favColor.ToLower())
            {
                case "red":
                    vehicle = "fire truck";
                    break;
                case "orange":
                    vehicle = "Vespa scooter";
                    break;
                case "yellow":
                    vehicle = "VW beetle";
                    break;
                case "green":
                    vehicle = "golf cart";
                    break;
                case "blue":
                    vehicle = "Ferrari";
                    break;
                case "indigo":
                    vehicle = "motorcycle";
                    break;
                case "violet":
                    vehicle = "Camaro";
                    break;
                default:
                    vehicle = "van down by the river";
                    break;
            }

            decimal moneyInTheBank;

            string firstNameUpper = firstName.ToUpper();
            string lastNameUpper = lastName.ToUpper();
            

            if (firstNameUpper.IndexOf(birthMonth[0]) != -1 || lastNameUpper.IndexOf(birthMonth[0]) != -1)
            {
                moneyInTheBank = 1000;
            }
            else if (firstNameUpper.IndexOf(birthMonth[1]) != -1 || lastNameUpper.IndexOf(birthMonth[1]) != -1)
            {
                moneyInTheBank = 10000;
            }
            else if (firstNameUpper.IndexOf(birthMonth[2]) != -1 || lastNameUpper.IndexOf(birthMonth[2]) != -1)
            {
                moneyInTheBank = 100000;
            }
            else
            {
                moneyInTheBank = 0;
            }

            // PART THREE: PRINTING OUT THE FORTUNE

            Console.WriteLine("Your fortune is:");
            Console.WriteLine("{0} {1} will retire in {2} years with ${3} in the bank, a vacation home in {4} and a {5}.", firstName, lastName, yearsToRetirement, moneyInTheBank, whereYouLive, vehicle);

        }
    }
}
