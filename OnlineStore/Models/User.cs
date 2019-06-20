using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class User
    {
        public User(string login, string password, int roleId)
        {
            Login = login;
            Password = password;
            RoleId = roleId;
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}
