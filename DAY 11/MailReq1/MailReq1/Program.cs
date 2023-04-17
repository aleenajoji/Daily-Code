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

namespace MailReq1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mail> li = new List<Mail>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter mail {0} detail:", i + 1);

                String[] s = Console.ReadLine().Split(',');
                Mail m = new Mail(long.Parse(s[0]), s[1], s[2], s[3], s[4], DateTime.ParseExact(s[5], "dd-MM-yyyy", null), double.Parse(s[6]));
                li.Add(m);


            }


            Console.WriteLine();
            int j = 1;
            foreach (var item in li)
            {
                Console.WriteLine("Mail{0}:", j);

                Console.WriteLine(item.ToString());
                j++;
            }
            if (li[0].Equals(li[1]))
            {
                Console.WriteLine("Mail 1 is same as Mail 2");
            }
            else
            {
                Console.WriteLine("Mail 1 and Mail 2 are different");
            }



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

Id:1002

To:satish @gmail.com

From:meyyappan @gmail.com

Subject:Master Copy

Content:Attached doc

ReceivedDate:05-05-2017

Size:10.0

Mail 1 and Mail 2 are different */

