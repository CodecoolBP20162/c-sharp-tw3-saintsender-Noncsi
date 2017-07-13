using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender
{
    class Login
    {
        string username;
        string password;

        public Login(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string[] Credentials()
        {
            string[] credential = { username, password };
            ReadEmailForm LetsSeeMyEmails = new ReadEmailForm();
            LetsSeeMyEmails.Show();
            return credential;
        }
    }
}
