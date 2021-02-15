/*Project: IJAssignment02
 *Purpose: Unit Test of a console application. PROG2070 Assignemnt02 
 *History: 
 *Created by Ilshin Ji February 14, 2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJAssignment02
{
    /// <summary>
    /// This class is a console application to allow a user to create and work with a single rectangle object. 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main control logic is in this main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Variable declaration
            int length = 0;
            int width = 0;
            int result = 0;
            int perimeter = 0;
            int area = 0;
            int chosenMenu = 0;
            Rectangle rectangle = new Rectangle();

            //The exit option quits the program and is the only way to exit the program
            while (chosenMenu != 7)
            {
                //It displays the option menu
                ShowMenu();
                //It parses the user input to an integer
                int.TryParse(Console.ReadLine(), out chosenMenu);
                Console.WriteLine();

                //It will proceed logics depending on the users's choice.
                switch (chosenMenu)
                {
                    //Get the rectangle length
                    case 1:
                        length = rectangle.GetLength();
                        Console.WriteLine($"The rectangle length is {length}\n");
                        break;

                    //Change the rectangle length
                    case 2:
                        Console.WriteLine($"The current rectangle length is {length}");
                        length = ChangeRectangleLengthorWidth();
                        result = ResultCheck(length);
                        length = rectangle.SetLength(result);
                        Console.WriteLine($"The new rectangle length is {result}\n");
                        break;

                    //Get the rectangle width
                    case 3:
                        width = rectangle.GetWidth();
                        Console.WriteLine($"The rectangle width is {width}\n");
                        break;

                    //Change the rectangle width
                    case 4:
                        Console.WriteLine($"The current rectangle width is {width}");
                        width = ChangeRectangleLengthorWidth();
                        result = ResultCheck(width);
                        width = rectangle.SetWidth(result);
                        Console.WriteLine($"The new rectangle width is {result}\n");
                        break;

                    //Get the rectangle's perimeter
                    case 5:
                        result = rectangle.GetPerimeter();
                        Console.WriteLine($"The rectangle's perimeter is {result}\n");
                        break;

                    //Get the rectangle's area
                    case 6:
                        result = rectangle.GetArea();
                        Console.WriteLine($"The rectangle's area is {result}\n");
                        break;

                    //Exit the program
                    case 7:
                        Environment.Exit(-1);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// It displays menu to users to choose.
        /// </summary>
        public static void ShowMenu()
        {
            Console.Write("Please Choose number option 1 to 7\n" +
                                "1.Get Rectangle Length\n" +
                                "2.Change Rectangle Length\n" +
                                "3.Get Rectangle Width\n" +
                                "4.Change Rectangle Width\n" +
                                "5.Get Rectangle Perimeter\n" +
                                "6.Get Rectangle Area\n" +
                                "7.Exit\n" +
                                "Your option is: ");
        }

        /// <summary>
        /// This method will ask the user to type value of length or witdh
        /// </summary>
        /// <returns>The user typed value. If it is not a number, it will return 0 </returns>
        private static int ChangeRectangleLengthorWidth()
        {
            Console.Write("Please enter a number greater than 0 integer\n" +
                    "your number is : ");
            int.TryParse(Console.ReadLine(), out int inputLength);
            return inputLength;
        }

        /// <summary>
        /// Error handling method for the user typed lenght or witdh.
        /// input is provided, the user is informed of their mistake and asked to please enter a
        /// value again. This error handling and input validation can be done within the console
        /// application, rather than the Rectangle class methods.
        /// </summary>
        /// <param name="result">user typed integer value without validtion</param>
        /// <returns>correctly typed value for lenght or witdh</returns>
        private static int ResultCheck(int result)
        {
            //Each side must be an integer greater than zero. 
            while (result < 1)
            {
                Console.Write("Please enter a number greater than 0 integer\n" +
                    "your number is : ");
                int.TryParse(Console.ReadLine(), out result);
            }
            return result;
        }

    }

}
