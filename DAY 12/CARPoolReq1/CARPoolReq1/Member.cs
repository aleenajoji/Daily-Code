using System;



namespace CarPoolingReq1

{

    class Member

    {

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

            set

            {

                _lastName = value;

            }

        }

        private string _email;

        public string Email

        {

            get { return _email; }

            set

            {

                _email = value;

            }

        }

        private string _contactNumber;

        public string ContactNumber

        {

            get

            {

                return _contactNumber;

            }

            set

            {

                _contactNumber = value;

            }

        }

        private string _licenseNumber;

        public string LicenseNumber

        {

            get { return _licenseNumber; }

            set

            {

                _licenseNumber = value;

            }

        }

        private DateTime _licenseStartDate;

        public DateTime LicenseStartDate

        {

            get

            {

                return _licenseStartDate;

            }

            set

            {

                _licenseStartDate = value;

            }

        }

        private DateTime _licenseExpiryDate;

        public DateTime LicenseExpiryDate

        {

            get

            {

                return _licenseExpiryDate;

            }

            set

            {

                _licenseExpiryDate = value;

            }

        }

        public Member() { }

        public Member(long id, string firstName, string lastName, string email, string contactNumber, string licenseNumber, DateTime licenseStartDate, DateTime licenseExpiryDate)

        {

            Id = id;

            FirstName = firstName;

            LastName = lastName;

            Email = email;

            ContactNumber = contactNumber;

            LicenseNumber = licenseNumber;

            LicenseStartDate = licenseStartDate;

            LicenseExpiryDate = licenseExpiryDate;

        }

        public override bool Equals(object obj)

        {

            if (obj == null)

            {

                return false;

            }

            Member other = (Member)obj;

            return Email.ToLower() == other.Email.ToLower() && ContactNumber.ToLower() == other.ContactNumber.ToLower();

            /*Member m1 = obj as Member;

            if (m1.Email == Email && m1.ContactNumber == ContactNumber)

            {

              return true;

            }

            else

            {

              return false;

            }*/

        }

        public override string ToString()

        {

            return string.Format("Member: {0}, {1}\nMember contact details: {2}, {3}\n", FirstName, LastName, Email, ContactNumber);

        }

        public override int GetHashCode()

        {

            return base.GetHashCode();

        }

    }

}