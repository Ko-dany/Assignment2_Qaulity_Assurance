using System;
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
    public class Rectangle
    {
        private int length, width;
        
        public Rectangle()
        {
            SetLength(1);
            SetWidth(1);
        }
        public Rectangle(int length, int width)
        {
            SetLength(length);
            SetWidth(width);
        }

        public int GetLength()
        {
            return length;
        }
        public int SetLength(int length)
        {
            this.length = length;
            return length;
        }
        public int GetWidth()
        {
            return width;
        }
        public int SetWidth(int width)
        {
            this.width = width;
            return width;
        }
        public int GetPerimeter()
        {
            return (width * 2 + length * 2);
        }
        public int GetArea()
        {
            return (width * length);
        }
    }
}
