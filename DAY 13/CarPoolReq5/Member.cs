using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Xml.Linq;

namespace CarPoolingReq5

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

        private long phone;

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

        public Member(int id, string firstname, string lastname, string email, long phone, string licensenumber, DateTime licensestartdate, DateTime licenseexpirydate)

        {

            Id = id;

            FirstName = firstname;

            LastName = lastname;

            Email = email;

            this.phone = phone;

            LicenseNumber = licensenumber;

            LicenseStartDate = licensestartdate;

            LicenseExpiryDate = licenseexpirydate;

        }

        public override string ToString()

        {

            return string.Format("Id:{0}\nFirstName:{1}\nLastName:{2}\nEmail:{3}\nContact:{4}License Number:{5}\nLicense Start Date:{6}\nLicense Expiry Date:{7}", Id, FirstName, LastName, Email, ContactNumber, LicenseNumber, LicenseStartDate.ToString("dd-mm-yy", null), LicenseExpiryDate.ToString("dd-mm-yy", null));

        }

    }

}