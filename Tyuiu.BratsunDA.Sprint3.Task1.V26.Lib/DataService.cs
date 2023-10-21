using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BratsunDA.Sprint3.Task1.V26.Lib
{
    public class DataService : ISprint3Task1V26
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries + Math.Pow((6/(Math.Pow(value, i))), 2);
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
