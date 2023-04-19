using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolReq6
{
    using System;

    using System.Collections.Generic;

    using System.Linq;

    using System.Text;

    using System.Threading.Tasks;

    namespace CarPoolingReq6

    {

        class Car

        {

            private long _id;

            public long Id

            { get { return _id; } set { _id = value; } }

            private string _name;

            public string Name

            { get { return _name; } set { _name = value; } }

            private string _model;

            public string Model

            { get { return _model; } set { _model = value; } }

            private Int32 _makeYear;

            public Int32 MakeYear

            { get { return _makeYear; } set { _makeYear = value; } }

            private string _company;

            public string Company

            { get { return _company; } set { _company = value; } }

            private Int32 _comfortLevel;

            public Int32 comfortLevel

            { get { return _comfortLevel; } set { _comfortLevel = value; } }

            public Car()

            {

            }

            public Car(long _id, string _name, string _model, int _makeYear, string _company, int _comfortLevel)

            {

                Id = _id;

                Name = _name;

                Model = _model;

                MakeYear = _makeYear;

                Company = _company;

                this.comfortLevel = _comfortLevel;

            }

        }

    }
}
