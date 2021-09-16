using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Controller;

namespace WebApplication1
{
    public partial class Register : System.Web.UI.Page
    {
        
        public string Message = "";
        public bool IsSucess = true;
        public List<User> userList = new List<User>();
        public int i = 1;
        public List<User> Get()
        {
            return userList;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var pass = txtPassword.Text;
            var email = txtEmail.Text;
            var address = txtAddress.Text;

            User user = new User {
                UserName = username,
                Password = pass,
                Email = email,
                Address = address
            };

            IsSucess = RegisterController.RegisterProcess(user);
            if(IsSucess)
            {
                Message = "Register Success!";
            }
            else
            {
                Message = "Register Failed!";
            }
        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            userList = RegisterController.GetListUsers();
        }
    }
}