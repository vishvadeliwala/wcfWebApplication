using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementClient
{
    public partial class SearchBooks : System.Web.UI.Page
    {
        LibraryManagementClient.ServiceReference1.LibraryServiceClient proxy;
        protected void Page_Load(object sender, EventArgs e)
        {
            proxy = new LibraryManagementClient.ServiceReference1.LibraryServiceClient();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = proxy.GetBooksByName(TextBox1.Text.ToString());
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = proxy.GetBooksByAuthor(TextBox2.Text.ToString());
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = proxy.GetBooksByGenre(TextBox3.Text.ToString());
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = proxy.GetBooks();
            GridView1.DataBind();
        }
    }
}