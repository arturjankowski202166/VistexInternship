using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistexInternship
{
    public interface IShape
    {
        //double GetLenghtOfSide();
        //int GetNumberOfCorners();
        double CalculateField();
        Point[] CalculateCorners();
    }
}
