using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_03_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*
            // #1. 배열 (Array)
            // 같은 자료형 변수 여러개를 하나의 배열로 처리
            // ㄴ 한 번에 여러 값을 저장할 수 있음

            int[] numbs = new int[8]; // 정수형 8개를 저장할 수 있는 배열.

            // 구조
            // 배열의 이름 : numbs 
            // 배열의 자료형 : int[] --> 정수형 배열
            // 배열 선언 및 메모리 공간 확보 : numbs = new int[8] == 8개 짜리 공간을 만듦
            // 배열의 요소(아이템) : 배열 안에 있는 하나하나
            // 배열의 위치(인덱스) : 0부터 시작 
            // 배열의 길이(크기) : 요소의 개수와 동일 

            // 입력되는 데이터의 크기를 알 수 없을때 배열로 처리
            int inputCount = 10;
            int[] inputData = new int[inputCount];

            // 배열의 각 요소에 접근, Index는 0부터 시작.
            inputData[0] = 20;
            int oneOfData = inputData[0];

            // 배열 할당 및 초기화
            int[] array1 = new int[5]; // 방 5칸  
            int[] array2 = { 1, 2, 3, 4, 5, 6 }; // 방 6칸에 각각 데이터 넣어줌

            // 2차원 배열 (행과 열로 구성)
            //  ㄴ 배열안에 배열이 들어갈 수 있음 
            // [,] -> 배열의 '모양'을 미리 정하는 표시
            //  ㄴ [] : 1차원, [,] : 2차원, [,,] : 3차원
            // {} -> 실제 값 넣기

            int[,] multiArray1 = new int[2,3]; //2행 3열
            int[,] multiArray2 = {{ 1, 2, 3 },{ 4, 5, 6 }};

            String[,] korean = new string[,]
            {
                {"가", "나", "다" },
                {"라", "마", "바" },
                {"사", "아", "자" }
            };
            //Quiz1. '가자' 글씨 출력해보기
            textBox1.Text = korean[0, 0] + korean[2, 2];

            //Quiz2. 3차원 배열에서 숫자 8 출력
            int[,,] nums2 = new int[,,]
            {
                {
                    {1,2,3},
                    {4,5,6}
                },
                {
                    {7,8,9},
                    {10,11,12}
                }
            };

            textBox1.Text = nums2[1, 0, 1].ToString();

            // 재그드(jagged) 배열 = 들쭉날쭉한 배열 (행마다 열이 길이가 다름)
            // [][] 중첩된 대괄호 사용
            // 첫 번째 [] : 바깥쪽 배열
            // 두 번째 [] : 안쪽 배열


            int[][] jaggedArray = new int[6][]; //행은 6으로 고정, 열은 자유로움 
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };// 첫번째 행에 4개의 데이터를 넣음 
            jaggedArray[1] = new int[3] { 1, 2, 3 }; // 두번째 행에 3개의 데이터를 넣음
            */

            /*
            // 실습 1

            String[][] jaggedArray = new string[3][];
            jaggedArray[0] = new string[2] { "승연", "마리" };
            jaggedArray[1] = new string[3] { "미주", "예경", "석류" };
            jaggedArray[2] = new string[1] { "한나" };


            textBox1.Text = "*1반 학생 목록:\r\n- " + jaggedArray[0][0] + "\r\n- " + jaggedArray[0][1] + "\r\n\r\n"
                          + "*2반 학생 목록:\r\n- " + jaggedArray[1][0] + "\r\n- " + jaggedArray[1][1] + "\r\n- " + jaggedArray[1][2] + "\r\n\r\n"
                          + "*3반 학생 목록:\r\n-" + jaggedArray[2][0];
            */


            /*
            // 실습 2

            string[] strings = new string[10];
            
            //2-1
            strings[0] = "동해 물과 백두산이".IndexOf("백두산").ToString();
          
            //2-2
            strings[1] = "토요일에 먹는 토마토".LastIndexOf("토").ToString();
            
            //2-3
            strings[2] = "질서 있는 퇴장".Contains("퇴").ToString();
           
            //2-4
            strings[3] = "그 사람의 그림자는 그랬다.".Replace("그", "이").ToString();
            
            //2-5
            strings[4] = "삼성 갤럭시".Insert(2, " 애플").ToString();
            
            //2-6
            strings[5] = "오늘은 왠지 더 배고프다".Remove(7,2).ToString(); // .Remove("오늘은 왠지 더 배고프다".IndexOf("더"),1) 
            
            //2-7
            string sample = "이름,나이,전화번호";
            strings[6] = sample.Split(',')[0];
            strings[7] = sample.Split(',')[1];
            strings[8] = sample.Split(',')[2];
            // .Trim() : 문자열의 양쪽 끝에 있는 공백을 없애주는 함수. 
            // 위에 적용을 해보면 >> sample.Split(',')[0].Trim(); 

            //2-8
            strings[9] = "우리 나라 만세".Substring(3,2);


            textBox1.Text = strings[0] + "\r\n" + strings[1] + "\r\n" + strings[2] + "\r\n"
                          + strings[3] + "\r\n" + strings[4] + "\r\n" + strings[5] + "\r\n"
                          + strings[6] + "\r\n" + strings[7] + "\r\n" + strings[8] + "\r\n"
                          + strings[9] + "\r\n";

            */

            /*
            // 실습 3
            string s = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. -공자";
            string ss = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. -공자";


            //3-1
            //textBox1.Text = s.IndexOf("-").ToString(); // 특수문자 찾기 - 30
            //textBox1.Text = s.Remove(30, 3).ToString(); // -공자 삭제하기

            //3-2

            //textBox1.Text = s.IndexOf("얼마나").ToString(); //'얼마나' 위치 찾기 - 9~
            //textBox1.Text = s.LastIndexOf("가는지").ToString(); // '가는지' 위치 찾기 - 17~19

            string s1 = s.Substring(9,11).ToString(); // 문자열 가져오기
                        
            //string[] array = s1.Split(' ');
            //textBox1.Text = string.Join("\r\n", array);

            string[] array = new string[3];

            array[0] = s1.Split(' ')[0];
            array[1] = s1.Split(' ')[1];
            array[2] = s1.Split(' ')[2];


            //3-3
            // textBox1.Text = s.IndexOf("-").ToString(); // 특수문자 찾기 - 30
            // textBox1.Text = s.IndexOf(".").ToString(); // 특수문자 찾기 - 29

            ss = ss.Remove(31, 1);
            ss = ss.Remove(29, 1);

            string s2 = ss.Trim();


            textBox1.Text = s.Remove(30, 4).ToString() + "\r\n"; // 3-1
            textBox1.Text += array[0] + "\r\n" + array[1] + "\r\n" + array[2] + "\r\n"; //3-2
            textBox1.Text += s2.Replace(" ", ",");//3-3

            */

            // 실습 4
            String[,] fruits = new string[,]
            {
                {"홍길동", "포도", "복숭아", "바나나" },
                {"아무개", "사과", "수박", "오렌지" },
                {"손오공", "바나나", "사과", "오렌지" },
            };


            //2-1. 바나나->바나나(유기농)

            fruits[0, 3] = "바나나(유기농)";
            fruits[2, 1] = "바나나(유기농)";

            //2-2


            //2-3
            fruits[1, 2] = "씨없는 수박";

            //홍길동
            textBox1.Text = fruits[0, 0] + ": " + fruits[0, 1] + " / " + fruits[0, 2] + " / " + fruits[0, 3] + "\r\n";
            textBox1.Text += "상품 첫 글자 요약: " + fruits[0, 1].Substring(0, 1) + " / " + fruits[0, 2].Substring(0, 1) + " / " + fruits[0, 3].Substring(0, 1) + "\r\n" +"\r\n";

            //아무개
            textBox1.Text += fruits[1, 0] + ": " + fruits[1, 1] + " / " + fruits[1, 2] + " / " + fruits[1, 3] + "\r\n";
            textBox1.Text += "상품 첫 글자 요약: " + fruits[1, 1].Substring(0, 1) + " / " + fruits[1, 2].Substring(0, 1) + " / " + fruits[1, 3].Substring(0, 1) + "\r\n" + "\r\n";

            //손오공
            textBox1.Text += fruits[2, 0] + ": " + fruits[2, 1] + " / " + fruits[2, 2] + " / " + fruits[2, 3] + "\r\n";
            textBox1.Text += "상품 첫 글자 요약: " + fruits[2, 1].Substring(0, 1) + " / " + fruits[2, 2].Substring(0, 1) + " / " + fruits[2, 3].Substring(0, 1) + "\r\n" + "\r\n";





        }
    }
}
