using System;

namespace SaintSender
{
    class SentMail : Mail
    {
        public int id;
        public string to;

        public SentMail(string subject, string message, DateTimeOffset date, int id, string to) : base(subject, message, date)
        {
            this.id = id;
            this.to = to;
            this.subject = subject;
            this.message = message;
            this.date = date;
        }
    }
}
