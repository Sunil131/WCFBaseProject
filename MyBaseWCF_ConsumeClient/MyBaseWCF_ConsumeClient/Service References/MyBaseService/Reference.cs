﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyBaseWCF_ConsumeClient.MyBaseService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/MyBaseWCF_Application")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/MyBaseWCF_Application")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsActiveField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmployeeName {
            get {
                return this.EmployeeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeNameField, value) != true)) {
                    this.EmployeeNameField = value;
                    this.RaisePropertyChanged("EmployeeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsActive {
            get {
                return this.IsActiveField;
            }
            set {
                if ((this.IsActiveField.Equals(value) != true)) {
                    this.IsActiveField = value;
                    this.RaisePropertyChanged("IsActive");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyBaseService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        MyBaseWCF_ConsumeClient.MyBaseService.CompositeType GetDataUsingDataContract(MyBaseWCF_ConsumeClient.MyBaseService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<MyBaseWCF_ConsumeClient.MyBaseService.CompositeType> GetDataUsingDataContractAsync(MyBaseWCF_ConsumeClient.MyBaseService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployee", ReplyAction="http://tempuri.org/IService1/GetEmployeeResponse")]
        MyBaseWCF_ConsumeClient.MyBaseService.Employee GetEmployee(int Employeeid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployee", ReplyAction="http://tempuri.org/IService1/GetEmployeeResponse")]
        System.Threading.Tasks.Task<MyBaseWCF_ConsumeClient.MyBaseService.Employee> GetEmployeeAsync(int Employeeid);
        
        // CODEGEN: Generating message contract since the wrapper name (EmployeeMessage) of message EmployeeMessage does not match the default value (GetEmployeeMessage)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployeeMessage", ReplyAction="http://tempuri.org/IService1/GetEmployeeMessageResponse")]
        MyBaseWCF_ConsumeClient.MyBaseService.EmployeeData GetEmployeeMessage(MyBaseWCF_ConsumeClient.MyBaseService.EmployeeMessage request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployeeMessage", ReplyAction="http://tempuri.org/IService1/GetEmployeeMessageResponse")]
        System.Threading.Tasks.Task<MyBaseWCF_ConsumeClient.MyBaseService.EmployeeData> GetEmployeeMessageAsync(MyBaseWCF_ConsumeClient.MyBaseService.EmployeeMessage request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EmployeeMessage", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EmployeeMessage {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public bool IsActive;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string EmployeeName;
        
        public EmployeeMessage() {
        }
        
        public EmployeeMessage(bool IsActive, string EmployeeName) {
            this.IsActive = IsActive;
            this.EmployeeName = EmployeeName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EmployeeData", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EmployeeData {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string Message;
        
        public EmployeeData() {
        }
        
        public EmployeeData(string Message) {
            this.Message = Message;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : MyBaseWCF_ConsumeClient.MyBaseService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<MyBaseWCF_ConsumeClient.MyBaseService.IService1>, MyBaseWCF_ConsumeClient.MyBaseService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public MyBaseWCF_ConsumeClient.MyBaseService.CompositeType GetDataUsingDataContract(MyBaseWCF_ConsumeClient.MyBaseService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<MyBaseWCF_ConsumeClient.MyBaseService.CompositeType> GetDataUsingDataContractAsync(MyBaseWCF_ConsumeClient.MyBaseService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public MyBaseWCF_ConsumeClient.MyBaseService.Employee GetEmployee(int Employeeid) {
            return base.Channel.GetEmployee(Employeeid);
        }
        
        public System.Threading.Tasks.Task<MyBaseWCF_ConsumeClient.MyBaseService.Employee> GetEmployeeAsync(int Employeeid) {
            return base.Channel.GetEmployeeAsync(Employeeid);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MyBaseWCF_ConsumeClient.MyBaseService.EmployeeData MyBaseWCF_ConsumeClient.MyBaseService.IService1.GetEmployeeMessage(MyBaseWCF_ConsumeClient.MyBaseService.EmployeeMessage request) {
            return base.Channel.GetEmployeeMessage(request);
        }
        
        public string GetEmployeeMessage(bool IsActive, string EmployeeName) {
            MyBaseWCF_ConsumeClient.MyBaseService.EmployeeMessage inValue = new MyBaseWCF_ConsumeClient.MyBaseService.EmployeeMessage();
            inValue.IsActive = IsActive;
            inValue.EmployeeName = EmployeeName;
            MyBaseWCF_ConsumeClient.MyBaseService.EmployeeData retVal = ((MyBaseWCF_ConsumeClient.MyBaseService.IService1)(this)).GetEmployeeMessage(inValue);
            return retVal.Message;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyBaseWCF_ConsumeClient.MyBaseService.EmployeeData> MyBaseWCF_ConsumeClient.MyBaseService.IService1.GetEmployeeMessageAsync(MyBaseWCF_ConsumeClient.MyBaseService.EmployeeMessage request) {
            return base.Channel.GetEmployeeMessageAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyBaseWCF_ConsumeClient.MyBaseService.EmployeeData> GetEmployeeMessageAsync(bool IsActive, string EmployeeName) {
            MyBaseWCF_ConsumeClient.MyBaseService.EmployeeMessage inValue = new MyBaseWCF_ConsumeClient.MyBaseService.EmployeeMessage();
            inValue.IsActive = IsActive;
            inValue.EmployeeName = EmployeeName;
            return ((MyBaseWCF_ConsumeClient.MyBaseService.IService1)(this)).GetEmployeeMessageAsync(inValue);
        }
    }
}
