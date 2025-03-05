﻿
using System.Windows;
using System.Windows.Controls;
using Classes_And_WPF.Classes;

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
            Class16 = new Class16();

            Class16[] class16s =
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
