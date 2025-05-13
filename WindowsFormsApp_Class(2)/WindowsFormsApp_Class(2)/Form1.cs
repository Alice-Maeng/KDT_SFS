using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Class_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region #1. 기본 상속
            // 클래스 실행 
            // * 객체 이니셜라이저
            // ㄴ 객체를 만들자마자 속성 값을 한꺼번에 초기화하는 문법. 
            
            Rectangle rect = new Rectangle()
            {
                Name = "사각형",
                Width = 4,
                Height = 5
            };

            // 위의 코드랑 아래 코드랑 같음 
            /*
            Rectangle rect = new Rectangle();
            rect.Name = "사각형";
            rect.Width = 4;
            rect.Height = 5;

            단, 해당 코드로 사용하기 위해서 클래스의 속성(Property)이 public{get;set;}처럼 외부에서 설정 가능해야함.
            */

            Triangle tri = new Triangle()
            {
                Name = "삼각형",
                BaseLength = 6,
                Height = 3
            };

            Circle cir = new Circle()
            {
                Name = "원",
                Radius = 2
            };

            rect.PrintName();
            Console.WriteLine($"넓이: {rect.Result()}");
            tri.PrintName();
            Console.WriteLine($"넓이: {tri.Result()}");
            cir.PrintName();
            Console.WriteLine($"넓이: {cir.Result():F2}");

            Console.ReadLine();
            #endregion

            #region #2. 다단계 상속
          
            Console.WriteLine("================================");

            GrandChild gc = new GrandChild();
            gc.SayHello();
            gc.SayHello2();
            gc.SayHello3();
            gc.SayHello4();

            Console.ReadLine();
            Console.WriteLine("================================");

            #endregion

            #region #3. base(...) 키워드
            Parent dad = new Parent("홍길동", 60);

            Console.ReadLine();
            Console.WriteLine("================================");

            GrandChild gc2 = new GrandChild("John", 70);

            Console.ReadLine();
            Console.WriteLine("================================");

            #endregion
        }
    }
}
