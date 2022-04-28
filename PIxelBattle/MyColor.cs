﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIxelBattle
{
    public class MyColor : StaticViewModel
    {
        private string _name;
        private string _color;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; OnPropertyChanged(); }
        }
    }
}
