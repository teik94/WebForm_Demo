using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Test : System.Web.UI.Page
    {
        public string Message = "";
        public bool IsSucess = true;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            //Check User


            //
            //SuccessMessage = "Login Successful!";
            IsSucess = true;
            Message = "Login Successful!";
        }

        protected void btnLogin2_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            //Check User


            //
            //SuccessMessage = "Login Successful!";
            IsSucess = false;
            Message = "Login Error!";
        }
    }
}