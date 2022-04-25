using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PIxelBattle
{
    public class ViewModel : StaticViewModel
    {
        public List<object> ListOfProperties = new List<object>();
        public ViewModel()
        {
            ListOfProperties.Add(A1);
            ListOfProperties.Add(A2);
        }
        private static string _selectedColor;
        public static string SelectedColor
        {
            get
            {
                return _selectedColor;
            }
            set
            {
                _selectedColor  = value;
            }
        }


        private RelayCommand _changeColor;
        public RelayCommand ChangeColor => _changeColor ?? new RelayCommand(x =>
        {
            SelectedColor = x.ToString();
            OnPropertyChanged();
        });

        public string A1 { get; set; } = "White";
        public string A2 { get; set; } = "White";

        private RelayCommand _setColor;
        public RelayCommand SetColor => _setColor ?? new RelayCommand(x =>
        {
            var param = x;
            var temp = ListOfProperties.Find(x => x == param);
            temp = SelectedColor;
        });
    }
}
