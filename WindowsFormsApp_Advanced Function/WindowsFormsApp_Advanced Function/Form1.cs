using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp_Advanced_Function
{
    #region #1. 구조체 정의 
    /*
     * 구조체 
     * - 여러 데이터를 하나로 묶어서 새로운 데이터 파일 생성 
     * 
     * Why ? 
     * - 관련 있는 데이터들을 하나로 묶기 위해 (작은 데이터 묶음) 
     * 
     * #1. 메모리 저장
     * - 값 형식으로 저장됨
     * - ㄴ 데이터를 직접 저장함. 변수끼리 복사하면 값이 복제됨.
     * 
     * #2. 구조체 선언 위치
     * - 클래스 밖, namespace 안
     * - 전역처럼 어디서든 사용 가능하기 위해서 
     */

    /*
    struct Point
    {
        public int x;
        internal int y; //internal(접근제한자) - 가은 플젝 안에서만 접근 가능.
        public int z;

        public int Diff_xy()
        {
            return x - y;
        }

    } 
    */
    #endregion

    struct Point
    {
        public int x;
        public int y;
        public static double Distnace(Point p1, Point p2)
        {
            int dx = p2.x - p1.x;
            int dy = p2.y - p1.y;

            return Math.Sqrt(dx * dx + dy * dy);

        }
    }

    struct Student
    {
        public string name;
        public int age;
        public double score;

    }

    public class User
    {
        int money = 1000;
        public int pay()
        {
            return money;
        }
    }

    public class machine
    {
        string[] item = new string[5];
    }
        public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region #실습1

            Console.Write("첫 번째 좌표 (x,y) 입력: ");
            string[] input1 = Console.ReadLine().Split();

            Point p1 = new Point();
            p1.x = int.Parse(input1[0]);
            p1.y = int.Parse(input1[1]);

            Console.Write("두 번째 좌표 (x,y) 입력: ");
            string[] input2 = Console.ReadLine().Split();

            Point p2 = new Point();
            p2.x = int.Parse(input2[0]);
            p2.y = int.Parse(input2[1]);

            double distance = Point.Distnace(p1, p2);
            Console.WriteLine($"두점 사이의 거리: {distance}");

            #endregion

            #region #실습2 (하다말아씀)

            /*
            Student[] studnets = new Student[3];


            for (int i=1; i <studnets.Length+1; i++)
            {
                Console.WriteLine($"학생{i}의 이름, 나이, 성적을 순서대로 기입해주세요: ");

            }

            string input = Console.ReadLine().Split(' ');
            */
            #endregion


            #region #2. 구조체 사용 
            /*
            Point point1 = new Point();
            Point point2;

            point1.x = 10;
            point2.x = 31; 

            Point point3 = new Point();
            point3.x = 20;
            point3.y = 40;

            int diff = point3.Diff_xy();

            Console.WriteLine($"point({point3.x}, {point3.y}, {point3.z}), 함수값: {diff}");
            #endregion

            #region #3. 구조체 배열 사용

            Point[] p = new Point[3];

            for (int i = 0; i < p.Length; i++)
            {
                p[i] = i;
                p[i].y = i * i;
                p[i].z = -i;

                Console.WriteLine($"p[{i}] ({p[i].x}, {p[i].y}, {p[i].z})");
                  
            }
            */
            #endregion

            #region #4. 표현식 본문(화살표 함수) 
            /*
            //한줄만 가능 
            //여러 줄이면 반드시 블록 본문으로 작성해야 함.

            int a = Add(2, 4);
            Console.WriteLine(a);
            int b = Add2(2,4);
            Console.WriteLine(b);
            Hi ();
            */
            #endregion
        }

        #region 실습3




    #endregion

        int Add(int a, int b)
        {
            return a + b;
        }

        int Add2(int a, int b) => a + b;

        void Hi() => Console.WriteLine("표현식 함수");


    

    }
}
