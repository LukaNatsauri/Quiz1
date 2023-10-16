using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    public class Circle : Shape
    {

        private double radius;

        public Circle(double aRadius)
        {
            radius = aRadius;
            CalculateCircleArea();
        }


        public double Radius 
        {
            get { return radius; }
            set { radius = value; }
        }

        private double CalculateCircleArea() 
        {
            double area = Math.PI * radius * radius;
            return area;
        }
    }
}
