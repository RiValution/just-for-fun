using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Circle : IGeometry
    {
        public double Square => R * R * Math.PI;

        public double Diameter => 2 * R;

        public int CompareTo(object obj)
        {
            Circle circle = (Circle)obj;
            if (Diameter > circle.Diameter) return 1;
            else if (Diameter < circle.Diameter) return -1;
            else return 0;
            // еще можно так
            // return Diameter.CompareTo((Circle)obj).Diameter);
        }
        public double R { get; set; }
        public Circle(double R)
        {
            if (R <= 0)
                throw new Exception();
            else
                this.R = R;
        }

        public override string ToString()
        {
            // сука перепиши
            // как в триангл
            return "Circle radius: " + $"{R:f2}" + "Square: " + $"{Square:f2}" + "Diameter: " + $"{Diameter:f2}";
        }
    }

}
