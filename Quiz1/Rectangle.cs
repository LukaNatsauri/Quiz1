using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Quiz1
{   
    public class Rectangle : Shape
    {
        
        private double length;
        private double width;

        public Rectangle(double aLength, double aWidth)
        {
            length = aLength;
            width = aWidth;
            CalculateRectangleArea();
        }


       
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double CalculateRectangleArea() 
        {
            double area = length * width;
            return area;
        }
    }
}
