using System;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit;
using MimeKit;
using System.Collections.Generic;

namespace SaintSender
{
    class GetMails
    {
        public ImapClient client;

        public void Authenticate(string username, string password)
        {
            client = new ImapClient();
            client.ServerCertificateValidationCallback = (s, c, h, e) => true;
            client.Connect("imap.gmail.com", 993, true);
            client.AuthenticationMechanisms.Remove("XOAUTH2");
            client.Authenticate(username, password);
        }

        public List<Mailbox> DownloadMessages()
        {
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            List<Mailbox> mails = new List<Mailbox>();
            for (int i = 0; i < inbox.Count; i++)
            {
                var message = inbox.GetMessage(i);
                Mailbox mail = new Mailbox(message.Subject, message.TextBody, message.Date, i, message.From.ToString());
                mails.Add(mail);
            }
            return mails;
        }
    }
}
