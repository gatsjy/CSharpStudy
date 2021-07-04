using System;

namespace Nullable
{
    // Nullable 타입의 도입
    // C#에서 정수, 부동자릿수, 구조체 등의 Value Type은 NULL을 가질 수 없다.
    // 
    class Program
    {
        double _Sum = 0;
        DateTime _Time;
        bool? _Selected;

        public void CheckInput(int? i, double? d, DateTime? time, bool? selected)
        {
            if (i.HasValue && d.HasValue)
                this._Sum = (double)i.Value + (double)d.Value;

            // time 값이 있는 체크
            if (!time.HasValue)
                throw new ArgumentException();
            else
                this._Time = time.Value;

            // 만약 selected가 NULL이면 false를 할당
            this._Selected = selected ?? false;
        }

        static void Main(string[] args)
        {
            // Value Type은 NULL을 가질 수 없다.
            //int i = null;
            int? a = null;
            Console.WriteLine("Hello World!");
        }
    }
}
