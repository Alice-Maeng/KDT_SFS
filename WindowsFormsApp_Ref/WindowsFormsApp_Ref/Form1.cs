using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Ref
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region #연습
            /*
             * #1. 기본 값 전달 방식
             *  ㄴ C#에서는 메서드에 값을 인자로 넘길 때(=매개변수 전달), 기본적으로 "값을 복사"하여 전달함 
             *  ㄴ 즉, 원본 변수와는 전혀 다른 "복사본"을 만들어 함수에 넘긴다는 뜻.
             *  ㄴ 그로 인해, 메서드 안에서 변수 값을 변경해도 원본 변수는 영향을 받지 않음.
             */

            int num = 10;
            ChangeValue(num);       // 값을 복사해서 전달 (num 복사)
            Console.WriteLine(num); // 결과 값 : 10 --- 원본 num은 전혀 바뀌지 않았음 !! 

            Console.WriteLine("====================");

            /*
             * ref, out 키워드 값 전달 방식
             * ㄴ why? 메서드에서 변수의 "원본 값을 직접 수정" 또는 return을 보완해서 "여러 값을 반환"하고 싶을때 사용함
             * ㄴ 참조전달 방식임 
             * ㄴ 정의부와 호출부 모두 키워드를 명시해야하며, 그렇지 않으면 오류남
             * 
             * [ref]
             * - 입력 + 출력  
             * - 호출 전 변수는 반드시 "초기화"되어 있어야 함 
             * - 메서드 안에서 값을 바꿀 수도, 안 바꿀 수도 있음 (즉, 선택가능)
             * - 기존 값 받아서 내부에서 수정하고 싶을 때 사용  
             * 
             * [out]
             * - 출력 
             * - 호출 전 변수는 초기화 안해도 됨 
             * - 메서드 안에서 반드시 값을 할당해야함 (필수)
             * - 내부에서 새 값을 만들어서 돌려주고 싶을 때 사용 (여러 값 반환 가능)
             */



            // #2. ref 
            int numRef = 10;
            ChangeRef(ref numRef);
            Console.WriteLine(numRef);

            Console.WriteLine("====================");

            // #3. out
            int numOut;     //초기화 안해도 됨
            ChangeOut(out numOut);
            Console.WriteLine(numOut);

            // #3-2. out 다중 값 반환
            int result1, result2;
            Divide(10, 3, out  result1, out result2);  //out 매개변수 전달 
            Console.WriteLine($"몫: {result1}, 나머지: {result2}");

            Console.WriteLine("====================");

            #endregion

            Console.ReadLine();

            #region #실습. 값의 참조
            //1번 문제
            int xRef = 1;
            int[] refExample= new int[5];

            Array1(ref xRef, ref refExample);
            Console.WriteLine($"[ref] 배열 값: {string.Join(", ", refExample)}");
            Console.ReadLine();


            //2번 문제
            int[] outExample;
            int aOut = 5; 

            Array2(out outExample, aOut);
            Console.WriteLine($"[out] 배열 값: {string.Join(", ", outExample)}");



            #endregion

        }

        #region #연습
        // [함수]
        // #1. 기본 값 전달 방식 (복사된 값만 바뀜, 원본 값은 그대로) 

        void ChangeValue(int x) => x = 99; // 복사된 x값만 바뀌고 num은 여전히 10

        // #2. ref 키워드를 사용한 참조 전달 방식 (참조 전달 -> 원본 값은 바뀜)
        void ChangeRef(ref int x)
        {
            x = 99;
        }

        // #3. out 키워드를 사용한 참조 전달 방식 (참조 전달 -> 반드시 값 할당)
        void ChangeOut(out int x)
        {
            x = 100; // 반드시 값을 할당해야 함.
        }

        // #3-2. out 키워드를 사용한 여러 값 반환 
        void Divide (int a, int b, out int result1, out int result2)
        {
            result1 = a / b;    // 몫
            result2 = a % b;    // 나머지
        }
        #endregion

        #region #실습

        void Array1 (ref int xRef, ref int[] refExample)
        {
            
            for (xRef=0; xRef < refExample.Length; xRef++)
            {
                refExample[xRef] = xRef +1;
            }
        }

        void Array2(out int[] outExample, int aOut)
        {
            outExample = new int[aOut];

            for (int i=0; i< aOut; i++)
            {
                outExample[i] = i + 1;
            }
        }

        #endregion
    }
}
