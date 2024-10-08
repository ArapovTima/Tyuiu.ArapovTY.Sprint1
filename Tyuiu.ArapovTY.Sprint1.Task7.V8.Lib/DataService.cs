﻿using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ArapovTY.Sprint1.Task7.V8.Lib
{
    public class DataService : ISprint1Task7V8
    {
        public double Calculate(double x, double y)
        {
            double res = (x * (Math.Log(x, Math.E))) + (y / (Math.Cos(x) - x / 3));
            return Math.Round(res, 3);
        }
    }
}