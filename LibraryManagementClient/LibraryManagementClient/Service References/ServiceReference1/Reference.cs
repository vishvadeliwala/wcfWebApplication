﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagementClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/LibraryManagement")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BookAuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BookGenreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BookIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BookNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BookNumberField;
        
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
        public string BookAuthor {
            get {
                return this.BookAuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.BookAuthorField, value) != true)) {
                    this.BookAuthorField = value;
                    this.RaisePropertyChanged("BookAuthor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BookGenre {
            get {
                return this.BookGenreField;
            }
            set {
                if ((object.ReferenceEquals(this.BookGenreField, value) != true)) {
                    this.BookGenreField = value;
                    this.RaisePropertyChanged("BookGenre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BookID {
            get {
                return this.BookIDField;
            }
            set {
                if ((this.BookIDField.Equals(value) != true)) {
                    this.BookIDField = value;
                    this.RaisePropertyChanged("BookID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BookName {
            get {
                return this.BookNameField;
            }
            set {
                if ((object.ReferenceEquals(this.BookNameField, value) != true)) {
                    this.BookNameField = value;
                    this.RaisePropertyChanged("BookName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BookNumber {
            get {
                return this.BookNumberField;
            }
            set {
                if ((this.BookNumberField.Equals(value) != true)) {
                    this.BookNumberField = value;
                    this.RaisePropertyChanged("BookNumber");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ILibraryService")]
    public interface ILibraryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetBooks", ReplyAction="http://tempuri.org/ILibraryService/GetBooksResponse")]
        LibraryManagementClient.ServiceReference1.Book[] GetBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetBooks", ReplyAction="http://tempuri.org/ILibraryService/GetBooksResponse")]
        System.Threading.Tasks.Task<LibraryManagementClient.ServiceReference1.Book[]> GetBooksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetBooksByName", ReplyAction="http://tempuri.org/ILibraryService/GetBooksByNameResponse")]
        LibraryManagementClient.ServiceReference1.Book[] GetBooksByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetBooksByName", ReplyAction="http://tempuri.org/ILibraryService/GetBooksByNameResponse")]
        System.Threading.Tasks.Task<LibraryManagementClient.ServiceReference1.Book[]> GetBooksByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetBooksByAuthor", ReplyAction="http://tempuri.org/ILibraryService/GetBooksByAuthorResponse")]
        LibraryManagementClient.ServiceReference1.Book[] GetBooksByAuthor(string author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetBooksByAuthor", ReplyAction="http://tempuri.org/ILibraryService/GetBooksByAuthorResponse")]
        System.Threading.Tasks.Task<LibraryManagementClient.ServiceReference1.Book[]> GetBooksByAuthorAsync(string author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetBooksByGenre", ReplyAction="http://tempuri.org/ILibraryService/GetBooksByGenreResponse")]
        LibraryManagementClient.ServiceReference1.Book[] GetBooksByGenre(string genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetBooksByGenre", ReplyAction="http://tempuri.org/ILibraryService/GetBooksByGenreResponse")]
        System.Threading.Tasks.Task<LibraryManagementClient.ServiceReference1.Book[]> GetBooksByGenreAsync(string genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/AddBook", ReplyAction="http://tempuri.org/ILibraryService/AddBookResponse")]
        int AddBook(int id, string name, string author, string genre, int num);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/AddBook", ReplyAction="http://tempuri.org/ILibraryService/AddBookResponse")]
        System.Threading.Tasks.Task<int> AddBookAsync(int id, string name, string author, string genre, int num);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/DeleteBook", ReplyAction="http://tempuri.org/ILibraryService/DeleteBookResponse")]
        int DeleteBook(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/DeleteBook", ReplyAction="http://tempuri.org/ILibraryService/DeleteBookResponse")]
        System.Threading.Tasks.Task<int> DeleteBookAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/UpdateBook", ReplyAction="http://tempuri.org/ILibraryService/UpdateBookResponse")]
        int UpdateBook(int id, string name, string author, string genre, int num);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/UpdateBook", ReplyAction="http://tempuri.org/ILibraryService/UpdateBookResponse")]
        System.Threading.Tasks.Task<int> UpdateBookAsync(int id, string name, string author, string genre, int num);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILibraryServiceChannel : LibraryManagementClient.ServiceReference1.ILibraryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LibraryServiceClient : System.ServiceModel.ClientBase<LibraryManagementClient.ServiceReference1.ILibraryService>, LibraryManagementClient.ServiceReference1.ILibraryService {
        
        public LibraryServiceClient() {
        }
        
        public LibraryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LibraryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LibraryManagementClient.ServiceReference1.Book[] GetBooks() {
            return base.Channel.GetBooks();
        }
        
        public System.Threading.Tasks.Task<LibraryManagementClient.ServiceReference1.Book[]> GetBooksAsync() {
            return base.Channel.GetBooksAsync();
        }
        
        public LibraryManagementClient.ServiceReference1.Book[] GetBooksByName(string name) {
            return base.Channel.GetBooksByName(name);
        }
        
        public System.Threading.Tasks.Task<LibraryManagementClient.ServiceReference1.Book[]> GetBooksByNameAsync(string name) {
            return base.Channel.GetBooksByNameAsync(name);
        }
        
        public LibraryManagementClient.ServiceReference1.Book[] GetBooksByAuthor(string author) {
            return base.Channel.GetBooksByAuthor(author);
        }
        
        public System.Threading.Tasks.Task<LibraryManagementClient.ServiceReference1.Book[]> GetBooksByAuthorAsync(string author) {
            return base.Channel.GetBooksByAuthorAsync(author);
        }
        
        public LibraryManagementClient.ServiceReference1.Book[] GetBooksByGenre(string genre) {
            return base.Channel.GetBooksByGenre(genre);
        }
        
        public System.Threading.Tasks.Task<LibraryManagementClient.ServiceReference1.Book[]> GetBooksByGenreAsync(string genre) {
            return base.Channel.GetBooksByGenreAsync(genre);
        }
        
        public int AddBook(int id, string name, string author, string genre, int num) {
            return base.Channel.AddBook(id, name, author, genre, num);
        }
        
        public System.Threading.Tasks.Task<int> AddBookAsync(int id, string name, string author, string genre, int num) {
            return base.Channel.AddBookAsync(id, name, author, genre, num);
        }
        
        public int DeleteBook(int id) {
            return base.Channel.DeleteBook(id);
        }
        
        public System.Threading.Tasks.Task<int> DeleteBookAsync(int id) {
            return base.Channel.DeleteBookAsync(id);
        }
        
        public int UpdateBook(int id, string name, string author, string genre, int num) {
            return base.Channel.UpdateBook(id, name, author, genre, num);
        }
        
        public System.Threading.Tasks.Task<int> UpdateBookAsync(int id, string name, string author, string genre, int num) {
            return base.Channel.UpdateBookAsync(id, name, author, genre, num);
        }
    }
}
