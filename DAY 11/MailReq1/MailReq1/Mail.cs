using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailReq1
{
    class Mail
    {
        private long _id;
        private string _to;
        private string _from;
        private string _subject;
        private string _content;
        private DateTime _receivedDate;
        private double _size;

        public Mail(long id, string to, string from, string subject, string content, DateTime receivedDate, double size)
        {
            _id = id;
            _to = to;
            _from = from;
            _subject = subject;
            _content = content;
            _receivedDate = receivedDate;
            _size = size;
        }

        // Properties
        public long Id
        {
            get { return _id; }
        }

        public string To
        {
            get { return _to; }
        }

        public string From
        {
            get { return _from; }
        }

        public string Subject
        {
            get { return _subject; }
        }

        public string Content
        {
            get { return _content; }
        }

        public DateTime ReceivedDate
        {
            get { return _receivedDate; }
        }

        public double Size
        {
            get { return _size; }
        }

        // Override ToString method
        public override string ToString()
        {
            return string.Format("Id:{0}\nTo:{1}\nFrom:{2}\nSubject:{3}\nContent:{4}\nReceivedDate:{5}\nSize:{6}\n", Id, To, From, Subject, Content, ReceivedDate.ToString("dd-MM-yyyy", null), Size.ToString("0.0"));
        }

        // Override Equals method
        public override bool Equals(object obj)
        {
            Mail m1 = obj as Mail;
            if (m1.To == To && m1.From == From && m1.Subject == Subject)
            {
                return true;
            }
            else
            {
                return false;
            }



        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
