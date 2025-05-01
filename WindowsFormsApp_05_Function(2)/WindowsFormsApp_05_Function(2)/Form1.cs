using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp_05_Function_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        #region <실습1>  
        
        bool Game(bool type)
        {
            //Random random = new Random(); //난수 생성 클래스, 현재시간을 기준으로 시드 자동 생성 
            //int result = random.Next() % 2; // random.Next() : 0보다 매우 큰 int 반환하는 코드

            if (type == true)
            {
                   return true;
            }

            return false;
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            string t = "True";
            string f = "False";

            /*
             * bool input = false;
             * 
             * if (textBox_input.Text.Length >0) // textBox_input에 뭐라도 적혀있을때 
             * {
             *      string inputText = textBox_input.Text; 
             *      
             *      if (!(inputText == "True" || inputText == "False"))
             *      {
             *          textBox_result.Text = "True or False 만 입력해주세요.";
             *          return;
             *          
             *          //void 타입 함수에서 return 사용하면, 아무것도 반환하지 않고 해당 함수 종료를 의미
             *          //즉, 함수 실행을 더이상 안하고 빠져나온다는 뜻
             *      }
             *      
             *      else 
             *      {
             *          input = bool.Parse(inputText);
             *      }
             * }
             * 
             * else if (radioButton1.Checked)
             * {
             *      input = true;
             * }
             * else if (radioButton2.Checked) 
             * {
             *      input = false;
             * }
             * 
             * textBox_result.Text = "입력하신 값은 " + input.ToString() + "입니다. \r\n";
             * textBox_result.Text += "동전 던지기 결과...\r\n";
             * string gameRM;
             * if (Game(input) == ture )
                {
                    gameRM = "승리^0^~~";
                }

                else
                {
                    gameRM = "패배ㅜ_ㅜ";
                }
            textBox_result .Text = gameRM + "\r\n";
             * 
         
            */

            if (textBox_input.Text != t && textBox_input.Text != f)
            {
                textBox_result.Text = "True or False 만 입력해주세요.";
            }

            else
            {
                textBox_result.Text = "입력하신 값은 " + textBox_input.Text + "입니다. \r\n";
                textBox_result.Text += "동전 던지기 결과...\r\n";

                bool input = textBox_input.Text == t;
                bool gameresult = Game(input);

            
                if (gameresult)
                {
                    textBox_result.Text += "승리^0^~~";
                }

                else
                {
                    textBox_result.Text += "패배ㅜ_ㅜ";
                }
            }

            // 라디오 버튼 초기화
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            // 입력 텍스트박스 초기화
            textBox_input.Text = "";
        }


        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_input.Text))
            {
                return;
            }

            if (radioButton1.Checked)
            {
                textBox_input.Text = "True";
            }

            else if (radioButton2.Checked)
            {
                textBox_input.Text = "False";
            }
        }
        #endregion

        
    }
}
