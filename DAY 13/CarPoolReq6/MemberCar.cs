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

    namespace CarPoolingReq6

    {

        class MemberCar

        {

            private long _id;

            public long Id

            {

                get { return _id; }

                set { _id = value; }

            }

            private long _memberId;

            public long MemberId

            {

                get

                {

                    return _memberId;

                }

                set

                {

                    _memberId = value;

                }

            }

            private long _carId;

            public long CarId

            {

                get

                {

                    return _carId;

                }

                set

                {

                    _carId = value;

                }

            }

            private string _carRegistrationNumber;

            public string CarRegistrationNumber

            {

                get

                {

                    return _carRegistrationNumber;

                }

                set

                {

                    _carRegistrationNumber = value;

                }

            }

            private string _carColor;

            public string CarColor

            {

                get

                {

                    return _carColor;

                }

                set

                {

                    _carColor = value;

                }

            }

            public MemberCar() { }

            public MemberCar(long id, long memberId, long carId, string carRegistrationNumber, string carColor)

            {

                Id = id;

                MemberId = memberId;

                CarId = carId;

                CarRegistrationNumber = carRegistrationNumber;

                CarColor = carColor;

            }

            public class CarPoolingSystem

            {

                private List<Member> members;

                private List<Car> cars;

                private List<MemberCar> memberCars;

                public CarPoolingSystem(List<Member> members, List<Car> cars, List<MemberCar> memberCars)

                {

                    this.members = members;

                    this.cars = cars;

                    this.memberCars = memberCars;

                }

                public Dictionary<string, List<MemberCar>> GroupByColor()

                {

                    var result = new Dictionary<string, List<MemberCar>>();

                    foreach (var car in cars)

                    {

                        var color = car.Company.ToLower();

                        if (!result.ContainsKey(color))

                        {

                            result[color] = new List<MemberCar>();

                        }

                        var memberCarsWithColor = memberCars.Where(mc => mc.CarId == car.Id);

                        result[color].AddRange(memberCarsWithColor);

                    }

                    return result;

                }

            }

        }

    }
















}
