using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Class_2_
{
    // #1. 다단계 상속 (조부모 ~ 손자 클래스) 
    // 최상위 클래스(조부모(조상))
    public class GrandParent
    {
        public GrandParent()     // 기본 생성자
        {
            Console.WriteLine("GrandParent 생성자 호출됨!");

        }

        // #2. base(...) 키워드 
        /*
         * 상속된 클래스에서 "자식" 생성자에서 "부모" 생성자를 선택적으로 호출하고 싶을 때 사용.
         * 손자 -> 조상(x) 
         */

        public GrandParent(string name, int age)
        {
            Console.WriteLine($"GrandParent 매개변수 생성자 호출됨!");
            Console.WriteLine($"이름은 {name}, 나이는 {age}입니다.");
        }
        public void SayHello()
        {
            Console.WriteLine("안녕하세요~ 저는 할머니입니다.");

        }
    }

    // 부모 클래스 
    public class Parent : GrandParent {
        public Parent()
        {
            Console.WriteLine("Parent 생성자 호출됨!");
        }


        // #2-1. base(...) 부모 클래스에서 조상 매개변수 생성자 호출
        public Parent(string name, int age ) : base (name, age)
        {
            Console.WriteLine($"Parent 매개변수 생성자 호출됨!"); 

        }
        public void SayHello2()
        {
            Console.WriteLine("저는 어머니입니다.");

        }
    }

    // 자식 클래스
    public class Child : Parent
    {
        // #3. 자식 클래스의 기본 생성자 없고, 매개변수 생성자만 존재 할 때, 
        // ㄴ 손자 클래스에서 반드시 자식 클래스의 생성자를 호출해야 함
        // ㄴ 손자 클래스에서도 기본 생성자를 삭제하던가 자식 클래스에 기본 생성자를 추가하던가... 
        // ㄴ 손자 클래스 생성자에서 base(...)로 부모 매개변수 생성자 명시 호출 
        // ㄴ ex.
        //        public GrandChild (string name) : base(name)
        //        {
        //            Console.WriteLine("~~~");
        //        }
        // ㄴ 그럼 이 때, base(name) 에 빨간줄 뜰텐데, Child 클래스에서 매개변수 생성자 호출하면됨.

        public Child()
        {
            Console.WriteLine("Child 생성자 호출됨!");
        }

        //#2-2. base(...) 손자 클래스에서 먼~ 조상 매개변수 생성자 호출
        // ㄴ 중간 다리 (전체) 연결 해줘야 함.

        public Child(string name, int age) : base(name, age)
        {
            Console.WriteLine("Child 매개변수 생성자 호출됨!"); 
        }

        

        public void SayHello3()
        {
            Console.WriteLine("저는 자식입니다.");

        }
    }

    // 손자.손녀 클래스
    public class GrandChild : Child
    {
        public GrandChild()
        {
            Console.WriteLine("GrandChild 생성자 호출됨!");
        }

        //#2-2. base(...) 손자 클래스에서 먼~ 조상 매개변수 생성자 호출
        public GrandChild(string name, int age) : base (name, age)
        {
            Console.WriteLine("GrandChild 매개변수 생성자 호출됨!");
        }

        public void SayHello4()
        {
            Console.WriteLine("저는 손녀입니다.");

        }
    }
}
