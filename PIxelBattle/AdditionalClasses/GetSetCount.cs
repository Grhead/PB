using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIxelBattle
{
    public class GetSetCount : StaticViewModel
    {
        private string _name;
        private int _count;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }
        public int Count
        {
            get { return _count; }
            set { _count = value; OnPropertyChanged(); }
        }
    }
}
