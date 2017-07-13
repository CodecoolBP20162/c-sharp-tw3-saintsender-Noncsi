using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender
{
    class WriteMails
    {   
        public void SendEmail(SentMail mailAboutToSend)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("codecool.b1ts.pls@gmail.com"));
            message.To.Add(new MailboxAddress(mailAboutToSend.to));
            message.Subject = mailAboutToSend.subject;

            message.Body = new TextPart("plain")
            {
                Text = mailAboutToSend.message
            };

            using (var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect("smtp.gmail.com", 587, false);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate("codecool.b1ts.pls@gmail.com", "mergeconflict");
                client.Send(message);
            }
        }
    }
}
