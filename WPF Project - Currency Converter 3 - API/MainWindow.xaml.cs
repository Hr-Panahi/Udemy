using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WPF_Project___Currency_Converter_3___API
{
    public partial class MainWindow : Window
    {
        Root val = new Root();

        public class Root            //Root Class is a Main Class. API returns rates
        {
            public Rate rates { get; set; } //get all record in rates and set in Rate Class as currency name wise
            public long timestamp;
            public string license;
        }

        public class Rate
        {
            public double USD { get; set; }
            public double EUR { get; set; }
            public double CAD { get; set; }
            public double GBP { get; set; }
            public double IRR { get; set; }
            public double TRY { get; set; }
            public double KWD { get; set; }
            public double CHF { get; set; }
            public double AED { get; set; }
            public double CNY { get; set; }
            public double BTC { get; set; }
            public double ETH { get; set; }

        }


        public MainWindow()
        {
            InitializeComponent();
            ClearControls();
            GetValue();

        }


        private async void GetValue()
        {
            val = await GetData<Root>("https://openexchangerates.org/api/latest.json?app_id=2964a9b007e0440aafe65c08ab6237f4");
            BindCurrency();
            
        }

        public static async Task<Root> GetData<T>(string url)
        {
            var myRoot = new Root();
            try
            {
                using (var client = new HttpClient()) //HttpClient class provides a base class for sending/receiving the HTTP request
                {
                    client.Timeout = TimeSpan.FromMinutes(1); //the timespan to wait before the request times out
                    HttpResponseMessage response = await client.GetAsync(url); //HttpsResponseMessage is a way of returning a message/date from your action
                    if (response.StatusCode == System.Net.HttpStatusCode.OK) //check API response status code ok
                    {
                        var ResponseString = await response.Content.ReadAsStringAsync(); //Serialize the HTTP content to a string
                        var ResponseObject = JsonConvert.DeserializeObject<Root>(ResponseString); //JsonConvert.DeserializeObject 

                        return ResponseObject; //Return API response 
                    }
                    return myRoot;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.None);
                return myRoot;
            }
        }


        private void BindCurrency()
        {

            //if (val != null && val.rate != null)
            //{
                DataTable dt = new DataTable();
                dt.Columns.Add("Text");
                dt.Columns.Add("Rate");

                dt.Rows.Add("--Select--", 0);
                dt.Rows.Add("USD", val.rates.USD);
                dt.Rows.Add("EUR", val.rates.EUR);
                dt.Rows.Add("CAD", val.rates.CAD);
                dt.Rows.Add("GBP", val.rates.GBP);
                dt.Rows.Add("IRR", val.rates.IRR);
                dt.Rows.Add("TRY", val.rates.TRY);
                dt.Rows.Add("KWD", val.rates.KWD);
                dt.Rows.Add("CHF", val.rates.CHF);
                dt.Rows.Add("AED", val.rates.AED);
                dt.Rows.Add("CNY", val.rates.CNY);
                dt.Rows.Add("BTC", val.rates.BTC);
                dt.Rows.Add("ETH", val.rates.ETH);

                cbFromCurrency.ItemsSource = dt.DefaultView;
                cbFromCurrency.DisplayMemberPath = "Text";
                cbFromCurrency.SelectedValuePath = "Rate";
                cbFromCurrency.SelectedIndex = 0;

                cbToCurrency.ItemsSource = dt.DefaultView;
                cbToCurrency.DisplayMemberPath = "Text";
                cbToCurrency.SelectedValuePath = "Rate";
                cbToCurrency.SelectedIndex = 0;
            //}
           // else
           // {
            //    MessageBox.Show("Error: Unable to retrieve currency rates.", 
            //        "Error", MessageBoxButton.OK, MessageBoxImage.Error);
           // }
        }
        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            double convertedAmount;

            //Check if the amount is Null or Blank
            if (amountCurrency == null || amountCurrency.Text.Trim() == "")
            {
                //If amount textbox is null or blank it will show this message box
                MessageBox.Show("Please enter amount", "Information",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                //After clicking OK on messagebox set focus on amount textbox
                amountCurrency.Focus();
                return;
            }
            //Else if the currency From is not selected or select default text --Select--
            else if (cbFromCurrency.SelectedValue == null || cbFromCurrency.SelectedIndex == 0)
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

                convertedAmount = (toRate * currentAmount) / fromRate;

                //some currencies like IRR have low value and it won't be seen when you are converting them
                //in the style of three decimal points. so you should show more decimal points.
                //also if you put more decimal points from the start, it will show some results like : 10.800000000
                if (convertedAmount.ToString("N3") != "0.000")
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