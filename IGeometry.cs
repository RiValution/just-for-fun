using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IGeometry : IComparable
    {
        // почему пробелов нет между методами?????
        double Square { get; }

        double Diameter { get; }

        string ToString();       
        // а эти пробелы для кого?????7
    }
}
