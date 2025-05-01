using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_05_Function_2_
{
    public partial class Form2 : Form
    {

        enum CoffeMenu
        {
            Plain,
            WithMilk,
            WithIceCream
        }
        public Form2()
        {
            InitializeComponent();

            #region #goto 점프문
            /* 
             * goto
             *  ㄴ 특정한 라벨(Label)로 점프해서 코드를 실행하도록 하는 명령문(제어문)
             *  ㄴ 코드 순서를 무시하고, 지정한 위치로 순간이동함.
             *  ㄴ 되도록 사용 권장 x
             *  ㄴ 특정 상황에서 빠르게 탈출, 중첩 반복문 빠져나갈 때 사용. 
             *  - 가독성 저하 / 유지보수 어려움 / 코드흐름에 혼란 야기 
            */

            int selection = 0;

            Start:
                 textBox1.Text = "start \r\n";
            Location:
                 textBox1.Text = "Location \r\n";

            if (selection == 0)
            {
                textBox1.Text += "if문 안 \r\n";
                selection = 1;

                goto Location;
            }

            #endregion

            #region # goto & switch 
            // 여러 case에서 같은 코드를 실행해야 할 때, 중복 없이 깔끔하게 처리 가능.
            // goto case에서는 break 안쓰는게 나음
            CoffeMenu menu = CoffeMenu.WithIceCream; // 2

            switch (menu)
            {
                case CoffeMenu.Plain:
                    textBox1.Text += "Coffee";
                    break;

                case CoffeMenu.WithMilk:
                    textBox1.Text += "Milk-";
                    goto case CoffeMenu.Plain;

                case CoffeMenu.WithIceCream:
                    textBox1.Text += "IceCream-";
                    goto case CoffeMenu.Plain;
            }

            #endregion

        }

        #region #Enum 열거형
        /*
         * 관련된 값들을 정수 기반 상수 목록으로 이름 붙여서 그룹화한 사용자 정의 자료형
         * 즉, 서로 관련있는 값들을 묶어서 이름을 붙여주는 사용자 정의 자료형 
         * 기본 값은 0부터 1씩 증가하나 값 지정도 가능 
         * 
         * Why? 코드의 의미가 명확해짐, 값이 바뀌어도 유지보수 쉬움, 가독성 증가
         * 
         */
        enum Food
        {
            pizza, //0
            bugger,//1
            pasta, //2
            kimchi = 100 // 값 지정도 가능 
        }

        enum Week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
            Error = 999
        }






        #endregion

        #region #Switch문




        #endregion

        #region #가위/바위/보 게임 만들기

        enum game
        {
            rock,
            scissors,
            paper,
            error = 999
        }

        enum result
        {
            win,
            lose,
            draw
        }

        // Jack의 랜덤 선택 만들기
        public int rspGame ()
        {
            Random random = new Random();
            int result = random.Next(2);

            switch (result)
            {
                case 0:
                    return (int)game.rock;
               
                case 1:
                    return (int)game.scissors;
             

                case 2:
                    return (int)game.paper;

                default:
                    return (int)game.error;

            }

        }

        //승,패,무승부 구현하기
        private result Judge(game alice, game jack)
        {

            if (alice == jack)
                return result.draw;

            if ((alice == game.rock && jack == game.scissors) || (alice == game.scissors && jack == game.paper)
                || (alice == game.paper && jack == game.rock))
                return result.win;
            else
                return result.lose;

        }

        // 게임 만들기
        int score_a = 0;
        int score_j = 0;

        private void Play (game alice)
        {

            game jack = (game)rspGame();
            result result = Judge(alice, jack);
        

            textBox1_result.Text = "Jack의 선택은: " + jack.ToString() + "\r\n";

            switch (result)
            {
                case result.win:
                    textBox1_result.Text += "오! 승리했습니다.";
                    score_a++;
                    score_A.Text = score_a.ToString();
                    break;
                case result.lose:
                    textBox1_result.Text += "이런... 패배하였습니다.";
                    score_j++;
                    score_J.Text = score_j.ToString();
                    break;
                case result.draw:
                    textBox1_result.Text += "흠... 무승부네요.";
                    break;

            }

            if (score_a > 2 || score_j > 2)
            {
                score_a = 0;
                score_j = 0;
                score_A.Text = "0";
                score_J.Text = "0";
                textBox1_result.Text = "3점을 먼저 획득하여 결과창을 초기화합니다.";
            }


        }


        private void rock_Click(object sender, EventArgs e)
        {

            Play(game.rock);
    
        }
        private void scissors_Click(object sender, EventArgs e)
        {
            Play (game.scissors);

        }
        private void paper_Click(object sender, EventArgs e)
        {
            Play (game.paper);
        }
       

        
        #endregion
    }
}


