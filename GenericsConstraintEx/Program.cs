using System;

/*
    제네릭스 타입 제약
    
    앞에 일반화 메소드, 일반화 클래스에서 사용하던 T(Type Parameter)는 모든 데이터 형식을 대신할 수 있는 매개변수 입니다.

    모든 형식을 대신하는 매개변수가 필요할 수도 있지만 그렇지 않은 경우도 종종있다.
    그런 경우에는 매개변수에 제약 조건을 줄 수 있다.

    제약 조건을 주는 방법으로 where 절을 이용한다.

    <예>

    class DemoList<T> where T: DemoClass
    {
    }

    위의 경우에 T라고 매개변수는 "DemoClass로 부터 상속받는 형식이어야한다." 라는 의미

    vois CopyData<T>(T a, T b) where T : struct
    {
    }
    위의 경우 T는 "값 형식이어야 한다" 라는 제약 조건을 준의미이다.

    - 제네릭스에서 제약조건을 주는 방식은
        where T : 제약조건
    
    [ 제약 조건의 종류 ]

        - where T : struct  :T가 값형식이어야 한다.
        - where T : class   :T가 참조형식이어야한다.
        - where T : new()   :T가 반드시 매개 변수가 없는 생성자가 있어야 한다.(기번생성자가 없으면 안된다.)
        - where T : 기반클래스명 : T는 기반클래스의 파생 클래스 이어야한다.
        - where T : 인터페이스명 : T는 인터페이스를 반드시 구현해야 한다. 인터페이스명은 여러개가 올 수도 있다.
        - where T : U             T는 또 다른 형식 매개변수 U로부터 상속받은 클래스이여야 한다.


*/
namespace GenericsConstraintEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
