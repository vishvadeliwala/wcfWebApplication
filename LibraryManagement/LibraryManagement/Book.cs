using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LibraryManagement
{
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
