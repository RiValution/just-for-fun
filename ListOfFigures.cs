using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class ListOfFigures<T> : IGeometry
    {
        List<T> list = new List<T>();


        public double Square
        {
            get
            {
                double sum = 0;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    // ты вот больной нет?
                    // он что конверитровать будет??
                    // ссылку на круг?
                    // укажи свойство в котором сраная площадь
                    // для этого приведи к интерфейсу

                    double x = (((IGeometry)list[i]).Square);
                    sum += x;

                }
                return sum;
            }
        }

        public double Diameter
        {
            get
            {
                double maxD = 0;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    // аналогично как с площадью
                    double x = (((IGeometry)list[i]).Diameter);
                    if (x > maxD)
                        maxD = x;
                }
                return maxD;
            }
        }

        public int CompareTo(object obj)
        {
            // оставь так пока
            throw new NotImplementedException();
        }
        public ListOfFigures()
        {

        }
        public ListOfFigures(List<T> newList)
        {
            List<T> list = new List<T>();
        }

        // блять у тебя this не List<T>, а ListOfFigurues<T>!
        // какие еще нахер triangles, circles
        // у тебя два объекта класса ListOfFigurues<T>
        // obj1 и obj2!
        public static ListOfFigures<T> operator +(ListOfFigures<T> obj1, ListOfFigures<T> obj2)
        {
            // я в шоке!! оно правильно написано!! 
            // только вот поменяй на ListOfFigurues<T>
            List<T> newList = new List<T>();
            newList.AddRange(obj1.list);
            newList.AddRange(obj2.list);
            return new ListOfFigures<T>(newList);

        }
        public override string ToString()
        {
            string line = "";
            for (int i = 0; i < list.Count; i++)
            {
                line = list[i].ToString();
                line += "\n";
            }
            return line;
        }


        // давай я тебе помогу
        public static ListOfFigures<T> GetListOfFigurues(int numberOfTriangles, int numberOfCircles)
        {
            Random r = new Random();
            List<T> modernList = new List<T>();

            for (int i = 0; i < numberOfTriangles - 1; i++)
            {
                try
                {
                    double A = Math.Round(-42.132 + r.NextDouble() * (7.003 + 42.132), 13);
                    double B = Math.Round(-42.132 + r.NextDouble() * (7.003 + 42.132), 13);
                    double C = Math.Round(-42.132 + r.NextDouble() * (7.003 + 42.132), 13);
                    modernList.Add((T)(IGeometry)new Triangle(A, B, C));
                }
                catch
                {
                    i--;
                }
            }
            for (int i = 0; i < numberOfCircles - 1; i++)
            {
                try
                {
                    double R = Math.Round(-42.132 + r.NextDouble() * (7.003 + 42.132), 13);
                    modernList.Add((T)(IGeometry)new Circle(R));
                }
                catch
                {
                    i--;
                }
            }
            return new ListOfFigures<T>(modernList);

            // зарандомь саначала треугольники потом кружки
            // рандомь стороны, затем добавляй в лист приводя тип к 
            // (T)(IGemoetry)
            // так как в конструкторах выбрасывается эксепшон
            // его надо ловить и рандомить заново 
        }

    }
}
