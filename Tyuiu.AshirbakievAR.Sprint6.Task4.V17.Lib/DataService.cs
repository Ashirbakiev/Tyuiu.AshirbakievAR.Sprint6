﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AshirbakievAR.Sprint6.Task4.V17.Lib
{
    public class DataService : ISprint6Task4V17
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
                if (x + 1.7 == 0)
                {
                    valueArray[count] = 0;
                    count++;
                    continue;
                }
                y = (Math.Sin(x)/(x+1.7)-Math.Cos(x)*4*x-6);
                valueArray[count] = Math.Round(y, 2);
                count++;

            }
            return valueArray;
        }
    }
}
