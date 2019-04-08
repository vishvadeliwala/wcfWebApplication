using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementClient
{
    public partial class AdminForm : System.Web.UI.Page
    {
        ServiceReference1.LibraryServiceClient proxy;
        protected void Page_Load(object sender, EventArgs e)
        {
            proxy = new LibraryManagementClient.ServiceReference1.LibraryServiceClient();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int ans = proxy.AddBook(Convert.ToInt32(TextBox1.Text), TextBox2.Text.ToString(), TextBox3.Text.ToString(), TextBox4.Text.ToString(), Convert.ToInt32(TextBox5.Text));
            if (ans == 1)
            {
                Label3.Text = "Book added Successfully";
            }
            else
            {
                Label3.Text = "Addition of book failed..!";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int ans = proxy.UpdateBook(Convert.ToInt32(TextBox1.Text), TextBox2.Text.ToString(), TextBox3.Text.ToString(), TextBox4.Text.ToString(), Convert.ToInt32(TextBox5.Text));
            if (ans == 1)
            {
                Label3.Text = "Book updated Successfully";
            }
            else
            {
                Label3.Text = "Updation of book failed..!";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int ans = proxy.DeleteBook(Convert.ToInt32(TextBox1.Text));
            if (ans == 1)
            {
                Label3.Text = "Book deleted Successfully";
            }
            else
            {
                Label3.Text = "Deletion of book failed..!";
            }
        }
    }
}