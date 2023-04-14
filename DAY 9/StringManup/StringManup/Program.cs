using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StringManup
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
            return $"Id:{_id}\nTo:{_to}\nFrom:{_from}\nSubject:{_subject}\n" +
                $"Content:{_content}\nReceived Date:{_receivedDate.ToString("dd-MM-yyyy")}\n" +
                $"Size:{_size:F1}";
        }

        // Override Equals method
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Mail))
            {
                return false;
            }

            Mail other = (Mail)obj;
            return string.Equals(_to, other._to, StringComparison.OrdinalIgnoreCase)
                && string.Equals(_from, other._from, StringComparison.OrdinalIgnoreCase)
                && string.Equals(_subject, other._subject, StringComparison.OrdinalIgnoreCase);
        }
    }


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter mail 1 detail:");
            Mail mail1 = ReadMailDetails();

            Console.WriteLine("Enter mail 2 detail:");
            Mail mail2 = ReadMailDetails();

            Console.WriteLine("Mail 1:");
            Console.WriteLine(mail1.ToString());

            Console.WriteLine("Mail 2:");
            Console.WriteLine(mail2.ToString());

            if (mail1.Equals(mail2))
            {
                Console.WriteLine("Mail 1 is same as Mail 2");
            }
            else
            {
                Console.WriteLine("Mail 1 and Mail 2 are different");
            }
        }

        static Mail ReadMailDetails()
        {
            Console.Write("Id:");
            long id = Convert.ToInt64(Console.ReadLine());

            Console.Write("To:");
            string to = Console.ReadLine().Trim();

            Console.Write("From:");
            string from = Console.ReadLine().Trim();

            Console.Write("Subject:");
            string subject = Console.ReadLine().Trim();

            Console.Write("Content:");
            string content = Console.ReadLine().Trim();

            Console.Write("Received Date:");
            DateTime receivedDate = DateTime.ParseExact(Console.ReadLine().Trim(), "dd-MM-yyyy", null);

            Console.Write("Size:");
            double size = Convert.ToDouble(Console.ReadLine());

            return new Mail(id, to, from, subject, content, receivedDate, size);
        }
    }
}


    
        /* Mail Folder - Requirement

 You work for a start-up company.The company has been using an outdated mail system.Looking at the difficulty in the old system, the management decided to build their own mail server.There are two major domains, Mail and Mail Folder.The mail details are stored in the mail domain.The mail folder is used to group the emails together.

 Requirement 1:

 Let’s start off by creating two Mail objects and check whether they are equal.

 1.	Create a Mail Class with the following attributes:

 Member Field Name Type

 _id long

 _to string

 _from   string

 _subject    string

 _content    string

 _receivedDate   DateTime

 _size   double

 2.	Mark all the attributes as private

 3.	Include appropriate properties.

 4.	Add a default constructor and a parameterized constructor to take in all attributes in the given order: Mail(long _id, string _to, string _from, string _subject, string _content, DateTime _receivedDate, double _size)

 5.	When the “mail” object is printed, it should display the following details: [Override the ToString method]

     Print format:

 Id:"_id"

 To:"_to"

 From:"_from"

 Subject:"_subject"

 Content:"_content"

 Received Date:"_receivedDate"

 Size:"_size"

 6.	Two emails are considered same if they have the same to address, from address, and subject.Implement the logic in the appropriate function. (Case – Insensitive) [Override the Equals method]

     The input format consists of mail details separated by comma in the below order,

 (_id, _to, _from, _subject, _content, _receivedDate, _size)

 The Input to your program would be details of two emails, you need to display their details as given in "5th point(refer above)" and compare the two emails and display if the Mails are same or different.

 Note: There is an empty line between display statements. Print the empty lines in Main function.

        Display one digit after the decimal point for double datatype.

 Sample INPUT & OUTPUT 1:

 Enter mail 1 detail:

 1001, meyyappan @gmail.com, satish @gmail.com, Master Copy, Attached doc,05-05-2017,10.0

 Enter mail 2 detail:

 1001, meyyappan @gmail.com, satish @gmail.com, Master Copy, Attached doc,05-05-2017,10.0

 Mail 1:

 Id:1001

 To:meyyappan @gmail.com

 From:satish @gmail.com

 Subject:Master Copy

 Content:Attached doc

 ReceivedDate:05-05-2017

 Size:10.0

 Mail 2:

 Id:1001

 To:meyyappan @gmail.com

 From:satish @gmail.com

 Subject:Master Copy

 Content:Attached doc

 ReceivedDate:05-05-2017

 Size:10.0

 Mail 1 is same as Mail 2

 Sample INPUT & OUTPUT 2:

 Enter mail 1 detail:

 1001, meyyappan @gmail.com, satish @gmail.com, Master Copy, Attached doc,05-05-2017,10.0

 Enter mail 2 detail:

 1002, satish @gmail.com, meyyappan @gmail.com, Master Copy, Attached doc,05-05-2017,10.0

 Mail 1:

 Id:1001

 To:meyyappan @gmail.com

 From:satish @gmail.com

 Subject:Master Copy

 Content:Attached doc

 ReceivedDate:05-05-2017

 Size:10.0

 Mail 2:

 Id:1002

 To:satish @gmail.com

 From:meyyappan @gmail.com

 Subject:Master Copy

 Content:Attached doc

 ReceivedDate:05-05-2017

 Size:10.0

 Mail 1 and Mail 2 are different */

