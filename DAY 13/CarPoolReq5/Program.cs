
using System;

using System.Collections;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace CarPoolingReq5

{

    internal class Program

    {

        static void Main(string[] args)

        {

            int num = 0;

            Console.WriteLine("Enter the number of members:");

            num = int.Parse(Console.ReadLine());

            ArrayList al = new ArrayList();

            try

            {

                for (int i = 0; i < num; i++)

                {

                    Console.WriteLine("Enter member {0} details:", i + 1);

                    string[] s = Console.ReadLine().Split(',');

                    int id = int.Parse(s[0]);

                    string firstname = s[1];

                    string lastname = s[2];

                    string email = s[3];

                    long phone = long.Parse(s[4]);

                    string licensenumber = s[5];

                    DateTime licensestartdate = DateTime.Parse(s[6]);

                    DateTime licenseexpirydate = DateTime.Parse(s[7]);

                    //Member m = new Member(long.Parse(s[0]), s[1], s[2], s[3], s[4], s[5], DateTime.ParseExact(s[6], "dd-MM-yyyy", null), DateTime.ParseExact(s[7], "dd-MM-yyyy", null));

                    Member m = new Member(id, firstname, lastname, email, phone, licensenumber, licensestartdate, licenseexpirydate);

                    al.Add(m);

                    if (!email.Contains("@") || (!email.EndsWith(".com") && !email.EndsWith(".org")))

                    {

                        throw new InvalidEmailException("InvalidEmailException: Invalid Email for " + firstname);

                    }

                }

            }

            catch (InvalidEmailException e)

            {

                Console.WriteLine(e.Message);

            }

            Console.WriteLine();

            int j = 1;

            foreach (var item in al)

            {

                Console.WriteLine("Member {0}: ", j);

                Console.WriteLine(item.ToString());

                j++;

            }

        }

    }

}






/*Problem Description

Car Pooling System - Requirement 5

Create a custom checked Exception “InvalidEmailException” with custom error message. 
"InvalidEmailException: Invalid Email for the user".

Read member details from Input (Console). One line would consist details relating one 
member in comma separated format. Create member objects for each line and add it to an arraylist.

a. During the parse, if an email id is invalid, A valid email has an @ and ends 
with “.com / .org”. Raise the custom exception and skip the entity to add into the list.

b. Sort the arraylist of members based on firstname ( hint: Use comparable).

Sample Input and Output:

[All text in bold corresponds to input and the rest corresponds to output.]

Enter the number of Members:

5

Enter the member details:

1,joe,root,joe.root@a.com,1234567890,AH1,12-12-2001,12-12-2010

2,ben,stokes,ben.stokes!a.com,2345678901,AH2,12-12-2002,12-12-2011

InvalidEmailException: Invalid Email for ben

3,virat,kohli,virat.kohli@a.com,3456789012,AH3,12-12-2003,12-12-2012

4,ravi,varma,ravi.varma@a.in,4357689010,AH4,11-10-2003,12-10-2013

InvalidEmailException: Invalid Email for ravi

5,mahendra,bagubali,mahi.bali@abc.com,1234798012,AH5,10-02-2003,12-02-2015

The member details are:

1,joe,root,joe.root@a.com,1234567890

5,mahendra,bagubali,mahi.bali@abc.com,1234798012

3,virat,kohli,virat.kohli@a.com,3456789012*/
