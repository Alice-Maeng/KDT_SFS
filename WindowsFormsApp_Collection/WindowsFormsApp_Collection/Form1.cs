using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp_Collection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        // 아이디, 비밀번호 저장용 딕셔너리 
        // ㄴ아이디(key), 비밀번호(value)로 저장

        Dictionary<string, string> idPwDc = new Dictionary<string, string>();

        // 아이디, 전화번호 저장용 딕셔너리 (전화번호 없을 경우, null) 
        // ㄴ아이디(key), 전화번호(value)로 저장

        Dictionary<string, string> idPhoneDc = new Dictionary<string, string>();

        //[1] 파일 불러오기 이벤트 

        private void button1_file_Click(object sender, EventArgs e)
        {
            //파일 선택 다이얼로그 열기
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "텍스트 파일 (*.txt)|*.txt";

            if(ofd.ShowDialog() == DialogResult.OK) 
            {
                //파일 열기 창에서 사용자가 파일 선택하고 "열기"를 누르면 OK

                string filePath = ofd.FileName; // [속성] 선택한 파일의 전체 경로 변수에 저장.

                //파일 열기
                using (StreamReader sr = new StreamReader(filePath)) 
                // 파일을 읽기 모드로 염
                // StreamReader : 텍스트 파일 등 내용을 한 줄씩 또는 전체 문자열로 읽어들이는 클래스 
                //  ㄴ using : 파일 사용이 끝나면 자동으로 닫음 (자원 누수 방지) 
                //        ㄴ 안전하게 닫히도록 처리
                {
                    string line; 
                    while ((line = sr.ReadLine()) != null)  // null이 아니면, 한 줄씩 line에 담겠다
                    {
                        string[] data = line.Split(',');    // 담긴 line을 쉼표 기준으로 분할 후 배열에 반환
                        string id = data[0];
                        string pw = data[1];

                        
                        string phone = null;    //전화번호가 없는 경우가 있으니까 기본 default 값으로 null 입력
                        if (data.Length > 3 && !string.IsNullOrWhiteSpace(data[2]))
                        // data 배열이 3개 이상이거나 3번째 배열이 공백이 아니라면 
                        {
                            phone = data[3];    //전화번호 값을 data[3]에 넣어랏
                        }

                        // 딕셔너리에 고대로 저장하기
                        idPwDc[id] = pw;
                        idPhoneDc[id] = phone;
                    }
                }

                MessageBox.Show("파일 불러오기 완료");

            }
        }
        // [2] 로그인 버튼 클릭 이벤트
        private void button_login_Click(object sender, EventArgs e)
        {
            //입력값에서 공백 제거 --- .Trim() 이용 
            string inputId = textBox1_id.Text.Trim();
            string inputPw = textBox2_pw.Text.Trim();

            // 아이디 존재 여부 확인 
            if (!idPwDc.ContainsKey(inputId))
            {
                MessageBox.Show("[에러]: 아이디가 존재하지 않습니다.");
                return;
            }

            // 비밀번호 존재 여부 확인 
            if (idPwDc[inputId] != inputPw)
            {
                MessageBox.Show("[에러]: 비밀번호가 일치하지 않습니다.");
                return;
            }

            //로그인 성공 -> 전화번호 여부 체크해야함 
            string phone = null;

            //딕셔너리에 해당아이디는 있는데 전화번호가 null이 아닐 때
            if (idPhoneDc.ContainsKey(inputId) && !string.IsNullOrWhiteSpace(idPhoneDc[inputId]))
            {
                phone = idPhoneDc[inputId];
            }

            if (phone != null) 
            {
                MessageBox.Show($"로그인 성공! \n 아이디: {inputId} \n 전화번호: {phone}");                
            }
            else
            {
                MessageBox.Show($"로그인 성공! \n 아이디: {inputId} \n 전화번호: 없음");
            }
        }



    }
}
