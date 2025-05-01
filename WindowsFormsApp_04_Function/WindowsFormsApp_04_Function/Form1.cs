using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_04_Function
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            /*
            int num = 200;
            int result = Add(100, num);

            textBox1.Text = result.ToString();
            Nothing();

            // [함수]
            // - 특정 작업을 수행하기 위해 독립적으로 설계된 코드 집합

           int Add(int x, int y)
            {
                return x + y;
            }

            // [구조] 
            // - int 자료형 : 이 함수가 돌려줄 값(return 값)의 타입
            // - Add  : 함수명 
            // - int x, int y : parameter
            //      ㄴ 함수 선언시 함수가 받아야하는 입력값(=매개변수)들.
            //      ㄴ 함수에 전달되는 외부 데이터
            // - {} Scope : 코드 실행 범위 (유효 범위)

            // - return (반환값) 
            //      ㄴ함수 내부 코드의 "최종 결과 값"
            //      ㄴ함수 본문에서 최종 결과를 저장하고 돌려주는 키워드
            //      ㄴreturn 키워드를 만나면 함수 실행 중단

            // [용어 정리] 
            // - 함수 정의(선언) : 함수를 "생성"
            // - 함수 호출 : 함수를 "사용" 

            // [return 값이 없는 함수]
            // void : 반환값이 없을 때 사용하는 키워드

            void Nothing()
            {
                textBox1.Text = "Nothig!!";
            }
            */

            /*
            // 실습1 
            int x = 5;
            int y = 22;

            int[] result = div(x, y);

            textBox1.Text = "몫:" + result[0] + "\r\n" + "나머지:" + result[1];
        
            private int[] div(int a, int b)
            {
                int[] result = new int[2];

                  result[0] = a / b;
                  result[1] = a % b;
                  return result;
            }
            */

            /*
            int inputnum = 10;
            
            //조건과 조건을 비교하는 연산을 수행
            bool is_true = inputnum==10; 

            //(조건1) or (조건2)
            bool compared = (inputNum >10 || inputNum < 5); // false
             */

            // 실습2

            if (Game(true))
            {
                textBox1.Text = "승리";
            }

            else
            {
                textBox1.Text = "패배";
            }

        }


        bool Game(bool type)
        {
            Random random = new Random(); //난수 생성 클래스, 현재시간을 기준으로 시드 자동 생성 
            int result = random.Next() % 2; // random.Next() : 0보다 매우 큰 int 반환하는 코드

            /* Math (=내장 클래스)
             * Math.Round() : 반올림
             * Math.Floor() : 내림
             * Math.Ceiling() : 올림
            */
            
            // 동전 결과(result)와 사용자의 선택(type)이 일치할 경우에만 true 반환 
            // 1이면 true(앞면), 0이면 flase(뒷면)
            if ((result == 1 && type == true) || (result == 0 && type == false))
            {
                return true;
            }

            return false; 

        }
    }
    
}
