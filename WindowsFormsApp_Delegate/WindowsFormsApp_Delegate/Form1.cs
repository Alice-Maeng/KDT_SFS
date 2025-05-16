using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Delegate
{
    #region Delegate 설명 
     /*
      * Delegate란 ? 
      *  ㄴ 메서드를 대신 실행해줌. 
      *  ㄴ 메서드에 대한 *참조*를 저장할 수 이쓴ㄴ 형식(타입)
      *  즉, 메서드를 직접 실행하지 않고 실행 방법만 담아두는 일종의 "포인터 함수" 역할 
      *  
      *  why? 
      *  1. 메서드를 나중에 실행하고 싶을 때 (실행 로직을 저장해뒀다가 특정 조건이 되면 실행) 
      *  2. 메서드를 매개변수로 전달하고 싶을 때
      *  3. 이벤트 시스템을 만들 때 
      *  
      *  [구조]
      *  - [접근제한자] delegate [반환형] [델리게이트 명]([매개변수 목록]); 
      *  
      *  [선언 위치]
      *  - namespace 안, 클래스 밖 
      */

    // [1] 델리게이트 기본 사용 법
    // #1-1. 델리게이트 선언 
    public delegate void Myelegate(); // 반환형 void, 매개변수 없음.
                                      // "이런 형태의 메서드를 받겠다" 라고 약속하는 타입 

    // [2] 멀티캐스트 델리게이트 
    /*
     * 하나의 델리게이트에 여러 개의 메서드를 연결해서 순차적으로 실행하는 기능
     * += : 메서드 연결
     * -= : 메서드 제거 
     * 
     * [주의] 
     * - 리턴 값이 있는 델리게이트에는 일반적으로 Multicast 사용 안함 !!  
     */

    public delegate void NotifyDelegate();


    // [3] 익명 메서드
    /*
     * 메서드를 따로 만들지 않고 "델리게이트에 직접 정의" 하는 것이 특징
     */

    public delegate void ActionDelegate();


    // [5] 람다식 & 델리게이트
    /*
     * 람다식 이란? 
     * - 메서드를 이름 없이 간결하게 표현하는 문법
     * - delegate 키워드 없이 () => {} 형식으로 작성 가능 
     */

    public delegate void CalcDelegate(int a, int b);


    public delegate void Runner();

    #endregion
    public partial class Form1 : Form
    {
        // #1-2. 메서드 정의
        public void SayHello() // 엇 ! 반환형 void, 매개변수 없네 -> MyDelgate와 형태가 똑같음 -> MyDelegate에 저장 가능 !! 
        {
            Console.WriteLine("안녕하세요!");
        }

        // #2-2. 메서드 정의
        public void SoundAlam()
        {
            Console.WriteLine("[1] 경보음이 울립니다.");
        }

        public void FlashLight()
        {
            Console.WriteLine("[2] 경고음이 깜빡입니다.");
        }

        public void SendNotification()
        {
            Console.WriteLine("[3] 관리자에게 알람을 보냅니다.");
        }

        public void RunnerCall(Runner runner) // 매개변수 1, 반환형 void 
        {
            runner();
        }

        public void Go() => Console.WriteLine("달려!!");
        public void Stop() => Console.WriteLine("멈춰!!");

        public Form1()
        {
            InitializeComponent();
            // #1-3. 델리게이트 객체 생성 & 메서드 참조
            Myelegate del = new Myelegate(SayHello);

            // 2) 암묵적 방식 
            Myelegate del2 = SayHello;

            // #1-4. 델리게이트 실행
            del();
            del2();

            Console.WriteLine("\n======멀티캐스트 델리게이트=======");
            // #2-3. 델리게이트 변수 선언 + 메서드 연결
            NotifyDelegate mulDel = SoundAlam;
            mulDel += FlashLight;
            mulDel += SendNotification;

            Console.WriteLine("메서드 실행");
            mulDel();

            // #2-4. 특정 메서드 제거
            Console.WriteLine("\nFlashLight 제거 후 동작");
            mulDel -= FlashLight;
            mulDel();

            Console.WriteLine("\n==========익명 메서드============");
            // #3-2. 익명 메서드로 델리게이트 정의
            ActionDelegate acDel = delegate ()
            {
                Console.WriteLine("익명 메서드입니당.");
            };

            acDel();


            Console.WriteLine("\n======내장 델리게이트 타입========");
            // [4] 내장 델리게이트 타입 & 익명 메서드 
            /*
             * 내장 델리게이트 타입 (C# 제공)
             * - C#이 자주 쓰는 함수 형태(매개변수+반환 값)를 위해 특정 표준 델리게이트 타입을 미리 정의
             * 
             * why?
             * - 간결하고, 범용적인 함수 형태를 빠르게 표현 할 수 있기 때문
             * 
             * When? 
             * - 간단한 함수, 반복적으로 많이 쓰이는 형태라면 내장 델리게이트트 타입을 사용하면 좋음 
             * - 의미있는 이름을 붙이고 싶거나, 복잡한 구조로 사용자 정의를 원한다면 직접 delegate를 선언해주면 됨ㅠ
             * 
             * [종류]
             * - Func<...>          - 반환 값 있음 / 반드시 마지막 타입이 반환형
             * - Action<...>        - 반환 값 없음 / void 
             * - Predicate<...>     - bool 타입을 반환하는 특수한 Function (조건 필터용) 
             * 
             * [구조]
             * Func<T1, T2, ..., TResult> 
             * - 앞쪽은 매개변수 타입, 마지막은 반환 타입
             * 
             */

            // Func<> 
            Console.WriteLine("\n#1. Func<>");
            Func<int, int, int> addDel = delegate (int a, int b)
            {
                return a + b;
            };
            int result = addDel(1, 2);
            Console.WriteLine($"{result}");

            // Action<>
            Console.WriteLine("\n#2. Action<>");
            Action<string> printMessage = delegate (string msg)
            {
                Console.WriteLine($"메세지 출력: {msg}");
            };
            printMessage("Action!!");

            Console.WriteLine("\n=============람다식=============");
            CalcDelegate printSum = (x, y) =>
            {
                int sum = x + y;
                Console.WriteLine($"[1] {x} + {y} = {sum}");
            };

            printSum(10, 20);

            Func<int,int,int> multiply = (a,b) => a * b;
            int result2 = multiply(2, 5);
            Console.WriteLine($"[2] {result2}");

            Action<string> callName = name => Console.WriteLine($"[3] {name}님 안녕!!");
            callName("Alice");

            Console.WriteLine("\n==============추가++==============");
            Runner runner = Go;
            RunnerCall(runner);

            // Runner runner2 = Stop;
            // RunnerCall (runner2);
            RunnerCall(new Runner(Stop));   // 위 두개의 문장을 간결하게 한 줄로 표현 
        }
    }
}
