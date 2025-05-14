using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp_Game
{
    public partial class Form1 : Form
    {
        public enum mon {slime, orc}
        public Form1()
        {
            InitializeComponent();

            //slime or orc 랜덤 발생을 위한 ... 
            Random random = new Random();
            int result = random.Next(2);

            //player 캐릭터 선택 --- wizard or warrior
            Console.Write($"[user]직업을 wizard / warrior 중 선택해주세요: ");
            string choice = Console.ReadLine();

            Character player = new Player(choice); // Upcasting 
            Monster monster = null; // 초기화

            if (choice == "wizard" || choice == "warrior")
            {
                switch (result)
                {
                    case 0:
                        Console.WriteLine("슬라임이 나타났습니다.");
                        monster = new Monster("slime");
                        break;
                    case 1:
                        Console.WriteLine("오크가 나타났습니다.");
                        monster = new Monster("orc");
                        break;
                }
            }
            
            player.Attack(monster);

            Console.ReadLine();
        }
    }
}
