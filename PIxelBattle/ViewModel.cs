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
        public ViewModel() 
        {
            _currentCell = "red";
            _dataSet = BasicData.BasicSet();
        }
        private string _currentCell;
        public string CurrentCell
        {
            get
            {
                return _currentCell;
            }
            set
            {
                _currentCell  = "red";
                OnPropertyChanged();
            }
        }
        private List<BasicData> _dataSet;
        public List<BasicData> DataSet
        {
            get { return _dataSet; }
            set { _dataSet = BasicData.BasicSet(); }
        }
        private RelayCommand _changeColor;
        public RelayCommand ChangeColor => _changeColor ?? new RelayCommand(x =>
        {
            CurrentCell = "red";
            OnPropertyChanged();
        });
    }
}
