using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PIxelBattle
{
    public class ViewModel : StaticViewModel
    {
        //public static List<MyColor> ListOfProperties = new List<MyColor>();
        public ObservableCollection<MyColor> _listOfProperties;
        public ObservableCollection<MyColor> ListOfProperties
        {
            get
            {
                return _listOfProperties;
            }
            set
            {
                _listOfProperties = value;
                OnPropertyChanged();
            }
        }
        public ViewModel()
        {
            ListOfProperties = new ObservableCollection<MyColor>();
            ListOfProperties.Add(new MyColor { Name = "A1", Color = "Red" });
            ListOfProperties.Add(new MyColor { Name = "A2", Color = "Green" });
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
            var temp = ListOfProperties.FirstOrDefault(x => x.Name == param);
            var test = new LogClass {Adress = param, ColorBefore = temp.Color, ColorAfter = SelectedColor};
            temp.Color = SelectedColor;
        });
    }
}
