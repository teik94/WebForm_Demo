using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Controller
{
    public static class RegisterExtension
    {
        static List<User> listUser = new List<User>();
        public static bool RegisterProcess(User user)
        {
            listUser.Add(user);
            return true;
        }

        public static List<User> GetListUsers()
        {
            return listUser;
        }

    }
}