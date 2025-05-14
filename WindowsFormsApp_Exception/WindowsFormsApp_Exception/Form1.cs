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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region #연습
            try
            {
                Console.Write("숫자를 입력하세요: ");
                string input = Console.ReadLine();

                //문자열 -> 정수 변환
                int number = int.Parse(input);

                //입력 받은 숫자로 100을 나눔
                int result = 100 / number;

                //[추가] throw : 개발자가 직접 의도적으로 예외를 발생시킬 때 사용
                if (number < 0)
                {
                    throw new Exception("헉! 예외발생. 이건 개발자가 일부러 던진 에러에요.");
                }

                Console.WriteLine($"100 / {number} = {result}");
            }

            // .NET이 제공하는 기본 예외 클래스 중 일부 
            catch (DivideByZeroException)
            {
                Console.WriteLine("오류: 0으로 나눌 수 없습니다.");
                Console.WriteLine($"[예외 메시지]: ");
            }

            /*
            catch (FormatException)
            {
                Console.WriteLine("오류: 숫자가 아닌 값을 입력하셨어요.");
                Console.WriteLine($"[예외 메시지]: ");
            }
            */

            catch (Exception ex)
            {
                // 모든 예외 처리 
                // Exception ex 객체로 할 수 있는것 (=자주 사용되는 것) 
                // ex.Message - 예외 메시지
                // ex.StacTrace - 예외가 어디서 발생했는지 추적 정보
                // ex.GetType() - 발생한 예외의 정확한 타입 반환 


                Console.WriteLine("오류: 예기치 못한 오류가 발생하였습니다.");
                Console.WriteLine($"[예외 메시지]: {ex.Message}");
                Console.WriteLine($"[예외 타입]: {ex.GetType()}");
                Console.WriteLine($"[스택 정보]: {ex.StackTrace}");

                Console.WriteLine("==================================");
                
                
                // [참고 1]
                // Console.WriteLine(ex); --- ex 객체 출력 가능 & 마지막에 배치해야 함!! 
                // Exception 객체는 .NET Framework의 내부 클래스 이긴하나, 우리가 직접 볼 수 없고, 
                // 내부적인 모든 내용을 볼 수 있는것도 아님                
            }

            finally
            {
                // 예외 발생 여부와 관계없이, 무조건 실행되는 블록
                Console.WriteLine("프로그램을 종료합니다.");
                Console.ReadLine();
            }

            #endregion
        }
    }
}
