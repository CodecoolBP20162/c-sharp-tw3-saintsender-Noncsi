using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SaintSender
{
    partial class ReadEmailForm : Form
    {
        List<Mailbox> mails;
        GetMails client;

        public ReadEmailForm(GetMails client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void ReadEmailForm_Shown(object sender, EventArgs e)
        {
            FillMailbox();
            timer.Start();          
        }

        public void DownloadMails()
        {
            mails = client.DownloadMessages();
        }

        void FillMailbox()
        {
            DownloadMails();
            foreach (Mailbox mail in mails)
            {
                lstMailbox.Name = mail.id.ToString();
                ListViewItem row = new ListViewItem(new[] { mail.from, mail.subject });
                row.Name = mail.id.ToString();
                lstMailbox.Items.Add(row);
            }
            lstMailbox.FullRowSelect = true;
        }

        private void lstMailbox_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedMail = lstMailbox.SelectedItems[0];
            foreach (Mailbox email in mails) if (email.id.ToString() == selectedMail.Name) txtMessage.Text = email.message;
        }

        // Refresh mails (1 min)
        private void timer_Tick(object sender, EventArgs e)
        {
            DownloadMails();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            WriteEmailForm sendMail = new WriteEmailForm();
            sendMail.Show();
        }

        
    }
}
