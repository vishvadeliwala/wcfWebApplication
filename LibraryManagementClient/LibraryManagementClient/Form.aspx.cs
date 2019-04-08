using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementClient
{
    public partial class Form : System.Web.UI.Page
    {
        LibraryManagementClient.ServiceReference1.LibraryServiceClient proxy;
        protected void Page_Load(object sender, EventArgs e)
        {
            proxy = new LibraryManagementClient.ServiceReference1.LibraryServiceClient();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (TextBox4.Text == "vishva" && TextBox5.Text=="12345")
            {
                Response.Redirect("AdminForm.aspx");
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchBooks.aspx");
        }
    }
}