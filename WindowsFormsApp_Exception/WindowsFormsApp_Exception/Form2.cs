using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Exception
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            try
            {
                Console.Write("닉네임을 입력해주세요: ");

                // 닉네임 입력
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    throw new Exception("닉네임을 입력해주세요.");
                }
                else if (input.Length < 2)
                {
                    throw new Exception("닉네임은 2글자 이상이어야 합니다.");
                }
                else if (input.Contains("admin"))
                {
                    throw new Exception("닉네임에 'admin'은 포함할 수 없습니다.");
                }
                else
                {
                    Console.WriteLine("닉네임 등록 완료!");
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("프로그램을 종료합니다.");
                Console.ReadLine();
            }
        }
    }
}
