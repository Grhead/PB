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
        private ObservableCollection<MyColor> _listOfProperties;
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
        private ObservableCollection<GetSetCount> _getSets;
        public ObservableCollection<GetSetCount> GetSets
        {
            get { return _getSets; }
            set {  _getSets = value; OnPropertyChanged(); }
        }
        private ObservableCollection<GetSetCount> _getGets;
        public ObservableCollection<GetSetCount> GetGets
        {
            get { return _getGets; }
            set { _getGets = value; OnPropertyChanged(); }
        }
        private void SetUp(int su)
        {
            if (su == 1)
            {

            ListOfProperties.Add(new MyColor { Name = "A1", Color = "White", Color2 = "Black" });
            ListOfProperties.Add(new MyColor { Name = "A2", Color = "White" , Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A3", Color = "White" , Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A4", Color = "White" , Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A5", Color = "White" , Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A6", Color = "White" , Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A7", Color = "White" , Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A8", Color = "White" , Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A9", Color = "White" , Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A10", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A11", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A12", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A13", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A14", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A15", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A16", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A17", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A18", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A19", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A20", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A21", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A22", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A23", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A24", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A25", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A26", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A27", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A28", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A29", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A30", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A31", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A32", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A33", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A34", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A35", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A36", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A37", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A38", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A39", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A40", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A41", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A42", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A43", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A44", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A45", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A46", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A47", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A48", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A49", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A50", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A51", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A52", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A53", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A54", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A55", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A56", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A57", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A58", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A59", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A60", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A61", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A62", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A63", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A64", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A65", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A66", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A67", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A68", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A69", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A70", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A71", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A72", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A73", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A74", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A75", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A76", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A77", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A78", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A79", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A80", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A81", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A82", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A83", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A84", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A85", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A86", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A87", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A88", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A89", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A90", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A91", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A92", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A93", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A94", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A95", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A96", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A97", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A98", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A99", Color = "White", Color2 = "Black"});
            ListOfProperties.Add(new MyColor { Name = "A100", Color = "White", Color2 = "Black" });
            }
            else
            {
                for (int i = 0; i < ListOfProperties.Count(); i++)
                {
                    ListOfProperties[i].Color = "White";
                    ListOfProperties[i].Color2 = "Black";
                }
            }
        }
        public ViewModel()
        {
            ListOfProperties = new ObservableCollection<MyColor>();
            SetUp(1);
            Log = new ObservableCollection<LogClass>(Service.data.LogClasses);

            GetSets = new ObservableCollection<GetSetCount>();
            GetSets.Add(new GetSetCount { Name = "Red", Count = 0 });
            GetSets.Add(new GetSetCount { Name = "Orange", Count = 0 });
            GetSets.Add(new GetSetCount { Name = "Yellow", Count = 0 });
            GetSets.Add(new GetSetCount { Name = "Green", Count = 0 });
            GetSets.Add(new GetSetCount { Name = "LightBlue", Count = 0 });
            GetSets.Add(new GetSetCount { Name = "Blue", Count = 0 });
            GetSets.Add(new GetSetCount { Name = "Purple", Count = 0 });

            GetGets = new ObservableCollection<GetSetCount>();
            GetGets.Add(new GetSetCount { Name = "Red", Count = 0 });
            GetGets.Add(new GetSetCount { Name = "Orange", Count = 0 });
            GetGets.Add(new GetSetCount { Name = "Yellow", Count = 0 });
            GetGets.Add(new GetSetCount { Name = "Green", Count = 0 });
            GetGets.Add(new GetSetCount { Name = "LightBlue", Count = 0 });
            GetGets.Add(new GetSetCount { Name = "Blue", Count = 0 });
            GetGets.Add(new GetSetCount { Name = "Purple", Count = 0 });
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
            if (test.ColorAfter != null && test.ColorAfter != test.ColorBefore)
            {
                Service.data.Add(test);
                Service.data.SaveChanges();
                if (SelectedColor != "White")
                {
                    Log = (new ObservableCollection<LogClass>(Service.data.LogClasses));
                    GetSetCount ColorCountSet = GetSets.FirstOrDefault(x => x.Name == SelectedColor);
                    GetSetCount ColorCountGet = GetGets.FirstOrDefault(x => x.Name == SelectedColor);
                    //ColorCountSet.Count = Service.data.LogClasses.Where(x => x.ColorAfter == ColorCountSet.Name).Count();
                    //ColorCountGet.Count = ColorCountSet.Count - Service.data.LogClasses.Where(x => x.ColorBefore == ColorCountGet.Name).Count();
                    foreach (var item in GetSets)
                    {
                        ColorCountSet = GetSets.FirstOrDefault(x => x.Name == item.Name);
                        ColorCountGet = GetGets.FirstOrDefault(x => x.Name == item.Name);
                        ColorCountSet.Count = Service.data.LogClasses.Where(x => x.ColorAfter == ColorCountSet.Name).Count();
                        ColorCountGet.Count = ColorCountSet.Count - Service.data.LogClasses.Where(x => x.ColorBefore == ColorCountGet.Name).Count();
                    }
                }
                temp.Color = SelectedColor;
                if (SelectedColor == "Purple" || SelectedColor == "Blue" || SelectedColor == "Green")
                {
                    temp.Color2= "White";
                }
                else
                {
                    temp.Color2 = "Black";
                }
            }
        });
        private RelayCommand _clearDB;
        public RelayCommand ClearDB => _clearDB ?? new RelayCommand(x =>
        {
            Service.data.LogClasses.RemoveRange(Log);
            Service.data.SaveChanges();
            Log = (new ObservableCollection<LogClass>(Service.data.LogClasses));
            GetSetCount ColorCountSet = GetSets.FirstOrDefault(x => x.Name == SelectedColor);
            GetSetCount ColorCountGet = GetGets.FirstOrDefault(x => x.Name == SelectedColor);
            foreach (var item in GetSets)
            {
                ColorCountSet = GetSets.FirstOrDefault(x => x.Name == item.Name);
                ColorCountGet = GetGets.FirstOrDefault(x => x.Name == item.Name);
                ColorCountSet.Count = Service.data.LogClasses.Where(x => x.ColorAfter == ColorCountSet.Name).Count();
                ColorCountGet.Count = ColorCountSet.Count - Service.data.LogClasses.Where(x => x.ColorBefore == ColorCountGet.Name).Count();
            }
            SetUp(2);
        });
    }
}
