using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string vowel = " IT IS A VOWEL "; 
            string notvowel = "IT IS NOT A VOWEL";
            char s = Convert.ToChar(TextBox1.Text);
            if (s == 'a' || s == 'e' || s == 'i' || s == 'o' || s == 'u' || s == 'A' || s == 'E' || s == 'I' || s == 'O' || s == 'U')
            {
                TextBox2.Text = vowel.ToString();

            }
            else
            {
                TextBox2.Text = notvowel.ToString();
            }
        }
    }
}