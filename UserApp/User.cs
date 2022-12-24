using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp
{
    class User
    {
        public int id { get; set; }

        private string login, pass, email;

        public string Login
        {
            get { return login; }
            set { this.login = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { this.pass = value; }
        }
        public string Email
        {
            get { return email; }
            set { this.email = value; }
        }

        public User() {}

        public User(string login, string pass, string email)
        {
            this.login = login;
            this.pass = pass;
            this.email = email;
        }
    }
}
