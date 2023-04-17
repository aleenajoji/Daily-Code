using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MailFolderApp
{
    class MailFolder
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        private List<Mail> _mailList;
        public List<Mail> MailList { get { return _mailList; } set { _mailList = value; } }

        public MailFolder()
        {
        }

        public MailFolder(string _name, List<Mail> _mailList)
        {
            Name = _name;
            MailList = _mailList;
        }

        public MailFolder(string _name)
        {
            Name = _name;
            MailList = new List<Mail>();
        }

        public void AddMailToFolder(Mail mail)
        {
            MailList.Add(mail);
            Console.WriteLine("Mail uccessfully added");
        }

        public bool RemoveMailFromFolder(long Id)
        {
            foreach (Mail mail in MailList)
            {
                if (mail.Id == Id)
                {
                    _mailList.Remove(mail);
                    Console.WriteLine("Mail successfully deleted");
                    return true;
                }
            }
            Console.WriteLine("Mail not found in the folder");
            return false;
        }
        public void DisplayMails()
        {
            Console.WriteLine();
            if (_mailList.Count == 0)
            {
                Console.WriteLine("No mails to show");
            }
            else
            {
                Console.WriteLine("Mails in {0}\n", _mailList);
                Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15} {6,15}", "Id", "From", "To", "Subject", "Content", "ReceivedDate", "Size");
                foreach (Mail mail in MailList)
                {
                    Console.WriteLine(mail);
                }
            }
        }
    }
}