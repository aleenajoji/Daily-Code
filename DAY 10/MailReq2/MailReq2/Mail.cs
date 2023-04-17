using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailFolderApp
{
    class Mail
    {
        private long _id;
        public long Id { get { return _id; } set { _id = value; } }

        private string _from;
        public string From { get { return _from; } set { _from = value; } }

        private string _to;
        public string To { get { return _to; } set { _to = value; } }

        private string _subject;
        public string Subject { get { return _subject; } set { _subject = value; } }

        private string _content;
        public string Content { get { return _content; } set { _content = value; } }

        private DateTime _receivedDate;
        public DateTime ReceivedDate
        {
            get
            {
                return _receivedDate;
            }
            set
            {
                _receivedDate = value;
            }
        }
        private double _size;
        public double Size { get { return _size; } set { _size = value; } }

        public Mail()
        {
        }

        public Mail(long _id, string _from, string _to, string _subject, string _content, DateTime _receivedDate, double _size)
        {
            Id = _id;
            From = _from;
            To = _to;
            Subject = _subject;
            Content = _content;
            ReceivedDate = _receivedDate;
            Size = _size;
        }
        public static Mail CreateMail(string detail)
        {
            string[] s = Console.ReadLine().Split(',');
            long _id = long.Parse(s[0]);
            string _from = s[1];
            string _to = s[2];
            string _subject = s[3];
            string _content = s[4];
            DateTime _receivedDate = DateTime.Parse(s[5]);
            double _size = double.Parse(s[6]);
            return new Mail(_id, _from, _to, _subject, _content, _receivedDate, _size);
        }

        public override string ToString()
        {
            return string.Format("{0} {1,15} {2,15} {3,15} {4,15} {5,15:dd-MM-yyyy} {6,15:0.0}", Id, From, To, Subject, Content, ReceivedDate, Size);
        }
    }
}
