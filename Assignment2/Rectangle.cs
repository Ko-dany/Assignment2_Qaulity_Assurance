/*
 * Program: PROG2070-SEC8
 * Purpose: Assignment 2
 * Revision History:
 *      created by Stefan Kobetich, Dahyun Ko, Feb/4/2024
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment2
{
    /// <summary>
    /// Rectangle class for manipulation and use of a triangle 
    /// </summary>
    public class Rectangle
    {
        private int length, width;

        // Main method of class
        public static void Main()
        {

        }
        
        // Default constructor that initialize the length & width as 1.
        public Rectangle()
        {
            SetLength(1);
            SetWidth(1);
        }

        // Constructor with params that sets the length & width as user inputs.
        public Rectangle(int length, int width)
        {
            SetLength(length);
            SetWidth(width);
        }

        // A getter method to recieve the rectangle length
        public int GetLength()
        {
            return length;
        }

        // A setter method to set the rectangle length as long as its bigger than 0 and smaller than 1100
        public int SetLength(int length)
        {
            if (length < 1100 && length > 0)
            {
                this.length = length;
            }
            else
            {
                this.length = 1;
            }
            return length;
        }

        // A getter method to recieve the rectangle width
        public int GetWidth()
        {
            return width;
        }

        // A setter method to set the rectangle width as long as its bigger than 0 and smaller than 1100
        public int SetWidth(int width)
        {
            if (width < 1100 && width > 0)
            {
                this.width = width;
            }
            else
            {
                this.width = 1;
            }
            return width;
        }

        // A get perimeter method that gets the perimeter of the rectangle
        public int GetPerimeter()
        {
            return (width * 2 + length * 2);
        }

        // A get area method that gets the area of the rectangle
        public int GetArea()
        {
            return (width * length);
        }
    }
}
