using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class About : Page
    {
        public int a = 10;
        public string MyText = "Sample Text";
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = "KIET";
        }
    }
}