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
using System.Windows.Shapes;

namespace work_7._2
{
    /// <summary>
    /// Логика взаимодействия для Input.xaml
    /// </summary>
    public partial class Input : Window
    {
        internal double result { set; get; }
        internal bool flag = false;
        public Input()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double val1 = Convert.ToDouble(TextBoxVal1.Text);
                double val2 = Convert.ToDouble(TextBoxVal2.Text);
                if (rbComp.IsChecked == true)
                {
                    result = val1 * val2;
                    flag = true;
                    Close();
                }  
                else if (rbPow.IsChecked == true)
                {
                    result = Math.Pow(val1, val2);
                    flag = true;
                    Close();
                }  
                else if (rbAver.IsChecked == true)
                {
                    result = (val1 + val2) / 2;
                    flag = true;
                    Close();
                }
                else MessageBox.Show("You didn't choose an operation!", "What's wrong?", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch
            {
                MessageBox.Show("Incorrect data", "What's wrong?", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
