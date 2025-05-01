using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_02._Valuable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*
            //변수의 선언
            int numOfCrew;

            //변수의 사용
            numOfCrew = 19;

            //변수의 초기화
            string className = "말하기";

            //변수의 값 덮어쓰기
            className = "수학";

            //선언보다 밑에 줄에서 사용 가능
            int lineCount;

            //같은 이름 사용 불가
            byte buffer;
            // float buffer;

            //데이터 타입이 완전히 다르면 복사 불가.
            int number = 10;
            string word = "안녕";

            // number = word; (x)

            //같은 형식에서 데이터 타입의 크기에 따라 복사 가능 or 불가능
            short word2 = 20;

            //int > short
            number = word2; // 자료형이 다르지만, 복사 가능 


            //변수끼리 값 복사 가능
            int var_x = 10;
            int var_y = var_x; // x값이 y로 복사 완료

            //사칙연산 및 괄호
            int var_z = var_x * var_y;
            int result = var_z + (var_x + 5);

            //Scope가 다르면 사용이 불가능
            {
                int inside = 100;
            }

            //int outside = inside + 50;
            textBox1.Text += numOfCrew.GetType() + "numOfCrew:" + numOfCrew.ToString() + "\r\n";
            */

            /*
            //************************ 실습1 ****************************

            byte attendees = 20;
            short word = 1000;
            int num = 5;
            float buffer = 3.5f;
            double check = 5.22;
            decimal money = 123.45m;

            textBox1.Text += attendees.GetType() + " attendees:" + attendees.ToString() + "\r\n"
                             + word.GetType() + " word:" + word.ToString() + "\r\n"
                             + num.GetType() + " num:" + num.ToString() + "\r\n"
                             + buffer.GetType() + " buffer:" + buffer.ToString() + "\r\n"
                             + check.GetType() + " check:" + check.ToString() + "\r\n"
                             + money.GetType() + " money:" + money.ToString() + "\r\n";

            */

            /*
            //연산자
          
            int a = 5;
            int b = 2;

            //textBox1 컨트롤은 "사용자에게 텍스트(문자열)를 보여주기위한 도구" 
            //textBox1.Text의 자료형이 string(문자열)임

            textBox1.Text = a.ToString(); //즉 숫자를 바로 넣을 수 없음
            
            // #1 형변환 방법
            textBox1.Text = (a + b).ToString() + "\r\n";


            // #2 문자열 보간 방법
            // $"{표현식}" 형태
            //     ㄴ 안에 있는 코드를 계산하고 자동으로 문자열을 만들어줌.
            textBox1.Text += $"{a - b}\r\n";


            //(주의!) C#에서의 거듭제곱 : Math.Pow(밑, 지수) 메서드를 사용해야함
            //              ㄴ 결과는 늘 double로 반환됨
            textBox1.Text += $"{Math.Pow(a, b)}\r\n";
            textBox1.Text += $"{Math.Sqrt(9)}\r\n"; // 루트(제곱근) 

            //비교 연산자
            // #1 도응 비교 : 같다 / 같지 않다.
            textBox1.Text += $"{1 == 1}\r\n";
            textBox1.Text += $"{1 == 2}\r\n";
            textBox1.Text += $"{1 != 2}\r\n";

            // #2 크기 비교 
            // #3 논리 연산자 
            //     ㄴ ! : not 의미 (참 --> 거짓 , 거짓--> 참)
            //     ㄴ && (그리고) , || (또는) 
            textBox1.Text += $"{!true}\r\n";
            textBox1.Text += $"{!false}\r\n";

            /*

            //************************ 실습2-1 ****************************
            string fruit = "사과";
            int price = 1000;
            int num = 5;
            
            textBox1.Text += fruit + num.ToString() +"개의 가격은" + $"{num*price}원 입니다.\r\n";

            */
            
            //************************ 실습2-2~ ****************************

            string laptop = "노트북";
            int price = 1200000;
            byte num = 8;
            bool isAvailable = num >= 1;
            float discount = 0.15f;
            double dp = price * (1 - discount);


            //구매가능 여부
            string result1 = (isAvailable == true) ? "구매가능: 할인가격은" + dp.ToString("N0") +"입니다." : "품절되었습니다.";
            textBox1.Text += result1;


            //재고 여부
            string result2 = (num >= 5) ? "여유있음" : "소량남음";
            textBox2.Text += result2;

            //상품 정보
            textBox3.Text += "상품명: " + laptop + ", 할인된 가격:" + dp.ToString("N0") + "원, 재고: " + num.ToString() + "개 \r\n";
           
           // 소수점  포맷 설정 
           // - 포맷 조정은 "출력용" 변환이다. (계산 자체가 바뀌진 않음) 
           // "N0" - 천 단위 구분 쉼표(,)를 찍어주는 서식 
           // "P1" - 퍼센트로 변환해서 소수 첫째 자리까지. 
           // "0" - 자리수 채움 (0으로 채움) 
           // "0.0" - 소수점 첫째자리까지, 없으면 0으로 채움 
           // "0.00" - 소수점 둘째자리까지, 없으면 0으로 채움
           // "0.###" - 소수점 세자리까지, 있으면 표시, 없으면 표시 안함.
           // "N2" - 쉼표 + 소수 둘째자리까지
        }

    }
}
