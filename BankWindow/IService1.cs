using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BankWindow
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string SendAccount(Account NewAccount);

        [OperationContract]
        DataSet ShowAccount();

        [OperationContract]
        DataSet ShowOperation(string NrAccount);
        //[OperationContract]
        //DataSet ShowAccount(Account NrAccount);

        [OperationContract]
        string SendOperation(Operation operation);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Account
    {
        int NrAccount;
        string FirstName;
        string LastName;
        string City;
        string Street;
        int NrHouse;
        int PostCode;
        double AccountBalance;

        [DataMember]
        public int NrAccount1
        {
            get { return NrAccount; }
            set { NrAccount = value; }
        }
        [DataMember]
        public string FirstName1
        {
            get { return FirstName; }
            set { FirstName = value; }
        }
        [DataMember]
        public string LastName1
        {
            get { return LastName; }
            set { LastName = value; }
        }
        [DataMember]
        public string City1
        {
            get { return City; }
            set { City = value; }
        }
        [DataMember]
        public string Street1
        {
            get { return Street; }
            set { Street = value; }
        }
        [DataMember]
        public int NrHouse1
        {
            get { return NrHouse; }
            set { NrHouse = value; }
        }
        [DataMember]
        public int PostCode1
        {
            get { return PostCode; }
            set { PostCode = value; }
        }
        [DataMember]
        public double AccountBalance1
        {
            get { return AccountBalance; }
            set { AccountBalance = value; }
        }
    }

    [DataContract]
    public class Operation
    {
        string NrAccount;
        int Amount;
        DateTime DateTransaction;

        [DataMember]
        public string NrAccount1
        {
            get { return NrAccount; }
            set { NrAccount = value; }
        }
        [DataMember]
        public int Amount1
        {
            get { return Amount; }
            set { Amount = value; }
        }
        [DataMember]
        public DateTime DateTransaction1
        {
            get { return DateTransaction; }
            set { DateTransaction = value; }
        }
    }
}
