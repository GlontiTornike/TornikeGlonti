using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
   public abstract class Shape
    {
        public abstract double Perimeter();
        public abstract double Area();
    }

    public class Circle : Shape
    {

        public double R { get; set; }
        public double P { get; set; }
        public Circle(double r)
        {
            R = r;
            P = Math.PI;
        }
        public override double Perimeter()
        {
            if (R > 0) {
                return 2 * R * P;
            }
            return double.NaN;
        }
        public override double Area()
        {
            if (R > 0)
            {
                return P*R*R;
            }
            return double.NaN;
        }

    }
    public class Rectangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }

        public Rectangle (double a, double b)
        {
            A = a;
            B = b;
        }
        public override double Perimeter()
        {
            if(A<=0 || B <= 0)
            {
                return 0;
            }
            return (A + B)*2;
        }
        public override double Area()
        {
            return A * B;
        }
    }



    public class Triangle : Shape
    {
        public double A {  get; set; }
        public double B { get; set; }
        public double C { get; set; }


        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public override double Perimeter()
        {
            if(A + B <= C || A + C <= B || B + C <= A || A <=0 || B <= 0 || C <= 0)
            {
                Console.WriteLine("There's no Triangle");
                return 0;
            }
            return A+B+C;
        }
        public override double Area()
        {
            if(A + B <= C || A + C <= B || B + C <= A || A <= 0 || B <= 0 || C <= 0)
            {
                Console.WriteLine("There's no Triangle");
                return 0;
            }
            double p = Perimeter()/2;
            return  Math.Sqrt(p*(p-A)*(p-B)*(p-C));
        }
    }



    
}
