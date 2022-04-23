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

        private string _selectedColor;
        public string SelectedColor
        {
            get
            {
                return _selectedColor;
            }
            set
            {
                _selectedColor  = value;
                OnPropertyChanged();
            }
        }
        //private List<BasicData> _dataSet;
        //public List<BasicData> DataSet
        //{
        //    get { return _dataSet; }
        //    set { _dataSet = BasicData.BasicSet(); }
        //}
        private RelayCommand _changeColor;
        public RelayCommand ChangeColor => _changeColor ?? new RelayCommand(x =>
        {
            SelectedColor = x.ToString();
            OnPropertyChanged();
        });
        private RelayCommand _setColor;
        public RelayCommand SetColor => _setColor ?? new RelayCommand(x =>
        {
            
            OnPropertyChanged();
        });
    }
}
