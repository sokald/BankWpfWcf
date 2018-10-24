using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankWindowsWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
        ServiceReferenceToDataBaseBank2.Service1Client obj2 = new ServiceReferenceToDataBaseBank2.Service1Client();
        //ServiceReference2.Service1Client obj3 = new ServiceReference2.Service1Client();

        public MainWindow()
        {
            InitializeComponent();
            ShowData();
        }

        // show account in dataGrid
        public void ShowData()
        {
            DataSet ds = new DataSet();
            //DataTable ds = new DataTable()
            ds = obj.ShowAccount();
            
            DataGridAccount.AutoGenerateColumns = true;           
            DataGridAccount.ItemsSource = ds.Tables[0].DefaultView;
        }

        // save new account in database
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ServiceReferenceToDataBaseBank2.Account NewAccount = new ServiceReferenceToDataBaseBank2.Account();
            BankWindow.Account NewAccount = new BankWindow.Account();

            //NewAccount.NrAccount1 = null;
            NewAccount.FirstName1 = TextBoxFirstName.Text;
            NewAccount.LastName1 = TextBoxLastName.Text;
            NewAccount.City1 = TextBoxCity.Text;
            NewAccount.Street1 = TextBoxStreet.Text;
            NewAccount.NrHouse1 = Int32.Parse(TextBoxNrHouse.Text);
            NewAccount.PostCode1 = Int32.Parse(TextBoxPostCode.Text.ToString());
            NewAccount.AccountBalance1 = Int32.Parse(TextBoxAccountBallance.Text.ToString());

            obj.SendAccount(NewAccount);
            ShowData();
        }

        public DataRowView AccountSelect;
        // SelectAccount to show operation
        private void SelectAccount(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            AccountSelect = gd.SelectedItem as DataRowView;
            //string NrAccount = AccountSelect["NrAccount"].ToString();
            
            
            DataSet ds = new DataSet();
            //DataTable ds = new DataTable()
            ds = obj.ShowOperation(AccountSelect["NrAccount"].ToString());

            DataGridOperation.AutoGenerateColumns = true;
            DataGridOperation.ItemsSource = ds.Tables[0].DefaultView;
        }

        private void SelectAccount(string NrAccount)
        {
            //DataGrid gd = (DataGrid)sender;
            //AccountSelect = gd.SelectedItem as DataRowView;
            //string NrAccount = AccountSelect["NrAccount"].ToString();


            DataSet ds = new DataSet();
            //DataTable ds = new DataTable()
            ds = obj.ShowOperation(NrAccount);

            DataGridOperation.AutoGenerateColumns = true;
            DataGridOperation.ItemsSource = ds.Tables[0].DefaultView;
        }

        private void ButtonSaveOperation_Click(object sender, RoutedEventArgs e)
        {
            //ServiceReferenceToDataBaseBank2.Account NewAccount = new ServiceReferenceToDataBaseBank2.Account();
            ServiceReference1.Operation NewOperation = new ServiceReference1.Operation();

            string NrAccount = AccountSelect["NrAccount"].ToString();

            NewOperation.NrAccount1 = NrAccount;
            NewOperation.Amount1 = int.Parse(TextBoxOperationAmount.Text.ToString());
            NewOperation.DateTransaction1 = DateOperation.SelectedDate.Value.Date;

            obj.SendOperation(NewOperation);
            //ShowData();
            SelectAccount(NrAccount);
        }
    }
}
