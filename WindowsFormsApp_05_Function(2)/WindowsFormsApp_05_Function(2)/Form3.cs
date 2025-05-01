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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        #region #enum & switch문 실습해보기
        enum week
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
      
        week InputCheck(string message)
        {
            switch (message)
            {
                case "월요일":
                    return week.Monday;
                case "화요일":
                    return week.Tuesday;
                case "수요일":
                    return week.Wednesday;
                case "목요일":
                    return week.Thursday;
                case "금요일":
                    return week.Friday;
                case "토요일":
                    return week.Saturday;
                case "일요일":
                    return week.Sunday;
                default:
                    return week.Error;
            }

         }


        private void button1_Click(object sender, EventArgs e)
        {
            week week = InputCheck(textBox_input.Text);

            switch (week)
            {
                case week.Monday:
                    textBox_result.Text = "월요병";
                    break;
                case week.Tuesday:
                    textBox_result.Text = "화요병";
                    break;
                case week.Wednesday:
                    textBox_result.Text = "수요병";
                    break;
                case week.Thursday:
                    textBox_result.Text = "목요병";
                    break;
                case week.Friday:
                    textBox_result.Text = "금요병";
                    break;
                case week.Saturday:
                    textBox_result.Text = "우왕!!  토요일!!";
                    break;
                case week.Sunday:
                    textBox_result.Text = "지나갑니다...일요일...ㅠ_ㅠ";
                    break;
                case week.Error:
                    textBox_result.Text = "입력해주세요";
                    break;

            }
        }
        #endregion

        #region #TBD 

        #endregion
    }
}
