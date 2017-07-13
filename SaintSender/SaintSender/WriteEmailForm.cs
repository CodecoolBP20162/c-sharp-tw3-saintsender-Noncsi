using System;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MimeKit;
using MailKit.Net.Smtp;

namespace SaintSender
{
    public partial class WriteEmailForm : Form
    {
        int SentEmailId;


        public WriteEmailForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            ++SentEmailId;
            SentMail mail = new SentMail(txtSubject.Text, txtMessage.Text, DateTimeOffset.Now, SentEmailId, txtTo.Text);
            WriteMails writeNewMail = new WriteMails();
            writeNewMail.SendEmail(mail);
            Hide();
        }

        
    }
}
