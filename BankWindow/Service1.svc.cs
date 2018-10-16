using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BankWindow
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public DataSet ShowAccount()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Bank2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Account", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }

        public string SendAccount(Account NewAccount)
        {
            string Message;
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Bank2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Account(FirstName,LastName,City,Street,NrHouse,PostCode,AccountBalance) values(@FirstName,@LastName,@City,@Street,@NrHouse,@PostCode,@AccountBalance)", con);
            //cmd.Parameters.AddWithValue("@NrAccount", NewAccount.NrAccount1);
            cmd.Parameters.AddWithValue("@FirstName", NewAccount.FirstName1);
            cmd.Parameters.AddWithValue("@LastName", NewAccount.LastName1);
            cmd.Parameters.AddWithValue("@City", NewAccount.City1);
            cmd.Parameters.AddWithValue("@Street", NewAccount.Street1);
            cmd.Parameters.AddWithValue("@NrHouse", NewAccount.NrHouse1);
            cmd.Parameters.AddWithValue("@PostCode", NewAccount.PostCode1);
            cmd.Parameters.AddWithValue("@AccountBalance", NewAccount.AccountBalance1);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = NewAccount.NrAccount1 + " Details inserted successfully";
            }
            else
            {
                Message = NewAccount.NrAccount1 + " Details not inserted successfully";
            }
            con.Close();
            return Message;
        }
    }
}
