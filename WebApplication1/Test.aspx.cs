using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Controller;

namespace WebApplication1
{
    public partial class Test : System.Web.UI.Page
    {
        public string Message = "";
        public bool IsSucess = true;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            //Check User
            var httpClient = new HttpClient();

            User user = new User
            {
                UserName = userName,
                Password = password,
                Email = "",
                Address = ""
            };

            string param = JsonConvert.SerializeObject(user);
            HttpContent content = new StringContent(param, Encoding.UTF8, "application/json");

            var result = await httpClient.PostAsync("https://localhost:44309/api/Register/Login", content);

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