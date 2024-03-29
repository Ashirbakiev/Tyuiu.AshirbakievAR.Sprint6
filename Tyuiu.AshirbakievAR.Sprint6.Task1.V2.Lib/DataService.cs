﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AshirbakievAR.Sprint6.Task1.V2.Lib
{
    public class DataService : ISprint6Task1V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y = 0;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x) + 2 == 0)
                {
                    valueArray[count] = 0;
                    count++;
                    continue;
                }
                y = ((((double)x * 5 + 2.5) / (Math.Sin(x) + 2)) + 2 * x + 2);
                valueArray[count] = Math.Round(y, 2);
                count++;

            }
            return valueArray;
        }
    }
}
