using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarPoolReq2
{
    
        class Member

        {

            private static List<Member> memberList = new List<Member>();

            private long _id;

            public long Id

            {

                get { return _id; }

                set { _id = value; }

            }

            private string _firstName;

            public string FirstName

            {

                get { return _firstName; }

                set { _firstName = value; }

            }

            private string _lastName;

            public string LastName

            {

                get { return _lastName; }

                set { _lastName = value; }

            }

            private string _email;

            public string Email

            {

                get { return _email; }

                set { _email = value; }

            }

            private string _contactNumber;

            public string ContactNumber

            {

                get { return _contactNumber; }

                set { _contactNumber = value; }

            }

            private string _licenseNumber;

            public string LicenseNumber

            {

                get { return _licenseNumber; }

                set { _licenseNumber = value; }

            }

            private DateTime _licenseStartDate;

            public DateTime LicenseStartDate

            {

                get { return _licenseStartDate; }

                set { _licenseStartDate = value; }

            }

            private DateTime _licenseExpiryDate;

            public DateTime LicenseExpiryDate

            {

                get { return _licenseExpiryDate; }

                set { _licenseExpiryDate = value; }

            }

            private List<MemberCar> _carList = new List<MemberCar>();

            public List<MemberCar> CarList

            {

                get { return _carList; }

                set { _carList = value; }

            }

            public Member()

            {

                _carList = new List<MemberCar>();

            }

            public Member(long _id, string _firstName, string _lastName, string _email, string _contactNumber, string _licenseNumber, DateTime _licenseStartDate, DateTime _licenseExpiryDate)

            {

                Id = _id;

                FirstName = _firstName;

                LastName = _lastName;

                Email = _email;

                ContactNumber = _contactNumber;

                LicenseNumber = _licenseNumber;

                LicenseStartDate = _licenseStartDate;

                LicenseExpiryDate = _licenseExpiryDate;

            }

            public static Member FindMember(ArrayList memberList, long _id)

            {

                foreach (Member member in memberList)

                {

                    if (member.Id == _id)

                    {

                        return member;

                    }

                }

                return null;

            }

        }
    }

    

















