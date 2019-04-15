using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int AddBook(int id, string name, string author, string genre, int num)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=booksdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string insertsql = "INSERT into books(bookId,bookName,author,genre,number) VALUES(@id,@name,@author,@genre,@num)";
            SqlCommand cmd = new SqlCommand(insertsql, conn);
            cmd.Connection = conn;
            cmd.CommandText = insertsql;
            cmd.Parameters.Add(new SqlParameter("@name", name));
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.Parameters.Add(new SqlParameter("@genre", genre));
            cmd.Parameters.Add(new SqlParameter("@author", author));
            cmd.Parameters.Add(new SqlParameter("@num", num));
            conn.Open();

            int ans;
            int temp = cmd.ExecuteNonQuery();
            if (temp > 0)
            {
                ans = 1;
            }
            else
                ans = 0;
            conn.Close();
            return ans;
        }

        public int DeleteBook(int id)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=booksdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE from books WHERE bookId=@id";
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            int ans;
            int temp = cmd.ExecuteNonQuery();
            if (temp > 0)
            {
                ans = 1;
            }
            else
                ans = 0;
            conn.Close();
            return ans;
        }

        public List<Book> GetBooks()
        {
            List<Book> blst = new List<Book>();
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=booksdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("SELECT bookId,bookName,author,genre,number FROM books", conn);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Book book = new Book();
                book.BookID = rd.GetInt32(0);
                book.BookName = rd.GetString(1);
                book.BookAuthor = rd.GetString(2);
                book.BookGenre = rd.GetString(3);
                book.BookNumber = rd.GetInt32(4);
                blst.Add(book);
            }
            rd.Close();
            conn.Close();
            return blst;
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            List<Book> blst = new List<Book>();
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=booksdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT bookId,bookName,author,genre,number FROM books WHERE author=@author";
            conn.Open();
            SqlParameter p = new SqlParameter("@author", author);
            cmd.Parameters.Add(p);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Book book = new Book();
                book.BookID = rd.GetInt32(0);
                book.BookName = rd.GetString(1);
                book.BookAuthor = rd.GetString(2);
                book.BookGenre = rd.GetString(3);
                book.BookNumber = rd.GetInt32(4);
                blst.Add(book);
            }
            rd.Close();
            conn.Close();
            return blst;
        }

        public List<Book> GetBooksByGenre(string genre)
        {
            List<Book> blst = new List<Book>();
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=booksdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT bookId,bookName,author,genre,number FROM books WHERE genre=@genre";
            SqlParameter p = new SqlParameter("@genre", genre);
            cmd.Parameters.Add(p);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Book book = new Book();
                book.BookID = rd.GetInt32(0);
                book.BookName = rd.GetString(1);
                book.BookAuthor = rd.GetString(2);
                book.BookGenre = rd.GetString(3);
                book.BookNumber = rd.GetInt32(4);
                blst.Add(book);
            }
            rd.Close();
            conn.Close();
            return blst;
        }

        public List<Book> GetBooksByName(string name)
        {
            List<Book> blst = new List<Book>();
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=booksdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT bookId,bookName,author,genre,number FROM books WHERE bookName=@name";
            SqlParameter p = new SqlParameter("@name", name);
            cmd.Parameters.Add(p);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Book book = new Book();
                book.BookID = rd.GetInt32(0);
                book.BookName = rd.GetString(1);
                book.BookAuthor = rd.GetString(2);
                book.BookGenre = rd.GetString(3);
                book.BookNumber = rd.GetInt32(4);
                blst.Add(book);
            }
            rd.Close();
            conn.Close();
            return blst;
        }

        public int UpdateBook(int id, string name, string author, string genre, int num)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=booksdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE books SET bookName=@name, author=@author, genre=@genre, number=@num WHERE bookId=@id";

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@genre", genre);
            cmd.Parameters.AddWithValue("@author", author);
            cmd.Parameters.AddWithValue("@num", num);
            conn.Open();
            int ans;
            int temp = cmd.ExecuteNonQuery();
            if (temp > 0)
            {
                ans = 1;
            }
            else
            {
                ans = 0;
            }
            conn.Close();
            return ans;
        }
    
}
}
