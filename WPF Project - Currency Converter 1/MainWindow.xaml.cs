using System;
using System.Collections.Generic;
using System.Data;
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
using System.Text.RegularExpressions;

namespace WPF_Project___Currency_Converter_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BindCurrency();

        }
        
        private void BindCurrency()
        {
            DataTable dtCurrency = new DataTable();
            dtCurrency.Columns.Add("Text");
            dtCurrency.Columns.Add("Value");

            dtCurrency.Rows.Add("--Select--", 0);
            dtCurrency.Rows.Add("IRR", 55350);
            dtCurrency.Rows.Add("USD", 1.08);
            dtCurrency.Rows.Add("EUR", 1);
            dtCurrency.Rows.Add("CAD", 1.48);
            dtCurrency.Rows.Add("POUND", 0.87);
            dtCurrency.Rows.Add("CNY", 7.85);
            dtCurrency.Rows.Add("TRY", 31.05);

            cbFromCurrency.ItemsSource = dtCurrency.DefaultView;
            cbFromCurrency.DisplayMemberPath = "Text";
            cbFromCurrency.SelectedValuePath = "Value";
            cbFromCurrency.SelectedIndex = 0;

            cbToCurrency.ItemsSource = dtCurrency.DefaultView;
            cbToCurrency.DisplayMemberPath = "Text";
            cbToCurrency.SelectedValuePath = "Value";
            cbToCurrency.SelectedIndex = 0;
        }
        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            double convertedAmount;

            //Check if the amount is Null or Blank
            if(amountCurrency == null || amountCurrency.Text.Trim() == "")
            {
                //If amount textbox is null or blank it will show this message box
                MessageBox.Show("Please enter amount","Information",
                    MessageBoxButton.OK,MessageBoxImage.Information);
                //After clicking OK on messagebox set focus on amount textbox
                amountCurrency.Focus();
                return;
            }
            //Else if the currency From is not selected or select default text --Select--
            else if(cbFromCurrency.SelectedValue == null || cbFromCurrency.SelectedIndex == 0)
            {
                //Show messagebox
                MessageBox.Show("Please select currency From", "information", 
                    MessageBoxButton.OK, MessageBoxImage.Information);
                cbFromCurrency.Focus();
                return;
            }
            else if (cbToCurrency.SelectedValue == null || cbToCurrency.SelectedIndex == 0)
            {
                //Show messagebox
                MessageBox.Show("Please select currency To", "information",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                cbToCurrency.Focus();
                return;
            }

            //check if Form and To combobox selected values are the same
            if (cbFromCurrency.Text == cbToCurrency.Text)
            {
                //Amount textbox value set in convertedAmount.
                //double.parse is used to convert data type string to double
                //textbox text have string and convertedAmount is double data type.
                convertedAmount = double.Parse(amountCurrency.Text);
                //Show the label converted currency and converted currency name and ToString("N3") is used to place 000 after the dot(.)
                lblCurrency.Content = cbToCurrency.Text + convertedAmount.ToString("N3");
            }
            else
            {
                double fromRate;
                double.TryParse(cbFromCurrency.SelectedValue.ToString(), out fromRate);
                double toRate;
                double.TryParse(cbToCurrency.SelectedValue.ToString(), out toRate);
                double currentAmount;
                double.TryParse(amountCurrency.Text, out currentAmount);

                convertedAmount = (toRate * currentAmount ) / fromRate;

                //some currencies like IRR have low value and it won't be seen when you are converting them
                //in the style of three decimal points. so you should show more decimal points.
                //also if you put more decimal points from the start, it will show some results like : 10.800000000
                if(convertedAmount.ToString("N3") != "0.000")
                {
                    lblCurrency.Content = cbToCurrency.Text + " " + convertedAmount.ToString("N3");
                }
                else
                {
                    lblCurrency.Content = cbToCurrency.Text + " " + convertedAmount.ToString("N6");
                }

            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            cbFromCurrency.SelectedIndex = 0;
            cbToCurrency.SelectedIndex = 0;
            lblCurrency.Content = string.Empty;
            amountCurrency.Text = string.Empty;
            amountCurrency.Focus();
        }


        private void NumberValidationTextBlock(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

    }
}
