using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ClassLibrary1;

namespace ConsoleApp27
{

    class Program
    {

        static void Main(string[] args)
        {
            do
            {
                var firstList = ListOfFigures<IGeometry>.GetListOfFigurues(8, 2);
                var secondList = ListOfFigures<IGeometry>.GetListOfFigurues(1, 4);

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        static void Serialization(ListOfFigures<IGeometry> Figures)
        {
            // какой блять дабл
            // пиши Т 
            // у нас лист фигур
            // ф и г у р!!! там лежать будут серклы и трианглы!
            XmlSerializer formatter = new XmlSerializer(typeof(ListOfFigures<T>));
            FileStream fs = new FileStream("figures.xml", FileMode.OpenOrCreate);
            formatter.Serialize(fs, Figures);
            fs.Close();
            // А ЗАКРЫВАТЬ ПОТОК!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        }
        static void DeSerialization()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(ListOfFigures<T>));
            FileStream fs = new FileStream("figures.xml", FileMode.OpenOrCreate);
            var newFigures = (new ListOfFigures<IGeometry>());
            newFigures = (ListOfFigures<IGeometry>)formatter.Deserialize(fs);

        }

    }
}
