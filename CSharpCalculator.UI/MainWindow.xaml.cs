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
using Calculator.common;

namespace CSharpCalculator.UI
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CalFunctions myObj = new CalFunctions();
            ComboBoxItem cbi = (ComboBoxItem)Select.SelectedItem;
            int x=Convert.ToInt32(Number1.Text), y=Convert.ToInt32(Number2.Text);



            if (cbi.Content.ToString() == "+")
            {
                Result.Text = Convert.ToString(myObj.Addition(x,y));
            }
            if (cbi.Content.ToString() == "-")
            {
                Result.Text = Convert.ToString(myObj.Subtraction(x, y));
            }
            if (cbi.Content.ToString() == "*")
            {
                Result.Text = Convert.ToString(myObj.Multiplication(x, y));
            }
            if (cbi.Content.ToString() == "/")
            {
                Result.Text = Convert.ToString(myObj.Division(x, y));
            }
            if(cbi.Content.ToString() == "%")
            {
                Result.Text = Convert.ToString(myObj.Modulus(x, y));
            }
            if(cbi.Content.ToString() == "m")
            {
                Result.Text = Convert.ToString(myObj.AcresToSquareMetres(x));
            }
            if(cbi.Content.ToString() == "cm")
            {
                Result.Text = Convert.ToString(myObj.InchesToCentimeter(x));
            }
            if(cbi.Content.ToString() == "FC")
            {
                Result.Text = Convert.ToString(myObj.FarhenitToCelsius(x));
            }
            if(cbi.Content.ToString() == "GL")
            {
                Result.Text = Convert.ToString(myObj.USGalleonsToLitres(x));
            }
            if(cbi.Content.ToString() == "PK")
            {
                Result.Text = Convert.ToString(myObj.PoundsToKilo(x));
            }
            if(cbi.Content.ToString() == "MI")
            {
                Result.Text = Convert.ToString(myObj.MetresPerSecondToInchesPerSecond(x));
            }
            if(cbi.Content.ToString() == "SH")
            {
                Result.Text = Convert.ToString(myObj.SecondsToHours(x));
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Number1.Text = "";
            Number2.Text = "";
            Result.Text = "";

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
    }
}
