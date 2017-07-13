using System;

namespace SaintSender
{
    class Mail
    {
        public string subject;
        public string message;
        public DateTimeOffset date;

        public Mail(string subject, string message, DateTimeOffset date)
        {
            this.subject = subject;
            this.message = message;
            this.date = date;
        }
    }
}
