using System;
using System.Collections.Generic;
using System.Data;
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
            ServiceReference1.Account NewAccount = new ServiceReference1.Account();
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

        // SelectAccount to show operation
        private void SelectAccount(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView AccountSelect = gd.SelectedItem as DataRowView;
            string nrAccount = AccountSelect["NrAccount"].ToString();
            

            DataSet ds = new DataSet();
            //DataTable ds = new DataTable()
            ds = obj.ShowOperation(nrAccount);

            DataGridOperation.AutoGenerateColumns = true;
            DataGridOperation.ItemsSource = ds.Tables[0].DefaultView;
        }
    }
}
