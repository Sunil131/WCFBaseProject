using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyBaseWCF_Application
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract()]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);


        [OperationContract]
        Employee GetEmployee(int Employeeid);

        [OperationContract]
        EmployeeData GetEmployeeMessage(EmployeeMessage emp);





        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }


    [DataContract]
    public class Employee
    {
        bool isActive = true;
        string employeeName = "Sunil";

        [DataMember]
        public bool IsActive {
            get { return isActive; }
            set { isActive = value;}
        }

        [DataMember]
        public string EmployeeName {
            get { return employeeName; }
            set { employeeName = value; }
        }

    }

    [MessageContract]
    public class EmployeeMessage
    {
        bool isActive = true;
        string employeeName = "Sunil";

        [MessageHeader]
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        [MessageBodyMember]
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

    }

    [MessageContract]
    public class EmployeeData
    {
        string message = "This is working fine";
        
        [MessageBodyMember]
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}
