using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_05_Function_2_
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            Addfile addfile = new Addfile();
            int resultSum = addfile.Sum(1,2);

            double value = addfile.d_value;

            #region #While문
            /*
             * 조건이 "true"일 동안 계속해서 반복하는 반복문.
             * =즉, 조건이 "false"가 될 때까지 무한 반복 가능
             * 
             * while (조건식)
             * {
             *      조건이 true일 때 실행할 코드
             * }
             */
            
            // ex1
            int count = 2;
            while (count <100)
            {
                Console.WriteLine(count);
                count++;

            }
          
            Console.WriteLine("------------------------------");

            // ex2. 1~5 출력
            int num = 1; 
            while (num <= 5)
            {
                Console.WriteLine(num);
                num++;
            }

            Console.WriteLine("------------------------------");

            // ex3. 무한 루프
            /*
            bool run = true;
            while (run)
            {
                Console.WriteLine("무한");
            }
            */

            // ex4. 무한루프 2 (의도적으로 벗어나기)
            int idx = 0;
            while (true)
            {
                idx += 2;
                if (idx == 10)
                {
                    break;
                }
                Console.WriteLine($"{idx}");
            }

            Console.WriteLine($"{idx}");
            Console.WriteLine("------------------------------");

            #endregion

            #region #break & contiue 
            /*
             * 반복문에서 사용되는 제어문.
             * # break = 반복문을 완전히 중단하고 빠져나옴.
             * # continue = 현재 반복을 중지하고 다음 단계로 넘어감 (즉, 이번 회차 건너뛰기) 
             */

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine($"{i}");
            }

            Console.WriteLine("------------------------------");

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine($"{i}");
            }
            #endregion
        }
    }
}

