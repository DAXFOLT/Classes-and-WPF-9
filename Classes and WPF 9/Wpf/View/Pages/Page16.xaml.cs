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
using Classes_and_WPF_9.Classes;

namespace Wpf.View.Pages
{
    public partial class Page16 : Page
    {
        public Page16()
        {
            InitializeComponent();
        }

        private void BtnTask16_Click(object sender, RoutedEventArgs e)
        {
            //double G = Math.Exp(2 * Convert.ToDouble(TbY.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
             Class1 = new Class1();

            Calculator16[] calculator16s =
                {
                    new Calculator16(3, 5, 4),

                    new Calculator16(3, 8, 11),

                    new Calculator16(9, 9, 9)
                };
            foreach (var calc in calculator16s)
            {
                string result = calc.CalculateA();
                MessageBox.Show($"Результат: {result}");
            }

        }
    }
}
