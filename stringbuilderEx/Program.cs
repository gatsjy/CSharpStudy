using System;
using System.Text;

namespace stringbuilderEx
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
             1. string
             string은 값타입이 아닌 참조변수 입니다. 즉, 문자열을 조합할 때마다 새로운 클래스가 생성되고 이전의 데이터는 GB(Garbage Collector)에 의해서 수집이 됩니다.
             따라서 문자열을 조합할때마다 부하가 발생합니다.
            */

            // 1. 문자열 단순 조합
            string Address = "천안시 " + " 동남구" + " 서북대로";
            Console.WriteLine(Address);
            /*여기서는 총 세번의 String 인스턴스가 생성이 되며 2개의 인스턴스는 GB에 의해서 언제가 될지는 모르지만 수집이 됩니다.
             따라서 메모리 낭비가 발생이 되며 비효율적인 코드가 생산이 됩니다.*/

            /*
             2. StringBuilder
             stringbuilder을 사용하면 문자열을 조합할 때마다 새로운 변수를 생성하지 않고 결합할 수 있다.
             내부에 함수가 존재해서 값들을 조합하거나 삭제할때에도 새로운 인스턴스가 생성되지 않습니다.
             */

            // 2. Stringbuilder사용 문자열 조합
            StringBuilder sbAddress = new StringBuilder();
            sbAddress.Append("천안시");
            sbAddress.Append(" 동남구");
            sbAddress.Append(" 서북대로");

            Console.WriteLine(sbAddress.ToString());

            /* 3. 주의
                문자열을 조합할 때마다 무조건적으로 StringBuilder을 사용하면 안됩니다. 각각의 장단점들이 있기 때문에 아래의 조건에 따라서
                String을 사용하지 StringBuilder을 사용할지 결정해야 합니다.
                3-1 String 클래스를 사용하는 경우
                - 문자열을 수정하는 수가 적을 경우(stringbuilder은 string에 비해서 무시해도 좋을 수준의 성능향상을 제공하거나 전혀 제공하지 않을 수 있음)
                - 부분적인 문자열 글자로 고정된 수의 문자열 연결 작업을 할때(컴파일러가 연결 작업을 단일 작업으로 결합할 수 있음)
                - 문자열을 작성하는 동안 광범위한 검색 작업을 수행할 때(StringBuilder클래스는 IndexOf 또는 StartWith같은 함수가 없다.)
                3-2 StringBuilder 클래스를 
                - 응용 프로그램이 설계시에는 알 수 없는 횟수의 문자열을 변경해야 할 때 (사용자의 입력등으로 조합할때)
                - 문자열에서 많은 횟수의 변경이 예상될때
                출저 : https://hongjinhyeon.tistory.com/91
             */
        }
    }
}
