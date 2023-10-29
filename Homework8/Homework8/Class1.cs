using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class Triangle //8.1
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }


        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public  double GetPerimeter()
        {
            if (A + B <= C || A + C <= B || B + C <= A || A <= 0 || B <= 0 || C <= 0)
            {
                Console.WriteLine("There's no Triangle");
                return 0;
            }
            return A + B + C;
        }
        public  double GetArea()
        {
            if (A + B <= C || A + C <= B || B + C <= A || A <= 0 || B <= 0 || C <= 0)
            {
                Console.WriteLine("There's no Triangle");
                return 0;
            }
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Triangle))
            {
                return false;
            }

            Triangle other = (Triangle)obj;
            return A == other.A && B == other.B && C == other.C;
        }

        public override int GetHashCode()
        {
            return A.GetHashCode() ^ B.GetHashCode() ^ C.GetHashCode();
        }

        public static bool operator ==(Triangle a, Triangle b)
        {
            if(ReferenceEquals(a, b)) return true;  
            if(ReferenceEquals(a, null)) return false;
            if(ReferenceEquals(b, null)) return false; 
            return a.Equals(b);
        }

        public static bool operator !=(Triangle a, Triangle b) 
        {  
            return !(a == b); 
        }

        public static bool operator <(Triangle a, Triangle b)
        {
            if (a.GetArea() < b.GetArea())
            {
                return true;
            }
            return false;
        }

        public static bool operator >(Triangle a, Triangle b)
        {
            if (a.GetArea() > b.GetArea())
            {
                return true;
            }
            return false;
        }

        public static Triangle operator +(Triangle a, Triangle b)
        {
            double sumArea = a.GetArea()+b.GetArea();
            double C = Math.Sqrt(a.A *a.A + a.B *a.B);

            return new Triangle (a.A, a.B, C);
        }
        
    }

    class EquirateralTriangle : Triangle
    {
        public EquirateralTriangle(double sideA):base (sideA, sideA , sideA)
        {

        }

        public static explicit operator EquirateralTriangle(double sideA)
        {
            if (sideA > 0)
            {
                return new EquirateralTriangle(sideA);
            }
            else
            {
                throw new ArgumentException ("Not Valid Number");
            }
            
            
        }
    }

    
}

