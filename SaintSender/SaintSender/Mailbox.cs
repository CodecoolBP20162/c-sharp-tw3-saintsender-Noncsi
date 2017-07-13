using System;

namespace SaintSender
{
    class Mailbox : Mail
    {
        public int id;
        public string from;

        public Mailbox(string subject, string message, DateTimeOffset date, int id, string from) : base(subject, message, date)
        {
            this.id = id;
            this.from = from;
            this.subject = subject;
            this.message = message;
            this.date = date;
        }
    }
}
