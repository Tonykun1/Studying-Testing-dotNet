using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingTesting.users
{
    public class User
    {
        private string username;
        private List<User_Role> roles = new List<User_Role>();

        public List<User_Role> Roles { get => roles; set => roles = value; }
        public string Username { get => username; set => username = value; }
        public bool CanOpenTable()
        {
            return roles != null && roles.Any(role => role == User_Role.ADMIN || role == User_Role.MANAGER);
        }
    }
}
