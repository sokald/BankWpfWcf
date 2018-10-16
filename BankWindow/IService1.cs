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
        //[OperationContract]
        //string GetData(int value);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        string SendAccount(Account NewAccount);

        [OperationContract]
        DataSet ShowAccount();

        //[OperationContract]
        //DataSet ShowAccount(Account NrAccount);
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
        public int NrAccount1 { get => NrAccount; set => NrAccount = value; }
        [DataMember]
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        [DataMember]
        public string LastName1 { get => LastName; set => LastName = value; }
        [DataMember]
        public string City1 { get => City; set => City = value; }
        [DataMember]
        public string Street1 { get => Street; set => Street = value; }
        [DataMember]
        public int NrHouse1 { get => NrHouse; set => NrHouse = value; }
        [DataMember]
        public int PostCode1 { get => PostCode; set => PostCode = value; }
        [DataMember]
        public double AccountBalance1 { get => AccountBalance; set => AccountBalance = value; }
    }
}
