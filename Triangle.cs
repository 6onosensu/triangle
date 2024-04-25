using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    internal class Triangle
    {
        public double A, B, C, S, H, side;
        public Triangle() { }
        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        // A equilateral triangle
        public Triangle(double side)
        {
            this.side = side;
            this.A = this.B = this.C = side;
        }

        public Triangle (double s, double a) 
        {
            this.S = s;
            this.A = a;
        }
        public bool isTriangle 
        { 
            get
            {
                if (A + B > C && A + B + C > B && B + C > A) return true;
                else return false;
            }
        }
        public double GetSetA 
        { 
            get { return A; }
            set { A = value; }
        }
        public double GetSetB
        {
            get { return B; }
            set { B = value; }
        }
        public double GetSetC
        {
            get { return C; }
            set { C = value; }
        }
        public double GetSetS
        {
            get { return S; }
            set { S = value; }
        }
        public string TriangleType 
        { 
            get 
            {
                if (isTriangle) 
                {
                    if (A == B && B == C && A == C) return "equilateral triangle";
                    else if (A == B || A == C || B == C) return "Isosceles triangle";
                    else return "scalene triangle";
                    
                }
                return "unknown type";
            } 
        }
        public double Perimeter() { return A + B + C; }
        public double PerimeterHalf() { return (A + B + C) / 2; }
        public double Area() 
        {
            S = 0;
            if (isTriangle)
            {
                double p = (A + B + C) / 2;
                S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
            return S;
        }
        public string OutputA()
        {
            return A.ToString();
        }
        public string OutputB() 
        { 
            return B.ToString();
        }
        public string OutputC()
        {
            return C.ToString();
        }
    }
}
