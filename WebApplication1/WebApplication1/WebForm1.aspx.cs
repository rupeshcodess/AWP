using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(TextBox1.Text);
            int b = Convert.ToInt32(TextBox2.Text);
            int c = Convert.ToInt32(TextBox3.Text);
            int d = Convert.ToInt32(TextBox4.Text);
            int result = a * b * c * d;
            TextBox5.Text = result.ToString();
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}