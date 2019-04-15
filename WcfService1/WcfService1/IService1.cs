using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<Book> GetBooks();
        [OperationContract]
        List<Book> GetBooksByName(string name);
        [OperationContract]
        List<Book> GetBooksByAuthor(string author);
        [OperationContract]
        List<Book> GetBooksByGenre(string genre);
        [OperationContract]
        int AddBook(int id, string name, string author, string genre, int num);
        [OperationContract]
        int DeleteBook(int id);
        [OperationContract]
        int UpdateBook(int id, string name, string author, string genre, int num);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Book
    {
        private int id;
        private string name;
        private string author;
        private string genre;
        private int num;

        [DataMember]
        public int BookID
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string BookName
        {
            get { return name; }
            set { name = value; }
        }
        [DataMember]
        public string BookAuthor
        {
            get { return author; }
            set { author = value; }
        }
        [DataMember]
        public string BookGenre
        {
            get { return genre; }
            set { genre = value; }
        }

        [DataMember]
        public int BookNumber
        {
            get { return num; }
            set { num = value; }
        }
    }
}
