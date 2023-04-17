using System;
using System.Collections.Generic;

namespace MailFolder
{
    internal class Program
    {
      

        static void Main(string[] args)
        {
            List<Mail> list = new List<Mail>();

            Console.WriteLine("Enter the name of the folder: ");
            string folderName = Console.ReadLine();
            MailFolder folder = new MailFolder(folderName, list);
            Mail m= new Mail();
            int ch;
            do
            {
                Console.WriteLine("\n1. Add Mail");
                Console.WriteLine("\n2. Delete Mail");
                Console.WriteLine("\n3. Display Mails");
                Console.WriteLine("\n4. Exit");
                Console.WriteLine("\nEnter choice: ");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("\nEnter the details of mail in CSV format: ");
                        string[] s = Console.ReadLine().Split(',');


                        Mail m1 = new Mail(long.Parse(s[0]), s[1], s[2], s[3], s[4], DateTime.ParseExact(s[5], "dd-MM-yyyy", null), double.Parse(s[6]));
                        folder.AddMailToFolder(m1);
                        break;

                    case 2:
                        Console.WriteLine("\nEnter the id of the mail to be deleted");
                        long mailId = long.Parse(Console.ReadLine());
                        folder.RemoveMailFromFolder(mailId);
                        break;

                    case 3:
                        folder.DisplayMails();
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("\nInvalid choice");
                        break;
                }
            }
            while (ch != 0);
            Console.WriteLine("Wrong choice");
        }
    }
}


/*Mail Folder - Requirement 2



Requirement 2:

Now we are going to start creating a folder and add mail to it. Start with creating a folder and use menu-driven 
approach to add, remove, display details of the mail in the folder.

a)Create a Class Mail with the following attributes:

Member Field Name	Type

_id	long

_from	string

_to	string

_subject	string

_content	string

_receivedDate	DateTime

_size	double

Mark all the attributes as private.

Include appropriate properties.

Add a default constructor and a parameterized constructor to take in all attributes in the given order:
public Mail(long _id, string _from, string _to, string _subject, string _content, DateTime _receivedDate, double _size)

b)Create a Class MailFolder with the following attributes:

Member Field Name	Type

_name	string

_mailList	List<Mail>

Mark all the attributes as private.

Include appropriate properties.

Add a default constructor and a parameterized constructor to take in all attributes in the given order:
MailFolder(string _name, List<Mail> _mailList). In constructor pass the _mailList value as an empty list. 
Only one folder will be present at a time.

c) Create the following static method in Mail class,

Method Name	Description

public static Mail CreateMail(string detail)	This method accepts a string 
which contains mail details separated by commas.
Split the details and create a mail object from the details and return it.

The mail details should be given as a comma-separated value in the below order,

_id,_from,_to, _subject, _content, _receivedDate, _size

d) Create the following methods in MailFolder class,

Method Name	Description

public void AddMailToFolder(Mail mail)	This method accepts a mail object and add the mail to the mail list of the current mail folder.

public bool RemoveMailFromFolder(long id)	This method will get the id of the mail and delete the mail with the specified _id from the 
current folder.

If a mail with the given _id found, delete the mail and return true. If a mail with the _id is not found return false.

public void DisplayMails()	This method will display the mail list in the current folder.

If the mail list is empty display "No mails to show", else

display "Mails in [folder name]" and display all the mail details in the specified format. Where [folder name] specifies the name of the folder.

After deletion, if true is returned print "Mail successfully deleted", else print "Mail not found in the folder". After adding mail to the
folder, print "Mail successfully added".

Note: The above print statements should be present in the Main method.

Display double values correct to one decimal place.

When the “mail” object is printed, it should display the following format

Print format:

Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15} {6,15}", "Id", "From", "To", "Subject", "Content", "Received Date", "Size");

Display 1 digit after decimal point in Double.

Sample Input and Output:

Enter the name of the folder:

Inbox

1.Add Mail

2.Delete Mail

3.Display Mails

4.Exit

Enter your choice:

3

No mails to show

1.Add Mail

2.Delete Mail

3.Display Mails

4.Exit

Enter your choice:

1

Enter the details of mail in CSV format:

12,john@abc.in,jane@abc.in,Hi,Happy New Year,01-01-2018,10

Mail successfully added

1.Add Mail

2.Delete Mail

3.Display Mails

4.Exit

Enter your choice:

1

Enter the details of mail in CSV format:

16,jack@abc.in,jane@abc.in,Hi,Happy Pongal,14-01-2018,15

Mail successfully added

1.Add Mail

2.Delete Mail

3.Display Mails

4.Exit

Enter your choice:

3

Mails in Inbox

Id From To Subject Content Received Date Size

12 john@abc.in jane@abc.in Hi Happy New Year 01-01-2018 10.0

16 jack@abc.in jane@abc.in Hi Happy Pongal 14-01-2018 15.0

1.Add Mail

2.Delete Mail

3.Display Mails

4.Exit

Enter your choice:

2

Enter the id of the mail to be deleted:

13

Mail not found in the folder

1.Add Mail

2.Delete Mail

3.Display Mails

4.Exit

Enter your choice:

2

Enter the id of the mail to be deleted:

16

Mail successfully deleted

1.Add Mail

2.Delete Mail

3.Display Mails

4.Exit

Enter your choice:

3

Mails in Inbox

Id From To Subject Content Received Date Size

12 john@abc.in jane@abc.in Hi Happy New Year 01-01-2018 10.0

1.Add Mail

2.Delete Mail

3.Display Mails

4.Exit

Enter your choice:

4

*/







