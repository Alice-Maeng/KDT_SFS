using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Class
{
    internal class VendingMachine_User
    {
        /* 1. User Class 정의 
         * - 구매자
         * - 속성 : 돈
         * - 메서드 : 음료수 반환  
         */
        
        //2. 필드 
        private int money;

        //3. 속성
        public int Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                    money = 0;
                else
                    money = value;
            }
        }


        //4. 생성자
        public VendingMachine_User()
        {
            money = 1000;
            Console.WriteLine("구매 완료.");
        }

        public VendingMachine_User(int money)
        {
            if (money < 1000)
            {
                Console.WriteLine("콜라를 구매할 수 없습니다.");
            } 
            else
            {
                Console.WriteLine("구매 완료");
            }

            this.Money = money;
        }

        //5. 메소드 
        public void PrintInfo()
        {
            Money = this.money;
            Console.WriteLine($"넣은 돈: {money}");
        }

    }
}
