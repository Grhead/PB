using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PIxelBattle
{
    public partial class MainWindow : Window
    {
        private List<BasicData> basicDatas = new List<BasicData>();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel();
            
        }

        private void b0_Click(object sender, RoutedEventArgs e)
        {
            var ca = b0.Background.ToString();
            var cb = (SolidColorBrush)new BrushConverter().ConvertFromString(ViewModel.SelectedColor);
            b0.Background = cb;
            BasicData nbd = new BasicData(ca, "b0", cb.ToString());
            basicDatas.Add(nbd);
        }
        private void b1_Click_1(object sender, RoutedEventArgs e)
        {
            b1.Background = (SolidColorBrush)new BrushConverter().ConvertFromString(ViewModel.SelectedColor);

        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            b2.Background = (SolidColorBrush)new BrushConverter().ConvertFromString(ViewModel.SelectedColor);

        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            b3.Background = (SolidColorBrush)new BrushConverter().ConvertFromString(ViewModel.SelectedColor);

        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            b4.Background = (SolidColorBrush)new BrushConverter().ConvertFromString(ViewModel.SelectedColor);
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            b5.Background = (SolidColorBrush)new BrushConverter().ConvertFromString(ViewModel.SelectedColor);
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            b6.Background = (SolidColorBrush)new BrushConverter().ConvertFromString(ViewModel.SelectedColor);
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            b7.Background = (SolidColorBrush)new BrushConverter().ConvertFromString(ViewModel.SelectedColor);
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            b8.Background = (SolidColorBrush)new BrushConverter().ConvertFromString(ViewModel.SelectedColor);
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            b9.Background = (SolidColorBrush)new BrushConverter().ConvertFromString(ViewModel.SelectedColor);
        }
    }
}
