﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_MVP_ModelViewPresenter.Model
{
    public class Rectangle
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public double CalcArea()
        {
            return Length * Breadth;
        }
    }
}
