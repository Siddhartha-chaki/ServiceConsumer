using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceConsumer.mohit_ka_serveice;

namespace ServiceConsumer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        mohit_ka_serveice.WebService1 wb;
        protected void Page_Load(object sender, EventArgs e)
        {
            wb = new WebService1();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Label1.Text = wb.testServer(int.Parse(TextBox1.Text));
        }

    }
}