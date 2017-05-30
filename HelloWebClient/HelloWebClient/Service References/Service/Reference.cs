﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloWebClient.Service {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataItem", Namespace="http://schemas.datacontract.org/2004/07/EmployeeService")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HelloWebClient.Service.FullTimeDataItem))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HelloWebClient.Service.PartTimeDataItem))]
    public partial class DataItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HelloWebClient.Service.DataItem.DataType TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string genderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        public HelloWebClient.Service.DataItem.DataType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime dateOfBirth {
            get {
                return this.dateOfBirthField;
            }
            set {
                if ((this.dateOfBirthField.Equals(value) != true)) {
                    this.dateOfBirthField = value;
                    this.RaisePropertyChanged("dateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string gender {
            get {
                return this.genderField;
            }
            set {
                if ((object.ReferenceEquals(this.genderField, value) != true)) {
                    this.genderField = value;
                    this.RaisePropertyChanged("gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                if ((object.ReferenceEquals(this.idField, value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
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
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name="DataItem.DataType", Namespace="http://schemas.datacontract.org/2004/07/EmployeeService")]
        public enum DataType : int {
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            FullTimeDataItem = 1,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            PartTimeDataItem = 2,
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FullTimeDataItem", Namespace="http://schemas.datacontract.org/2004/07/EmployeeService")]
    [System.SerializableAttribute()]
    public partial class FullTimeDataItem : HelloWebClient.Service.DataItem {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AnnualSalaryField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AnnualSalary {
            get {
                return this.AnnualSalaryField;
            }
            set {
                if ((this.AnnualSalaryField.Equals(value) != true)) {
                    this.AnnualSalaryField = value;
                    this.RaisePropertyChanged("AnnualSalary");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PartTimeDataItem", Namespace="http://schemas.datacontract.org/2004/07/EmployeeService")]
    [System.SerializableAttribute()]
    public partial class PartTimeDataItem : HelloWebClient.Service.DataItem {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HoursPayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HoursWorkedField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HoursPay {
            get {
                return this.HoursPayField;
            }
            set {
                if ((this.HoursPayField.Equals(value) != true)) {
                    this.HoursPayField = value;
                    this.RaisePropertyChanged("HoursPay");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HoursWorked {
            get {
                return this.HoursWorkedField;
            }
            set {
                if ((this.HoursWorkedField.Equals(value) != true)) {
                    this.HoursWorkedField = value;
                    this.RaisePropertyChanged("HoursWorked");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetEmployee", ReplyAction="http://tempuri.org/IService/GetEmployeeResponse")]
        HelloWebClient.Service.DataItem GetEmployee(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetEmployee", ReplyAction="http://tempuri.org/IService/GetEmployeeResponse")]
        System.Threading.Tasks.Task<HelloWebClient.Service.DataItem> GetEmployeeAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SetEmployee", ReplyAction="http://tempuri.org/IService/SetEmployeeResponse")]
        void SetEmployee(HelloWebClient.Service.DataItem name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SetEmployee", ReplyAction="http://tempuri.org/IService/SetEmployeeResponse")]
        System.Threading.Tasks.Task SetEmployeeAsync(HelloWebClient.Service.DataItem name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : HelloWebClient.Service.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<HelloWebClient.Service.IService>, HelloWebClient.Service.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public HelloWebClient.Service.DataItem GetEmployee(int id) {
            return base.Channel.GetEmployee(id);
        }
        
        public System.Threading.Tasks.Task<HelloWebClient.Service.DataItem> GetEmployeeAsync(int id) {
            return base.Channel.GetEmployeeAsync(id);
        }
        
        public void SetEmployee(HelloWebClient.Service.DataItem name) {
            base.Channel.SetEmployee(name);
        }
        
        public System.Threading.Tasks.Task SetEmployeeAsync(HelloWebClient.Service.DataItem name) {
            return base.Channel.SetEmployeeAsync(name);
        }
    }
}