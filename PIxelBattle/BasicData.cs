﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIxelBattle
{
    public class BasicData
    {
        public string ColorBefore { get; set; }
        public string Adress { get; set; }
        public string ColorAfter { get; set; }

        public BasicData(string ColorBefore, string Adress, string ColorAfter)
        {
           this.ColorBefore = ColorBefore;
           this.Adress = Adress;
           this.ColorAfter = ColorAfter;
        }
    }
    
}
