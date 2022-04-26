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
        //public static List<MyColor> ListOfProperties = new List<MyColor>();
        public static List<MyColor> ListOfProperties { get; set; }
        public ViewModel()
        {
            ListOfProperties = new List<MyColor>();
            ListOfProperties.Add(new MyColor { Name = "A1", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A2", Color = "White" });
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

        private RelayCommand _setColor;
        public RelayCommand SetColor => _setColor ?? new RelayCommand(x =>
        {
            var param = x.ToString();
            var temp = ListOfProperties.Find(x => x.Name == param);
            temp.Color = SelectedColor;
            var a = ListOfProperties[0].Color;
        });
    }
}
