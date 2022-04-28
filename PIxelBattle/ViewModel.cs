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
            ListOfProperties.Add(new MyColor { Name = "A1", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A2", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A3", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A4", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A5", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A6", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A7", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A8", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A9", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A10", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A11", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A12", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A13", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A14", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A15", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A16", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A17", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A18", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A19", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A20", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A21", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A22", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A23", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A24", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A25", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A26", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A27", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A28", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A29", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A30", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A31", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A32", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A33", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A34", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A35", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A36", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A37", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A38", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A39", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A40", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A41", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A42", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A43", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A44", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A45", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A46", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A47", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A48", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A49", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A50", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A51", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A52", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A53", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A54", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A55", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A56", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A57", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A58", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A59", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A60", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A61", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A62", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A63", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A64", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A65", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A66", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A67", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A68", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A69", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A70", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A71", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A72", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A73", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A74", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A75", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A76", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A77", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A78", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A79", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A80", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A81", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A82", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A83", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A84", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A85", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A86", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A87", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A88", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A89", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A90", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A91", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A92", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A93", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A94", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A95", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A96", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A97", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A98", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A99", Color = "White" });
            ListOfProperties.Add(new MyColor { Name = "A100", Color = "White" });
            Log = new ObservableCollection<LogClass>(Service.data.LogClasses);

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
        private ObservableCollection<LogClass> _logs = new ObservableCollection<LogClass>();
        public ObservableCollection<LogClass> Log
        {
            get { return _logs; }
            set { _logs = value; OnPropertyChanged(); }
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
            LogClass test = new LogClass {Adress = param, ColorBefore = temp.Color, ColorAfter = SelectedColor};
            Service.data.Add(test);
            Service.data.SaveChanges();
            Log = (new ObservableCollection<LogClass>(Service.data.LogClasses));
            temp.Color = SelectedColor;
        });
    }
}
