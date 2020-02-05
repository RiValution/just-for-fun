using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Triangle : IGeometry
    {

        public double Square => Math.Sqrt((A + B + C) / 2 * ((A + B + C) / 2 - A) * ((A + B + C) / 2 - B) * ((A + B + C) / 2 - C));

        public double Diameter
        {
            get
            {

                return Math.Max(Math.Max(A, B), C);
                // в си шарпе есть функция Max, поменяй
                /*if (A > B && A > C)
                    return A;
                else if (B > C)
                    return B;
                else
                    return C;*/
            }
        }

        public int CompareTo(object obj)
        {
            // this убери
            Triangle triangle = (Triangle)obj;
            if (this.Diameter > triangle.Diameter) return 1;
            else if (this.Diameter < triangle.Diameter) return -1;
            else return 0;
        }
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double A, double B, double C)
        {
            // блять может сначала все таки проверка,потом присваивание

            // а отрицательные типа можно да?
            if (A != 0 && B != 0 && C != 0)
            {
                if (A + B < C || A + C < B || B + C < A)
                    throw new Exception();
                else if (A > 0 && B > 0 && C > 0)
                {
                    this.A = A;
                    this.B = B;
                    this.C = C;
                }
            }
            else
                throw new Exception();
        }
        public override string ToString()
        {
            // что такое {A}:f2????? надо {A:f2}!!!
            return "Triangle:" + "сторона А:" + $"{A:f2}" + "сторона В:" + $"{B:f2}" + "сторона С:" + $"{C:f2}" + "." + "Square=" + $"{Square:f2}" + "Diameter=" + $"{Diameter:f2}";
        }
    }
}
