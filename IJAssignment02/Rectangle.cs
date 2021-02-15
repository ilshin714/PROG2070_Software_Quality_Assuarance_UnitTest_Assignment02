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
    /// Rectangle class
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// lentgh variable
        /// </summary>
        private int length;

        /// <summary>
        /// width vadiable 
        /// </summary>
        private int width;

        /// <summary>
        /// Default Constructor which sets the length and width each to the value of 1
        /// </summary>
        public Rectangle()
        {
            this.length = 1;
            this.width = 1;
        }

        /// <summary>
        /// A non-default constructor which sets the length and width to whatever the user inputs
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        /// <summary>
        /// It gets the current length value in the class
        /// </summary>
        /// <returns>length value</returns>
        public int GetLength()
        {
            return this.length;
        }

        /// <summary>
        /// It overwrites the old length with the new length
        /// </summary>
        /// <param name="length">an user typed lentgh</param>
        /// <returns></returns>
        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }

        /// <summary>
        /// It gets the current width value in the class
        /// </summary>
        /// <returns>width value</returns>
        public int GetWidth()
        {
            return this.width;
        }

        /// <summary>
        /// It overwrites the old width with the new width
        /// </summary>
        /// <param name="width">>an user typed width</param>
        /// <returns></returns>
        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }

        /// <summary>
        /// It gets the perimeter value of a Rectangle with the length and width value
        /// </summary>
        /// <returns>the calculated perimeter value</returns>
        public int GetPerimeter()
        {
            int result = 0;
            result = (length + width) * 2;
            return result;
        }

        /// <summary>
        ///  It gets the area value of the Rectangle with the length and width value
        /// </summary>
        /// <returns>the calculated area value</returns>
        public int GetArea()
        {
            int result = 0;
            result = length * width;
            return result;
        }

    }

}
