using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace COMP100SEC007_LAB02
{
    internal class Program
    {
        static void Main(string[] args)
        {  //variables
            int userInput;
            double inches, centimeters, Fahrenheit, Celsius, a, b, c, discriminant = 0, x, x1;

            Console.WriteLine("Hello dear user, for this program you can select the following functions");
            Console.WriteLine();

            //while loop until condiction is false
            do
            {
                //Display the menu option for user
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("1. Converting Inches to CM");
                Console.WriteLine("2. Converting Fahrenheit to Celsius(\x00B0F to \x00B0C conversion)");
                Console.WriteLine("3. Calculating Quadratic Equations");
                Console.WriteLine("4. Exit");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine();


                //get user input and convert to integer
                userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                //using swith statment to handle different user inputs
                switch (userInput)
                {
                    case 1:
                        //prompt for inches from user
                        Console.Write("Please enter the measurement in Inches: ");
                        inches = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        //calculate the centimeters
                        centimeters = inches * 2.54;
                        //display output
                        Console.WriteLine($"{inches} inches is equal to {centimeters} CM");
                        break;
                    case 2:
                        //prompt for temperature in Fahrenheit
                        Console.Write("Please enter the temperature in Fahrenheit: ");
                        Fahrenheit = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        //calculate degree Celsius
                        Celsius = (Fahrenheit - 32) / 1.8;
                        //display output
                        //I googled that \x00B0 is the degree symbol
                        Console.WriteLine($"{Fahrenheit}\x00B0F is equal to {Celsius:f2}\x00B0C");
                        break;
                    case 3:
                        // prompt for the value of a b and c from user
                        Console.Write("Please enter a for quadratic Equation: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Please enter b for quadratic Equation: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Please enter c for quadratic Equation: ");
                        c = Convert.ToDouble(Console.ReadLine());

                        //importatnt condiction decideds the equation has two real roots or one or two distinct roots
                        discriminant = (b * b) - (4 * a * c);

                        //using if statement to check discriminant
                        if (discriminant > 0)
                        {
                            x = (-b + Math.Sqrt(b * b - 4 * a * c)) / (a * 2);
                            x1 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (a * 2);
                            Console.WriteLine($"X1 = {x}  X2 = {x1}");
                        }
                        else if (discriminant == 0)
                        {
                            x = (-b + Math.Sqrt(b * b - 4 * a * c)) / (a * 2);
                            Console.WriteLine($"There is one real root x = {x}");
                        }
                        else
                        {
                            Console.WriteLine("This equation has two distinct(non-real) roots");
                        }
                        break;
                    case 4:
                        Console.WriteLine("thank you for using");
                        Console.ReadLine();
                        return;
                    //user inputs number not in (1~4)
                    default:
                        Console.WriteLine("The number is out of range please try again");
                        Console.WriteLine();
                        continue;
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            
            } while (userInput != 4);
           
            
            Console.ReadLine();
        }
    }
}
