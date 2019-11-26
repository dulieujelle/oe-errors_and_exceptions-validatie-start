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

namespace oe_errors_and_exceptions_validatie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void IntegerTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void FloatTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DecimalTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtInteger.TextChanged += IntegerTextBox_TextChanged;
            txtFloat.TextChanged += FloatTextBox_TextChanged;
            txtDecimal.TextChanged += DecimalTextBox_TextChanged;
            txtAantal.TextChanged += IntegerTextBox_TextChanged;
            txtSnelheid.TextChanged += FloatTextBox_TextChanged;
            txtPrijs.TextChanged += DecimalTextBox_TextChanged;
            tbkFeedBack.Visibility = Visibility.Hidden;
        }

        private void btnBevestig_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
