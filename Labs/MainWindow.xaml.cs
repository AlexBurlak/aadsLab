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
using Labs.Sorting;

namespace Labs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly RandomHelper _randomHelper;
        public MainWindow()
        {
            InitializeComponent();
            _randomHelper = new RandomHelper();
        }


        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            var array = _randomHelper.GenerateArray(10);
            ArrayValues.Text = string.Join(", ", array);
        }

        private void ArrayValues_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SortButton_Click(object sender, RoutedEventArgs e)
        {
            var array = ArrayValues.Text.Split(", ").Select(s => Int32.Parse(s)).ToArray();
            BubleSorter.Sort(ref array, out string sortStamp);
            SortResult.Text = string.Join(", ", array);
            ArraySteps.Text = sortStamp;
        }
    }
}
