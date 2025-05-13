using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Class
{

    internal class VendingMachine
    {
        /* 1. 자판기 Class 정의 
         * - 음료 자판기 
         * - 속성 : 음료수 
         * - 메서드 : 음료수 반환  
         */

        // 2. 필드
        private string coke; // 음료수
                             

        // 3. 속성
        public bool Coke
        {
            get { return coke == "콜라"; }
    
        }

        // 4. 생성자
        public VendingMachine ()
        {
            coke = "콜라";
        }

        // 5. 메서드
        public void Printinfo()
        {
            if (coke == "콜라") 
            {
                Console.WriteLine($"선택한 음료수: {coke}");
            }

            else
                Console.WriteLine("모두 sold out 되었습니다.");
        }

    }
}
