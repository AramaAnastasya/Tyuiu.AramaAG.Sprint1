﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AramaAG.Sprint1.Task3.V19.Lib
{
    public class DataService : ISprint1Task3V19
    {
        public bool ElephCanMove(double x1, double x2, double y1, double y2)
        {
            bool res;
            if(Math.Abs(x1-x2) == Math.Abs(y1 - y2))
            {
                res = true;
            }
            else { res = false; }
            return res;
        }
    }
}