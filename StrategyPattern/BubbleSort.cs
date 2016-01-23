﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class BubbleSort : SortBase
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("Sorting using BubbleSort");
        }
    }
}
