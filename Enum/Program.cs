using System;

namespace Enum
{
    class Program
    {
        enum City
        {
            Seoul,
            Daejun,
            Busan = 5,
            Jeju = 10
        }

        static void Main(string[] args)
        {

            City myCity;

            // enum 타입에 값을 대입하는 방법
            myCity = City.Seoul;

            // enum을 int로 치환(Casting) 하는 방법.
            // (int)를 앞에 지정.
            int cityValue = (int)myCity;

            if (myCity == City.Seoul)
            {
                Console.WriteLine("서울에 오신걸 환영합니다.");
            }
        }
    }
}
