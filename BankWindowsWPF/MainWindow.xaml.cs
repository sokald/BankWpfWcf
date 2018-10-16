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
        ServiceReferenceToDataBaseBank2.Service1Client obj = new ServiceReferenceToDataBaseBank2.Service1Client();

        public MainWindow()
        {
            InitializeComponent();
            ShowData();
        }

        public void ShowData()
        {
            DataSet ds = new DataSet();
            ds = obj.ShowAccount();
            DataGridAccount.DataContext = ds.Tables[0];
            //DataGridAccount.CanUserResizeColumns
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ServiceReferenceToDataBaseBank2.Account NewAccount = new ServiceReferenceToDataBaseBank2.Account();

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
    }
}
