using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace WindowsFormsApp_05_Function_2_
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();


            #region #for문 
            /*
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------");

            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            
            #endregion

            #region Quiz1
            /*
            int sum = 0;

            for (int i = 1; i <=20; i++)
            {
                if (i % 2 == 0)
                {  
                    sum += i;
       
                }
            }

            Console.WriteLine(sum);
            */
            #endregion

            Console.WriteLine("----------------------------");

            #region Quiz2
            /*
            int sum = 0;
            int count = 0;

            for (int i = 1; i <= 100; i++)
            {
                if(i%3==0 && !(i % 5 == 0))
                {
                    sum += i;
                    count++;
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("총합은: " + sum);
            Console.WriteLine("개수는: " + count);
            */
            #endregion

            Console.WriteLine("----------------------------");
            #region # 중첩 for문
            /*
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j<=2; j++)
                {
                    Console.WriteLine($"i={i}, j={j}");
                }
            }
            */
            #endregion

            Console.WriteLine("----------------------------");

            #region Quiz3 - 구구단 2단~9단 
            int m = 0;

            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    m = i * j;
                    Console.WriteLine(i + " x " + j + " = " + m);
                }
                Console.WriteLine();
            }

            #endregion

            Console.WriteLine("----------------------------");

            #region Quiz4 - 별찍기 
            /*
             * |   *
             * |  **
             * | ***
             * |****
             */

            int s = 4;

            for (int i = 1; i <= s; i++) // 줄 수
            {
                //공백 출력
                for (int j = 1; j <= s - i; j++)
                {
                    Console.Write(" ");
                }

                //별 출력
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            #endregion

            Console.WriteLine("----------------------------");

            #region Quiz4 - 별찍기 Lv.2
            /*
             *|   *     // 빈칸 3개, 별 1개, 빈칸 3개
             *|  ***    // 빈칸 2개, 별 3개, 빈칸 2개
             *| *****   // 빈칸 1개, 별 5개, 빈칸 1개
             *|*******  // 빈칸 0개, 별 7개, 빈칸 0개
             */

            int s2 = 4;
            for (int i = 1; i <= s2; i++)
            {
                //공백 출력
                for (int j = 1; j <= s2 - i; j++)
                {
                    Console.Write(" ");
                }

                //별 출력
                for (int k = 1; k <= ((2 * i) - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }

            #endregion

            Console.WriteLine("----------------------------");

            #region #배열 반복문
            /*
            // EX1 
            string[] fruits = {"사과", "바나나", "포도", "딸기"};
            
            //before
            Console.WriteLine(fruits[0]);
            Console.WriteLine(fruits[1]);
            Console.WriteLine(fruits[2]);
            Console.WriteLine(fruits[3]);
            Console.WriteLine(fruits.Length); // 4

            Console.WriteLine("----------------------------");

            //after
            for (int i = 0; i < fruits.Length; i++)        // ~.Length :배열의 크기(길이)
            {
                Console.WriteLine(fruits[i]);
            }
            

            /* 
             * foreach 문 
                ㄴ 배열의 모든 항목(요소)을 "처음~끝" 하나씩 꺼내며 반복 실행하는 문법
                ㄴ 배열을 순화하면서 각 요소에 대해 "동일한 작업"을 수행할 때 사용
                ㄴ "순서가 있는 구조 반복"에 적합
               foreach (자료형 변수명 in 배열이름) 
               {
                      배열의 항목 하나씩 사용
               }
            
          
            string[] fruits = { "사과", "바나나", "포도", "딸기" };
            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

             */
            Console.WriteLine("----------------------------");

            /*
            // Ex2) for문 버전
            int[] score = { 85, 90, 78, 92, 88 };
            int sum = 0;

            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }

            double average = (double)sum / (double)score.Length;

            Console.WriteLine("총합: "+sum);
            Console.WriteLine("평균: " + average);
            */

            /*
            // Ex3) Ex2 예제 -> foreach문으로 변환 
            int[] score = { 85, 90, 78, 92, 88 };
            int sum = 0; 
            foreach (int scores in score)
            {
                sum += scores;
            }
            double average = (double)sum / (double)score.Length;

            Console.WriteLine("총합: "+sum);
            Console.WriteLine("평균: " + average);
            */
            #endregion


            

            
            
            
        }

        #region Quiz5 - 랜덤 성적표
        private void button1_Click(object sender, EventArgs e)
        {
            int array_size;

            if (int.TryParse(textBox_sn.Text, out array_size))
            {
                int[] student = new int[array_size];
                Random rnd = new Random();

                textBox_result.Text = "";

                for (int i = 0; i < array_size; i++)
                {
                    student[i] = rnd.Next(0, 101);
                    textBox_result.Text += "학생" + (i + 1) + "번: " 
                                        + student[i].ToString() + "점\r\n";
                }
            }

            else
            {
                textBox_result.Text = "학생수를 입력해주세요.";
            }

        }
        #endregion
    }
}
