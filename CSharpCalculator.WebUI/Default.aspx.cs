using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CSharpCalculator.WebUI
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ResetCalculator();
            }
        }

        private void ResetCalculator()
        {
            textboxNumber1.Text = string.Empty;
            textboxNumber2.Text = string.Empty;
            labelResult.Text = string.Empty;
        }

        protected void buttonReset_Click(object sender, EventArgs e)
        {
            ResetCalculator();
        }

        protected void buttonCalculate_Click(object sender, EventArgs e)
        {
            switch (dropdownlistOperator.SelectedItem.Text)
            {
                case "+":
                    labelResult.Text = string.Format("Result is {0}", Convert.ToInt16(textboxNumber1.Text) + Convert.ToInt16(textboxNumber2.Text));
                    break;
                case "-":
                    labelResult.Text = string.Format("Result is {0}", Convert.ToInt16(textboxNumber1.Text) - Convert.ToInt16(textboxNumber2.Text));
                    break;
                case "*":
                    labelResult.Text = string.Format("Result is {0}", Convert.ToInt16(textboxNumber1.Text) * Convert.ToInt16(textboxNumber2.Text));
                    break;
                case "/":
                    labelResult.Text = string.Format("Result is {0}", Convert.ToInt16(textboxNumber1.Text) / Convert.ToInt16(textboxNumber2.Text));
                    break;
                case "%":
                    labelResult.Text = string.Format("Result is {0}", Convert.ToInt16(textboxNumber1.Text) % Convert.ToInt16(textboxNumber2.Text));
                    break;
                case "m":
                    labelResult.Text = string.Format("Result is {0}", Convert.ToInt16(textboxNumber1.Text) * Convert.ToDouble(4046.86));
                    break;
                case "cm":
                    labelResult.Text = string.Format("Result is {0}", Convert.ToInt16(textboxNumber1.Text) * Convert.ToDouble(2.54));
                    break;
                case "FC":
                    labelResult.Text = string.Format("Result is {0}", Convert.ToInt16(textboxNumber1.Text) - Convert.ToDouble(32) * Convert.ToDouble(5556));
                    break;
                case "GL":
                    labelResult.Text = string.Format("Result is {0}", Convert.ToDouble(textboxNumber1.Text) * Convert.ToDouble(3.785));
                    break;
                case "PK":
                    labelResult.Text = string.Format("Result is {0}", Convert.ToDouble(textboxNumber1.Text) * Convert.ToDouble(0.4535));
                    break;
                case "MI":
                    labelResult.Text = string.Format("Result is {0}", Convert.ToDouble(textboxNumber1.Text) / Convert.ToDouble(39.370));
                    break;
                case "SH":
                    labelResult.Text = string.Format("Result is {0}", Convert.ToDouble(textboxNumber1.Text) / Convert.ToDouble(3600));
                    break;
                default:
                    break;
                    //Unit test on every function--excel inout values and shows which tests passed and which tests failed
            }
        }
    }
}