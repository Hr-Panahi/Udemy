using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPF_Project___Currency_Converter_2___DB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection con = new SqlConnection(); //Create Object for SqlConnection
        SqlCommand cmd = new SqlCommand();       //Create Object for SqlCommand
        SqlDataAdapter da = new SqlDataAdapter();//Create Object for for SqlDataAdapter

        private int CurrencyId = 0;
        private double FromAmount = 0;
        private double ToAmount = 0;

        public MainWindow()
        {
            InitializeComponent();
            BindCurrency();
            GetData();
        }

        public void mycon()
        {
            String Conn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString; //
            con = new SqlConnection(Conn);
            con.Open(); //Connection open
        }


        private void BindCurrency()
        {
            mycon();
            //Create object for DataTable
            DataTable dt = new DataTable();
            //Write query to get data from Currency_Master table
            cmd = new SqlCommand("select Id, CurrencyName from Currency_Master", con);
            //CommandType defines which type of command we use to write a query
            cmd.CommandType = CommandType.Text;

            //It is accepting a parameter that contains the command text of the object's selectCommand property
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            //Create an object for DataRow
            DataRow newRow = dt.NewRow();
            //Asign a value to Id column
            newRow["Id"] = 0;
            //Assign a value to CurrencyName column
            newRow["CurrencyName"] = "--Select--";

            //Insert a new row in dt with the data at 0 position
            dt.Rows.InsertAt(newRow, 0);

            //dt is not null and rows count greater than 0
            if (dt != null && dt.Rows.Count > 0)
            {
                //Assing the datatable data to cbFromCurrency combobox using ItemSource property.
                cbFromCurrency.ItemsSource = dt.DefaultView;

                //Assign the datatable data to cbToCurrency combobox using ItemSource property.
                cbToCurrency.ItemsSource = dt.DefaultView;
            }
            con.Close();

            cbFromCurrency.DisplayMemberPath = "CurrencyName";
            cbFromCurrency.SelectedValuePath = "Id";
            cbFromCurrency.SelectedIndex = 0;

            cbToCurrency.DisplayMemberPath = "CurrencyName";
            cbToCurrency.SelectedValuePath = "Id";
            cbToCurrency.SelectedIndex = 0;
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
                double.TryParse(GetConversionRate(cbFromCurrency.SelectedValue), out fromRate);
                double toRate;
                double.TryParse(GetConversionRate(cbToCurrency.SelectedValue), out toRate);
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


        //Method to Get Conversion Rates
        private string GetConversionRate(object currencyId)
        {
            string conversionRate = "0"; // Default value

            try
            {
                mycon();
                cmd = new SqlCommand("SELECT Amount FROM Currency_Master WHERE Id = @Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", currencyId);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    conversionRate = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                con.Close();
            }

            return conversionRate;
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

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtAmount.Text == null || txtAmount.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter Amount", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtAmount.Focus();
                    return;
                }
                else if (txtCurrencyName.Text == null || txtCurrencyName.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter Currency Name", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtCurrencyName.Focus();
                    return;
                }
                else
                {
                    if (CurrencyId > 0)
                    {
                        if (MessageBox.Show("Are you sure you want to update?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            mycon();
                            DataTable dt = new DataTable();
                            cmd = new SqlCommand("UPDATE Currency_Master SET Amount = @Amount, CurrencyName = @CurrencyName WHERE Id = @Id"
                                , con); //Update Query  Record update using Id
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@Id", CurrencyId);
                            cmd.Parameters.AddWithValue("@Amount", txtAmount.Text);
                            cmd.Parameters.AddWithValue("@CurrencyName", txtCurrencyName.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("Data Updated Successfully!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to save?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)

                        {
                            mycon();
                            cmd = new SqlCommand("INSERT INTO Currency_Master (Amount, CurrencyName) VALUES (@Amount, @CurrencyName)"
                                , con); //Insert Query for Save data in the table   
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@Amount", txtAmount.Text);
                            cmd.Parameters.AddWithValue("@CurrencyName", txtCurrencyName.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("Data Updated Successfully!", "Information", MessageBoxButton.OK,
                                MessageBoxImage.Information);
                        }

                    }
                    ClearMaster();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ClearMaster()
        {
            try
            {
                txtAmount.Text = string.Empty;
                txtCurrencyName.Text = string.Empty;
                btnSave.Content = "Save";
                GetData();
                CurrencyId = 0;
                BindCurrency();
                txtAmount.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void GetData() //Bind Data in datagrid view
        {
            mycon();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("SELECT * FROM Currency_Master", con);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
                dgvCurrency.ItemsSource = dt.DefaultView;
            else
                dgvCurrency.ItemsSource = null;
            con.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClearMaster();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void dgvCurrency_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {
                DataGrid grd = (DataGrid)sender;
                DataRowView row_selected = grd.CurrentItem as DataRowView;

                if (row_selected != null)
                {
                    if (dgvCurrency.Items.Count > 0)
                    {
                        if (grd.SelectedCells.Count > 0)
                        {
                            CurrencyId = Int32.Parse(row_selected["Id"].ToString());

                            if (grd.SelectedCells[0].Column.DisplayIndex == 0)
                            {
                                txtAmount.Text = row_selected["Amount"].ToString();
                                txtCurrencyName.Text = row_selected["CurrencyName"].ToString();
                                btnSave.Content = "Update";
                            }
                            if (grd.SelectedCells[0].Column.DisplayIndex == 1)
                            {
                                if (MessageBox.Show("Are you sure you want to delete?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Question)
                                    == MessageBoxResult.Yes)
                                {
                                    mycon();
                                    DataTable dt = new DataTable();
                                    cmd = new SqlCommand("DELETE FROM Currency_Master WHERE Id = @Id", con);
                                    cmd.CommandType = CommandType.Text;
                                    cmd.Parameters.AddWithValue("@Id", CurrencyId);
                                    cmd.ExecuteNonQuery();
                                    con.Close();

                                    MessageBox.Show("Data deleted successfully", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                                    ClearMaster();
                                }
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}