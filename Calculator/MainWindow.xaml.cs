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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Button_Click_sum(object sender, RoutedEventArgs e)
        {
            try
            {
                if (value1.Text != "" && value2.Text != "")
                {
                    double x = Convert.ToDouble(value1.Text);
                    double y = Convert.ToDouble(value2.Text);
                    double summa = x + y;
                    result.Text = summa.ToString();
                }
                else
                    result.Text = "Введены не все значения";
            }
            catch 
            {
               result.Text="Неверный формат ввода";
            }
        }

        private void Button_Click_raznost(object sender, RoutedEventArgs e)
        {
            try 
            {
                if (value1.Text != "" && value2.Text != "")
                {
                    double x = Convert.ToDouble(value1.Text);
                    double y = Convert.ToDouble(value2.Text);
                    double raznost = x - y;
                    result.Text = raznost.ToString();
                }
                else
                    result.Text = "Введены не все значения";
            }
            catch 
            {
                result.Text = "Неверный формат ввода";
            }
        }

        private void Button_Click_umnozhenie(object sender, RoutedEventArgs e)
        {
            try
            {
                if (value1.Text != "" && value2.Text != "")
                {
                    double x = Convert.ToDouble(value1.Text);
                    double y = Convert.ToDouble(value2.Text);
                    double umnozhenie = x * y;
                    result.Text = umnozhenie.ToString();
                }
                else
                    result.Text = "Введены не все значения";
            }
            catch 
            {
                result.Text = "Неверный формат ввода";
            }
        }

        private void Button_Click_delenie(object sender, RoutedEventArgs e)
        {
            try
            {
                if (value1.Text != "" && value2.Text != "")
                {
                    double x = Convert.ToDouble(value1.Text);
                    double y = Convert.ToDouble(value2.Text);
                    double delenie = x / y;
                    if (y == 0)
                        result.Text = "Ошибка! Деление на 0";
                    else
                        result.Text = delenie.ToString();
                }
                else
                    result.Text = "Введены не все значения";
            }
            catch 
            {
                result.Text = "Неверный формат ввода";
            }
        }

        private void Button_Click_kvadrat(object sender, RoutedEventArgs e)
        {
            try
            {
                if (value1.Text != "")
                {
                    double x = Convert.ToDouble(value1.Text);
                    double kvadrat = Math.Pow(x, 2);
                    value2.Clear();
                    result.Text = kvadrat.ToString();
                }
                else
                    result.Text = "Введите значение x";
            }
            catch 
            {
                result.Text = "Неверный формат ввода";
            }
        }

        private void Button_Click_stepen(object sender, RoutedEventArgs e)
        {
            try
            {
                if (value1.Text != "" && value2.Text != "")
                {
                    double x = Convert.ToDouble(value1.Text);
                    double y = Convert.ToDouble(value2.Text);
                    double stepen = Math.Pow(x, y);
                    result.Text = stepen.ToString();
                }
                else
                    result.Text = "Введены не все значения";
            }
            catch 
            {
                result.Text = "Неверный формат ввода";
            }
        }

        private void Button_Click_koren(object sender, RoutedEventArgs e)
        {
            try
            {
                if (value1.Text != "")
                {
                    double x = Convert.ToDouble(value1.Text);
                    double koren = Math.Sqrt(x);
                    value2.Clear();
                    result.Text = koren.ToString();
                }
                else
                    result.Text = "Введите значение x";
            }
            catch 
            {
                result.Text = "Неверный формат ввода";
            }
        }

        private void Button_Click_sbros(object sender, RoutedEventArgs e)
        {
            value1.Clear();
            value2.Clear();
            result.Clear();
        }
    }
}
