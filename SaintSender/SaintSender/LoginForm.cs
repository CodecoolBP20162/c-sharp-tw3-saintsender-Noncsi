using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GetMails client = new GetMails();
            client.Authenticate(txtUsername.Text, txtPassword.Text);
            ReadEmailForm letsSeeMyEmails = new ReadEmailForm(client);
            letsSeeMyEmails.Show();
            Hide();
        }
    }

}
