﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWork_Baltbet.Web.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Account", Namespace="http://schemas.datacontract.org/2004/07/TestWork_Baltbet.Server")]
    [System.SerializableAttribute()]
    public partial class Account : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PassportField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordHashField;
        
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
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Passport {
            get {
                return this.PassportField;
            }
            set {
                if ((object.ReferenceEquals(this.PassportField, value) != true)) {
                    this.PassportField = value;
                    this.RaisePropertyChanged("Passport");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PasswordHash {
            get {
                return this.PasswordHashField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordHashField, value) != true)) {
                    this.PasswordHashField = value;
                    this.RaisePropertyChanged("PasswordHash");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IBaltbetService")]
    public interface IBaltbetService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBaltbetService/AddUser", ReplyAction="http://tempuri.org/IBaltbetService/AddUserResponse")]
        bool AddUser(string Gender, int Age, string Login, string Name, string LastName, string Passport, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBaltbetService/AddUser", ReplyAction="http://tempuri.org/IBaltbetService/AddUserResponse")]
        System.Threading.Tasks.Task<bool> AddUserAsync(string Gender, int Age, string Login, string Name, string LastName, string Passport, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBaltbetService/CheckUserLogin", ReplyAction="http://tempuri.org/IBaltbetService/CheckUserLoginResponse")]
        bool CheckUserLogin(string Login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBaltbetService/CheckUserLogin", ReplyAction="http://tempuri.org/IBaltbetService/CheckUserLoginResponse")]
        System.Threading.Tasks.Task<bool> CheckUserLoginAsync(string Login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBaltbetService/CheckUser", ReplyAction="http://tempuri.org/IBaltbetService/CheckUserResponse")]
        bool CheckUser(string Login, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBaltbetService/CheckUser", ReplyAction="http://tempuri.org/IBaltbetService/CheckUserResponse")]
        System.Threading.Tasks.Task<bool> CheckUserAsync(string Login, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBaltbetService/GetListAccounts", ReplyAction="http://tempuri.org/IBaltbetService/GetListAccountsResponse")]
        TestWork_Baltbet.Web.ServiceReference.Account[] GetListAccounts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBaltbetService/GetListAccounts", ReplyAction="http://tempuri.org/IBaltbetService/GetListAccountsResponse")]
        System.Threading.Tasks.Task<TestWork_Baltbet.Web.ServiceReference.Account[]> GetListAccountsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBaltbetServiceChannel : TestWork_Baltbet.Web.ServiceReference.IBaltbetService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BaltbetServiceClient : System.ServiceModel.ClientBase<TestWork_Baltbet.Web.ServiceReference.IBaltbetService>, TestWork_Baltbet.Web.ServiceReference.IBaltbetService {
        
        public BaltbetServiceClient() {
        }
        
        public BaltbetServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BaltbetServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BaltbetServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BaltbetServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddUser(string Gender, int Age, string Login, string Name, string LastName, string Passport, string Password) {
            return base.Channel.AddUser(Gender, Age, Login, Name, LastName, Passport, Password);
        }
        
        public System.Threading.Tasks.Task<bool> AddUserAsync(string Gender, int Age, string Login, string Name, string LastName, string Passport, string Password) {
            return base.Channel.AddUserAsync(Gender, Age, Login, Name, LastName, Passport, Password);
        }
        
        public bool CheckUserLogin(string Login) {
            return base.Channel.CheckUserLogin(Login);
        }
        
        public System.Threading.Tasks.Task<bool> CheckUserLoginAsync(string Login) {
            return base.Channel.CheckUserLoginAsync(Login);
        }
        
        public bool CheckUser(string Login, string Password) {
            return base.Channel.CheckUser(Login, Password);
        }
        
        public System.Threading.Tasks.Task<bool> CheckUserAsync(string Login, string Password) {
            return base.Channel.CheckUserAsync(Login, Password);
        }
        
        public TestWork_Baltbet.Web.ServiceReference.Account[] GetListAccounts() {
            return base.Channel.GetListAccounts();
        }
        
        public System.Threading.Tasks.Task<TestWork_Baltbet.Web.ServiceReference.Account[]> GetListAccountsAsync() {
            return base.Channel.GetListAccountsAsync();
        }
    }
}