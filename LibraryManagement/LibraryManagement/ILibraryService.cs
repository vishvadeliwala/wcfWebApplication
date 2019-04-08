using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    [ServiceContract]
    public interface ILibraryService
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
        int AddBook(int id, string name,string author, string genre, int num);
        [OperationContract]
        int DeleteBook(int id);
        [OperationContract]
        int UpdateBook(int id, string name, string author, string genre, int num);
    }
}
