﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Rectangle.cs class
 * Rectangle class, is the main class of the program.
 * Created by Stefan
 * Created on 2/4/2024
 */

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
        
        // Default constructor of the class
        public Rectangle()
        {
            SetLength(1);
            SetWidth(1);
        }

        // Constructor with params 
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

        // A setter method to set the rectangle length
        public int SetLength(int length)
        {
            this.length = length;
            return length;
        }

        // A getter method to recieve the rectangle width
        public int GetWidth()
        {
            return width;
        }

        // A setter method to set the rectangle width
        public int SetWidth(int width)
        {
            this.width = width;
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
